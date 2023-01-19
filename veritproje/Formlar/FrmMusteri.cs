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

namespace veritproje.Formlar
{
    public partial class FrmMusteri : Form
    {
        otogaleri oto = new otogaleri();
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string cümle = "insert into TblMusteri(TC,Ad,Soyad,Telefon,Adres,Mail) values(@TC,@Ad,@Soyad,@Telefon,@Adres,@Mail)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@TC", TxtTC.Text);
            komut2.Parameters.AddWithValue("@Ad", TxtAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@Telefon", TxtTelefon.Text);
            komut2.Parameters.AddWithValue("@Adres", TxtAdres.Text);
            komut2.Parameters.AddWithValue("@Mail", TxtMail.Text);
            oto.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }
        private void YenileListele()
        {
            string cümle = "select *from TblMusteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oto.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "TC";
            dataGridView1.Columns[2].HeaderText = "AD";
            dataGridView1.Columns[3].HeaderText = "SOYAD";
            dataGridView1.Columns[4].HeaderText = "TELEFON";
            dataGridView1.Columns[5].HeaderText = "ADRES";
            dataGridView1.Columns[6].HeaderText = "E-MAİL";
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            TxtID.Text = satır.Cells[0].Value.ToString();
            TxtTC.Text = satır.Cells[1].Value.ToString();
            TxtAd.Text = satır.Cells[2].Value.ToString();
            TxtSoyad.Text = satır.Cells[3].Value.ToString();
            TxtTelefon.Text = satır.Cells[4].Value.ToString();
            TxtAdres.Text = satır.Cells[5].Value.ToString();
            TxtMail.Text = satır.Cells[6].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update TblMusteri set TC=@TC,Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon,Adres=@Adres,Mail=@Mail where ID=@ID";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ID", TxtID.Text);
            komut2.Parameters.AddWithValue("@TC", TxtTC.Text);
            komut2.Parameters.AddWithValue("@Ad", TxtAd.Text);
            komut2.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@Telefon", TxtTelefon.Text);
            komut2.Parameters.AddWithValue("@Adres", TxtAdres.Text);
            komut2.Parameters.AddWithValue("@Mail", TxtMail.Text);
            oto.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from TblMusteri where ID='" + satır.Cells["ID"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            oto.ekle_sil_güncelle(komut2, cümle);
            YenileListele();
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            YenileListele();
        }
    }
}
