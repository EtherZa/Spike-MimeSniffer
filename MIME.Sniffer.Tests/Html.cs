namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.HtmlCollection), Inspectors.Html.Mime)]
    public class Html : DocumentTypeBase
    {
    }
}