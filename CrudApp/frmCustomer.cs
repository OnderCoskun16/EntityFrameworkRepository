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
using CrudApp.Repository;

namespace CrudApp
{
    public partial class frmCustomer : Form
    {
        CustomerRepository Cuztomer = new CustomerRepository();
        private int ID;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customers Cuser = Cuztomer.FindById(ID);

            if (Cuser == null)
                Cuser = new Customers();
            Cuser.Name         = txtCompanyName.Text;
            Cuser.ContactPhone = txtContactPhone.Text;
            Cuser.ContactTitle = txtContactTitle.Text;

            int result = 0;

            if (ID == 0) result = Cuztomer.Create(Cuser);
            else         result = Cuztomer.Update(Cuser);

            //_ = (result > 0) ? MessageBox.Show("Başarılı") : MessageBox.Show("Başarısız");
            if (result > 0) MessageBox.Show("Başarılı");
            else MessageBox.Show("Başarısız");
            Doldur();
            Clear();

        }

       

        private void dgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            ID = (int)dgwCustomer.Rows[e.RowIndex].Cells[0].Value;
            txtCompanyName.Text  = (string)dgwCustomer.Rows[e.RowIndex].Cells[2].Value;
            txtContactTitle.Text = (string)dgwCustomer.Rows[e.RowIndex].Cells[3].Value;
            txtContactPhone.Text = (string)dgwCustomer.Rows[e.RowIndex].Cells[4].Value;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Clear();
            Doldur();
        }

        void Clear()
        {
            txtCompanyName.Clear();
            txtContactPhone.Clear();
            txtContactTitle.Clear();
            ID = 0;
        }
        void Doldur()
        {

            dgwCustomer.DataSource = Cuztomer.List().Select(c => new
            {
                c.ID,
                c.CreDate,
                c.Name,
                c.ContactTitle,                
                c.ContactPhone

            }).ToList();
        }
    }
}
