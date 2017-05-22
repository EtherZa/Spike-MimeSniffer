namespace MIME.Sniffer.Inspectors
{
    internal class Odp : OpenDocumentInspector
    {
        public const string Mime = "application/vnd.oasis.opendocument.presentation";

        public Odp()
            : base(
                new Document
                    {
                        Mime = Odp.Mime
                    })
        {
        }
    }
}