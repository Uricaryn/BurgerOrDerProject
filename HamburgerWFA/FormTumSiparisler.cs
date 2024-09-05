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
    public partial class FormTumSiparisler : Form
    {
        public FormTumSiparisler()
        {
            InitializeComponent();
        }

        private void FormTumSiparisler_Load(object sender, EventArgs e)
        {
            decimal ciro = 0, ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in FormSiparis.tumSiparisler)
            {
                lstTumSiparisler.Items.Add(siparis);
                ciro += siparis.ToplamTutar;
                foreach (EkstraMalzeme ekstra in siparis.EkstraMalzemeler)
                {
                    ekstraMalzemeGeliri += ekstra.Fiyatı;
                }
                satisAdedi += siparis.Adet;
            }
            lblToplamSiparisSayisi.Text=lstTumSiparisler.Items.Count.ToString();
            lblCiro.Text=ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblSatilanUrunAdedi.Text = satisAdedi.ToString();
        }
    }
}
