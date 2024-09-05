namespace HamburgerWFA
{
    partial class FormEkstra
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
            groupBox1 = new GroupBox();
            btnMalzemeEkle = new Button();
            nmrFiyat = new NumericUpDown();
            txtMalzemeAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnMalzemeEkle);
            groupBox1.Controls.Add(nmrFiyat);
            groupBox1.Controls.Add(txtMalzemeAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİSİ";
            // 
            // btnMalzemeEkle
            // 
            btnMalzemeEkle.Location = new Point(55, 130);
            btnMalzemeEkle.Name = "btnMalzemeEkle";
            btnMalzemeEkle.Size = new Size(159, 54);
            btnMalzemeEkle.TabIndex = 3;
            btnMalzemeEkle.Text = "Ekstra Malzemeyi Kaydet";
            btnMalzemeEkle.UseVisualStyleBackColor = true;
            btnMalzemeEkle.Click += btnMalzemeEkle_Click;
            // 
            // nmrFiyat
            // 
            nmrFiyat.Location = new Point(155, 75);
            nmrFiyat.Name = "nmrFiyat";
            nmrFiyat.Size = new Size(59, 23);
            nmrFiyat.TabIndex = 2;
            // 
            // txtMalzemeAdi
            // 
            txtMalzemeAdi.Location = new Point(134, 40);
            txtMalzemeAdi.Name = "txtMalzemeAdi";
            txtMalzemeAdi.Size = new Size(100, 23);
            txtMalzemeAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 83);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(100, 12);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı:";
            // 
            // FormEkstra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 210);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEkstra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEkstra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMalzemeEkle;
        private NumericUpDown nmrFiyat;
        private TextBox txtMalzemeAdi;
        private Label label2;
        private Label label1;
    }
}