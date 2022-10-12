using System;
using System.Collections.Generic;
using System.Data.Common;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LibraryManagamentSystem.FormsUI.Auth;
using LibraryManagementSystem.Entities.Concrete;
using PostSharp.Aspects.Advices;

namespace LibraryManagamentSystem.FormsUI.Utilites.ExportTools
{
    public class ConvertToPDF
    {
   
        public static bool ConvertToPDF_(DataGridView _dgw,string name)
        {

            BaseFont STF_Helvetica_Turkish = BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
            Font fontTitle = new Font(STF_Helvetica_Turkish, 7, iTextSharp.text.Font.NORMAL);

            bool result = false;

            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(_dgw.ColumnCount);

                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.
                pdfTable.DefaultCell.Padding = 3; // hücre duvarı ve veri arasında mesafe
                pdfTable.WidthPercentage = 80; // hücre genişliği
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // yazı hizalaması

                pdfTable.DefaultCell.BorderWidth = 1; // kenarlık kalınlığı
                                                      // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.

               
              

                foreach (DataGridViewColumn column in _dgw.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontTitle));
                    cell.BackgroundColor = new BaseColor(240, 240, 240); // hücre arka plan rengi
                    pdfTable.AddCell(cell);
                }
                try
                {
                    foreach (DataGridViewRow row in _dgw.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }
                    
                    
                }
                catch (NullReferenceException)
                {
                }
               
                    try
                    {
                    FileStream stream = new FileStream(save.FileName, FileMode.CreateNew);
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);// sayfa boyutu.
                        pdfDoc.AddCreator(name);



                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        result = pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
                    catch  {

                    throw new Exception("File name already exists");
                
                }
                
            }
            return result;

        }
       
        
            
    }
}
