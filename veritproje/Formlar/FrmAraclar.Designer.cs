
namespace veritproje.Formlar
{
    partial class FrmAraclar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnResimEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxYakit = new System.Windows.Forms.ComboBox();
            this.CbxVites = new System.Windows.Forms.ComboBox();
            this.CbxSeri = new System.Windows.Forms.ComboBox();
            this.CbxMarka = new System.Windows.Forms.ComboBox();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 378);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnCikis);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.BtnResimEkle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbxYakit);
            this.groupBox1.Controls.Add(this.CbxVites);
            this.groupBox1.Controls.Add(this.CbxSeri);
            this.groupBox1.Controls.Add(this.CbxMarka);
            this.groupBox1.Controls.Add(this.TxtRenk);
            this.groupBox1.Controls.Add(this.TxtModel);
            this.groupBox1.Controls.Add(this.TxtPlaka);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 378);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(111, 19);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(121, 20);
            this.TxtID.TabIndex = 42;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(258, 242);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(68, 67);
            this.BtnSil.TabIndex = 41;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(340, 168);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(68, 67);
            this.BtnEkle.TabIndex = 40;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(340, 241);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(68, 67);
            this.BtnGuncelle.TabIndex = 39;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(258, 315);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(150, 40);
            this.BtnCikis.TabIndex = 38;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(258, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // BtnResimEkle
            // 
            this.BtnResimEkle.Location = new System.Drawing.Point(258, 168);
            this.BtnResimEkle.Name = "BtnResimEkle";
            this.BtnResimEkle.Size = new System.Drawing.Size(68, 67);
            this.BtnResimEkle.TabIndex = 33;
            this.BtnResimEkle.Text = "Resim Ekle";
            this.BtnResimEkle.UseVisualStyleBackColor = true;
            this.BtnResimEkle.Click += new System.EventHandler(this.BtnResimEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Yakıt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Vites Tipi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Renk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Seri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Plaka:";
            // 
            // CbxYakit
            // 
            this.CbxYakit.FormattingEnabled = true;
            this.CbxYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Lpg",
            "Benzin+Lpg",
            "Elektrikli",
            "Hibrit"});
            this.CbxYakit.Location = new System.Drawing.Point(111, 334);
            this.CbxYakit.Name = "CbxYakit";
            this.CbxYakit.Size = new System.Drawing.Size(121, 21);
            this.CbxYakit.TabIndex = 24;
            // 
            // CbxVites
            // 
            this.CbxVites.FormattingEnabled = true;
            this.CbxVites.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.CbxVites.Location = new System.Drawing.Point(111, 288);
            this.CbxVites.Name = "CbxVites";
            this.CbxVites.Size = new System.Drawing.Size(121, 21);
            this.CbxVites.TabIndex = 23;
            // 
            // CbxSeri
            // 
            this.CbxSeri.FormattingEnabled = true;
            this.CbxSeri.Location = new System.Drawing.Point(111, 146);
            this.CbxSeri.Name = "CbxSeri";
            this.CbxSeri.Size = new System.Drawing.Size(121, 21);
            this.CbxSeri.TabIndex = 22;
            // 
            // CbxMarka
            // 
            this.CbxMarka.FormattingEnabled = true;
            this.CbxMarka.Items.AddRange(new object[] {
            "Renault",
            "Volkswagen",
            "Fiat",
            "Ford",
            "BMW",
            "Audi",
            "Mercedes",
            "Tesla",
            "Toyota",
            "Hyundai"});
            this.CbxMarka.Location = new System.Drawing.Point(111, 103);
            this.CbxMarka.Name = "CbxMarka";
            this.CbxMarka.Size = new System.Drawing.Size(121, 21);
            this.CbxMarka.TabIndex = 21;
            this.CbxMarka.SelectedIndexChanged += new System.EventHandler(this.CbxMarka_SelectedIndexChanged);
            // 
            // TxtRenk
            // 
            this.TxtRenk.Location = new System.Drawing.Point(111, 242);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(121, 20);
            this.TxtRenk.TabIndex = 19;
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(111, 192);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(121, 20);
            this.TxtModel.TabIndex = 18;
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(111, 57);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(121, 20);
            this.TxtPlaka.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(984, 406);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAraclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAraclar";
            this.Load += new System.EventHandler(this.FrmAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnResimEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxYakit;
        private System.Windows.Forms.ComboBox CbxVites;
        private System.Windows.Forms.ComboBox CbxSeri;
        private System.Windows.Forms.ComboBox CbxMarka;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}