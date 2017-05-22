namespace MIME.Sniffer.Inspectors
{
    internal class Gif : ByteInspector
    {
        public const string Mime = "image/gif";

        public Gif()
            : base(
                new Document
                    {
                        Mime = Gif.Mime
                    },
                new byte?[]
                    {
                        71,
                        73,
                        70,
                        56
                    })
        {
        }
    }
}