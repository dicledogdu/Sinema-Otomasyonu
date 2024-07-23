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
using System.Diagnostics.Eventing.Reader;

namespace cinemaximum1
{
    public partial class salonAtama : Form
    {
        public salonAtama()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kaydetme işlevi buraya eklenecek
        }

        private void salonAtama_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            bugununTarihi();
            salonAdiGetir();
        }

        void filmAdiGetir()
        {
            string sorgu = "select * from Tbl_filmler ORDER BY ADI ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                string gelenTarih = read["TARIH"].ToString();
                DateTime fTarih = Convert.ToDateTime(gelenTarih);
                DateTime bugun = DateTime.Today;

                TimeSpan timespan = fTarih - bugun;
                if (timespan.TotalDays <= 0)
                {
                    cbFilmAdi.Items.Add(read["ADI"].ToString());
                }
            }
            connection.Close();
        }

        void salonAdiGetir()
        {
            string sorgu = "select * from Tbl_salonlar ORDER BY SALONADI ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox4.Items.Add(read["SALONADI"].ToString());
            }
            connection.Close();
        }

        void bugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;
        }

        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach(RadioButton item in panelSeans.Controls)
            {
                if(item.Checked)
                {
                    lblSecilen.Text = item.Text.ToString();
                }
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if (btnYukle.Text == "TAMAMLA")
            {
                string sorgu = "select DISTINCT SAAT from Tbl_kontrol WHERE TARIH=@tarih AND SALONADI=@salonadi";
                string tarih = nGun.Value+"-"+nAy.Value+"-"+nYil.Value;
                connection.Open();
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@salonadi", comboBox4.Text.ToString());
                SqlDataReader read = komut.ExecuteReader();
                cbDoluSaatler.Items.Clear(); // Önceki öğeleri temizleyin
                while (read.Read())
                {
                    cbDoluSaatler.Items.Add(read["SAAT"].ToString());
                }
                connection.Close();

                btnYukle.Text = "OLUŞTUR";
                btnYukle.BackColor = Color.DarkBlue;
            
                seansKonrol();
            }
            else
            {
                kaydet();
                cbDoluSaatler.Items.Clear();
                btnYukle.Text = "TAMAMLA";
                btnYukle.BackColor = Color.Peru;
            }
        }
        void kaydet()
        {
            
            string sorgu = "insert into Tbl_kontrol(FILMADI,TARIH,SAAT,SALONADI) Values (@filmadi,@tarih,@saat,@salonadi)";
            string tarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
            connection.Open();

            SqlCommand ekle = new SqlCommand(sorgu,connection);
            ekle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            ekle.Parameters.AddWithValue("@tarih",tarih);
            ekle.Parameters.AddWithValue("@saat", lblSecilen.Text.ToString());
            ekle.Parameters.AddWithValue("@salonadi", comboBox4.Text.ToString());
            ekle.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("SALON ATAMA İŞLEMİ GERÇEKLEŞTİRİLDİ!");

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Gerekirse grup kutusu enter olayını burada ele alabilirsiniz
        }

        void seansKonrol()
        {
            panelSeans.Controls.Clear();
            List<string> doluSaatler = cbDoluSaatler.Items.Cast<string>().ToList();
            for (int i = 10; i <= 22; i++)
            {
                for (int j = 0; j <= 30; j += 30)
                {
                    RadioButton rdn = new RadioButton();
                    rdn.ForeColor = Color.FromArgb(249, 164, 26);
                    rdn.FlatStyle = FlatStyle.Flat;
                    rdn.Width = 70;
                    rdn.CheckedChanged += new EventHandler(SeansSaatler);
                    if (j == 0)
                    {
                        rdn.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rdn.Text = i.ToString() + ":" + j.ToString();
                    }
                    if (doluSaatler.Contains(rdn.Text))
                    {
                        rdn.Visible = false;
                    }
                    panelSeans.Controls.Add(rdn);
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

