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
using System.Drawing.Text;

namespace hastaTakipSistemi
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        sqlbaglanti sqlbaglanti = new sqlbaglanti();
        private void frmistatistik_Load(object sender, EventArgs e)
        {
            toplamHasta();
            Ortalama();
            CinsiyetOran();
            Exhasta();

        }
        private void toplamHasta()
        {
            SqlCommand toplam = new SqlCommand("select count(*) from tbl_hastabilgi",sqlbaglanti.baglanti());
            SqlDataReader dr = toplam.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr[0].ToString();
            }
        }
        private void Ortalama()
        {
            SqlCommand yas = new SqlCommand("select avg(hYas) from tbl_hastabilgi", sqlbaglanti.baglanti());
            SqlDataReader dr = yas.ExecuteReader();
            while (dr.Read())
            {
                label5.Text = dr[0].ToString();
            }
        }
        private void CinsiyetOran()
        {
            SqlCommand erkek = new SqlCommand("select count(*) from tbl_hastabilgi where hCinsiyet='Erkek'", sqlbaglanti.baglanti());
            SqlDataReader dr = erkek.ExecuteReader();
            while (dr.Read())
            {
                label7.Text = dr[0].ToString();
            }
            SqlCommand kadın = new SqlCommand("select count(*) from tbl_hastabilgi where hCinsiyet='Kadın'", sqlbaglanti.baglanti());
            SqlDataReader dr2 = kadın.ExecuteReader();
            while (dr2.Read())
            {
                label9.Text = dr2[0].ToString();
            }
        }
        private void Exhasta()
        {
             SqlCommand ex = new SqlCommand("select count(*) from tbl_hastabilgi where hDurum=1", sqlbaglanti.baglanti());
            SqlDataReader dr = ex.ExecuteReader();
            while (dr.Read())
            {
                label11.Text = dr[0].ToString();
            }
        }
    }
}
