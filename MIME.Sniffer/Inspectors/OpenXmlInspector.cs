namespace MIME.Sniffer.Inspectors
{
    using System;
    using System.IO;
    using System.Xml;

    using ICSharpCode.SharpZipLib.Zip;

    internal abstract class OpenXmlInspector : ByteInspector
    {
        private readonly string relationshipType;

        protected OpenXmlInspector(IDocument document, string relationshipType)
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
            this.relationshipType = relationshipType;
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
                    var rels = zip.GetEntry("_rels/.rels");
                    if (rels != null)
                    {
                        using (var relsStream = zip.GetInputStream(rels))
                        {
                            var x = new XmlDocument();
                            x.Load(relsStream);

                            var officeNamespace = "http://schemas.openxmlformats.org/package/2006/relationships";
                            var nsmgr = new XmlNamespaceManager(x.NameTable);
                            nsmgr.AddNamespace("o", officeNamespace);

                            var docType = x.SelectSingleNode(string.Format("/o:Relationships/o:Relationship[@Type='{0}']/@Target", this.relationshipType), nsmgr);
                            if (docType != null)
                            {
                                var path = docType.Value;
                                if (path.StartsWith("/"))
                                {
                                    path = path.Substring(1);
                                }

                                var target = zip.GetEntry(path);
                                if (target != null)
                                {
                                    using (var targetStream = zip.GetInputStream(target))
                                    {
                                        try
                                        {
                                            // targetStream is not seekable
                                            using (var ms = new MemoryStream())
                                            {
                                                targetStream.CopyTo(ms);
                                                ms.Seek(0, SeekOrigin.Begin);

                                                if (this.InspectTarget(path, ms))
                                                {
                                                    doc = this.Document;
                                                    return true;
                                                }
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            // yes, swallow
                                            doc = null;
                                            return false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            doc = null;
            return false;
        }

        protected abstract bool InspectTarget(string filename, Stream stream);
    }
}