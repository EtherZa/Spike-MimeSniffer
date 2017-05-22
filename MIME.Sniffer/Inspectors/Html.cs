namespace MIME.Sniffer.Inspectors
{
    using System.Text.RegularExpressions;

    public class Html : TextInspector
    {
        public const string Mime = @"text/html";

        public Html()
            : base(
                new Document
                    {
                        Mime = Html.Mime
                    },
                new Regex(@"<(!doctype )?html[^<>]*>", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Singleline))
        {
        }
    }
}