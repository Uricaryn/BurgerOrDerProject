using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HamburgerProject.Concrete;
using HamburgerProject.Enums;
using HamburgerProject.Abstract;



namespace HamburgerWFA
{
    public partial class FormSiparis : Form
    {
        public FormSiparis()
        {
            InitializeComponent();

        }
        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu(){Ad="Big King", Fiyatı=155.00M},
            new Menu(){Ad="Double King Chicken", Fiyatı=140.00M},
            new Menu(){Ad="SteakHouse", Fiyatı=180.00M},
            new Menu(){Ad="Chicken Royale", Fiyatı=150.00M},
            new Menu(){Ad="Whooper", Fiyatı=160.00M},
            new Menu(){Ad="Whooper Jr.", Fiyatı=140.00M},
        };

        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme(){Ad="Ketçap", Fiyatı= 2.50M},
            new EkstraMalzeme(){Ad="Mayonez", Fiyatı= 2.50M},
            new EkstraMalzeme(){Ad="BBQ", Fiyatı= 3.75M},
            new EkstraMalzeme(){Ad="Acı Sos", Fiyatı= 3.00M},
        };

        public static List<Siparis> mevcutSiparisler = new List<Siparis>();
        public static List<Siparis> tumSiparisler = new List<Siparis>();

        private void FormSiparis_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in menuler)
            {
                cmbMenuler.Items.Add(menu);
            }

            cmbMenuler.SelectedIndex = 0;
            rdbKucuk.Checked = true;

            foreach (EkstraMalzeme ekstra in ekstralar)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = ekstra.Ad, Tag = ekstra });
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lstSiparisler.Items.Add(item);
            }


        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yenisiparis = new Siparis();
            yenisiparis.SeciliMenu = (Menu)cmbMenuler.SelectedItem;
            yenisiparis.Boyut = rdbKucuk.Checked ? Boyut.Küçük : rdbOrta.Checked ? Boyut.Orta : Boyut.Büyük;


            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    yenisiparis.EkstraMalzemeler.Add((EkstraMalzeme)item.Tag);
                }
            }
            yenisiparis.Adet = Convert.ToInt16(nmrAdet.Value);
            yenisiparis.Hesapla();
            mevcutSiparisler.Add(yenisiparis);
            lstSiparisler.Items.Add(yenisiparis);
            TutarHesapla();
            Functions.ResetForm(this.Controls);
        }
        private decimal TutarHesapla()
        {
            decimal tutar = 0;
            foreach (Siparis item in lstSiparisler.Items)
            {
                tutar += item.ToplamTutar;
            }

            lblToplamTutar.Text = tutar.ToString("C2");
            return tutar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Toplam Sipariş Tutarı {TutarHesapla().ToString("C2")}   \n Siparişi tamamlamak ister misiniz? ", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                lstSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlandı");
            }
            else
            {
                MessageBox.Show("İptal Edildi");
            }


        }


    }
}
