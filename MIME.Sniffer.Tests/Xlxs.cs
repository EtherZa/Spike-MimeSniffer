namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Inspectors;
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.XlsxCollection), Xlsx.Mime)]
    public class Xlxs : DocumentTypeBase
    {
    }
}