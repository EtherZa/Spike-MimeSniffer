namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.PngCollection), Inspectors.Png.Mime)]
    public class Png : DocumentTypeBase
    {
    }
}