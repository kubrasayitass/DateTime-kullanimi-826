namespace DateTime_826
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSuan = new System.Windows.Forms.Label();
            this.lblBugun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(12, 43);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSuan
            // 
            this.lblSuan.AutoSize = true;
            this.lblSuan.Location = new System.Drawing.Point(130, 53);
            this.lblSuan.Name = "lblSuan";
            this.lblSuan.Size = new System.Drawing.Size(30, 13);
            this.lblSuan.TabIndex = 1;
            this.lblSuan.Text = "şuan";
            // 
            // lblBugun
            // 
            this.lblBugun.AutoSize = true;
            this.lblBugun.Location = new System.Drawing.Point(130, 91);
            this.lblBugun.Name = "lblBugun";
            this.lblBugun.Size = new System.Drawing.Size(37, 13);
            this.lblBugun.TabIndex = 2;
            this.lblBugun.Text = "bugün";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBugun);
            this.Controls.Add(this.lblSuan);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSuan;
        private System.Windows.Forms.Label lblBugun;
    }
}

