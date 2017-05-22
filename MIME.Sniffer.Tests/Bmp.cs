namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.BmpCollection), Inspectors.Bmp.Mime)]
    public class Bmp : DocumentTypeBase
    {
    }
}