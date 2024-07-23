using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaximum1
{
    public partial class frmAnaform : Form
    {
        public frmAnaform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();

        }
        public string kisiAdiSoyadi = "";

        private void button2_Click(object sender, EventArgs e)
        {
            frm_yonetmen frm = new frm_yonetmen();
            frm.ShowDialog();
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmYonetmenListesi frm = new frmYonetmenListesi();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmOyuncuKayit frm = new FrmOyuncuKayit();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmOyuncuListesi frm = new frmOyuncuListesi();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmFilmKayit frm = new FrmFilmKayit();
            frm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmFilmListe frm = new FrmFilmListe();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmBiletOlusturma frm = new FrmBiletOlusturma();
            frm.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmBiletSorgu frm = new FrmBiletSorgu();
            frm.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            salonAtama frm = new salonAtama();
            frm.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
