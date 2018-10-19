using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPdf;

namespace Facturas
{
    class pdfHelper
    {
        public void createPdfFromHtmlFile(string OutputPath, string fileHtml) {
            // Create a PDF from an existing HTML using C#
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHTMLFileAsPdf(fileHtml);
            PDF.SaveAs(OutputPath);
            System.Diagnostics.Process.Start(OutputPath);
        }
        public void createPdfHtml(string OutputPath, string textHtml)
        {
            // Render any HTML fragment or document to HTML
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHtmlAsPdf(textHtml);
            PDF.SaveAs(OutputPath);
            // This neat trick opens our PDF file so we can see the result in our default PDF viewer
            System.Diagnostics.Process.Start(OutputPath);
        }
        public void createPdfFromUrl(string OutputPath, string url)
        {
            // Create a PDF from any existing web page
            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderUrlAsPdf(url);
            PDF.SaveAs(OutputPath);
            // This neat trick opens our PDF file so we can see the result
            System.Diagnostics.Process.Start(OutputPath);
        }
    }
}
