namespace MIME.Sniffer.Inspectors
{
    using System.Text.RegularExpressions;

    internal class Eml : TextInspector
    {
        public const string Mime = "message/rfc822";

        public Eml()
            : base(
                new Document
                    {
                        Mime = Eml.Mime
                    },
                new Regex(@"(^From:.*$)|(^To:.*$)", RegexOptions.Compiled | RegexOptions.Multiline),
                100,
                4096)
        {
        }
    }
}