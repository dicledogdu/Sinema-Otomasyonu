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
    public partial class yListeAraci : UserControl
    {
        public yListeAraci()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=cinemaximum/VT;Integrated Security=True");
        private void lblAdi_Click_1(object sender, EventArgs e)
        {
            if (lblAdi.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);

                pictureBox1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\tik.png";

                connection.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_secilenler (KISI,TUR) values (@kisi,@tur)", connection);
                komut.Parameters.AddWithValue("@kisi",lblAdi.Text);
                komut.Parameters.AddWithValue("@tur","YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 28, 43);
                pictureBox1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\tik.png";
                connection.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_secilenler WHERE KISI=@kisi AND TUR=@tur", connection);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur","YÖNETMEN");
                komut.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 12, FontStyle.Regular);
        }

        private void lblAdi_MouseMove(object sender, MouseEventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 12, FontStyle.Underline);
        }

        private void yListeAraci_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_secilenler Where KISI=@kisi AND TUR=@tur", connection);
            komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
            komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
            SqlDataReader read = komut.ExecuteReader();
            if(read.Read())
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);

                pictureBox1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\tik.png";
            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 28, 43);
                pictureBox1.ImageLocation = @"C:\Users\ASUS\OneDrive\Masaüstü\tik.png";
            }
            connection.Close();
        }
    }
}
