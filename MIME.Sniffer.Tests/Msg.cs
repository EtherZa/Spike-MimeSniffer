namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Tests.Helper;

    [MimeType(typeof(ResourcesCollection.MsgCollection), Inspectors.Msg.Mime)]
    public class Msg : DocumentTypeBase
    {
    }
}