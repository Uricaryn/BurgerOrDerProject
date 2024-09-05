using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HamburgerProject.Concrete;

namespace HamburgerWFA
{
    public partial class FormEkstra : Form
    {
        public FormEkstra()
        {
            InitializeComponent();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            FormSiparis.ekstralar.Add(new EkstraMalzeme()
            {
                Ad = txtMalzemeAdi.Text,
                Fiyatı = nmrFiyat.Value
            });

            MessageBox.Show("Malzeme Eklendi");
            Functions.ResetForm(this.Controls);
        }
    }
}
