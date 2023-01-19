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
    public partial class FrmAdmin : Form
    {
        otogaleri oto4 = new otogaleri();
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string cümle = "insert into TblAdmin(Kullanici,Sifre) values(@Kullanici,@Sifre)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Kullanici", TxtKullaniciAdi.Text);
            komut2.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
            oto4.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }
        private void Admin()
        {
            string cümle = "select *from TblAdmin";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oto4.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Kullanici";
            dataGridView1.Columns[2].HeaderText = "Sifre";
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update TblAdmin set Kullanici=@Kullanici,Sifre=@Sifre where ID=@ID";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ID", TxtID.Text);
            komut2.Parameters.AddWithValue("@Kullanici", TxtKullaniciAdi.Text);
            komut2.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
            oto4.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            Admin();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from TblAdmin where ID='" + satır.Cells["ID"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            oto4.ekle_sil_güncelle(komut2, cümle);
            //foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            Admin();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            Admin();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            TxtID.Text = satır.Cells[0].Value.ToString();
            TxtKullaniciAdi.Text = satır.Cells[1].Value.ToString();
            TxtSifre.Text = satır.Cells[2].Value.ToString();
        }
    }
}
