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
namespace hastaTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     sqlbaglanti bgl = new sqlbaglanti();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisyap_Click(object sender, EventArgs e)
        {
            if (txtkullanici.Text != "" && txtSifre.Text != "")
            {
                SqlCommand giris = new SqlCommand("girisYap", bgl.baglanti());
                giris.CommandType = CommandType.StoredProcedure;
                giris.Parameters.AddWithValue("@kulAdi", txtkullanici.Text);
                giris.Parameters.AddWithValue("@sifre", txtSifre.Text);
                SqlDataReader dr = giris.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bgl.baglanti().Close();

                AnaSayfa ana = new AnaSayfa();
                ana.Show();
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kayıtol_Click(object sender, EventArgs e)
        {
            kayıtformu kayit = new kayıtformu();
            kayit.Show();
        }
    }
}
