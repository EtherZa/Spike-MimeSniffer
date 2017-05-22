namespace MIME.Sniffer.Inspectors
{
    internal class Pdf : ByteInspector
    {
        public const string Mime = "application/pdf";

        public Pdf()
            : base(
                new Document
                    {
                        Mime = Pdf.Mime
                    },
                new byte?[]
                    {
                        37,
                        80,
                        68,
                        70,
                        45,
                        49,
                        46
                    })
        {
        }
    }
}