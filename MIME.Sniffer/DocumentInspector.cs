namespace MIME.Sniffer
{
    using System;
    using System.Diagnostics;
    using System.IO;

    using MIME.Sniffer.Inspectors;

    public class DocumentInspector : IDocumentInspector
    {
        private readonly IDocStreamInspector[] streamInspectors;

        public DocumentInspector()
        {
            // order is important
            this.streamInspectors = new IDocStreamInspector[]
                {
                    // PDF
                    new Pdf(), new Xps(),

                    // Images
                    new Bmp(), new Gif(), new Tiff(), new Png(), new Jpeg(), new Jpeg2000(), new Icon(),

                    // Word
                    new Doc(), new Rtf(), new Docx(), new Odt(),

                    // Excel
                    new Xls(), new Xlsx(), new Xlsb(), new Ods(),

                    // PPT
                    new Ppt(), new Ppptx(), new Odp(),

                    // Email
                    new Msg(), new Mht(), new Eml(),

                    // VCF
                    new Vcf(),

                    // HTML
                    new Html(),

                    // ZIP (must be after open xml inspectors)
                    new Zip(),

                    // CSV
                    new Csv(),

                    // Txt
                    new Txt()
                };
        }

        public IDocument GetDocumentInfo(byte[] doc)
        {
            using (var ms = new MemoryStream(doc))
            {
                foreach (var inspector in this.streamInspectors)
                {
                    try
                    {
                        IDocument info;
                        if (inspector.TryGetDocInfo(ms, out info))
                        {
                            return info;
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine($"An error occurred while using inspector '{inspector}'");

                        ex.Data.Add("Inspector", inspector.ToString());
                        throw;
                    }
                }
            }

            return null;
        }
    }
}