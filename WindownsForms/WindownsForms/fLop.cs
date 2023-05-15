using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class fLop : Form
    {
        Classes.Function dtBase = new Classes.Function();
        DataTable dtTable;
        public fLop()
        {
            InitializeComponent();
        }
        private void fLop_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadLop();
        }
        private void ResetValues()
        {
            txbID.Text = "";
            txbName.Text = "";
            txbName.Enabled = false;
            txbID.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
        }
        void LoadLop()
        {
            string sql;
            sql = "SELECT Id, Lop FROM LOPHOC where TrangThai = 0";
            dtTable = dtBase.DataReader(sql);
            dgvLop.DataSource = dtTable;
            dgvLop.Columns[0].HeaderText = "ID";
            dgvLop.Columns[1].HeaderText = "Lớp";
            dgvLop.Columns[0].Width = 100;
            dgvLop.Columns[1].Width = 210;
            dgvLop.AllowUserToAddRows = false;
            dgvLop.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
        private void fLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txbID.Text = dgvLop.CurrentRow.Cells[0].Value.ToString();
            txbName.Text = dgvLop.CurrentRow.Cells[1].Value.ToString();
            txbName.Focus();
            txbName.Enabled = true;
            btnDelete.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            txbID.Text = dtBase.SinhMaTuDong("LOPHOC", "Id");
            txbName.Focus();// đặt con trỏ vào textbox đó
            txbName.Text = "";
            txbName.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;

            if (txbName.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbName.Focus();
                return;
            }
            sql = "Select * FROM LOPHOC where Lop =N'" + txbName.Text + "'";
            if (dtBase.CheckKey(sql))
            {
                sql = "UPDATE LOPHOC SET  TrangThai = 0 where Lop =N'" + txbName.Text + "'";
                dtBase.DataChange(sql);
            }
            else
            {
                sql = "INSERT INTO LOPHOC(Lop)" + " VALUES (N'" + txbName.Text.Trim() + "')";
                dtBase.DataChange(sql);
            }
            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txbName.Focus();
            LoadLop();
            ResetValues();
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtTable.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txbID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "UPDATE LOPHOC SET TrangThai = 1 where Id=" + txbID.Text.Trim();
                dtBase.DataChange(sql);

                LoadLop();
                ResetValues();
            }
        }
    }
}
