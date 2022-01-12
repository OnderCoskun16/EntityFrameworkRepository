
namespace CrudApp
{
    partial class frmShippers
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwShippers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShippers)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(72, 31);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(73, 20);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Şirket Adı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(72, 67);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(264, 27);
            this.txtAdi.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(72, 111);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 29);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(212, 111);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(124, 29);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwShippers
            // 
            this.dgwShippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShippers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwShippers.Location = new System.Drawing.Point(0, 279);
            this.dgwShippers.Name = "dgwShippers";
            this.dgwShippers.RowHeadersWidth = 51;
            this.dgwShippers.RowTemplate.Height = 29;
            this.dgwShippers.Size = new System.Drawing.Size(406, 188);
            this.dgwShippers.TabIndex = 6;
            this.dgwShippers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwShippers_CellClick);
            // 
            // frmShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 467);
            this.Controls.Add(this.dgwShippers);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.Lbl1);
            this.Name = "frmShippers";
            this.Text = "frmShippers";
            this.Load += new System.EventHandler(this.frmShippers_Load);
            this.Click += new System.EventHandler(this.frmShippers_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgwShippers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwShippers;
    }
}