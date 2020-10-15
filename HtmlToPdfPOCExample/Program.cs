using DinkToPdf;

namespace DinkToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = 
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Landscape,
                    PaperSize = PaperKind.A4Plus,
                    Out = @"D:\Temp\Yarmill.pdf",
                },
                Objects = {
                    new ObjectSettings()
                    {
                        Page = "https://www.whatsmybrowser.org/"
                        // Page = "https://ywa-740-browser-check--friendly-hermann-eceb82.netlify.app/plan/week?group=93&week=2020-09-29&avoidBrowserCheck=1",
                    }
                }
            };

            var converter = new BasicConverter(new PdfTools());
            converter.Convert(doc);
        }
    }
}
