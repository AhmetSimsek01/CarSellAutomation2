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
    public partial class FrmAraclar : Form
    {
        otogaleri oto2 = new otogaleri();
        public FrmAraclar()
        {
            InitializeComponent();
        }

        private void BtnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CbxSeri.Items.Clear();
                if (CbxMarka.SelectedItem.ToString() == "Renault")
                {
                    CbxSeri.Items.Add("Symbol");
                    CbxSeri.Items.Add("Clio");
                    CbxSeri.Items.Add("Kadjar");
                }
                else if (CbxMarka.SelectedItem.ToString() == "Volkswagen")
                {
                    CbxSeri.Items.Add("Passat");
                    CbxSeri.Items.Add("Golf");
                    CbxSeri.Items.Add("Tiguen");
                }
                else if (CbxMarka.SelectedItem.ToString() == "Fiat")
                {
                    CbxSeri.Items.Add("Egea");
                    CbxSeri.Items.Add("Doblo");
                    CbxSeri.Items.Add("Linea");
                }
                else if (CbxMarka.SelectedItem.ToString() == "Ford")
                {
                    CbxSeri.Items.Add("Focus");
                    CbxSeri.Items.Add("Mustang");
                    CbxSeri.Items.Add("Edge");
                }
                else if (CbxMarka.SelectedItem.ToString() == "BMW")
                {
                    CbxSeri.Items.Add("1 Serisi");
                    CbxSeri.Items.Add("6 Serisi");
                    CbxSeri.Items.Add("X5");
                }
                else if (CbxMarka.SelectedItem.ToString() == "Audi")
                {
                    CbxSeri.Items.Add("A6");
                    CbxSeri.Items.Add("RS");
                    CbxSeri.Items.Add("R8");
                }
                else if (CbxMarka.SelectedItem.ToString() == "Mercedes")
                {
                    CbxSeri.Items.Add("A Serisi");
                    CbxSeri.Items.Add("Benz");
                    CbxSeri.Items.Add("S Serisi");
                }
                else if (CbxMarka.SelectedItem.ToString() == "Tesla")
                {
                    CbxSeri.Items.Add("3 Serisi");
                    CbxSeri.Items.Add("S Serisi");
                    CbxSeri.Items.Add("X Serisi");
                }
                else if (CbxMarka.SelectedItem.ToString() == "Toyota")
                {
                    CbxSeri.Items.Add("Corolla");
                    CbxSeri.Items.Add("Yaris");
                    CbxSeri.Items.Add("RAV4");
                }
                else if (CbxMarka.SelectedItem.ToString() == "Hyundai")
                {
                    CbxSeri.Items.Add("İ20");
                    CbxSeri.Items.Add("H100");
                    CbxSeri.Items.Add("Accent");
                }
            }
            catch
            {

                throw;
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string cümle = "insert into TblAraclar(Plaka,Marka,Seri,Model,Renk,Vites,Yakit,Gorsel) values(@Plaka,@Marka,@Seri,@Model,@Renk,@Vites,@Yakit,@Gorsel)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Plaka", TxtPlaka.Text);
            komut2.Parameters.AddWithValue("@Marka", CbxMarka.Text);
            komut2.Parameters.AddWithValue("@Seri", CbxSeri.Text);
            komut2.Parameters.AddWithValue("@Model", TxtModel.Text);
            komut2.Parameters.AddWithValue("@Renk", TxtRenk.Text);
            komut2.Parameters.AddWithValue("@Vites", CbxVites.Text);
            komut2.Parameters.AddWithValue("@Yakit", CbxYakit.Text);
            komut2.Parameters.AddWithValue("@Gorsel", pictureBox1.ImageLocation);
            oto2.ekle_sil_güncelle(komut2, cümle);
            CbxSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            TxtID.Text = satır.Cells["ID"].Value.ToString();
            TxtPlaka.Text = satır.Cells["Plaka"].Value.ToString();
            CbxMarka.Text = satır.Cells["Marka"].Value.ToString();
            CbxSeri.Text = satır.Cells["Seri"].Value.ToString();
            TxtModel.Text = satır.Cells["Model"].Value.ToString();
            TxtRenk.Text = satır.Cells["Renk"].Value.ToString();
            CbxVites.Text = satır.Cells["Vites"].Value.ToString();
            CbxYakit.Text = satır.Cells["Yakit"].Value.ToString();
            pictureBox1.ImageLocation = satır.Cells["Gorsel"].Value.ToString();
        }
        private void YenileAraçListe()
        {
            string cümle = "select *from TblAraclar";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = oto2.listele(adtr2, cümle);
        }

        private void FrmAraclar_Load(object sender, EventArgs e)
        {
            YenileAraçListe();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update TblAraclar set Plaka=@Plaka,Marka=@Marka,Seri=@Seri,Model=@Model,Renk=@Renk,Vites=@Vites,Yakit=@Yakit,Gorsel=@Gorsel where ID=@ID";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ID", TxtID.Text);
            komut2.Parameters.AddWithValue("@Plaka", TxtPlaka.Text);
            komut2.Parameters.AddWithValue("@Marka", CbxMarka.Text);
            komut2.Parameters.AddWithValue("@Seri", CbxSeri.Text);
            komut2.Parameters.AddWithValue("@Model", TxtModel.Text);
            komut2.Parameters.AddWithValue("@Renk", TxtRenk.Text);
            komut2.Parameters.AddWithValue("@Vites", CbxVites.Text);
            komut2.Parameters.AddWithValue("@Yakit", CbxYakit.Text);
            komut2.Parameters.AddWithValue("@Gorsel", pictureBox1.ImageLocation);
            oto2.ekle_sil_güncelle(komut2, cümle);
            CbxSeri.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            YenileAraçListe();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from TblAraclar where ID='" + satır.Cells["ID"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            oto2.ekle_sil_güncelle(komut2, cümle);
            YenileAraçListe();
        }
    }
}
