using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms.Classes
{
    public class Function
    {
        string strConnect = "Data Source=.\\sqlexpress;Initial Catalog=Db_BangDiem;Integrated Security=True";
        SqlConnection sqlConnect = null;
        //Phương thức mở kết nối 
        void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Phương thức đóng kết nối 
        void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        //Phương thức thực thi câu lệnh Select trả về một DataTable 
        public DataTable DataReader(string sqlSelct)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelct, sqlConnect);
            sqlData.Fill(tblData);
            CloseConnect();
            return tblData;
        }
        //Phương thức thực hiện câu lệnh dạng insert,update,delete 
        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand sqlcomma = new SqlCommand();
            sqlcomma.Connection = sqlConnect;
            sqlcomma.CommandText = sql;
            sqlcomma.ExecuteNonQuery();
            CloseConnect();

        }

        public bool CheckKey(string sql)
        {
            OpenConnect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlConnect);
            DataTable table = new DataTable();
            dap.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else return false;

        }
        public bool CheckURL(string cot1, string cot2, string cot3, string cot4, int id1,int id2, int id3, int id4)
        {
            OpenConnect();
            string sql = "Select * from BANGDIEM where "+cot1+"="+id1 + " and " + cot2 + "=" + id2 + " and " + cot3 + "=" + id3 + " and " + cot4 + "=" + id4;
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlConnect); 
            DataTable table = new DataTable();
            dap.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            OpenConnect();
            SqlCommand sqlcomma = new SqlCommand();
            sqlcomma.Connection = sqlConnect;

            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlConnect);
            DataTable table = new DataTable();

            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }

        public string SinhMaTuDong(string TenBang, string TruongMa)
        {
            OpenConnect();
            string ma = "";
            string sql = "SELECT * FROM  " + TenBang + "  WHERE " + TruongMa + " = (SELECT MAX(" + TruongMa + " ) FROM " + TenBang + ")";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, sqlConnect);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    ma = reader.GetValue(0).ToString();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnect();
            int n = int.Parse(ma);
            n++;
            string m = n.ToString();
            return m;
        }
        public string GetPasswordAdmin(string username)
        {
            OpenConnect();
            string password = "";
            string query = "Select MatKhau from TAIKHOAN where TenTK = '" + username + "' and Quyen = 1";
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnect);
                SqlDataReader reader =cmd.ExecuteReader();
                while (reader.Read())
                    password = reader.GetValue(0).ToString();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnect();
            return password;
        }
        public string GetPasswordUser(string username)
        {
            OpenConnect();
            string password = "";
            string query = "Select MatKhau from TAIKHOAN where TenTK = '" + username + "' and Quyen = 0";
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    password = reader.GetValue(0).ToString();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnect();
            return password;
        }
        public string GetUrl(string cot1, string cot2, string cot3, string cot4, int id1, int id2, int id3, int id4)
        {
            OpenConnect();
            string url = "";
            string query = "Select UrlFile from BANGDIEM where " + cot1 + "=" + id1 + " and " + cot2 + "=" + id2 + " and " + cot3 + "=" + id3 + " and " + cot4 + "=" + id4;
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnect);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    url = reader.GetValue(0).ToString();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnect();
            return url;
        }
        public string GetFieldValues(string ten, int id, string bang)
        {
            OpenConnect();
            string ma = "";
            string query = "Select " + ten + " from " + bang + " where Id = " + id;
            try
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnect);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    ma = reader.GetValue(0).ToString();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            CloseConnect();
            return ma;
        }

        public string GetPath()
        {
            string path = "";
            string url = Application.StartupPath.ToString();
            string result = Path.GetDirectoryName(url);
            string result1 = Path.GetDirectoryName(result);
            string result2 = Path.GetDirectoryName(result1);
            string result3 = Path.GetDirectoryName(result2);
            path = result3 + "\\Danh sách lưu trữ\\";
            return path;
        }


    }
}
