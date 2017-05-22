namespace MIME.Sniffer.Inspectors
{
    internal class Ppptx : OfficeDocumentInspector
    {
        public const string Mime = "application/vnd.openxmlformats-officedocument.presentationml.presentation";

        public Ppptx()
            : base(
                new Document
                    {
                        Mime = Ppptx.Mime
                    })
        {
        }

        protected override bool IsExpectedNamespace(string nspace)
        {
            return nspace.StartsWith("http://schemas.openxmlformats.org/presentationml/");
        }
    }
}