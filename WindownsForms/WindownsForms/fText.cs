using IronOcr;
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
using Tesseract;
using WindowsForms.Classes;

namespace WindownsForms
{
    public partial class fText : Form
    {
        Function dtBase = new Function();
        private string _id;
        string text = "";
        public fText()
        {
            InitializeComponent();
        }
        public fText(string id) : this()
        {
            _id = id;
        }
        void LoadText()
        {
            text = new IronTesseract().Read(_id).Text;
            rtbText.Text = text;
        }

        private void fText_Load(object sender, EventArgs e)
        {
            LoadText();
        }
    }
}
