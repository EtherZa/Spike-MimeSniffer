namespace MIME.Sniffer.Inspectors
{
    using OpenMcdf;

    public class Xls : CompoundBinaryInspector
    {
        public const string Mime = "application/excel";

        public Xls()
            : base(
                new Document
                    {
                        Mime = Xls.Mime
                    })
        {
        }

        protected override bool InspectFile(CompoundFile file)
        {
            var stream = file.RootStorage.TryGetStream("Workbook");
            return stream != null;
        }
    }
}