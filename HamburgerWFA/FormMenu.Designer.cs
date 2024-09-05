namespace HamburgerWFA
{
    partial class FormMenu
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
            btnMenuEkle = new Button();
            nmrMenuFiyat = new NumericUpDown();
            txtMenuAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnMenuEkle);
            groupBox1.Controls.Add(nmrMenuFiyat);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 231);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ BİLGİSİ";
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.Location = new Point(40, 125);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(159, 54);
            btnMenuEkle.TabIndex = 3;
            btnMenuEkle.Text = "Menüyü Kaydet";
            btnMenuEkle.UseVisualStyleBackColor = true;
            btnMenuEkle.Click += btnMenuEkle_Click;
            // 
            // nmrMenuFiyat
            // 
            nmrMenuFiyat.Location = new Point(140, 76);
            nmrMenuFiyat.Name = "nmrMenuFiyat";
            nmrMenuFiyat.Size = new Size(59, 23);
            nmrMenuFiyat.TabIndex = 2;
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(140, 41);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(100, 23);
            txtMenuAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 84);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(51, 12);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 231);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMenuEkle;
        private NumericUpDown nmrMenuFiyat;
        private TextBox txtMenuAdi;
        private Label label2;
        private Label label1;
    }
}