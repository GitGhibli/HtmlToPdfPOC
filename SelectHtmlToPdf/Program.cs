using SelectPdf;

namespace SelectHtmlToPdf
{
    class Program
    {
        //https://selectpdf.com/html-to-pdf/docs/html/License.htm
        static void Main(string[] args)
        {
            var htmlToPdf = new HtmlToPdf();

            var result = htmlToPdf.ConvertUrl("https://www.whatsmybrowser.org/");
            result.Save(@"C:\Temp\SelectHtmlToPdf.pdf");
        }
    }
}
