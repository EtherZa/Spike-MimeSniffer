namespace MIME.Sniffer.Metadata
{
    public class CsvMetadata : IMetadata
    {
        public CsvMetadata()
        {
            this.DelimeterSpecified = false;
            this.Delimeter = string.Empty;
        }

        public string Delimeter { get; internal set; }

        public bool DelimeterSpecified { get; internal set; }
    }
}