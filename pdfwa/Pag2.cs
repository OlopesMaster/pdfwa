using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfiumViewer;


namespace pdfwa
{
    public partial class Pag2 : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public Pag2()
        {
            InitializeComponent();
            pdf = new PdfViewer();
            pdf.Height = 311;
            pdf.Width = 341;
            this.Controls.Add(pdf);
        }



        public static string caminho2;
        private void cmdInserirPag2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;


            ofdPag1.InitialDirectory = "C:\\Users\\olope\\Desktop";
            ofdPag1.RestoreDirectory = false;

            if (ofdPag1.ShowDialog() == DialogResult.OK)
            {
                filePath = ofdPag1.FileName;
                //MessageBox.Show();
                byte[] bytes = System.IO.File.ReadAllBytes(filePath);
                var stream = new System.IO.MemoryStream(bytes);
                PdfDocument pdfDocument = PdfDocument.Load(stream);
                pdf.Document = pdfDocument;
                caminho2 = filePath;
                //sbyte
                //frm.Close();
            }
        }
    }
}
