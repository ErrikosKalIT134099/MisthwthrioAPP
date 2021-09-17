using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisthwthrioAppV2
{
    class syncFusionRTFtoPdf
    {

        public void rtfToPDF(string rtfPath,string pdfExportPath)
        {
            //Create a new PDF document
            PdfDocument doc = new PdfDocument();
            //Add a page
            PdfPage page = doc.Pages.Add();
            SizeF bounds = page.GetClientSize();
            //Read RTF document
            StreamReader reader = new StreamReader(rtfPath, Encoding.ASCII);
            string text = reader.ReadToEnd();
            reader.Close();
            //Convert it to metafile
            PdfMetafile imageMetafile = (PdfMetafile)PdfImage.FromRtf(text, bounds.Width, PdfImageType.Metafile);
            PdfMetafileLayoutFormat format = new PdfMetafileLayoutFormat();
            //Allow text to flow multiple pages without any break
            format.SplitTextLines = true;
            //Draws image
            imageMetafile.Draw(page, 0, 0, format);
            //Save the document
            doc.Save(pdfExportPath);
            doc.Close(true);
            //This will open the PDF file so, the result will be seen in default PDF viewer
            Process.Start(pdfExportPath);
            
        }
    }
}
