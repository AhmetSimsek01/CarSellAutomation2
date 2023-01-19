using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritproje.Formlar
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin ekle = new FrmAdmin();
            ekle.ShowDialog();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteri ekle = new FrmMusteri();
            ekle.ShowDialog();
        }

        private void BtnAraclar_Click(object sender, EventArgs e)
        {
            FrmAraclar ekle = new FrmAraclar();
            ekle.ShowDialog();
        }

        private void BtnSatislar_Click(object sender, EventArgs e)
        {
            FrmSatislar ekle = new FrmSatislar();
            ekle.ShowDialog();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
