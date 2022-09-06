
using P05BibliotekaZawodnikVM;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04BibliotekaPDF
{
    public class PdfManager
    {

        public string StworzPDF(ZawodnikVM[] zawodnicy)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            for(int i = 0; i < zawodnicy.Length; i++)
            {
                string napis = zawodnicy[i].Imie + " " + zawodnicy[i].Nazwisko + " " + zawodnicy[i].Kraj;
                gfx.DrawString(napis, font, XBrushes.Blue, 50, 100 + i * 30);
            }

            // Save the document...
            string filename = DateTime.Now.ToString("ddMMyyyyHHmmss") + "raport.pdf";
            document.Save(filename);
            // ...and start a viewer.
            //Process.Start(filename);
            return filename;
        }
    }

}
