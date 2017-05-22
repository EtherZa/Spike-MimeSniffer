namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.EmlCollection), Inspectors.Eml.Mime)]
    public class Eml : DocumentTypeBase
    {
    }
}