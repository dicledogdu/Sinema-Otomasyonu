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
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && cbKoltukSayisi.Text != "")
            {
                connection.Open();
                SqlCommand kaydet = new SqlCommand("insert into Tbl_salonlar (SALONADI,KOLTUKSAYISI) Values(@p1,@p2)", connection);
                kaydet.Parameters.AddWithValue("@p1", txtSalonAdi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cbKoltukSayisi.Text);
                kaydet.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("SALON KAYDETME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ!");
                txtSalonAdi.Text = "";
                cbKoltukSayisi.Text = "";
                txtSalonAdi.Focus();
                listeGetir();
            }
            else
            {
                MessageBox.Show("LÜTFEN BİR DEĞER GİRİNİZ!");

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            listeGetir();
            kOlustur();
        }

        void kOlustur()
        {
            for(int i=1 ;i<=200 ;i++)
            {
                cbKoltukSayisi.Items.Add(i.ToString());
            }
        }
        void listeGetir()
        {
            panelSalon.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_salonlar ORDER BY SALONADI ASC", connection);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                salonListesi arac = new salonListesi();
                arac.lblSalonAdi.Text = read["SALONADI"].ToString();
                arac.label2.Text = read["KOLTUKSAYISI"].ToString();
                panelSalon.Controls.Add(arac);
              
            }


            connection.Close();

        }

        private void panelSalon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
