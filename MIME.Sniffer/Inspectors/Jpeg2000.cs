namespace MIME.Sniffer.Inspectors
{
    internal class Jpeg2000 : ByteInspector
    {
        public const string Mime = "image/jp2";

        public Jpeg2000()
            : base(
                new Document
                    {
                        Mime = Jpeg2000.Mime
                    },
                new byte?[]
                    {
                        0x00,
                        0x00,
                        0x00,
                        0x0C,
                        0x6A,
                        0x50,
                        0x20,
                        0x20
                    })
        {
        }
    }
}