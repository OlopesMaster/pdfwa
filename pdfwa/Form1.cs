using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PdfiumViewer;
namespace pdfwa
{
    public partial class Form1 : Form
    {
        string caminhopdf = "";
        public Form1()
        {
            InitializeComponent();
            Pag1 frm = new Pag1();
            frm.TopLevel = false;
            pnlForm1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();

            Pag2 frm2 = new Pag2();
            frm2.TopLevel = false;
            pnlForm2.Controls.Add(frm2);
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();

            caminhopdf = caminho.SelectedPath;
        }
        
        private void juntar_Click(object sender, EventArgs e)
        {
            PdfReader PDF1 = new PdfReader(Pag1.caminho1);
            PdfReader PDF2 = new PdfReader(Pag2.caminho2);
            Document PDFNEW = new Document();

            PdfCopy juntar = new PdfCopy(PDFNEW, new FileStream(caminhopdf+"\\" + txtNomeArquivo.Text+".pdf", FileMode.Create));
            PDFNEW.Open();

            PdfImportedPage importa1 = juntar.GetImportedPage(PDF1, 1);
            PdfImportedPage importa2 = juntar.GetImportedPage(PDF2, 1);

            juntar.AddPage(importa1);
            juntar.AddPage(importa2);

            PDF1.Close();
            PDF2.Close();
            juntar.Close();
            PDFNEW.Close();

            MessageBox.Show("ok");

        }
        
        private void btnSalvarCaminho_Click(object sender, EventArgs e)
        {
            
            if (caminho.ShowDialog() == DialogResult.OK)
            {
                caminhopdf = caminho.SelectedPath;
                lblcaminho.Text = caminhopdf;
            }
        }
    }
}
