using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace hastaTakipSistemi
{
    public partial class kayıtformu : Form
    {
        public kayıtformu()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkullaniciAdi.Text!= "" && txtSifre.Text != "")
            {
                SqlCommand kayıt = new SqlCommand("kayitol",bgl.baglanti());
                kayıt.CommandType = CommandType.StoredProcedure;
                kayıt.Parameters.AddWithValue("@kulAdi", txtkullaniciAdi.Text);
                kayıt.Parameters.AddWithValue("@sifre", txtSifre.Text);
                kayıt.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information); 

            }
            else{
                MessageBox.Show("Lütfen boş alan bırakmayınız","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);    
            }
        }
    }
}
