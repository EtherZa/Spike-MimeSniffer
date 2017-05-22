namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.GifCollection), Inspectors.Gif.Mime)]
    public class Gif : DocumentTypeBase
    {
    }
}