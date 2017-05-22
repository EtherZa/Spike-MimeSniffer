namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.XlsCollection), Inspectors.Xls.Mime)]
    public class Xls : DocumentTypeBase
    {
    }
}