using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindownsForms;

namespace WindowsForms
{
    public partial class fAdmin : Form
    {
        Classes.Function dtBase = new Classes.Function();
        DataTable dtTable;

        public fAdmin()
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

        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            string sql;
            sql = "select * from MONHOC where TrangThai = 0 order by TenMon";
            dtBase.FillCombo(sql, cbMon, "Id", "TenMon");
            cbMon.SelectedIndex = -1;
            dtBase.FillCombo(sql, cbMonLai, "Id", "TenMon");
            cbMonLai.SelectedIndex = -1;
            sql = "select * from HOCKY where TrangThai = 0 order by HocKy";
            dtBase.FillCombo(sql, cbHocKy, "Id", "HocKy");
            cbHocKy.SelectedIndex = -1;
            sql = "select * from LOPHOC where TrangThai = 0 order by Lop";
            dtBase.FillCombo(sql, cbLop, "Id", "Lop");
            cbLop.SelectedIndex = -1;
            sql = "select * from KHOA where TrangThai = 0 order by Khoa";
            dtBase.FillCombo(sql, cbKhoa, "Id", "Khoa");
            cbKhoa.SelectedIndex = -1;
            sql = "select * from NAMHOC where TrangThai = 0 order by NamHoc";
            dtBase.FillCombo(sql, cbNam, "Id", "NamHoc");
            cbNam.SelectedIndex = -1;

            txbUrlChinh.Text = "";
            txbUrlLai.Text = "";
            btnSave.Enabled = false;
            btnSave_Lai.Enabled = false;
            rbtnLan1.Checked = true;
            btnNew.Enabled = true;
            btnNew_Lai.Enabled = true;

            LoadDanhSach();
        }
        private void btnHocKy_Click(object sender, EventArgs e)
        {
            fHocKy f = new fHocKy();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            fMon f = new fMon();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            fLop f = new fLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            fKhoa f = new fKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            fNam f = new fNam();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }
        private void fAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }

        int maLan = 0;

        private void btnNew_Click(object sender, EventArgs e)
        {
            string lan = "";
            string NameFolder = "";
            if (rbtnLan1.Checked == true)
            {
                maLan = 1;
                lan = dtBase.GetFieldValues("TenLan", maLan, "LANHOC");
                NameFolder = cbMon.Text.Trim() + "_" + cbLop.Text.Trim() + "_" + cbKhoa.Text.Trim() + "_" + lan;
            }
            if (rbtnLan2.Checked == true)
            {
                maLan = 2;
                lan = dtBase.GetFieldValues("TenLan", maLan, "LANHOC");
                NameFolder = cbMon.Text.Trim() + "_" + cbLop.Text.Trim() + "_" + cbKhoa.Text.Trim() + "_" + lan;
            }
            if (cbMon.Text.Trim() == "" || cbKhoa.Text.Trim() == "" || cbLop.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtBase.CheckURL("Id_Mon", "Id_Lop", "Id_Khoa", "Id_LanHoc", cbMon.SelectedValue.GetHashCode(), cbLop.SelectedValue.GetHashCode(), cbKhoa.SelectedValue.GetHashCode(), maLan))
            {
                MessageBox.Show("Đã tồn tại Folder lưu trữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                txbUrlChinh.Text = dtBase.GetPath() + NameFolder;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            DirectoryInfo directory = new DirectoryInfo(txbUrlChinh.Text.Trim());

            directory.Create();
            sql = "INSERT INTO BANGDIEM(Id_Mon,Id_Lop,Id_Khoa,Id_LanHoc,UrlFile)" + " VALUES (" + cbMon.SelectedValue.GetHashCode() + "," + cbLop.SelectedValue.GetHashCode() + "," + cbKhoa.SelectedValue.GetHashCode() + "," + maLan + ",N'" + txbUrlChinh.Text + "')";
            dtBase.DataChange(sql);
            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadData();
        }

        private void btnNew_Lai_Click(object sender, EventArgs e)
        {
            string NameFolder = "";
            string lan = dtBase.GetFieldValues("TenLan", 3, "LANHOC"); ;
            NameFolder = cbMonLai.Text.Trim() + "_" + cbHocKy.Text.Trim() + "_" + cbNam.Text.Trim() + "_" + lan; ;

            if (cbMonLai.Text.Trim() == "" || cbNam.Text.Trim() == "" || cbHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtBase.CheckURL("Id_Mon", "Id_Nam", "Id_HocKy", "Id_LanHoc", cbMonLai.SelectedValue.GetHashCode(), cbNam.SelectedValue.GetHashCode(), cbHocKy.SelectedValue.GetHashCode(), 3))
            {
                MessageBox.Show("Đã tồn tại Folder lưu trữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                txbUrlLai.Text = dtBase.GetPath() + NameFolder;
                btnSave_Lai.Enabled = true;

            }
        }

        private void btnSave_Lai_Click(object sender, EventArgs e)
        {
            string sql = "";
            DirectoryInfo directory = new DirectoryInfo(txbUrlLai.Text.Trim());

            directory.Create();
            sql = "INSERT INTO BANGDIEM(Id_Mon,Id_Nam,Id_HocKy,Id_LanHoc,UrlFile)" + " VALUES (" + cbMonLai.SelectedValue.GetHashCode() + "," + cbNam.SelectedValue.GetHashCode() + "," + cbHocKy.SelectedValue.GetHashCode() + "," + 3 + ",N'" + txbUrlLai.Text + "')";
            dtBase.DataChange(sql);
            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "Select Id, UrlFile FROM BANGDIEM where UrlFile like N'%" + txtSearch.Text + "%'";
            dgvDanhSach.DataSource = dtBase.DataReader(sql);
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
