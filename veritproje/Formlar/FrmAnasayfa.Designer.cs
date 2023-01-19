
namespace veritproje.Formlar
{
    partial class FrmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnSatislar = new System.Windows.Forms.Button();
            this.BtnAraclar = new System.Windows.Forms.Button();
            this.BtnMusteriler = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(503, 3);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(117, 51);
            this.BtnCikis.TabIndex = 5;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnSatislar
            // 
            this.BtnSatislar.Location = new System.Drawing.Point(380, 3);
            this.BtnSatislar.Name = "BtnSatislar";
            this.BtnSatislar.Size = new System.Drawing.Size(117, 51);
            this.BtnSatislar.TabIndex = 4;
            this.BtnSatislar.Text = "Satışlar";
            this.BtnSatislar.UseVisualStyleBackColor = true;
            this.BtnSatislar.Click += new System.EventHandler(this.BtnSatislar_Click);
            // 
            // BtnAraclar
            // 
            this.BtnAraclar.Location = new System.Drawing.Point(257, 3);
            this.BtnAraclar.Name = "BtnAraclar";
            this.BtnAraclar.Size = new System.Drawing.Size(117, 51);
            this.BtnAraclar.TabIndex = 3;
            this.BtnAraclar.Text = "Araçlar";
            this.BtnAraclar.UseVisualStyleBackColor = true;
            this.BtnAraclar.Click += new System.EventHandler(this.BtnAraclar_Click);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.Location = new System.Drawing.Point(134, 3);
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.Size = new System.Drawing.Size(117, 51);
            this.BtnMusteriler.TabIndex = 2;
            this.BtnMusteriler.Text = "Müşteriler";
            this.BtnMusteriler.UseVisualStyleBackColor = true;
            this.BtnMusteriler.Click += new System.EventHandler(this.BtnMusteriler_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Location = new System.Drawing.Point(10, 3);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(118, 51);
            this.BtnAdmin.TabIndex = 1;
            this.BtnAdmin.Text = "Admin";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnCikis);
            this.panel1.Controls.Add(this.BtnSatislar);
            this.panel1.Controls.Add(this.BtnAdmin);
            this.panel1.Controls.Add(this.BtnAraclar);
            this.panel1.Controls.Add(this.BtnMusteriler);
            this.panel1.Location = new System.Drawing.Point(77, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 57);
            this.panel1.TabIndex = 2;
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnasayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnSatislar;
        private System.Windows.Forms.Button BtnAraclar;
        private System.Windows.Forms.Button BtnMusteriler;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Panel panel1;
    }
}