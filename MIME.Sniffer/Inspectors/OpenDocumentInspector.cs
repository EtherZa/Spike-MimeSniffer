namespace MIME.Sniffer.Inspectors
{
    using System;
    using System.IO;

    using ICSharpCode.SharpZipLib.Zip;

    internal class OpenDocumentInspector : ByteInspector
    {
        public OpenDocumentInspector(IDocument document)
            : base(
                document,
                new byte?[]
                    {
                        0x50,
                        0x4B,
                        0x03,
                        0x04
                    })
        {
        }

        public override bool TryGetDocInfo(Stream stream, out IDocument doc)
        {
            if (!base.TryGetDocInfo(stream, out doc))
            {
                return false;
            }

            stream.Seek(0, SeekOrigin.Begin);

            using (var zipStream = new MemoryStream())
            {
                // copy so that primary stream is not closed automatically
                stream.CopyToAsync(zipStream);
                using (var zip = new ZipFile(zipStream))
                {
                    foreach (ZipEntry entry in zip)
                    {
                        if (entry.Name.Equals("mimetype", StringComparison.OrdinalIgnoreCase))
                        {
                            if (entry.CanDecompress)
                            {
                                using (var sr = new StreamReader(zip.GetInputStream(entry)))
                                {
                                    string value = sr.ReadToEnd();
                                    if (value.Equals(this.Document.Mime))
                                    {
                                        doc = this.Document;
                                        return true;
                                    }

                                    // not in this zip
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            doc = null;
            return false;
        }
    }
}