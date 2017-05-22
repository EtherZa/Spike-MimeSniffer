namespace MIME.Sniffer
{
    public interface IDocumentInspector
    {
        IDocument GetDocumentInfo(byte[] doc);
    }
}