namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.TiffCollection), Inspectors.Tiff.Mime)]
    public class Tiff : DocumentTypeBase
    {
    }
}