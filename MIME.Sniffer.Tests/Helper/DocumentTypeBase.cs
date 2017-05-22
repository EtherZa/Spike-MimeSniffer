namespace MIME.Sniffer.Tests.Helper
{
    using System.Collections;
    using System.Reflection;
    using System.Text.RegularExpressions;

    using NUnit.Framework;

    public abstract class DocumentTypeBase
    {
        [Test]
        [TestCaseSourceEx(nameof(DocumentTypeBase.Resources))]
        public void MimeTypeIsDeterminedCorrectly(byte[] bytes, string mimeType)
        {
            var actual = this.GetDocument(bytes);

            var re = new Regex(mimeType, RegexOptions.IgnoreCase);
            Assert.IsTrue(re.IsMatch(actual.Mime));
        }

        protected static IEnumerable Resources(TestContext context)
        {
            var type = context.TypeUnderTest;
            var attribute = type.GetCustomAttribute<MimeTypeAttribute>(false);

            foreach (var resource in attribute.Resources)
            {
                var data = new TestCaseData(resource.Content, attribute.MimeType);
                if (!string.IsNullOrWhiteSpace(attribute.MimeType))
                {
                    data.SetCategory(attribute.MimeType);
                    data.SetName($"{resource.Name}");
                }
                else
                {
                    data.SetName(resource.Name);
                }

                yield return data;
            }
        }

        protected IDocument GetDocument(byte[] bytes)
        {
            var target = new DocumentInspector();
            return target.GetDocumentInfo(bytes);
        }
    }
}