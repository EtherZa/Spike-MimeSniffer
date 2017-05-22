namespace MIME.Sniffer.Inspectors
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    public class ByteInspector : IDocStreamInspector
    {
        private readonly List<Signature> signatures;

        public ByteInspector(IDocument document, byte?[] header, int offset = 0)
            : this(document)
        {
            this.AddSignature(header, offset);
        }

        protected ByteInspector(IDocument document)
        {
            this.Document = document;
            this.signatures = new List<Signature>();
        }

        public IDocument Document { get; private set; }

        public virtual bool TryGetDocInfo(Stream stream, out IDocument doc)
        {
            Debug.Assert(this.signatures.Any(), "No signatures registered.");

            foreach (var signature in this.signatures)
            {
                if (stream.Length < signature.Offset + signature.Header.Length)
                {
                    continue;
                }

                if (stream.Position != signature.Offset)
                {
                    stream.Seek(signature.Offset, SeekOrigin.Begin);
                }

                var found = true;
                foreach (var headerByte in signature.Header)
                {
                    var streamByte = stream.ReadByte();
                    if (headerByte.HasValue && headerByte != streamByte)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    doc = this.Document;
                    return true;
                }
            }

            doc = null;
            return false;
        }

        protected void AddSignature(byte?[] header, int offset = 0)
        {
            this.signatures.Add(
                new Signature()
                    {
                        Header = header,
                        Offset = offset
                    });
        }

        private class Signature
        {
            public byte?[] Header { get; set; }

            public int Offset { get; set; }
        }
    }
}