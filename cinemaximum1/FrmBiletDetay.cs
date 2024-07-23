using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cinemaximum1
{
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");
        public string biletNo = "";
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            barkodNoOlustur();
            bilgiGetir();
        }

        void bilgiGetir()
        {
            string sorgu = "select * from Tbl_biletler where BKOD=@kod ";
            connection.Open();
            SqlCommand getir = new SqlCommand(sorgu, connection);
            getir.Parameters.AddWithValue("@kod", biletNo);
            SqlDataReader read = getir.ExecuteReader();
            if(read.Read())
            {
                lblFilm.Text = read["FILMADI"].ToString();
                lblAdSoyad.Text = read["ADSOYAD"].ToString();
                lblSalonAdi.Text = read["SALON"].ToString();
                labelSalonSeans.Text= read["SALON"].ToString();
                lblTarihSaat.Text = read["TARIH"].ToString() + " " + read["SEANS"].ToString();
                labelTarih.Text = read["TARIH"].ToString() + " " + read["SEANS"].ToString();
                lblKoltuklar.Text = read["KOLTUKNO"].ToString();
                lblKoltuk2.Text= read["KOLTUKNO"].ToString();


            }
            connection.Close();

        }
        void barkodNoOlustur()
        {
            Random rastgele = new Random();
            string karakterler = "123456789";
            string kod = "";

            for (int i = 1; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblFilmAdi_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblFilm_Click(object sender, EventArgs e)
        {

        }
    }
}
