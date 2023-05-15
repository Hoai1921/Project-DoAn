using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class fNam : Form
    {
        Classes.Function dtBase = new Classes.Function();
        DataTable dtTable;
        public fNam()
        {
            InitializeComponent();
        }
        private void fNam_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadNamList();
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
        void LoadNamList()
        {
            string sql;
            sql = "SELECT Id,NamHoc FROM NAMHOC where TrangThai = 0 order by NamHoc";
            dtTable = dtBase.DataReader(sql);
            dgvNam.DataSource = dtTable;
            dgvNam.Columns[0].HeaderText = "ID";
            dgvNam.Columns[1].HeaderText = "Năm Học";
            dgvNam.Columns[0].Width = 90;
            dgvNam.Columns[1].Width = 200;

            dgvNam.AllowUserToAddRows = false;
            dgvNam.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void fNam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel= false;
            else e.Cancel = true;
        }

        private void dgvNam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txbID.Text = dgvNam.CurrentRow.Cells[0].Value.ToString();
            txbName.Text = dgvNam.CurrentRow.Cells[1].Value.ToString();
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
            txbID.Text = dtBase.SinhMaTuDong("NAMHOC", "Id");
            txbName.Focus();// đặt con trỏ vào textbox đó
            txbName.Text = "";
            txbName.Enabled = true;
            txbName.MaxLength = 4;
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
            string nam = txbName.Text.Trim();
            int nam2= int.Parse(nam)+1;
            string name = nam + "-" + nam2.ToString();
            sql = "Select * FROM NAMHOC where NamHoc =N'" + name + "'";
            if (dtBase.CheckKey(sql))
            {
                sql = "UPDATE NAMHOC SET  TrangThai = 0 where NamHoc =N'" + name + "'";
                dtBase.DataChange(sql);
            }
            else
            {
                sql = "INSERT INTO NAMHOC(NamHoc)" + " VALUES (N'" + name + "')";
                dtBase.DataChange(sql);
            }
            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txbName.Focus();
            LoadNamList();
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
                sql = "UPDATE NAMHOC SET TrangThai = 1 where Id=" + txbID.Text.Trim();
                dtBase.DataChange(sql);

                LoadNamList();
                ResetValues();
            }
        }
    }
}
