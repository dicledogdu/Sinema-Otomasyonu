using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cinemaximum1
{
    public partial class FrmFilmListe : Form
    {
        public FrmFilmListe()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmFilmListe_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            string sorgu = "select * from Tbl_filmler ORDER BY ADI ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                filmListesi arac = new filmListesi();
                arac.lblFilmAdi.Text = read["ADI"].ToString();
                arac.pBResim.ImageLocation = read["AFIS"].ToString();
                arac.lblIdNo.Text = read["ID"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_filmler where ADSOYAD LIKE '%" + txtAramaYap.Text + "%'", connection);
            SqlDataReader read = ara.ExecuteReader();
            while (read.Read())
            {
                yonetmenListesi arac = new yonetmenListesi();
                arac.lblID.Text = read["ID"].ToString();
                arac.lblAdSoyad.Text = read["ADSOYAD"].ToString();
                arac.pBresimDetay.ImageLocation = read["FOTOGRAF"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }
    }
}
