namespace MIME.Sniffer.Inspectors
{
    internal class Jpeg : ByteInspector
    {
        public const string Mime = "image/jpeg";

        public Jpeg()
            : base(
                new Document
                    {
                        Mime = Jpeg.Mime
                    },
                new byte?[]
                    {
                        255,
                        216,
                        255
                    })
        {
        }
    }
}