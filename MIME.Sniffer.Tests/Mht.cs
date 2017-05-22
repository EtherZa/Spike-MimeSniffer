namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.MhtCollection), Inspectors.Mht.Mime)]
    public class Mht : DocumentTypeBase
    {
    }
}