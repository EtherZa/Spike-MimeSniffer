namespace MIME.Sniffer.Tests 
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;

            
        public class ResourcesCollection : IResourceCollection
        {
            
             public IEnumerable<Resource> All 
             { 
                get
                {
                    return null;   
                }
            }
                    
        public class BmpCollection : IResourceCollection
        {
            
            public Resource _16Colour 
            {
                get
                {
                    return new Resource("_16Colour", @"~\Resources\Bmp\16 Colour.bmp");
                }
            }

        
            public Resource _24bit 
            {
                get
                {
                    return new Resource("_24bit", @"~\Resources\Bmp\24 bit.bmp");
                }
            }

        
            public Resource _256Colour 
            {
                get
                {
                    return new Resource("_256Colour", @"~\Resources\Bmp\256 Colour.bmp");
                }
            }

        
            public Resource _8bit 
            {
                get
                {
                    return new Resource("_8bit", @"~\Resources\Bmp\8 bit.bmp");
                }
            }

        
            public Resource Monochrome 
            {
                get
                {
                    return new Resource("Monochrome", @"~\Resources\Bmp\Monochrome.bmp");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this._16Colour;
                    yield return this._24bit;
                    yield return this._256Colour;
                    yield return this._8bit;
                    yield return this.Monochrome;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Bmp"; } }
        }

        
        public IResourceCollection Bmp 
        { 
            get 
            { 
                return new BmpCollection();
            }
        }
        
        public class CsvCollection : IResourceCollection
        {
            
            public Resource CommaSeparatedNotSpecified 
            {
                get
                {
                    return new Resource("CommaSeparatedNotSpecified", @"~\Resources\Csv\Comma Separated - Not Specified.csv");
                }
            }

        
            public Resource PipeSeparatorSpecified 
            {
                get
                {
                    return new Resource("PipeSeparatorSpecified", @"~\Resources\Csv\Pipe Separator - Specified.csv");
                }
            }

        
            public Resource SemicolonSeparatedNotSpecified 
            {
                get
                {
                    return new Resource("SemicolonSeparatedNotSpecified", @"~\Resources\Csv\Semicolon Separated - Not Specified.csv");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.CommaSeparatedNotSpecified;
                    yield return this.PipeSeparatorSpecified;
                    yield return this.SemicolonSeparatedNotSpecified;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Csv"; } }
        }

        
        public IResourceCollection Csv 
        { 
            get 
            { 
                return new CsvCollection();
            }
        }
        
        public class DocCollection : IResourceCollection
        {
            
            public Resource Word972003 
            {
                get
                {
                    return new Resource("Word972003", @"~\Resources\Doc\Word 97-2003.doc");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.Word972003;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Doc"; } }
        }

        
        public IResourceCollection Doc 
        { 
            get 
            { 
                return new DocCollection();
            }
        }
        
        public class DocxCollection : IResourceCollection
        {
            
            public Resource WordDocument 
            {
                get
                {
                    return new Resource("WordDocument", @"~\Resources\Docx\Word Document.docx");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.WordDocument;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Docx"; } }
        }

        
        public IResourceCollection Docx 
        { 
            get 
            { 
                return new DocxCollection();
            }
        }
        
        public class EmlCollection : IResourceCollection
        {
            
            public Resource RFC822 
            {
                get
                {
                    return new Resource("RFC822", @"~\Resources\Eml\RFC 822.eml");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.RFC822;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Eml"; } }
        }

        
        public IResourceCollection Eml 
        { 
            get 
            { 
                return new EmlCollection();
            }
        }
        
        public class GifCollection : IResourceCollection
        {
            
            public Resource _1bit 
            {
                get
                {
                    return new Resource("_1bit", @"~\Resources\Gif\1 bit.gif");
                }
            }

        
            public Resource _2bit 
            {
                get
                {
                    return new Resource("_2bit", @"~\Resources\Gif\2 bit.gif");
                }
            }

        
            public Resource _8bit 
            {
                get
                {
                    return new Resource("_8bit", @"~\Resources\Gif\8 bit.gif");
                }
            }

        
            public Resource Animated 
            {
                get
                {
                    return new Resource("Animated", @"~\Resources\Gif\Animated.gif");
                }
            }

        
            public Resource Static 
            {
                get
                {
                    return new Resource("Static", @"~\Resources\Gif\Static.gif");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this._1bit;
                    yield return this._2bit;
                    yield return this._8bit;
                    yield return this.Animated;
                    yield return this.Static;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Gif"; } }
        }

        
        public IResourceCollection Gif 
        { 
            get 
            { 
                return new GifCollection();
            }
        }
        
        public class HtmlCollection : IResourceCollection
        {
            
            public Resource _32Final 
            {
                get
                {
                    return new Resource("_32Final", @"~\Resources\Html\3.2 Final.html");
                }
            }

        
            public Resource _401Frameset 
            {
                get
                {
                    return new Resource("_401Frameset", @"~\Resources\Html\4.01 Frameset.html");
                }
            }

        
            public Resource _401Loose 
            {
                get
                {
                    return new Resource("_401Loose", @"~\Resources\Html\4.01 Loose.html");
                }
            }

        
            public Resource _401Strict 
            {
                get
                {
                    return new Resource("_401Strict", @"~\Resources\Html\4.01 Strict.html");
                }
            }

        
            public Resource _5 
            {
                get
                {
                    return new Resource("_5", @"~\Resources\Html\5.html");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this._32Final;
                    yield return this._401Frameset;
                    yield return this._401Loose;
                    yield return this._401Strict;
                    yield return this._5;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Html"; } }
        }

        
        public IResourceCollection Html 
        { 
            get 
            { 
                return new HtmlCollection();
            }
        }
        
        public class JpegCollection : IResourceCollection
        {
            
            public Resource _24bitRGB 
            {
                get
                {
                    return new Resource("_24bitRGB", @"~\Resources\Jpeg\24 bit RGB.jpg");
                }
            }

        
            public Resource Sample 
            {
                get
                {
                    return new Resource("Sample", @"~\Resources\Jpeg\Sample.jpg");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this._24bitRGB;
                    yield return this.Sample;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Jpeg"; } }
        }

        
        public IResourceCollection Jpeg 
        { 
            get 
            { 
                return new JpegCollection();
            }
        }
        
        public class Jpeg2000Collection : IResourceCollection
        {
            
            public Resource _16k 
            {
                get
                {
                    return new Resource("_16k", @"~\Resources\Jpeg2000\16k.jp2");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this._16k;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Jpeg2000"; } }
        }

        
        public IResourceCollection Jpeg2000 
        { 
            get 
            { 
                return new Jpeg2000Collection();
            }
        }
        
        public class MhtCollection : IResourceCollection
        {
            
            public Resource Sample 
            {
                get
                {
                    return new Resource("Sample", @"~\Resources\Mht\Sample.MHTML");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.Sample;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Mht"; } }
        }

        
        public IResourceCollection Mht 
        { 
            get 
            { 
                return new MhtCollection();
            }
        }
        
        public class MsgCollection : IResourceCollection
        {
            
            public Resource OutlookMessageFormatUnicode 
            {
                get
                {
                    return new Resource("OutlookMessageFormatUnicode", @"~\Resources\Msg\Outlook Message Format - Unicode.msg");
                }
            }

        
            public Resource OutlookMessageFormat 
            {
                get
                {
                    return new Resource("OutlookMessageFormat", @"~\Resources\Msg\Outlook Message Format.msg");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.OutlookMessageFormatUnicode;
                    yield return this.OutlookMessageFormat;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Msg"; } }
        }

        
        public IResourceCollection Msg 
        { 
            get 
            { 
                return new MsgCollection();
            }
        }
        
        public class OdpCollection : IResourceCollection
        {
            
            public Resource OpenDocumentPresentation 
            {
                get
                {
                    return new Resource("OpenDocumentPresentation", @"~\Resources\Odp\OpenDocument Presentation.odp");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.OpenDocumentPresentation;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Odp"; } }
        }

        
        public IResourceCollection Odp 
        { 
            get 
            { 
                return new OdpCollection();
            }
        }
        
        public class OdsCollection : IResourceCollection
        {
            
            public Resource OpenDocumentSpreadsheet 
            {
                get
                {
                    return new Resource("OpenDocumentSpreadsheet", @"~\Resources\Ods\OpenDocument Spreadsheet.ods");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.OpenDocumentSpreadsheet;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Ods"; } }
        }

        
        public IResourceCollection Ods 
        { 
            get 
            { 
                return new OdsCollection();
            }
        }
        
        public class OdtCollection : IResourceCollection
        {
            
            public Resource OpenDocumentText 
            {
                get
                {
                    return new Resource("OpenDocumentText", @"~\Resources\Odt\OpenDocument Text.odt");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.OpenDocumentText;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Odt"; } }
        }

        
        public IResourceCollection Odt 
        { 
            get 
            { 
                return new OdtCollection();
            }
        }
        
        public class PdfCollection : IResourceCollection
        {
            
            public Resource _13 
            {
                get
                {
                    return new Resource("_13", @"~\Resources\Pdf\1.3.pdf");
                }
            }

        
            public Resource _14 
            {
                get
                {
                    return new Resource("_14", @"~\Resources\Pdf\1.4.pdf");
                }
            }

        
            public Resource _15 
            {
                get
                {
                    return new Resource("_15", @"~\Resources\Pdf\1.5.pdf");
                }
            }

        
            public Resource _16 
            {
                get
                {
                    return new Resource("_16", @"~\Resources\Pdf\1.6.pdf");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this._13;
                    yield return this._14;
                    yield return this._15;
                    yield return this._16;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Pdf"; } }
        }

        
        public IResourceCollection Pdf 
        { 
            get 
            { 
                return new PdfCollection();
            }
        }
        
        public class PngCollection : IResourceCollection
        {
            
            public Resource _1bitDithered 
            {
                get
                {
                    return new Resource("_1bitDithered", @"~\Resources\Png\1 bit Dithered.png");
                }
            }

        
            public Resource _1bit 
            {
                get
                {
                    return new Resource("_1bit", @"~\Resources\Png\1 bit.png");
                }
            }

        
            public Resource _12bitRGB 
            {
                get
                {
                    return new Resource("_12bitRGB", @"~\Resources\Png\12 bit RGB.png");
                }
            }

        
            public Resource _15bitRGB 
            {
                get
                {
                    return new Resource("_15bitRGB", @"~\Resources\Png\15 bit RGB.png");
                }
            }

        
            public Resource _16bitRGB 
            {
                get
                {
                    return new Resource("_16bitRGB", @"~\Resources\Png\16 bit RGB.png");
                }
            }

        
            public Resource _18bitRGB 
            {
                get
                {
                    return new Resource("_18bitRGB", @"~\Resources\Png\18 bit RGB.png");
                }
            }

        
            public Resource _2bitDithered 
            {
                get
                {
                    return new Resource("_2bitDithered", @"~\Resources\Png\2 bit Dithered.png");
                }
            }

        
            public Resource _2bit 
            {
                get
                {
                    return new Resource("_2bit", @"~\Resources\Png\2 bit.png");
                }
            }

        
            public Resource _3bitRGB 
            {
                get
                {
                    return new Resource("_3bitRGB", @"~\Resources\Png\3 bit RGB.png");
                }
            }

        
            public Resource _4bitdithered 
            {
                get
                {
                    return new Resource("_4bitdithered", @"~\Resources\Png\4 bit dithered.png");
                }
            }

        
            public Resource _4bitRGBI 
            {
                get
                {
                    return new Resource("_4bitRGBI", @"~\Resources\Png\4 bit RGBI.png");
                }
            }

        
            public Resource _4bit 
            {
                get
                {
                    return new Resource("_4bit", @"~\Resources\Png\4 bit.png");
                }
            }

        
            public Resource _48bit 
            {
                get
                {
                    return new Resource("_48bit", @"~\Resources\Png\48 bit.png");
                }
            }

        
            public Resource _6bitRGB 
            {
                get
                {
                    return new Resource("_6bitRGB", @"~\Resources\Png\6 bit RGB.png");
                }
            }

        
            public Resource _8bit 
            {
                get
                {
                    return new Resource("_8bit", @"~\Resources\Png\8 bit.png");
                }
            }

        
            public Resource _9bitRGB 
            {
                get
                {
                    return new Resource("_9bitRGB", @"~\Resources\Png\9 bit RGB.png");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this._1bitDithered;
                    yield return this._1bit;
                    yield return this._12bitRGB;
                    yield return this._15bitRGB;
                    yield return this._16bitRGB;
                    yield return this._18bitRGB;
                    yield return this._2bitDithered;
                    yield return this._2bit;
                    yield return this._3bitRGB;
                    yield return this._4bitdithered;
                    yield return this._4bitRGBI;
                    yield return this._4bit;
                    yield return this._48bit;
                    yield return this._6bitRGB;
                    yield return this._8bit;
                    yield return this._9bitRGB;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Png"; } }
        }

        
        public IResourceCollection Png 
        { 
            get 
            { 
                return new PngCollection();
            }
        }
        
        public class PptCollection : IResourceCollection
        {
            
            public Resource Powerpoint972003Presentation 
            {
                get
                {
                    return new Resource("Powerpoint972003Presentation", @"~\Resources\Ppt\Powerpoint 97-2003 Presentation.ppt");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.Powerpoint972003Presentation;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Ppt"; } }
        }

        
        public IResourceCollection Ppt 
        { 
            get 
            { 
                return new PptCollection();
            }
        }
        
        public class TiffCollection : IResourceCollection
        {
            
            public Resource Sample 
            {
                get
                {
                    return new Resource("Sample", @"~\Resources\Tiff\Sample.tif");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.Sample;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Tiff"; } }
        }

        
        public IResourceCollection Tiff 
        { 
            get 
            { 
                return new TiffCollection();
            }
        }
        
        public class TxtCollection : IResourceCollection
        {
            
            public Resource Ucs2BEBOM 
            {
                get
                {
                    return new Resource("Ucs2BEBOM", @"~\Resources\Txt\Ucs-2 BE BOM.txt");
                }
            }

        
            public Resource Utf8 
            {
                get
                {
                    return new Resource("Utf8", @"~\Resources\Txt\Utf-8.txt");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.Ucs2BEBOM;
                    yield return this.Utf8;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Txt"; } }
        }

        
        public IResourceCollection Txt 
        { 
            get 
            { 
                return new TxtCollection();
            }
        }
        
        public class XlsCollection : IResourceCollection
        {
            
            public Resource Excel972003Workbook 
            {
                get
                {
                    return new Resource("Excel972003Workbook", @"~\Resources\Xls\Excel 97-2003 Workbook.xls");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.Excel972003Workbook;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Xls"; } }
        }

        
        public IResourceCollection Xls 
        { 
            get 
            { 
                return new XlsCollection();
            }
        }
        
        public class XlsxCollection : IResourceCollection
        {
            
            public Resource ExcelWorkbook 
            {
                get
                {
                    return new Resource("ExcelWorkbook", @"~\Resources\Xlsx\Excel Workbook.xlsx");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.ExcelWorkbook;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Xlsx"; } }
        }

        
        public IResourceCollection Xlsx 
        { 
            get 
            { 
                return new XlsxCollection();
            }
        }
        
        public class XpsCollection : IResourceCollection
        {
            
            public Resource Sample 
            {
                get
                {
                    return new Resource("Sample", @"~\Resources\Xps\Sample.xps");
                }
            }

        
             public IEnumerable<Resource> All 
             { 
                get
                {
                    yield return this.Sample;
                }
            }
            
            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    return null;
                }
            }

            public string Name { get { return "Xps"; } }
        }

        
        public IResourceCollection Xps 
        { 
            get 
            { 
                return new XpsCollection();
            }
        }

            public IEnumerable<IResourceCollection> Collections 
            { 
                get
                {
                    yield return this.Bmp; 
                    yield return this.Csv; 
                    yield return this.Doc; 
                    yield return this.Docx; 
                    yield return this.Eml; 
                    yield return this.Gif; 
                    yield return this.Html; 
                    yield return this.Jpeg; 
                    yield return this.Jpeg2000; 
                    yield return this.Mht; 
                    yield return this.Msg; 
                    yield return this.Odp; 
                    yield return this.Ods; 
                    yield return this.Odt; 
                    yield return this.Pdf; 
                    yield return this.Png; 
                    yield return this.Ppt; 
                    yield return this.Tiff; 
                    yield return this.Txt; 
                    yield return this.Xls; 
                    yield return this.Xlsx; 
                    yield return this.Xps; 
                }
            }

            public string Name { get { return "Resources"; } }
        }

    public static class Resources
    {
        static ResourcesCollection defaultCollection = new ResourcesCollection();

        public static ResourcesCollection Default
        {
            get 
            {
                return defaultCollection;
            }
        }
    }

    public interface IResourceCollection
    {
        string Name { get; }

        IEnumerable<IResourceCollection> Collections { get; }

        IEnumerable<Resource> All { get; }
    }

    public sealed class Resource
    {
        static string assemblyPath;

        static Resource()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            assemblyPath = Path.GetDirectoryName(path);
        }

        internal Resource(string name, string fileName)
        {
            this.Name = name;
            this.FullPath = fileName.Replace("~", assemblyPath);
        }

        public string Name { get; private set; }

        public Byte[] Content
        {
            get
            {
                return File.ReadAllBytes(this.FullPath);
            }
        }

        public string FileName 
        { 
            get
            {
               var file = new FileInfo(this.FullPath);
               return file.Name;                                
            }
        }

        public string FullPath { get; }
    }    
}
