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
using veritproje.Formlar;

namespace veritproje.Formlar
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BMDV61B;Initial Catalog=otogaleri;Integrated Security=True");
        DataTable tablo;

        private void button1_Click(object sender, EventArgs e)
        {
             try
            { baglanti.Open(); string sql = "Select * From TblAdmin where Kullanici=@Kullanici AND Sifre=@Sifre"; 
              SqlParameter prm1 = new SqlParameter("adi", textBox1);
              SqlParameter prm2 = new SqlParameter("sifresi", textBox2); 
              SqlCommand komut = new SqlCommand(sql, baglanti); 
              komut.Parameters.Add(prm1); komut.Parameters.Add(prm2);
              FrmAnasayfa anaSayfa = new FrmAnasayfa(); 
              this.Hide(); anaSayfa.Show(); } catch (Exception) { MessageBox.Show("Hatalı Giriş"); }
        }
    }
}
