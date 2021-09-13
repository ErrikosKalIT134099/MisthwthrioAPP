using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisthwthrioAppV2
{
    class pdfMerge
    {

        public void pdfMergeMethod(string path1,string path2,string outputNamePath)
        {
            try
            {
                using (PdfDocument one = PdfSharp.Pdf.IO.PdfReader.Open(path1, PdfDocumentOpenMode.Import))
                using (PdfDocument two = PdfReader.Open(path2, PdfDocumentOpenMode.Import))


                using (PdfDocument outPdf = new PdfDocument())
                {
                    CopyPages(one, outPdf);
                    CopyPages(two, outPdf);

                    outPdf.Save(outputNamePath);
                }

                void CopyPages(PdfDocument from, PdfDocument to)
                {
                    for (int i = 0; i < from.PageCount; i++)
                    {
                        to.AddPage(from.Pages[i]);
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error Type: " + er.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
