namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.OdsCollection), Inspectors.Ods.Mime)]
    public class Ods : DocumentTypeBase
    {
    }
}