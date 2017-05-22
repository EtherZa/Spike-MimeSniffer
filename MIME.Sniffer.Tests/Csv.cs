namespace MIME.Sniffer.Tests
{
    using MIME.Sniffer.Inspectors;
    using MIME.Sniffer.Metadata;
    using MIME.Sniffer.Tests.Helper;

    using NUnit.Framework;

    [MimeType(typeof(ResourcesCollection.CsvCollection), Csv.Mime)]
    public class CommaSeparatedValues : DocumentTypeBase
    {
        private readonly ResourcesCollection.CsvCollection collection;

        public CommaSeparatedValues()
        {
            this.collection = new ResourcesCollection.CsvCollection();
        }

        [Test]
        [Category(Csv.Mime)]
        public void CommaSeparatorNotSpecified()
        {
            this.CheckSeparator(this.collection.CommaSeparatedNotSpecified.Content, ",", false);
        }

        [Test]
        [Category(Csv.Mime)]
        public void SemiColonSeparatorNotSpecified()
        {
            this.CheckSeparator(this.collection.SemicolonSeparatedNotSpecified.Content, ";", false);
        }

        [Test]
        [Category(Csv.Mime)]
        public void PipeSeparatorSpecified()
        {
            this.CheckSeparator(this.collection.PipeSeparatorSpecified.Content, "|", true);
        }

        private void CheckSeparator(byte[] content, string expectedSeparator, bool separatorSpecified)
        {
            var target = new DocumentInspector();
            var result = target.GetDocumentInfo(content);

            var actual = result.Metadata as CsvMetadata;
            Assert.NotNull(actual);

            Assert.AreEqual(separatorSpecified, actual.DelimeterSpecified);
            Assert.AreEqual(expectedSeparator, actual.Delimeter);
        }
    }
}