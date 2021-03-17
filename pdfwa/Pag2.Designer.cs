
namespace pdfwa
{
    partial class Pag2
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
            this.cmdInserirPag2 = new System.Windows.Forms.Button();
            this.lblPag2 = new System.Windows.Forms.Label();
            this.ofdPag1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // cmdInserirPag2
            // 
            this.cmdInserirPag2.Location = new System.Drawing.Point(101, 7);
            this.cmdInserirPag2.Name = "cmdInserirPag2";
            this.cmdInserirPag2.Size = new System.Drawing.Size(78, 33);
            this.cmdInserirPag2.TabIndex = 11;
            this.cmdInserirPag2.Text = "c";
            this.cmdInserirPag2.UseVisualStyleBackColor = true;
            this.cmdInserirPag2.Click += new System.EventHandler(this.cmdInserirPag2_Click);
            // 
            // lblPag2
            // 
            this.lblPag2.AutoSize = true;
            this.lblPag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag2.Location = new System.Drawing.Point(12, 9);
            this.lblPag2.Name = "lblPag2";
            this.lblPag2.Size = new System.Drawing.Size(83, 24);
            this.lblPag2.TabIndex = 10;
            this.lblPag2.Text = "Pagina 2";
            // 
            // ofdPag1
            // 
            this.ofdPag1.FileName = "ofdPag1";
            // 
            // Pag2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 340);
            this.Controls.Add(this.cmdInserirPag2);
            this.Controls.Add(this.lblPag2);
            this.Name = "Pag2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdInserirPag2;
        private System.Windows.Forms.Label lblPag2;
        private System.Windows.Forms.OpenFileDialog ofdPag1;
    }
}