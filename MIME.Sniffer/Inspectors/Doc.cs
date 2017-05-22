namespace MIME.Sniffer.Inspectors
{
    using OpenMcdf;

    internal class Doc : CompoundBinaryInspector
    {
        public const string Mime = "application/msword";

        public Doc()
            : base(
                new Document
                    {
                        Mime = Doc.Mime
                    })
        {
        }

        protected override bool InspectFile(CompoundFile file)
        {
            var stream = file.RootStorage.TryGetStream("WordDocument");
            return stream != null;
        }
    }
}