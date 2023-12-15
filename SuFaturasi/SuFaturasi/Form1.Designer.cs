namespace SuFaturasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbAdSoyad = new System.Windows.Forms.TextBox();
            this.TbSonIndex = new System.Windows.Forms.TextBox();
            this.TbIlkIndex = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbMesken = new System.Windows.Forms.RadioButton();
            this.RbUmumi = new System.Windows.Forms.RadioButton();
            this.BtHesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LbAdiSoyadi = new System.Windows.Forms.ListBox();
            this.LbSuMiktari = new System.Windows.Forms.ListBox();
            this.LbFaturaTutari = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Son İndex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "İlk İndex:";
            // 
            // TbAdSoyad
            // 
            this.TbAdSoyad.Location = new System.Drawing.Point(78, 4);
            this.TbAdSoyad.Name = "TbAdSoyad";
            this.TbAdSoyad.Size = new System.Drawing.Size(308, 20);
            this.TbAdSoyad.TabIndex = 2;
            // 
            // TbSonIndex
            // 
            this.TbSonIndex.Location = new System.Drawing.Point(78, 30);
            this.TbSonIndex.Name = "TbSonIndex";
            this.TbSonIndex.Size = new System.Drawing.Size(308, 20);
            this.TbSonIndex.TabIndex = 3;
            // 
            // TbIlkIndex
            // 
            this.TbIlkIndex.Location = new System.Drawing.Point(78, 56);
            this.TbIlkIndex.Name = "TbIlkIndex";
            this.TbIlkIndex.Size = new System.Drawing.Size(308, 20);
            this.TbIlkIndex.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbMesken);
            this.groupBox1.Controls.Add(this.RbUmumi);
            this.groupBox1.Location = new System.Drawing.Point(78, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanım Yeri";
            // 
            // RbMesken
            // 
            this.RbMesken.AutoSize = true;
            this.RbMesken.Location = new System.Drawing.Point(79, 19);
            this.RbMesken.Name = "RbMesken";
            this.RbMesken.Size = new System.Drawing.Size(63, 17);
            this.RbMesken.TabIndex = 0;
            this.RbMesken.TabStop = true;
            this.RbMesken.Text = "Mesken";
            this.RbMesken.UseVisualStyleBackColor = true;
            // 
            // RbUmumi
            // 
            this.RbUmumi.AutoSize = true;
            this.RbUmumi.Location = new System.Drawing.Point(6, 19);
            this.RbUmumi.Name = "RbUmumi";
            this.RbUmumi.Size = new System.Drawing.Size(57, 17);
            this.RbUmumi.TabIndex = 0;
            this.RbUmumi.TabStop = true;
            this.RbUmumi.Text = "Umumi";
            this.RbUmumi.UseVisualStyleBackColor = true;
            // 
            // BtHesapla
            // 
            this.BtHesapla.Location = new System.Drawing.Point(311, 147);
            this.BtHesapla.Name = "BtHesapla";
            this.BtHesapla.Size = new System.Drawing.Size(75, 23);
            this.BtHesapla.TabIndex = 6;
            this.BtHesapla.Text = "Hesapla";
            this.BtHesapla.UseVisualStyleBackColor = true;
            this.BtHesapla.Click += new System.EventHandler(this.BtHesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adı Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kul. Su Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fatura Tutarı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LbAdiSoyadi
            // 
            this.LbAdiSoyadi.FormattingEnabled = true;
            this.LbAdiSoyadi.Location = new System.Drawing.Point(12, 203);
            this.LbAdiSoyadi.Name = "LbAdiSoyadi";
            this.LbAdiSoyadi.Size = new System.Drawing.Size(116, 329);
            this.LbAdiSoyadi.TabIndex = 7;
            // 
            // LbSuMiktari
            // 
            this.LbSuMiktari.FormattingEnabled = true;
            this.LbSuMiktari.Location = new System.Drawing.Point(142, 203);
            this.LbSuMiktari.Name = "LbSuMiktari";
            this.LbSuMiktari.Size = new System.Drawing.Size(116, 329);
            this.LbSuMiktari.TabIndex = 7;
            // 
            // LbFaturaTutari
            // 
            this.LbFaturaTutari.FormattingEnabled = true;
            this.LbFaturaTutari.Location = new System.Drawing.Point(272, 203);
            this.LbFaturaTutari.Name = "LbFaturaTutari";
            this.LbFaturaTutari.Size = new System.Drawing.Size(116, 329);
            this.LbFaturaTutari.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 541);
            this.Controls.Add(this.LbFaturaTutari);
            this.Controls.Add(this.LbSuMiktari);
            this.Controls.Add(this.LbAdiSoyadi);
            this.Controls.Add(this.BtHesapla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbIlkIndex);
            this.Controls.Add(this.TbSonIndex);
            this.Controls.Add(this.TbAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Su Faturası";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbAdSoyad;
        private System.Windows.Forms.TextBox TbSonIndex;
        private System.Windows.Forms.TextBox TbIlkIndex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbMesken;
        private System.Windows.Forms.RadioButton RbUmumi;
        private System.Windows.Forms.Button BtHesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox LbAdiSoyadi;
        private System.Windows.Forms.ListBox LbSuMiktari;
        private System.Windows.Forms.ListBox LbFaturaTutari;
    }
}

