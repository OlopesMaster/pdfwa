
namespace pdfwa
{
    partial class Pag1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdPag1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPag1 = new System.Windows.Forms.Label();
            this.cmdInserirPag1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdPag1
            // 
            this.ofdPag1.FileName = "ofdPag1";
            // 
            // lblPag1
            // 
            this.lblPag1.AutoSize = true;
            this.lblPag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag1.Location = new System.Drawing.Point(10, 9);
            this.lblPag1.Name = "lblPag1";
            this.lblPag1.Size = new System.Drawing.Size(83, 24);
            this.lblPag1.TabIndex = 11;
            this.lblPag1.Text = "Pagina 1";
            // 
            // cmdInserirPag1
            // 
            this.cmdInserirPag1.Location = new System.Drawing.Point(99, 7);
            this.cmdInserirPag1.Name = "cmdInserirPag1";
            this.cmdInserirPag1.Size = new System.Drawing.Size(78, 33);
            this.cmdInserirPag1.TabIndex = 12;
            this.cmdInserirPag1.Text = "Inserir";
            this.cmdInserirPag1.UseVisualStyleBackColor = true;
            this.cmdInserirPag1.Click += new System.EventHandler(this.cmdInserirPag1_Click);
            // 
            // Pag1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 340);
            this.Controls.Add(this.lblPag1);
            this.Controls.Add(this.cmdInserirPag1);
            this.Name = "Pag1";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdPag1;
        private System.Windows.Forms.Label lblPag1;
        private System.Windows.Forms.Button cmdInserirPag1;
    }
}