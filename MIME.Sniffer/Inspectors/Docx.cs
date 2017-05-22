namespace MIME.Sniffer.Inspectors
{
    internal class Docx : OfficeDocumentInspector
    {
        public const string Mime = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";

        public Docx()
            : base(
                new Document
                    {
                        Mime = Docx.Mime
                    })
        {
        }

        protected override bool IsExpectedNamespace(string nspace)
        {
            return nspace.StartsWith("http://schemas.microsoft.com/office/word/");
        }
    }
}