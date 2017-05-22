namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.DocxCollection), Inspectors.Docx.Mime)]
    public class DocX : DocumentTypeBase
    {
    }
}