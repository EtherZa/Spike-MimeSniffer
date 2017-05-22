namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.PptCollection), Inspectors.Ppt.Mime)]
    public class Ppt : DocumentTypeBase
    {
    }
}