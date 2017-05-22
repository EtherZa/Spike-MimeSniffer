namespace MIME.Sniffer.Inspectors
{
    internal class Ods : OpenDocumentInspector
    {
        public const string Mime = "application/vnd.oasis.opendocument.spreadsheet";

        public Ods()
            : base(
                new Document
                    {
                        Mime = Ods.Mime
                    })
        {
        }
    }
}