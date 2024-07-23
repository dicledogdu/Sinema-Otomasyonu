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
    public partial class filmListesi : UserControl
    {
        public filmListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");
        private void filmListesi_Load(object sender, EventArgs e)
        {
      

        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            {
                connection.Open();
                string sorgu = "select * from Tbl_filmler WHERE ID=@p1";
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@p1", lblIdNo.Text);
                SqlDataReader read = komut.ExecuteReader();

                if (read.Read())
                {
                    string detay = read["DETAY"].ToString();
                    string adi = read["ADI"].ToString();
                    string turu = read["TURU"].ToString();
                    string ozellikleri = read["OZELLIKLERI"].ToString();
                    string bicimi = read["BICIMI"].ToString();
                    string yonetmen = read["YONETMEN"].ToString();
                    string oyuncu = read["OYUNCU"].ToString();
                    string puan = read["PUAN"].ToString(); // Örneğin film yılı
                    string tarih = read["TARIH"].ToString(); // Örneğin film türü

                    // Bilgileri birleştirerek mesaj oluşturulur.
                    string mesaj = $"FİLM DETAYI: {detay}\n" +
                                   $"ADI: {adi}\n" +
                                   $"TÜRÜ: {turu}\n" +
                                   $"ÖZELLİKLERİ: {ozellikleri}\n" +
                                   $"BİÇİMİ: {bicimi}\n" +
                                   $"YÖNETMEN: {yonetmen}\n" +
                                   $"OYUNCU: {oyuncu}\n" +
                                   $"PUAN: {puan}\n" +
                                   $"TARIH: {tarih}";

                    // Mesaj kutusunda gösterilir.
                    MessageBox.Show(mesaj, adi);

                }
            }
        }
    }
}
