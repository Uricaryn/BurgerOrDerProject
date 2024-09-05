namespace HamburgerWFA
{
    partial class FormTumSiparisler
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
            lstTumSiparisler = new ListBox();
            label1 = new Label();
            grpCiro = new GroupBox();
            lblCiro = new Label();
            grpToplamSiparisSayisi = new GroupBox();
            lblToplamSiparisSayisi = new Label();
            grpEkstraMalzemeGeliri = new GroupBox();
            lblEkstraMalzemeGeliri = new Label();
            grpSatilanUrunAdedi = new GroupBox();
            lblSatilanUrunAdedi = new Label();
            grpCiro.SuspendLayout();
            grpToplamSiparisSayisi.SuspendLayout();
            grpEkstraMalzemeGeliri.SuspendLayout();
            grpSatilanUrunAdedi.SuspendLayout();
            SuspendLayout();
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 15;
            lstTumSiparisler.Location = new Point(12, 38);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(160, 424);
            lstTumSiparisler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Tüm Siparişler";
            // 
            // grpCiro
            // 
            grpCiro.Controls.Add(lblCiro);
            grpCiro.Location = new Point(206, 38);
            grpCiro.Name = "grpCiro";
            grpCiro.Size = new Size(178, 86);
            grpCiro.TabIndex = 2;
            grpCiro.TabStop = false;
            grpCiro.Text = "CİRO";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(31, 33);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(13, 15);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "0";
            // 
            // grpToplamSiparisSayisi
            // 
            grpToplamSiparisSayisi.Controls.Add(lblToplamSiparisSayisi);
            grpToplamSiparisSayisi.Location = new Point(206, 142);
            grpToplamSiparisSayisi.Name = "grpToplamSiparisSayisi";
            grpToplamSiparisSayisi.Size = new Size(178, 87);
            grpToplamSiparisSayisi.TabIndex = 2;
            grpToplamSiparisSayisi.TabStop = false;
            grpToplamSiparisSayisi.Text = "TOPLAM SİPARİŞ SAYISI";
            // 
            // lblToplamSiparisSayisi
            // 
            lblToplamSiparisSayisi.AutoSize = true;
            lblToplamSiparisSayisi.ForeColor = Color.Red;
            lblToplamSiparisSayisi.Location = new Point(31, 33);
            lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            lblToplamSiparisSayisi.Size = new Size(13, 15);
            lblToplamSiparisSayisi.TabIndex = 0;
            lblToplamSiparisSayisi.Text = "0";
            // 
            // grpEkstraMalzemeGeliri
            // 
            grpEkstraMalzemeGeliri.Controls.Add(lblEkstraMalzemeGeliri);
            grpEkstraMalzemeGeliri.Location = new Point(206, 254);
            grpEkstraMalzemeGeliri.Name = "grpEkstraMalzemeGeliri";
            grpEkstraMalzemeGeliri.Size = new Size(178, 93);
            grpEkstraMalzemeGeliri.TabIndex = 2;
            grpEkstraMalzemeGeliri.TabStop = false;
            grpEkstraMalzemeGeliri.Text = "EKSTRA MALZEME GELİRİ";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.ForeColor = Color.Red;
            lblEkstraMalzemeGeliri.Location = new Point(31, 33);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(13, 15);
            lblEkstraMalzemeGeliri.TabIndex = 0;
            lblEkstraMalzemeGeliri.Text = "0";
            // 
            // grpSatilanUrunAdedi
            // 
            grpSatilanUrunAdedi.Controls.Add(lblSatilanUrunAdedi);
            grpSatilanUrunAdedi.Location = new Point(206, 367);
            grpSatilanUrunAdedi.Name = "grpSatilanUrunAdedi";
            grpSatilanUrunAdedi.Size = new Size(178, 93);
            grpSatilanUrunAdedi.TabIndex = 2;
            grpSatilanUrunAdedi.TabStop = false;
            grpSatilanUrunAdedi.Text = "SATILAN ÜRÜN ADEDİ";
            // 
            // lblSatilanUrunAdedi
            // 
            lblSatilanUrunAdedi.AutoSize = true;
            lblSatilanUrunAdedi.ForeColor = Color.Red;
            lblSatilanUrunAdedi.Location = new Point(31, 33);
            lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            lblSatilanUrunAdedi.Size = new Size(13, 15);
            lblSatilanUrunAdedi.TabIndex = 0;
            lblSatilanUrunAdedi.Text = "0";
            // 
            // FormTumSiparisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(402, 474);
            Controls.Add(grpSatilanUrunAdedi);
            Controls.Add(grpEkstraMalzemeGeliri);
            Controls.Add(grpToplamSiparisSayisi);
            Controls.Add(grpCiro);
            Controls.Add(label1);
            Controls.Add(lstTumSiparisler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTumSiparisler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTumSiparişler";
            Load += FormTumSiparisler_Load;
            grpCiro.ResumeLayout(false);
            grpCiro.PerformLayout();
            grpToplamSiparisSayisi.ResumeLayout(false);
            grpToplamSiparisSayisi.PerformLayout();
            grpEkstraMalzemeGeliri.ResumeLayout(false);
            grpEkstraMalzemeGeliri.PerformLayout();
            grpSatilanUrunAdedi.ResumeLayout(false);
            grpSatilanUrunAdedi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTumSiparisler;
        private Label label1;
        private GroupBox grpCiro;
        private Label lblCiro;
        private GroupBox grpToplamSiparisSayisi;
        private Label lblToplamSiparisSayisi;
        private GroupBox grpEkstraMalzemeGeliri;
        private Label lblEkstraMalzemeGeliri;
        private GroupBox grpSatilanUrunAdedi;
        private Label lblSatilanUrunAdedi;
    }
}