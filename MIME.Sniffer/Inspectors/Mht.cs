namespace MIME.Sniffer.Inspectors
{
    using System.Text.RegularExpressions;

    internal class Mht : TextInspector
    {
        public const string Mime = "multipart/related";

        public Mht()
            : base(
                new Document
                    {
                        Mime = Mht.Mime
                    },
                new Regex(@"^Content-Type:\s+multipart/related", RegexOptions.Compiled | RegexOptions.Multiline),
                100,
                4096)
        {
        }
    }
}