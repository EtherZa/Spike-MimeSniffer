namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.JpegCollection), Inspectors.Jpeg.Mime)]
    public class Jpeg : DocumentTypeBase
    {
    }
}