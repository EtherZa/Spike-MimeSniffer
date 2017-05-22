namespace MIME.Sniffer.Inspectors
{
    internal class Zip : ByteInspector
    {
        public const string Mime = "application/x-compressed";

        public Zip()
            : base(
                new Document
                    {
                        Mime = Zip.Mime
                    },
                new byte?[]
                    {
                        0x50,
                        0x4B,
                        0x03,
                        0x04
                    })
        {
        }
    }
}