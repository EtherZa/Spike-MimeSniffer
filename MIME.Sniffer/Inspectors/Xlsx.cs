namespace MIME.Sniffer.Inspectors
{
    internal class Xlsx : OfficeDocumentInspector
    {
        public const string Mime = "application/vnd.openxmlformats-officedocument.spreadsheetml";

        public Xlsx()
            : base(
                new Document
                    {
                        Mime = Xlsx.Mime
                    })
        {
        }

        protected override bool IsExpectedNamespace(string nspace)
        {
            return nspace.StartsWith("http://schemas.openxmlformats.org/spreadsheetml/");
        }
    }
}