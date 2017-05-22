namespace MIME.Sniffer.Metadata
{
    using System.Text;

    public class TxtMetadata : IMetadata
    {
        public TxtMetadata(Encoding encoding)
        {
            this.Encoding = encoding;
        }

        public Encoding Encoding { get; private set; }
    }
}