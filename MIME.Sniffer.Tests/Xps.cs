namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.XpsCollection), Inspectors.Xps.Mime)]
    public class Xps : DocumentTypeBase
    {
    }
}