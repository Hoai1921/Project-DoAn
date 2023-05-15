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
using WindownsForms;

namespace WindowsForms
{
    public partial class fLogin : Form
    {
        Classes.Function dtBase = new Classes.Function();
        DataTable dtTable;
        public bool ischeck = false;
        public fLogin()
        {
            InitializeComponent();
        }
        private void fLogin_Load(object sender, EventArgs e)
        {
            ResetPath();
        }
        //Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK) {
                e.Cancel = true;
            }
        }
        private string GetMD5(string input)
        {
            string str = "";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(input);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer =md5.ComputeHash(buffer);
            foreach(byte b in buffer)
            {
                str += b.ToString("x2");
            }
            return str;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txbUserName.Text;
            string password = txbPassWord.Text;
            if (user == "" || password == "")
            {
                MessageBox.Show("Bạn cần điền đẩy đủ thông tin !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (GetMD5(password) == dtBase.GetPasswordAdmin(user))
            {
                fAdmin f = new fAdmin();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else 
           
                if (GetMD5(password) == dtBase.GetPasswordUser(user))
                {
                    fUser f = new fUser();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản không chính xác !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }
        void ResetPath()
        {
            dtTable = dtBase.DataReader("Select * from BANGDIEM");
            foreach (DataRow row in dtTable.Rows)
            {
                string url = row[7].ToString();
                string[] str = url.Split('\\');
                string newPath = dtBase.GetPath() + str[str.Length - 1];
                string sql = "UPDATE BANGDIEM SET UrlFile = N'" + newPath + "' where Id=" + row[0].ToString();
                dtBase.DataChange(sql);
                DirectoryInfo directory = new DirectoryInfo(newPath);
                directory.Create();
            }
        }

    }
}
