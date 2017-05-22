namespace MIME.Sniffer
{
    using System.IO;

    public interface IDocStreamInspector
    {
        bool TryGetDocInfo(Stream stream, out IDocument document);
    }
}