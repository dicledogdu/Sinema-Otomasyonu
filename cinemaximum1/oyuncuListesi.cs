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
    public partial class oyuncuListesi : UserControl
    {
        public oyuncuListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");
        private void oyuncuListesi_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from Tbl_oyuncular WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblID.Text);
            SqlDataReader read = komut.ExecuteReader();

            if (read.Read())
            {
                lblCinsiyet.Text = read["CINSIYET"].ToString();
            }
            connection.Close();
            if (lblCinsiyet.Text == "0")
            {
                pBcinsiyet.ImageLocation = @"C:\\Users\\ASUS\\OneDrive\\Masaüstü\\ERKEK.png";
            }
            else
            {
                pBcinsiyet.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\KADN.png";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_oyuncular WHERE ID=@p1", connection);
            sil.Parameters.AddWithValue("@p1", lblID.Text);
            sil.ExecuteNonQuery();
            connection.Close();


            MessageBox.Show(lblAdSoyad.Text + " Kişisine Ait Kayıt Başarılı Bir Şekilde Silindi!");
            this.Hide();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from Tbl_oyuncular WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblID.Text);
            SqlDataReader read = komut.ExecuteReader();

            if (read.Read())
            {
                MessageBox.Show("BİYOGRAFİ: " + read["BIYOGRAFI"].ToString(), read["ADSOYAD"].ToString());
            }
        }
    }
}
