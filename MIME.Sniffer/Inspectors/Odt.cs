namespace MIME.Sniffer.Inspectors
{
    internal class Odt : OpenDocumentInspector
    {
        public const string Mime = "application/vnd.oasis.opendocument.text";

        public Odt()
            : base(
                new Document
                    {
                        Mime = Odt.Mime
                    })
        {
        }
    }
}