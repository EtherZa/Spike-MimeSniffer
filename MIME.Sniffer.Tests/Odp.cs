namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.OdpCollection), Inspectors.Odp.Mime)]
    public class Odp : DocumentTypeBase
    {
    }
}