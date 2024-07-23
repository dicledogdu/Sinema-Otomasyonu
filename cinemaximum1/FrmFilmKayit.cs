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
    public partial class FrmFilmKayit : Form
    {
        public FrmFilmKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_secilenler", connection);
            komut.ExecuteNonQuery();

            connection.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmFilmKayit_Load(object sender, EventArgs e)
        {
            yListesiGetir();
            oListesiGetir();
            bugununTarihi();

        }

        void bugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;
            

        }
        void yListesiGetir()
        {
            string sorgu = "select * from Tbl_yonetmenler1 ORDER BY ADSOYAD ASC";
            fYonetmenPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu,connection);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                yListeAraci arac = new yListeAraci();
                arac.lblAdi.Text = read["ADSOYAD"].ToString();
                fYonetmenPaneli.Controls.Add(arac);
            }
            connection.Close();
        }
        void oListesiGetir()
        {
            string sorgu = "select * from Tbl_oyuncular ORDER BY ADSOYAD ASC";
            fOyuncuPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                oListeAraci arac = new oListeAraci();
                arac.lblAdi.Text = read["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "1";
            
            
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "2";
        }

        private void rB3_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "3";
        }

        private void rB4_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "4";
        }

        private void rB5_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "5";
        }

        private void rB6_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "6";
        }

        private void rB7_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "7";
        }

        private void rB8_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "8";
        }

        private void rB9_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "9";
        }

        private void rB10_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "10";
        }
        string resimYolu = "";
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

        private void lblKarakter_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int count = textBox10.Text.Length;
            int backdown = 300 - count;
            lblKarakter.Text = backdown.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            yonetmenAra();
        }

        private void lblYonetmenAra_Click(object sender, EventArgs e)
        {

        }
        
        
        
        void yonetmenAra()
        {
           
            string sorgu = "select * from Tbl_yonetmenler1 where ADSOYAD LIKE '% collate Turkish_CI_AS" + txtYonetmenAra.Text + "%'";
            fYonetmenPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                yListeAraci arac = new yListeAraci();
                arac.lblAdi.Text = read["ADSOYAD"].ToString();
                fYonetmenPaneli.Controls.Add(arac);
            }
            connection.Close();
        }
        
        
        void oyuncuAra()
        { 
            string sorgu = "select * from Tbl_oyuncular where ADSOYAD LIKE '% collate Turkish_CI_AS" + txtOyuncuAra.Text + "%'";
            fOyuncuPaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                oListeAraci arac = new oListeAraci();
                arac.lblAdi.Text = read["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void txtOyuncuAra_TextChanged(object sender, EventArgs e)
        {
            oyuncuAra();
        }

        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            if(lblAksiyon.ForeColor==Color.FromArgb(84,110,122))
            {
                lblAksiyon.ForeColor = Color.FromArgb(249, 164, 24);
            }
            else
            {
                lblAksiyon.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (lblAsk.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblAsk.ForeColor = Color.FromArgb(249, 164, 24);
            }
            else
            {
                lblAsk.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (lblDram.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblDram.ForeColor = Color.FromArgb(249, 164, 24);
            }
            else
            {
                lblDram.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string secilenTur = "";

            foreach(Control arac in grBTur.Controls)
            {
                if(arac is Label)
                {
                    if(arac.ForeColor==Color.FromArgb(84,110,122))
                    {

                    }
                    else
                    {
                        secilenTur += " ," + arac.Text.ToString();
                    }
                }
            }
        if(secilenTur.Length>2)
            {
                MessageBox.Show("Seçilenler: "+secilenTur.Substring(2));
            }
        else
            {
                MessageBox.Show("Seçim Yapılmadı!");
            }
        }


        private void lblKorku_Click(object sender, EventArgs e)
        {
            if (lblKorku.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKorku.ForeColor = Color.FromArgb(249, 164, 24);
            }
            else
            {
                lblKorku.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblRating_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

            if (lblTurkce.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblTurkce.ForeColor = Color.FromArgb(249, 164, 24);
            }
            else
            {
                lblTurkce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblIngilizce_Click(object sender, EventArgs e)
        {

            if (lblIngilizce.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblIngilizce.ForeColor = Color.FromArgb(249, 164, 24);
            }
            else
            {
                lblIngilizce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblAltyazi_Click(object sender, EventArgs e)
        {
            if (lblAltyazi.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblAltyazi.ForeColor = Color.FromArgb(249, 164, 24);
            }
            else
            {
                lblAltyazi.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string secilenTur = "";
            foreach (Control arac in grBbicim.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenTur += " ," + arac.Text.ToString();
                    }
                }
            }
            if (secilenTur.Length > 2)
            {
                MessageBox.Show("Seçilenler: " + secilenTur.Substring(2));
            }
            else
            {
                MessageBox.Show("Seçim Yapılmadı!");
            }
        }

        private void lblKorkuSiddet_Click(object sender, EventArgs e)
        {

            if (lblKorkuSiddet.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKorkuSiddet.ForeColor = Color.FromArgb(249, 164, 24);
                pB1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\unlock.png";
            }
            else
            {
                lblKorkuSiddet.ForeColor = Color.FromArgb(84, 110, 122);
                pB1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\lock.png";
            }
        }

        private void genelIzleyici_Click(object sender, EventArgs e)
        {
            if (genelIzleyici.ForeColor == Color.FromArgb(84, 110, 122))
            {
                genelIzleyici.ForeColor = Color.FromArgb(249, 164, 24);
                pB1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\unlock.png";
            }
            else
            {
                genelIzleyici.ForeColor = Color.FromArgb(84, 110, 122);
                pB1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\lock.png";
            }
        }

        private void olumsuzIcerik_Click(object sender, EventArgs e)
        {
            if (olumsuzIcerik.ForeColor == Color.FromArgb(84, 110, 122))
            {
                olumsuzIcerik.ForeColor = Color.FromArgb(249, 164, 24);
                pB1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\unlock.png";
            }
            else
            {
                olumsuzIcerik.ForeColor = Color.FromArgb(84, 110, 122);
                pB1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\lock.png";
            }
        }

        private void arti18_Click(object sender, EventArgs e)
        {
            if (arti18.ForeColor == Color.FromArgb(84, 110, 122))
            {
                arti18.ForeColor = Color.FromArgb(249, 164, 24);
                pB1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\unlock.png";
            }
            else
            {
                arti18.ForeColor = Color.FromArgb(84, 110, 122);
                pB1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\lock.png";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string secilenTur = "";
            foreach (Control arac in gBDil.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenTur += " ," + arac.Text.ToString();
                    }
                }
            }
            if (secilenTur.Length > 2)
            {
                MessageBox.Show("Seçilenler: " + secilenTur.Substring(2));
            }
            else
            {
                MessageBox.Show("Seçim Yapılmadı!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vizyonTarihiHesapla();
        }

        string vTarih = "";
        string durum = "0";
        void vizyonTarihiHesapla()
        {
            vTarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime bugunTarihi = DateTime.Today;

            TimeSpan tSpan = dVTarih - bugunTarihi;

            if(tSpan.TotalDays<0)
            {
                MessageBox.Show("GEÇMİŞ TARİHLERE AİT FİLM EKLENMESİ YAPILAMAZ!");
                bugununTarihi();
            }
            else if (tSpan.TotalDays==0)
            {
                MessageBox.Show("FİLM BUGÜN VİZYONDA!");
                durum = "1";
            }
            else
            {
                MessageBox.Show(" " + tSpan.TotalDays.ToString() + " GÜN SONRA VİZYONDA! ");
                durum = "0";
            }
        }
        string yonetmen = "";
        string oyuncu = "";

        void secilenYonetmen()
        {
            connection.Open();
            string sorgu = "select * from Tbl_secilenler Where TUR='YÖNETMEN'";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                yonetmen += "," + read["KISI"].ToString();
            }

            connection.Close();
        }
        void secilenOyuncu()
        {
            connection.Open();
            string sorgu = "select * from Tbl_secilenler Where TUR='OYUNCU'";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                oyuncu += "," + read["KISI"].ToString();
            }

            connection.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secilenYonetmen();
            secilenOyuncu();
            tur();
            ozellik();
            bicim();




            string sorgu = "insert into Tbl_filmler (ADI,TURU,OZELLIKLERI,BICIMI,YONETMEN,OYUNCU,DETAY,PUAN,AFIS,TARIH,DURUM) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", textBox1.Text.ToUpper());
            if (secilenTur.Length > 2)
            {
                komut.Parameters.AddWithValue("@p2", secilenTur.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p2", secilenTur);
            }

            if (secilenOzellik.Length > 2)
            {
                komut.Parameters.AddWithValue("@p3", secilenOzellik.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p3", secilenOzellik);
            }

            if (secilenBicim.Length > 2)
            {
                komut.Parameters.AddWithValue("@p4", secilenBicim.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p4", secilenBicim);
            }

            if (yonetmen.Length > 2)
            {
                komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p5", yonetmen);
            }

            if (oyuncu.Length > 2)
            {
                komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));

            }
            else
            {
                komut.Parameters.AddWithValue("@p6", oyuncu);
            }

            komut.Parameters.AddWithValue("@p7", textBox10.Text.ToUpper());
            komut.Parameters.AddWithValue("@p8", lblRating.Text.ToUpper());
            komut.Parameters.AddWithValue("@p9", resimYolu);
            komut.Parameters.AddWithValue("@p10", vTarih);
            komut.Parameters.AddWithValue("@p11", durum);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("FİLM KAYDI BAŞARILI BİR ŞEKİLDE EKLENDİ!");
        }

        string secilenTur = "";
        string secilenOzellik = "";
        string secilenBicim = "";
        void tur()
        {

            foreach (Control arac in grBTur.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenTur += " ," + arac.Text.ToString();
                    }
                }
            }

        }
        void ozellik()
        {
            foreach (Control arac in grBbicim.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenOzellik += " ," + arac.Text.ToString();
                    }
                }
            }
        }
        void bicim()
        {
            foreach (Control arac in gBDil.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenBicim += " ," + arac.Text.ToString();
                    }
                }
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fYonetmenPaneli_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
