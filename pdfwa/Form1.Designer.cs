
namespace pdfwa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.juntar = new System.Windows.Forms.Button();
            this.ofdPag1 = new System.Windows.Forms.OpenFileDialog();
            this.ofdPag2 = new System.Windows.Forms.OpenFileDialog();
            this.sfdJuntar = new System.Windows.Forms.SaveFileDialog();
            this.pnlForm1 = new System.Windows.Forms.Panel();
            this.pnlForm2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.caminho = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSalvarCaminho = new System.Windows.Forms.Button();
            this.lblcaminho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Location = new System.Drawing.Point(286, 441);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(204, 20);
            this.txtNomeArquivo.TabIndex = 11;
            this.txtNomeArquivo.Text = "OS";
            // 
            // juntar
            // 
            this.juntar.Location = new System.Drawing.Point(286, 479);
            this.juntar.Name = "juntar";
            this.juntar.Size = new System.Drawing.Size(204, 106);
            this.juntar.TabIndex = 6;
            this.juntar.Text = "Juntar";
            this.juntar.UseVisualStyleBackColor = true;
            this.juntar.Click += new System.EventHandler(this.juntar_Click);
            // 
            // ofdPag1
            // 
            this.ofdPag1.FileName = "openFileDialog1";
            // 
            // ofdPag2
            // 
            this.ofdPag2.FileName = "openFileDialog2";
            // 
            // pnlForm1
            // 
            this.pnlForm1.Location = new System.Drawing.Point(15, 2);
            this.pnlForm1.Name = "pnlForm1";
            this.pnlForm1.Size = new System.Drawing.Size(290, 379);
            this.pnlForm1.TabIndex = 12;
            // 
            // pnlForm2
            // 
            this.pnlForm2.Location = new System.Drawing.Point(496, 2);
            this.pnlForm2.Name = "pnlForm2";
            this.pnlForm2.Size = new System.Drawing.Size(290, 379);
            this.pnlForm2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = ".pdf";
            // 
            // caminho
            // 
            this.caminho.SelectedPath = "C:\\Users\\olope\\Desktop";
            // 
            // btnSalvarCaminho
            // 
            this.btnSalvarCaminho.Location = new System.Drawing.Point(266, 387);
            this.btnSalvarCaminho.Name = "btnSalvarCaminho";
            this.btnSalvarCaminho.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCaminho.TabIndex = 15;
            this.btnSalvarCaminho.Text = "salvar em:";
            this.btnSalvarCaminho.UseVisualStyleBackColor = true;
            this.btnSalvarCaminho.Click += new System.EventHandler(this.btnSalvarCaminho_Click);
            // 
            // lblcaminho
            // 
            this.lblcaminho.AutoSize = true;
            this.lblcaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaminho.Location = new System.Drawing.Point(283, 413);
            this.lblcaminho.Name = "lblcaminho";
            this.lblcaminho.Size = new System.Drawing.Size(154, 16);
            this.lblcaminho.TabIndex = 16;
            this.lblcaminho.Text = "C:\\Users\\olope\\Desktop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 597);
            this.Controls.Add(this.lblcaminho);
            this.Controls.Add(this.btnSalvarCaminho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlForm2);
            this.Controls.Add(this.pnlForm1);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.juntar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.Button juntar;
        private System.Windows.Forms.OpenFileDialog ofdPag1;
        private System.Windows.Forms.OpenFileDialog ofdPag2;
        private System.Windows.Forms.SaveFileDialog sfdJuntar;
        private System.Windows.Forms.Panel pnlForm1;
        private System.Windows.Forms.Panel pnlForm2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog caminho;
        private System.Windows.Forms.Button btnSalvarCaminho;
        private System.Windows.Forms.Label lblcaminho;
    }
}

