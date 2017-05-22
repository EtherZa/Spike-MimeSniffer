namespace MIME.Sniffer.Inspectors
{
    using OpenMcdf;

    internal class Ppt : CompoundBinaryInspector
    {
        public const string Mime = "application/mspowerpoint";

        public Ppt()
            : base(
                new Document
                    {
                        Mime = Ppt.Mime
                    })
        {
        }

        protected override bool InspectFile(CompoundFile file)
        {
            var stream = file.RootStorage.TryGetStream("PowerPoint Document");
            return stream != null;
        }
    }
}