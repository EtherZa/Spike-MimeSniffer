namespace MIME.Sniffer
{
    public interface IDocument
    {
        IMetadata Metadata { get; }

        string Mime { get; }
    }
}