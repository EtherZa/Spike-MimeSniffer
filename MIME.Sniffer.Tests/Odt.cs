namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.OdtCollection), Inspectors.Odt.Mime)]
    public class Odt : DocumentTypeBase
    {
    }
}