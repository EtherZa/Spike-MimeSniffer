namespace MIME.Sniffer.Inspectors
{
    internal class Rtf : ByteInspector
    {
        public const string Mime = "application/rtf";

        public Rtf()
            : base(
                new Document
                    {
                        Mime = Rtf.Mime,
                    },
                new byte?[]
                    {
                        0x7B,
                        0x5C,
                        0x72,
                        0x74,
                        0x66,
                        0x31
                    })
        {
        }
    }
}