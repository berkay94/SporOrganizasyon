using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SporOrganizasyon
{
    public partial class AnaEkran : Form
    {
        BusinessLogic bl;
        public AnaEkran()
        {
            InitializeComponent();
            bl = new BusinessLogic();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = bl.EtkinlikAl();
            dataGridView1.Columns["EtkinlikId"].Visible = false;
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Hide();
            giris.ShowDialog();
            labelGiris.Text = bl.Girildi();
            
            this.Show();
        }

        private void AnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonMekan_Click(object sender, EventArgs e)
        {
            Mekan mekan = new Mekan();
            this.Hide();
            mekan.ShowDialog();
            this.Show();
        }

        private void buttonEtkinlik_Click(object sender, EventArgs e)
        {
            Etkinlik etkinlik = new Etkinlik();
            this.Hide();
            etkinlik.ShowDialog();
            this.Show();
        }

        private void buttonKatil_Click(object sender, EventArgs e)
        {

        }
    }
}
