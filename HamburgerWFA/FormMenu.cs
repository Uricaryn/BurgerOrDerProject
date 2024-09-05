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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            FormSiparis.menuler.Add(new Menu()
            {
                Ad = txtMenuAdi.Text,
                Fiyatı = nmrMenuFiyat.Value,
               
            });

            MessageBox.Show("Menü Eklendi");
            Functions.ResetForm(this.Controls);
        }
    }
}
