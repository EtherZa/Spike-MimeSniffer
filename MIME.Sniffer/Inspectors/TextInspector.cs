namespace MIME.Sniffer.Inspectors
{
    using System;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public class TextInspector : IDocStreamInspector
    {
        private readonly IDocument document;

        private readonly int maxBytes;

        private readonly int minBytes;

        private readonly Regex regex;

        public TextInspector(IDocument document, Regex regex, int minBytes = 50, int maxBytes = 300)
        {
            this.regex = regex;
            this.document = document;
            this.minBytes = minBytes;
            this.maxBytes = maxBytes;
        }

        public bool TryGetDocInfo(Stream stream, out IDocument doc)
        {
            if (stream.Length < this.minBytes)
            {
                doc = null;
                return false;
            }

            if (stream.Position > 0)
            {
                stream.Seek(0, SeekOrigin.Begin);
            }

            var len = (int)Math.Min(this.maxBytes, stream.Length);
            var bufferSize = Math.Min(1024, len);

            using (var reader = new StreamReader(stream, Encoding.Default, true, bufferSize, true))
            {
                var buffer = new char[len];
                reader.Read(buffer, 0, len);

                var value = new string(buffer);
                if (this.regex.IsMatch(value))
                {
                    doc = this.document;
                    return true;
                }
            }

            doc = null;
            return false;
        }
    }
}