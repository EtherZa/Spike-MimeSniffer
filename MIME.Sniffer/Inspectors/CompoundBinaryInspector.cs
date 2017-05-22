namespace MIME.Sniffer.Inspectors
{
    using System.IO;

    using OpenMcdf;

    public abstract class CompoundBinaryInspector : ByteInspector
    {
        protected CompoundBinaryInspector(IDocument document)
            : base(
                document,
                new byte?[]
                    {
                        0xD0,
                        0xCF,
                        0x11,
                        0xE0,
                        0xA1,
                        0xB1,
                        0x1A,
                        0xE1
                    })
        {
        }

        public override bool TryGetDocInfo(Stream stream, out IDocument doc)
        {
            IDocument docInfo;
            if (!base.TryGetDocInfo(stream, out docInfo))
            {
                doc = null;
                return false;
            }

            var cb = new CompoundFile(stream, CFSUpdateMode.ReadOnly, CFSConfiguration.Default);
            try
            {
                if (!this.InspectFile(cb))
                {
                    doc = null;
                    return false;
                }
            }
            finally
            {
                cb.Close(false);
            }

            doc = this.Document;
            return true;
        }

        protected abstract bool InspectFile(CompoundFile file);
    }
}