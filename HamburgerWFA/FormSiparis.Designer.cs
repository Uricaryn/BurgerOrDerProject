namespace HamburgerWFA
{
    partial class FormSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparis));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbMenuler = new ComboBox();
            rdbKucuk = new RadioButton();
            rdbOrta = new RadioButton();
            rdbBuyuk = new RadioButton();
            label3 = new Label();
            flpEkstraMalzemeler = new FlowLayoutPanel();
            label4 = new Label();
            nmrAdet = new NumericUpDown();
            groupBox1 = new GroupBox();
            btnSiparisEkle = new Button();
            lstSiparisler = new ListBox();
            label2 = new Label();
            lblToplamTutar = new Label();
            btnSiparisiTamamla = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(92, 242);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİN";
            // 
            // cmbMenuler
            // 
            cmbMenuler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuler.FormattingEnabled = true;
            cmbMenuler.Location = new Point(12, 272);
            cmbMenuler.Name = "cmbMenuler";
            cmbMenuler.Size = new Size(254, 23);
            cmbMenuler.TabIndex = 2;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Location = new Point(6, 22);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(58, 19);
            rdbKucuk.TabIndex = 3;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Location = new Point(70, 22);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(48, 19);
            rdbOrta.TabIndex = 3;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Location = new Point(136, 22);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(58, 19);
            rdbBuyuk.TabIndex = 3;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(22, 401);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 1;
            label3.Text = "EKSTRA MALZEME SEÇİN";
            // 
            // flpEkstraMalzemeler
            // 
            flpEkstraMalzemeler.Location = new Point(12, 419);
            flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            flpEkstraMalzemeler.Size = new Size(254, 137);
            flpEkstraMalzemeler.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 583);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 5;
            label4.Text = "ADET";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(133, 583);
            nmrAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(133, 23);
            nmrAdet.TabIndex = 6;
            nmrAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbKucuk);
            groupBox1.Controls.Add(rdbOrta);
            groupBox1.Controls.Add(rdbBuyuk);
            groupBox1.ForeColor = Color.Green;
            groupBox1.Location = new Point(21, 312);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 70);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOYUT SEÇİNİZ";
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(12, 625);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(254, 60);
            btnSiparisEkle.TabIndex = 8;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 15;
            lstSiparisler.Location = new Point(316, 21);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(449, 454);
            lstSiparisler.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(350, 501);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 10;
            label2.Text = "TOPLAM TUTAR";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(477, 501);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(14, 15);
            lblToplamTutar.TabIndex = 11;
            lblToplamTutar.Text = "0";
            // 
            // btnSiparisiTamamla
            // 
            btnSiparisiTamamla.BackColor = Color.PaleTurquoise;
            btnSiparisiTamamla.Location = new Point(619, 529);
            btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            btnSiparisiTamamla.Size = new Size(120, 41);
            btnSiparisiTamamla.TabIndex = 8;
            btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            btnSiparisiTamamla.UseVisualStyleBackColor = false;
            btnSiparisiTamamla.Click += button1_Click;
            // 
            // FormSiparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 697);
            Controls.Add(lblToplamTutar);
            Controls.Add(label2);
            Controls.Add(lstSiparisler);
            Controls.Add(btnSiparisiTamamla);
            Controls.Add(btnSiparisEkle);
            Controls.Add(groupBox1);
            Controls.Add(nmrAdet);
            Controls.Add(label4);
            Controls.Add(flpEkstraMalzemeler);
            Controls.Add(cmbMenuler);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSiparis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSiparis";
            Load += FormSiparis_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbMenuler;
        private RadioButton rdbKucuk;
        private RadioButton rdbOrta;
        private RadioButton rdbBuyuk;
        private Label label3;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private Label label4;
        private NumericUpDown nmrAdet;
        private GroupBox groupBox1;
        private Button btnSiparisEkle;
        private ListBox lstSiparisler;
        private Label label2;
        private Label lblToplamTutar;
        private Button btnSiparisiTamamla;
    }
}