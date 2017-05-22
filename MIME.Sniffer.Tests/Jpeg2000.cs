namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.Jpeg2000Collection), Inspectors.Jpeg2000.Mime)]
    public class Jpeg2000 : DocumentTypeBase
    {
    }
}