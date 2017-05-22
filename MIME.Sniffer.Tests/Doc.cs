namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.DocCollection), Inspectors.Doc.Mime)]
    public class Doc : DocumentTypeBase
    {
    }
}