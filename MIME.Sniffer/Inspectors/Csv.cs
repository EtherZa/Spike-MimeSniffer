namespace MIME.Sniffer.Inspectors
{
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    using CsvHelper;
    using CsvHelper.Configuration;

    using MIME.Sniffer.Metadata;

    internal class Csv : IDocStreamInspector
    {
        public const string Mime = "text/csv";

        private static readonly Regex SepRegex;

        static Csv()
        {
            Csv.SepRegex = new Regex("^sep=(?<Delimeter>.+)", RegexOptions.Compiled | RegexOptions.Singleline);
        }

        public bool TryGetDocInfo(Stream stream, out IDocument document)
        {
            var delimiters = new[]
                                 {
                                     ",",
                                     ";"
                                 };

            if (stream.Position != 0)
            {
                stream.Seek(0, SeekOrigin.Begin);
            }

            string firstLine;
            using (var reader = new StreamReader(stream, Encoding.Default, true, 1024, true))
            {
                firstLine = reader.ReadLine();
            }

            if (!string.IsNullOrWhiteSpace(firstLine))
            {
                var match = Csv.SepRegex.Match(firstLine);
                if (match.Success)
                {
                    var config = new CsvConfiguration
                                     {
                                         HasExcelSeparator = true
                                     };
                    if (this.TestConfig(stream, config))
                    {
                        document = this.CreateDocInfo(
                            new CsvMetadata
                                {
                                    DelimeterSpecified = true,
                                    Delimeter = match.Groups["Delimeter"].Value
                                });
                        return true;
                    }
                }
            }

            foreach (var delimiter in delimiters)
            {
                var config = new CsvConfiguration
                                 {
                                     Delimiter = delimiter
                                 };
                if (this.TestConfig(stream, config))
                {
                    document = this.CreateDocInfo(
                        new CsvMetadata
                            {
                                Delimeter = delimiter
                            });
                    return true;
                }
            }

            document = null;
            return false;
        }

        private IDocument CreateDocInfo(CsvMetadata metadata)
        {
            return new Document
                       {
                           Mime = Csv.Mime,
                           Metadata = metadata
                       };
        }

        /// <summary>
        /// Will test a particular config for
        ///     1. A minimum of 2 columns
        ///     2. A minimum of 2 rows
        ///     2. All rows have the same number of columns
        /// </summary>
        private bool TestConfig(Stream stream, CsvConfiguration config)
        {
            try
            {
                if (stream.Position != 0)
                {
                    stream.Seek(0, SeekOrigin.Begin);
                }

                using (var reader = new StreamReader(stream, Encoding.Default, true, 1024, true))
                {
                    config.DetectColumnCountChanges = true;

                    var csv = new CsvParser(reader, config);
                    var row = csv.Read();
                    if (row != null && row.Length > 1)
                    {
                        var rows = 0;
                        do
                        {
                            row = csv.Read();
                            rows++;
                        }
                        while (rows <= 5 && row != null);

                        if (rows > 1)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (CsvBadDataException)
            {
            }

            return false;
        }
    }
}