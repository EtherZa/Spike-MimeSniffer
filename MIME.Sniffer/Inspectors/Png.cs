namespace MIME.Sniffer.Inspectors
{
    internal class Png : ByteInspector
    {
        public const string Mime = "image/png";

        public Png()
            : base(
                new Document
                    {
                        Mime = Png.Mime
                    },
                new byte?[]
                    {
                        137,
                        80,
                        78,
                        71,
                        13,
                        10,
                        26,
                        10,
                        0,
                        0,
                        0,
                        13,
                        73,
                        72,
                        68,
                        82
                    })
        {
        }
    }
}