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
    public partial class FrmBiletOlusturma : Form
    {
        public FrmBiletOlusturma()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBiletOlusturma_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            biletNoOlustur();
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
                cbFilmAdi.Items.Add(read["ADI"].ToString());
            }
            connection.Close();
        }

        void biletNoOlustur()
        {
            Random rastgele = new Random();
            string karakterler = "123456789";
            string kod = "";

            for (int i = 1; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            txtBarkod.Text = kod.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTarih.Items.Clear();
            string sorgu = "select DISTINCT TARIH, FILMADI from Tbl_kontrol where FILMADI=@filmadi";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cbTarih.Items.Add(read["TARIH"].ToString());
            }
            connection.Close();
        }

        private void panelSeans_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelSeans.Controls)
            {
                if (item.Checked)
                {
                    lblSeansSec.Text = item.Text;
                    comboBox4.Items.Clear();

                    string sorgu = "select DISTINCT SALONADI from Tbl_kontrol where FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat";
                    connection.Open();
                    SqlCommand komut = new SqlCommand(sorgu, connection);
                    komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
                    komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
                    SqlDataReader read = komut.ExecuteReader();
                    while (read.Read())
                    {
                        comboBox4.Items.Add(read["SALONADI"].ToString());
                    }
                    connection.Close();
                }
            }
        }

        private void cbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSeans.Controls.Clear();
            string saatler = "";
            string sorgu = "select DISTINCT SAAT from Tbl_kontrol where FILMADI=@filmadi AND TARIH=@tarih";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                saatler = read["SAAT"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.Red;
                rnd.CheckedChanged += new EventHandler(SeansSaatler);
                panelSeans.Controls.Add(rnd);
            }
            connection.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from Tbl_salonlar where SALONADI=@salonadi";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@salonadi", comboBox4.Text.ToString());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                koltukSayisi.Text = (read["KOLTUKSAYISI"].ToString());
                if (gelenKoltuk.Text.Length > 2)
                {
                    gelenKoltuk.Text = gelenKoltuk.Text.Substring(2);
                }
            }
            connection.Close();
            koltukGetir();
            doldur();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        void biletNoSorgula()
        {
            connection.Open();
            string sorgu = "select * from Tbl_Biletler Where BKOD=@no";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@no", txtBarkod.Text.ToString());
            SqlDataReader read = komut.ExecuteReader();
            if (!read.Read())
            {
                kaydetMETODU();
            }
            else
            {
                biletNoOlustur();
                connection.Close();
                biletNoSorgula();
            }
            connection.Close();
        }

        void kaydetMETODU()
        {
            string sorgu = "insert into Tbl_biletler (BKOD, ADSOYAD, KOLTUKNO, FILMADI, TARIH, SEANS, SALON) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
            connection.Close();
            connection.Open();
            SqlCommand kayit = new SqlCommand(sorgu, connection);
            kayit.Parameters.AddWithValue("@p1", txtBarkod.Text.ToString());
            kayit.Parameters.AddWithValue("@p2", txtAdSoyad.Text.ToString());
            kayit.Parameters.AddWithValue("@p3", textBox2.Text.ToString()); // Seçilen koltuk numaraları
            kayit.Parameters.AddWithValue("@p4", cbFilmAdi.Text.ToString());
            kayit.Parameters.AddWithValue("@p5", cbTarih.Text.ToString());
            kayit.Parameters.AddWithValue("@p6", lblSeansSec.Text.ToString());
            kayit.Parameters.AddWithValue("@p7", comboBox4.Text.ToString());
            kayit.ExecuteNonQuery();
            connection.Close();

            string sorgu2 = "UPDATE Tbl_Kontrol SET KOLTUKLAR=@numara WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            connection.Open();
            SqlCommand guncelle = new SqlCommand(sorgu2, connection);
            guncelle.Parameters.AddWithValue("@numara", gelenKoltuk.Text.ToString() + "," + textBox2.Text.ToString());
            guncelle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadi", comboBox4.Text.ToString());
            guncelle.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("BİLET BAŞARILI BİR ŞEKİLDE AYIRTILDI!");
            MessageBox.Show("güncellendi");
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtBarkod.Text != "" && textBox2.Text != "" && cbFilmAdi.Text != "" && cbTarih.Text != "")
            {
                biletNoSorgula();
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ DOLDURUN!");
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Panel panel;

            if (control is Panel)
            {
                panel = (Panel)control;
            }
            else if (control.Parent is Panel)
            {
                panel = (Panel)control.Parent;
            }
            else
            {
                return; // Eğer ne panel ne de parent panel ise, çık
            }

            if (panel.BackColor == Color.Red)
            {
                MessageBox.Show("Koltuk doludur");
            }
            else if (panel.BackColor == Color.Blue) // Koltuk boşsa
            {
                panel.BackColor = Color.Yellow; // Sarı yap
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is PictureBox)
                    {
                        ((PictureBox)ctrl).Image = Properties.Resources.orange;
                    }
                }
                listeBelirlenen.Items.Add(panel.Tag); // Sarı yapılan koltuğun numarasını listeye ekle
            }
            else if (panel.BackColor == Color.Yellow) // Koltuk sarıysa
            {
                panel.BackColor = Color.Blue; // Mavi yap (geri al)
                foreach (Control ctrl in panel.Controls)
                {
                    if (ctrl is PictureBox)
                    {
                        ((PictureBox)ctrl).Image = Properties.Resources.blue;
                    }
                }
                listeBelirlenen.Items.Remove(panel.Tag); // Mavi yapılan koltuğun numarasını listeden çıkar
            }

            // TextBox2'ye seçilen koltukları yazdır
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            StringBuilder selectedSeats = new StringBuilder();
            foreach (var item in listeBelirlenen.Items)
            {
                selectedSeats.Append(item.ToString() + ",");
            }

            // Son eklenen virgülü kaldırmak için
            if (selectedSeats.Length > 0)
            {
                selectedSeats.Length -= 1;
            }

            textBox2.Text = selectedSeats.ToString();
        }



        void doldur()
        {
            koltukPaneli.Controls.Clear();
            int sayi = Convert.ToInt16(koltukSayisi.Text);

            for (int i = 1; i <= sayi; i++)
            {
                // Koltuk paneli oluştur
                Panel koltukPanel = new Panel
                {
                    Width = 50,
                    Height = 70, // Yükseklik, PictureBox ve Label için yeterli olmalı
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = i // Koltuk numarasını saklamak için kullanılır
                };

                // PictureBox oluştur
                PictureBox picBox = new PictureBox
                {
                    Width = 50,
                    Height = 50,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Image = Properties.Resources.blue // Başlangıçta mavi resim
                };

                // Label oluştur
                Label lbl = new Label
                {
                    Text = i.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Bottom
                };

                if (listeGelenKoltuk.Items.Contains(i.ToString()))
                {
                    picBox.Image = Properties.Resources.red;
                    koltukPanel.BackColor = Color.Red;
                }
                else
                {
                    picBox.Image = Properties.Resources.blue;
                    koltukPanel.BackColor = Color.Blue;
                }

                // Click olayını ekleyerek buton davranışı kazandırıyoruz
                koltukPanel.Click += new EventHandler(Control_Click);
                picBox.Click += new EventHandler(Control_Click);
                lbl.Click += new EventHandler(Control_Click);

                // PictureBox ve Label'i panel içine ekle
                koltukPanel.Controls.Add(picBox);
                koltukPanel.Controls.Add(lbl);

                // Koltuk panelini ana panele ekle
                koltukPaneli.Controls.Add(koltukPanel);
            }
        }

        void koltukGetir()
        {
            gelenKoltuk.Text = "";
            string sorgu = "select * from Tbl_kontrol where FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            komut.Parameters.AddWithValue("@salonadi", comboBox4.Text.ToString());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                gelenKoltuk.Text += "," + read["KOLTUKLAR"].ToString();
            }
            connection.Close();
            koltukAyirma();
        }

        void koltukAyirma()
        {
            listeGelenKoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = gelenKoltuk.Text.ToString();
            sec = no.Split(','); //hangi karakteri aramak istersek o karakterde ayırma işlemi yapar ve çift tırnak kullanılır

            foreach (string bulunan in sec)
            {
                listeGelenKoltuk.Items.Add(bulunan);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listeBelirlenen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
