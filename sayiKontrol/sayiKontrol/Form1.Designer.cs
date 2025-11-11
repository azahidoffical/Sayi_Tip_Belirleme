namespace sayiKontrol
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKontrol = new System.Windows.Forms.Button();
            this.tbGirdi = new System.Windows.Forms.TextBox();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.lbBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(223, 192);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(202, 66);
            this.btnKontrol.TabIndex = 0;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // tbGirdi
            // 
            this.tbGirdi.Location = new System.Drawing.Point(223, 142);
            this.tbGirdi.Multiline = true;
            this.tbGirdi.Name = "tbGirdi";
            this.tbGirdi.Size = new System.Drawing.Size(202, 44);
            this.tbGirdi.TabIndex = 1;
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 16;
            this.lbSonuc.Location = new System.Drawing.Point(431, 142);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(207, 116);
            this.lbSonuc.TabIndex = 2;
            // 
            // lbBaslik
            // 
            this.lbBaslik.AutoSize = true;
            this.lbBaslik.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBaslik.Location = new System.Drawing.Point(175, 97);
            this.lbBaslik.Name = "lbBaslik";
            this.lbBaslik.Size = new System.Drawing.Size(501, 24);
            this.lbBaslik.TabIndex = 3;
            this.lbBaslik.Text = "Sayının Muhteşem, Zengin sayı olduğunu kontrol etme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rough Rakoon Out PERSONAL USE", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(351, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "azahidoffical";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBaslik);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.tbGirdi);
            this.Controls.Add(this.btnKontrol);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.TextBox tbGirdi;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Label lbBaslik;
        private System.Windows.Forms.Label label1;
    }
}

