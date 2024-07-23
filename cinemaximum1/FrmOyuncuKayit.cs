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
    public partial class FrmOyuncuKayit : Form
    {
        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtBiyografi.Text != "" && resimYolu != "")
            {
                connection.Open();
                string adSoyad = txtAd.Text.ToString().ToUpper() + " " + txtSoyad.Text.ToString().ToUpper();


                //instert,update,delete,select
                SqlCommand kayit = new SqlCommand("insert into Tbl_oyuncular (ADSOYAD,CINSIYET,BIYOGRAFI,FOTOGRAF) VALUES (@p1,@p2,@p3,@p4)", connection);
                kayit.Parameters.AddWithValue("@p1", adSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", txtBiyografi.Text.ToString());
                kayit.Parameters.AddWithValue("@p4", resimYolu);
                kayit.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("OYUNCU KAYIT İŞLEMİ BAŞARILI!");

                aracTemizle();
            }
            else
            {
                MessageBox.Show(" LÜTFEN TÜM ALANLARI EKSİKSİZ BİÇİMDE DOLDURUNUZ!");
            }

        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string resimYolu = "";
        private void btnYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Fotograf Secme Ekrani";
            ofd.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|All Files|*.*";
            ofd.FilterIndex = 4;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBResim.Image = new Bitmap(ofd.FileName);

                resimYolu = ofd.FileName.ToString();
            }
        }
        
        public string cinsiyet = "0";

        private void rBerkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void rBkadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }

        private void lblKarakter_Click(object sender, EventArgs e)
        {

        }

        private void txtBiyografi_TextChanged(object sender, EventArgs e)
        {
            int count = txtBiyografi.Text.Length;
            int backdown = 300 - count;
            lblKarakter.Text = backdown.ToString();
            //MessageBox.Show(count.ToString());
        }
        void aracTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtBiyografi.Text = "";
            rBerkek.Checked = true;
            rBkadin.Checked = false;
            lblKarakter.Text = "300";
            cinsiyet = "0";
            pBResim.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\NOPİC.jpg";
            txtAd.Focus();
        }
    }
}
