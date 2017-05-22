namespace MIME.Sniffer.Inspectors
{
    internal class Bmp : ByteInspector
    {
        public const string Mime = "image/bmp";

        public Bmp()
            : base(
                new Document
                    {
                        Mime = Bmp.Mime
                    },
                new byte?[]
                    {
                        66,
                        77
                    })
        {
        }
    }
}