using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms;

namespace WindownsForms
{
    public partial class fPDF : Form
    {
        private string _id;
        public fPDF()
        {
            InitializeComponent();
        }
        public fPDF(string id) : this()
        {
            _id = id;
        }
        void LoadFile()
        {
            axAcroPDF.src = _id;
        }
        private void fPDF_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

    }
}
