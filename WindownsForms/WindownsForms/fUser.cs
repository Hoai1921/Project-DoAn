using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;

namespace WindownsForms
{
    public partial class fUser : Form
    {
        Function dtBase = new Function();
        DataTable dtTable;
        public fUser()
        {
            InitializeComponent();
        }
        void LoadDanhSach()
        {
            string sql = "SELECT Id, UrlFile FROM BANGDIEM ";
            dtTable = dtBase.DataReader(sql);
            dgvDanhSach.DataSource = dtTable;
            dgvDanhSach.Columns[0].HeaderText = "ID";
            dgvDanhSach.Columns[1].HeaderText = "Path";
            dgvDanhSach.Columns[0].Width = 100;
            dgvDanhSach.Columns[1].Width = 750;
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
                string sql = "Select Id, UrlFile FROM BANGDIEM where UrlFile like N'%" + txtSearch.Text + "%'";
                dgvDanhSach.DataSource = dtBase.DataReader(sql);
        }

        private void fUser_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void dgvDanhSach_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fAnh f = new fAnh(dgvDanhSach.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void dgvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
            dlg.ShowDialog();
        }
    }


}
