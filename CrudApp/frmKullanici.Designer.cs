
namespace CrudApp
{
    partial class frmKullanici
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.dgwKullanici = new System.Windows.Forms.DataGridView();
            this.chbAktif = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(111, 192);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 29);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanici Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(12, 43);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(193, 27);
            this.txtKullanici.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(12, 121);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(193, 27);
            this.txtSifre.TabIndex = 4;
            // 
            // dgwKullanici
            // 
            this.dgwKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanici.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwKullanici.Location = new System.Drawing.Point(0, 244);
            this.dgwKullanici.Name = "dgwKullanici";
            this.dgwKullanici.RowHeadersWidth = 51;
            this.dgwKullanici.RowTemplate.Height = 29;
            this.dgwKullanici.Size = new System.Drawing.Size(539, 218);
            this.dgwKullanici.TabIndex = 5;
            this.dgwKullanici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKullanici_CellClick);
            this.dgwKullanici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKullanici_CellContentClick);
            // 
            // chbAktif
            // 
            this.chbAktif.AutoSize = true;
            this.chbAktif.Location = new System.Drawing.Point(12, 162);
            this.chbAktif.Name = "chbAktif";
            this.chbAktif.Size = new System.Drawing.Size(83, 24);
            this.chbAktif.TabIndex = 6;
            this.chbAktif.Text = "Aktif mi";
            this.chbAktif.UseVisualStyleBackColor = true;
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 462);
            this.Controls.Add(this.chbAktif);
            this.Controls.Add(this.dgwKullanici);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Name = "frmKullanici";
            this.Text = "frmKullanici";
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.DataGridView dgwKullanici;
        private System.Windows.Forms.CheckBox chbAktif;
    }
}