namespace MIME.Sniffer.Tests
{
    using System.Text;

    using MIME.Sniffer.Metadata;
    using MIME.Sniffer.Tests.Helper;

    using NUnit.Framework;

    [MimeType(typeof(ResourcesCollection.TxtCollection), "text/plain")]
    public class Txt : DocumentTypeBase
    {
        public const string BaseMimeType = "text/plain";

        private readonly ResourcesCollection.TxtCollection collection;

        public Txt()
        {
            this.collection = new ResourcesCollection.TxtCollection();
        }

        [Test]
        [Category(Txt.BaseMimeType)]
        public void Utf8()
        {
            Txt.CheckEncoding(this.collection.Utf8.Content, Encoding.UTF8);
        }

        [Test]
        [Category(Txt.BaseMimeType)]
        public void Ucs2BigEndianByteOrderMarker()
        {
            Txt.CheckEncoding(this.collection.Ucs2BEBOM.Content, Encoding.BigEndianUnicode);
        }

        private static void CheckEncoding(byte[] content, Encoding encoding)
        {
            var expectedHeader = $"text/plain; charset={encoding.HeaderName}";

            var target = new DocumentInspector();
            var result = target.GetDocumentInfo(content);

            var metadata = result.Metadata as TxtMetadata;
            Assert.NotNull(metadata);

            var actualEncoding = metadata.Encoding;
            Assert.AreEqual(encoding, actualEncoding);

            var actualHeader = result.Mime;
            Assert.AreEqual(expectedHeader, actualHeader);
        }
    }
}