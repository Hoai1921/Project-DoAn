using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Classes;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindownsForms
{
    public partial class fAnh : Form
    {
        Function dtBase = new Function();
        private string _id;
        ListViewItem lstviewItem;
        string[] listFile;
        string url = "";
        public fAnh()
        {
            InitializeComponent();
        }
        public fAnh(string id) : this()
        {
            _id = id;
        }
        void LoadAnh()
        {

            string path = dtBase.GetFieldValues("UrlFile", Int32.Parse(_id), "BANGDIEM");
            url = path;
            listFile = Directory.GetFiles(@path);
            foreach (string file in listFile)
            {
                string[] pathFile = file.Split('\\');
                lstviewItem = new ListViewItem(pathFile[pathFile.Length - 1]);
                lvImage.Items.Add(lstviewItem);
            }

        }

        private void fAnh_Load(object sender, EventArgs e)
        {
            lvImage.View = View.Details;
            lvImage.Columns.Add("File");
            lvImage.Columns[0].Width = 300;
            LoadAnh();
        }

        private void btnConverted_Click(object sender, EventArgs e)
        {
            if (listFile != null)
            {
                int i = 0;
                foreach (string file in listFile)
                {
                    i++;
                    string file_path, file_name, file_extension;
                    file_path = Path.GetDirectoryName(file); //lấy thư mục của file từ đường dẫn file
                    file_name = Path.GetFileNameWithoutExtension(file); //lấy tên file không bao gồm phần đuôi kiểu file
                    file_extension = Path.GetExtension(file); //lấy phần đuôi của file vd: .pdf,.png
                    System.IO.File.Move(file, file_path + "\\" + txtConverted.Text.Trim() + "_" + i + file_extension); //đổi tên file đó thành tên file mới đã 

                }
                lvImage.Items.Clear();
                LoadAnh();
            }
        }

        private void lvImage_Click(object sender, EventArgs e)
        {
            fPDF f = new fPDF(url + "\\" + lvImage.SelectedItems[0].Text);

            f.ShowDialog();
            this.Hide();
            this.Show();
        }
    }
}
