using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudApp.Models;

namespace CrudApp
{
    public partial class frmShippers : Form
    {
        CrudAppDbContext dbContext = new CrudAppDbContext();
        private int ID;

        public frmShippers()
        {
            InitializeComponent();
        }

        private void dgwShippers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;

            ID          = (int)   dgwShippers.Rows[e.RowIndex].Cells[0].Value;
            txtAdi.Text = (string)dgwShippers.Rows[e.RowIndex].Cells[1].Value;           

        }

        private void frmShippers_Load(object sender, EventArgs e)
        {
            ShipperDoldur();
        }

        private void frmShippers_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (ID==0)
            {
                MessageBox.Show("Silme işlemi için önce kayıt Seç");
                return;
            }
            if (MessageBox.Show("Silmek istediğinize Emin misiniz", "Uyarı",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                return;

            Shippers sip = dbContext.Nakliyeci.Find(ID);
            dbContext.Nakliyeci.Remove(sip);
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                ShipperDoldur();
                Clear();
                ID = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
        }        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Shippers ship = dbContext.Nakliyeci.Find(ID);

            if (ship == null)
                ship = new Shippers();

            ship.Name = txtAdi.Text;

            if (ID == 0)
                dbContext.Nakliyeci.Add(ship);

            //Shippers ship = new Shippers();
            //ship.Name = txtAdi.Text;
            //dbContext.Nakliyeci.Add(ship);

            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("İşlem Başarılı");
                ShipperDoldur();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }

            ID = 0;
        }
        void ShipperDoldur()
        {
            //List<Shi>
            dgwShippers.DataSource = dbContext.Nakliyeci.Select(c=> new
            {
                c.ID,
                c.Name,
                c.CreDate

            }).ToList();

        }
        void Clear()
        {
            txtAdi.Clear();
        }
    }
}
