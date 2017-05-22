namespace MIME.Sniffer.Inspectors
{
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System.Xml.XPath;

    internal abstract class OfficeDocumentInspector : OpenXmlInspector
    {
        protected OfficeDocumentInspector(IDocument document)
            : base(document, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument")
        {
        }

        protected override bool InspectTarget(string filename, Stream stream)
        {
            var t = new XmlDocument();
            t.Load(stream);

            var navigator = t.CreateNavigator();
            while (navigator.MoveToFollowing(XPathNodeType.Element))
            {
                var localNamespaces = navigator.GetNamespacesInScope(XmlNamespaceScope.Local);
                if ((localNamespaces != null) && localNamespaces.Values.Any(this.IsExpectedNamespace))
                {
                    return true;
                }
            }

            return false;
        }

        protected abstract bool IsExpectedNamespace(string nspace);
    }
}