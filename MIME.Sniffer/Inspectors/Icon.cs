namespace MIME.Sniffer.Inspectors
{
    internal class Icon : ByteInspector
    {
        public const string Mime = "image/x-icon";

        public Icon()
            : base(
                new Document
                    {
                        Mime = Icon.Mime
                    },
                new byte?[]
                    {
                        0,
                        0,
                        1,
                        0
                    })
        {
        }
    }
}