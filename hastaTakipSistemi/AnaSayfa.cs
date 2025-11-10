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

namespace hastaTakipSistemi
{
    public partial class AnaSayfa : Form
    {
        sqlbaglanti bgl = new sqlbaglanti();
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
            durumDoldur();
            bolumDoldur();
        }

        private void Listele()
        {
            SqlCommand liste = new SqlCommand("listele", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(liste);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void durumDoldur()
        {
            SqlCommand durum = new SqlCommand("durumDoldur", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(durum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtdurum.DataSource = dt;
            txtdurum.DisplayMember = "durumAd";
            txtdurum.ValueMember = "durumID";

        }

        private void bolumDoldur()
        {

            SqlCommand bolum = new SqlCommand("bolumDoldur", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(bolum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtbolum.DataSource = dt;
            txtbolum.DisplayMember = "bolumAd";
            txtbolum.ValueMember = "bolumID";






        }
        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

            {

            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void girisyap_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtdurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBoxTC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBoxTEL.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxYAŞ.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBoxCİNSİYET.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            textBoxŞİKAYET.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textBoxTARİH.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtbolum.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            label5.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();


        }

        private void rbEvet_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEvet.Checked == true)
            {

                label5.Text = "true";
            }
            else
            {
                label5.Text = "false";
            }
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            if (label5.Text == "true")
            {
                rbEvet.Checked = true;
            }
            else
            {
                rbHayır.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxAD.Text != "" && txtbolum.Text != "" && textBoxCİNSİYET.Text != "" && txtdurum.Text != "" && textBoxŞİKAYET.Text != "" && textBoxSOYAD.Text != "" && textBoxTC.Text != "" && textBoxTEL.Text != "")
            {
                kaydet();
            }
            else
            {

                MessageBox.Show("Lütfen boş alan bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void kaydet()
        {

            SqlCommand kaydet = new SqlCommand("kaydet", bgl.baglanti());
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("@ad", textBoxAD.Text.ToString());
            kaydet.Parameters.AddWithValue("@soyad", textBoxSOYAD.Text.ToString());
            kaydet.Parameters.AddWithValue("@tc", textBoxTC.Text.ToString());
            kaydet.Parameters.AddWithValue("@tel", textBoxTEL.Text.ToString());
            kaydet.Parameters.AddWithValue("@yas", int.Parse(textBoxYAŞ.Text.ToString()));
            kaydet.Parameters.AddWithValue("@cins", textBoxCİNSİYET.Text.ToString());
            kaydet.Parameters.AddWithValue("@sikayet", textBoxŞİKAYET.Text.ToString());
            kaydet.Parameters.AddWithValue("@tarih", DateTime.Now);
            kaydet.Parameters.AddWithValue("@durum", txtdurum.SelectedValue);
            kaydet.Parameters.AddWithValue("@bolum", txtbolum.SelectedValue);
            if (label5.Text == "True")
            {
                kaydet.Parameters.AddWithValue("@ex", 1);
            }
            else
            {
                kaydet.Parameters.AddWithValue("@ex", 0);
            }
            kaydet.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void sil()
        {
            DialogResult dr = MessageBox.Show("Kaydı Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("sil", bgl.baglanti());
                sil.CommandType = CommandType.StoredProcedure;
                sil.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text.ToString()));
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{textBoxID.Text}Kayıt Güncellenecek Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                guncelle();
                Listele();
            }
        }
        private void guncelle()
        {
            SqlCommand guncelle = new SqlCommand("guncelle", bgl.baglanti());
            guncelle.CommandType = CommandType.StoredProcedure;
            guncelle.Parameters.AddWithValue("@ID", int.Parse(textBoxID.Text.ToString()));
            guncelle.Parameters.AddWithValue("@ad", textBoxAD.Text.ToString());
            guncelle.Parameters.AddWithValue("@soyad", textBoxSOYAD.Text.ToString());
            guncelle.Parameters.AddWithValue("@tc", textBoxTC.Text.ToString());
            guncelle.Parameters.AddWithValue("@tel", textBoxTEL.Text.ToString());
            guncelle.Parameters.AddWithValue("@yas", int.Parse(textBoxYAŞ.Text.ToString()));
            guncelle.Parameters.AddWithValue("@cins", textBoxCİNSİYET.Text.ToString());
            guncelle.Parameters.AddWithValue("@sikayet", textBoxŞİKAYET.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", DateTime.Now);
            guncelle.Parameters.AddWithValue("@durum", txtdurum.SelectedValue);
            guncelle.Parameters.AddWithValue("@bolum", txtbolum.SelectedValue);
            if (label5.Text == "True")
            {
                guncelle.Parameters.AddWithValue("@ex", 1);
            }
            else
            {
                guncelle.Parameters.AddWithValue("@ex", 0);
            }
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void temizle()
        {
            textBoxID.Text="";
            textBoxAD.Text="";
            textBoxSOYAD.Text="";
            textBoxTC.Text="";
            textBoxTEL.Text="";
            textBoxYAŞ.Text="";
            textBoxCİNSİYET.Text="";
            textBoxŞİKAYET.Text="";
            txtbolum.Text = "";
            txtdurum.Text = "";
            rbHayır.Checked = true;
            label5.Text="false";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmistatistik fr = new frmistatistik();
            fr.Show();
        }
        
    }
}

