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
//sql kütüphanesi
namespace cinemaximum1
{
    public partial class frmAcilis : Form
    {
        public frmAcilis()
        {
            InitializeComponent();
        }
        // connectionstring dediğimiz veritabanımızın yolunu projemize eklememiz gerekiyor.
        //SqlConnection connection = new SqlConnection("Data Source=Veritabanimizin_yolu;Initial Catalog=Veritabanimizin_adi;Integrated Security=True");
        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");
        // başına @ işareti koyarak da yol oldugunu gosterebiliriz(// kullandım)
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sorgula = new SqlCommand("select * from Tbl_kullanicilar WHERE KADI=@username AND KSIFRE=@password",connection);
            
            sorgula.Parameters.AddWithValue("@username" , textBox1.Text);
            sorgula.Parameters.AddWithValue("@password" , textBox2.Text);

            SqlDataReader read = sorgula.ExecuteReader();
            if(read.Read())
            {
                MessageBox.Show("giriş başarılı!");
                frmAnaform frm = new frmAnaform();
                frm.kisiAdiSoyadi = read["ADSOYAD"].ToString();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı kaydı bulunamadı!");
            }
            connection.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus(); //imleci konumlandır.





            //connection.Open();

            //if(connection.State==ConnectionState.Open)
            //{
            //   MessageBox.Show("basarili!");
            //}
            //connection.Close();
        }
    }
}
