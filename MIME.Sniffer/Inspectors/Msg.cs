namespace MIME.Sniffer.Inspectors
{
    using OpenMcdf;

    internal class Msg : CompoundBinaryInspector
    {
        public const string Mime = "application/vnd.ms-outlook";

        public Msg()
            : base(
                new Document
                    {
                        Mime = Msg.Mime
                    })
        {
        }

        protected override bool InspectFile(CompoundFile file)
        {
            var stream = file.RootStorage.TryGetStream("__properties_version1.0");
            return stream != null;
        }
    }
}