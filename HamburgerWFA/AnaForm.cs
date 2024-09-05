namespace HamburgerWFA
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();

        }
        void Childform(Form children)
        {
            bool durum = false;
            this.Width = children.Width + 30;
            this.Height = children.Height + 80;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == children.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                children.MdiParent = this;
                children.Show();
            }

            children.MdiParent = this;
            children.Show();
        }
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Childform(new FormSiparis());

        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Childform(new FormTumSiparisler());
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Childform(new FormMenu());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Childform(new FormEkstra());
        }
        
    }
}
