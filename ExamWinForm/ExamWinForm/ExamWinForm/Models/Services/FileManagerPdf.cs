using ExamWinForm.Entity;
using ExamWinForm.Interfaces;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ExamWinForm.Models
{
    public class FileManagerPdf : IFileManager<List<Task>>
    {
        static int  count=0;
        public void SaveToFile(List<Task> items)
        {

            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            document.Info.Title = "List tasks";

            XFont font = new XFont("Verdana", 9, XFontStyle.Italic);

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

           
            var savefile = items.ToArray();
            ;
            int heigth = 0;
            for (int i = 0; i < savefile.Count(); i++)
            {
                var s = savefile[i].ToString();
                gfx.DrawString(s, font, XBrushes.Black, new XRect(0, heigth, page.Width, page.Height), XStringFormats.TopLeft);
                heigth += 10;
            }

            // Save the document...
            string filename = $"Tasks\\Tasks{++count}.pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }
    }
}
