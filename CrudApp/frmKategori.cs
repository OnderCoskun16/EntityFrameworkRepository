using CrudApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudApp
{
    public partial class frmKategori : Form
    {
        CrudAppDbContext dbContext = new CrudAppDbContext();
        private int ID;

        public frmKategori()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Name = txtKategori.Text;
            c.Description = txtAciklama.Text;

            dbContext.Kategori.Add(c);
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Tebrikler. \n Kategori Ekleme Başarılı");
                Clear();
                KategoriDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu");

            }
            

        }

        void Clear()
        {
            txtKategori.Text = " ";
            txtAciklama.Text = " ";
        }
        void KategoriDoldur()
        {
            //List<Categories> katList = dbContext.Kategori.ToList();
            //dgwKategoriler.DataSource = katList;

            var katList2 = dbContext.Kategori.Select(c => new
            {
                c.ID,
                c.Name,
                c.Description,
                c.CreDate
            }).ToList();

            dgwKategoriler.DataSource = katList2;

        }
        private void frmKategori_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
        }

        private void dgwKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            if (rowIndex == -1 || colIndex == -1)
                return;

            ID = (int)dgwKategoriler.Rows[rowIndex].Cells[0].Value;
            txtKategori.Text = (string)dgwKategoriler.Rows[rowIndex].Cells[1].Value;
            txtAciklama.Text = (string)dgwKategoriler.Rows[rowIndex].Cells[2].Value;

            btnGuncelle.Enabled = true;
            btnSil.Enabled      = true;
            btnEkle.Enabled     = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Categories kategori = dbContext.Kategori.Find(ID);
            kategori.Name = txtKategori.Text;
            kategori.Description = txtAciklama.Text;
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                Clear();
                ID = 0;
                KategoriDoldur();
                btnGuncelle.Enabled = false;
                btnSil.Enabled      = false;
                btnEkle.Enabled     = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hay aksi... Bir hata var...");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Gerçekten silmek istiyor musun???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.No)
                return;

            
            Categories kategori = dbContext.Kategori.Find(ID);
            dbContext.Remove(kategori);

            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Silme İşlemi Başarılı");
                Clear();
                ID = 0;
                KategoriDoldur();
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                btnEkle.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(" Bir hata var...");
            }


        }
    }
}
