namespace MIME.Sniffer.Inspectors
{
    using System.Text.RegularExpressions;

    public class Vcf : TextInspector
    {
        public const string Mime = @"text/vcard";

        public Vcf()
            : base(
                new Document
                    {
                        Mime = Vcf.Mime
                    },
                new Regex(@"^\s*BEGIN:VCARD.+^END:VCARD\s*$", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.Multiline),
                100,
                5120)
        {
        }
    }
}