namespace MIME.Sniffer.Inspectors
{
    internal class Document : IDocument
    {
        public IMetadata Metadata { get; internal set; }

        public string FileName { get; set; }

        public string Mime { get; internal set; }
    }
}