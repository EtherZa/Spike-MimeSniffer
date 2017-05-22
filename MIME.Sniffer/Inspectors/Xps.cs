namespace MIME.Sniffer.Inspectors
{
    using System.IO;

    internal class Xps : OpenXmlInspector
    {
        public const string Mime = "application/xps";

        public Xps()
            : base(
                new Document
                    {
                        Mime = Xps.Mime
                    },
                @"http://schemas.microsoft.com/xps/2005/06/fixedrepresentation")
        {
        }

        protected override bool InspectTarget(string filename, Stream stream)
        {
            return true;
        }
    }
}