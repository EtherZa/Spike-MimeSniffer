namespace MIME.Sniffer.Inspectors
{
    internal class Tiff : ByteInspector
    {
        public const string Mime = "image/tiff";

        public Tiff()
            : base(
                new Document
                    {
                        Mime = Tiff.Mime
                    },
                new byte?[]
                    {
                        73,
                        73,
                        42,
                        0
                    })
        {
        }
    }
}