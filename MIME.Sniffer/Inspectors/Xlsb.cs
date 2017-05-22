namespace MIME.Sniffer.Inspectors
{
    using System.IO;

    internal class Xlsb : OpenXmlInspector
    {
        public const string Mime = "application/vnd.openxmlformats-officedocument.spreadsheetml";

        private readonly ByteInspector binInspector;

        public Xlsb()
            : base(
                new Document
                    {
                        Mime = Xlsb.Mime
                    },
                "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument")
        {
            this.binInspector = new ByteInspector(
                new Document(),
                new byte?[]
                    {
                        0x83,
                        0x01,
                        0x00
                    });
        }

        protected override bool InspectTarget(string filename, Stream stream)
        {
            IDocument doc;
            return this.binInspector.TryGetDocInfo(stream, out doc);
        }
    }
}