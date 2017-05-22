namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.PdfCollection), Inspectors.Pdf.Mime)]
    public class Pdf : DocumentTypeBase
    {
    }
}