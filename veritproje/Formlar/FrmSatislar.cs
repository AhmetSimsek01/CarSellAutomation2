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
    public partial class FrmSatislar : Form
    {
        otogaleri oto3 = new otogaleri();
        public FrmSatislar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BMDV61B;Initial Catalog=otogaleri;Integrated Security=True");
        DataTable tablo;
        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            Satis();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ID from TblMusteri",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CbxMusteri.Items.Add(dr[0]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select ID from TblAraclar", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CbxArac.Items.Add(dr2[0]);
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Satis()
        {
            string cümle = "select *from TblSatis";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oto3.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Musteri";
            dataGridView1.Columns[2].HeaderText = "Arac";
            dataGridView1.Columns[3].HeaderText = "Ucret";
            dataGridView1.Columns[4].HeaderText = "Tarih";
        }

        private void CbxMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string cümle = "insert into TblSatis(Musteri,Arac,Ucret,Tarih) values(@Musteri,@Arac,@Ucret,@Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Musteri", Convert.ToInt32 (CbxMusteri.Text));
            komut2.Parameters.AddWithValue("@Arac", Convert.ToInt32 (CbxArac.Text));
            komut2.Parameters.AddWithValue("@Ucret", textBox1.Text);
            komut2.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
            oto3.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update TblSatis set Musteri=@Musteri,Arac=@Arac,Ucret=@Ucret,Tarih=@Tarih where ID=@ID";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ID", textBox3.Text);
            komut2.Parameters.AddWithValue("@Musteri", Convert.ToInt32(CbxMusteri.Text));
            komut2.Parameters.AddWithValue("@Arac", Convert.ToInt32(CbxArac.Text));
            komut2.Parameters.AddWithValue("@Ucret", textBox1.Text);
            komut2.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
            oto3.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            Satis();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox3.Text = satır.Cells[0].Value.ToString();
            CbxMusteri.Text = satır.Cells[1].Value.ToString();
            CbxArac.Text = satır.Cells[2].Value.ToString();
            textBox1.Text = satır.Cells[3].Value.ToString();
            dateTimePicker1.Text = satır.Cells[4].Value.ToString();
        }
    }
}
