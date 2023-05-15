namespace WindowsForms
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpHocChinh = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUrlChinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.gbLanHoc = new System.Windows.Forms.GroupBox();
            this.rbtnLan2 = new System.Windows.Forms.RadioButton();
            this.rbtnLan1 = new System.Windows.Forms.RadioButton();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHocLai = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbUrlLai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave_Lai = new System.Windows.Forms.Button();
            this.btnNew_Lai = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnHocKy = new System.Windows.Forms.Button();
            this.btnMonLai = new System.Windows.Forms.Button();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMonLai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDanhSach = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tcAdmin.SuspendLayout();
            this.tpHocChinh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbLanHoc.SuspendLayout();
            this.tbHocLai.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tbDanhSach.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpHocChinh);
            this.tcAdmin.Controls.Add(this.tbHocLai);
            this.tcAdmin.Controls.Add(this.tbDanhSach);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1061, 201);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpHocChinh
            // 
            this.tpHocChinh.Controls.Add(this.panel2);
            this.tpHocChinh.Controls.Add(this.panel1);
            this.tpHocChinh.Location = new System.Drawing.Point(4, 25);
            this.tpHocChinh.Name = "tpHocChinh";
            this.tpHocChinh.Padding = new System.Windows.Forms.Padding(3);
            this.tpHocChinh.Size = new System.Drawing.Size(1053, 172);
            this.tpHocChinh.TabIndex = 0;
            this.tpHocChinh.Text = "Học Kỳ Chính";
            this.tpHocChinh.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUrlChinh);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(6, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 46);
            this.panel2.TabIndex = 1;
            // 
            // txbUrlChinh
            // 
            this.txbUrlChinh.Enabled = false;
            this.txbUrlChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUrlChinh.Location = new System.Drawing.Point(105, 10);
            this.txbUrlChinh.Name = "txbUrlChinh";
            this.txbUrlChinh.Size = new System.Drawing.Size(669, 27);
            this.txbUrlChinh.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "URL:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(921, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::WindownsForms.Properties.Resources.thêm4;
            this.btnNew.Location = new System.Drawing.Point(813, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 40);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Tạo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLop);
            this.panel1.Controls.Add(this.btnKhoa);
            this.panel1.Controls.Add(this.btnMon);
            this.panel1.Controls.Add(this.gbLanHoc);
            this.panel1.Controls.Add(this.cbLop);
            this.panel1.Controls.Add(this.cbKhoa);
            this.panel1.Controls.Add(this.cbMon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 110);
            this.panel1.TabIndex = 0;
            // 
            // btnLop
            // 
            this.btnLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.Image = ((System.Drawing.Image)(resources.GetObject("btnLop.Image")));
            this.btnLop.Location = new System.Drawing.Point(994, 8);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(29, 28);
            this.btnLop.TabIndex = 9;
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoa.Image")));
            this.btnKhoa.Location = new System.Drawing.Point(472, 66);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(29, 28);
            this.btnKhoa.TabIndex = 8;
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnMon
            // 
            this.btnMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMon.Image = ((System.Drawing.Image)(resources.GetObject("btnMon.Image")));
            this.btnMon.Location = new System.Drawing.Point(472, 8);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(29, 28);
            this.btnMon.TabIndex = 7;
            this.btnMon.UseVisualStyleBackColor = true;
            this.btnMon.Click += new System.EventHandler(this.btnMon_Click);
            // 
            // gbLanHoc
            // 
            this.gbLanHoc.Controls.Add(this.rbtnLan2);
            this.gbLanHoc.Controls.Add(this.rbtnLan1);
            this.gbLanHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLanHoc.Location = new System.Drawing.Point(583, 47);
            this.gbLanHoc.Name = "gbLanHoc";
            this.gbLanHoc.Size = new System.Drawing.Size(405, 53);
            this.gbLanHoc.TabIndex = 6;
            this.gbLanHoc.TabStop = false;
            this.gbLanHoc.Text = "Lần Học";
            // 
            // rbtnLan2
            // 
            this.rbtnLan2.AutoSize = true;
            this.rbtnLan2.Location = new System.Drawing.Point(287, 23);
            this.rbtnLan2.Name = "rbtnLan2";
            this.rbtnLan2.Size = new System.Drawing.Size(72, 24);
            this.rbtnLan2.TabIndex = 1;
            this.rbtnLan2.TabStop = true;
            this.rbtnLan2.Text = "Lần 2";
            this.rbtnLan2.UseVisualStyleBackColor = true;
            // 
            // rbtnLan1
            // 
            this.rbtnLan1.AutoSize = true;
            this.rbtnLan1.Location = new System.Drawing.Point(119, 23);
            this.rbtnLan1.Name = "rbtnLan1";
            this.rbtnLan1.Size = new System.Drawing.Size(72, 24);
            this.rbtnLan1.TabIndex = 0;
            this.rbtnLan1.TabStop = true;
            this.rbtnLan1.Text = "Lần 1";
            this.rbtnLan1.UseVisualStyleBackColor = true;
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(627, 9);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(361, 28);
            this.cbLop.TabIndex = 5;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(105, 66);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(361, 28);
            this.cbKhoa.TabIndex = 4;
            // 
            // cbMon
            // 
            this.cbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(105, 8);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(361, 28);
            this.cbMon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(579, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn Học:";
            // 
            // tbHocLai
            // 
            this.tbHocLai.Controls.Add(this.panel5);
            this.tbHocLai.Controls.Add(this.panel6);
            this.tbHocLai.Location = new System.Drawing.Point(4, 25);
            this.tbHocLai.Name = "tbHocLai";
            this.tbHocLai.Padding = new System.Windows.Forms.Padding(3);
            this.tbHocLai.Size = new System.Drawing.Size(1053, 172);
            this.tbHocLai.TabIndex = 1;
            this.tbHocLai.Text = "Học Lại";
            this.tbHocLai.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbUrlLai);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.btnSave_Lai);
            this.panel5.Controls.Add(this.btnNew_Lai);
            this.panel5.Location = new System.Drawing.Point(5, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1042, 47);
            this.panel5.TabIndex = 4;
            // 
            // txbUrlLai
            // 
            this.txbUrlLai.Enabled = false;
            this.txbUrlLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUrlLai.Location = new System.Drawing.Point(108, 10);
            this.txbUrlLai.Name = "txbUrlLai";
            this.txbUrlLai.Size = new System.Drawing.Size(669, 27);
            this.txbUrlLai.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "URL:";
            // 
            // btnSave_Lai
            // 
            this.btnSave_Lai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Lai.Image = ((System.Drawing.Image)(resources.GetObject("btnSave_Lai.Image")));
            this.btnSave_Lai.Location = new System.Drawing.Point(923, 3);
            this.btnSave_Lai.Name = "btnSave_Lai";
            this.btnSave_Lai.Size = new System.Drawing.Size(102, 40);
            this.btnSave_Lai.TabIndex = 1;
            this.btnSave_Lai.Text = "Lưu";
            this.btnSave_Lai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave_Lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave_Lai.UseVisualStyleBackColor = true;
            this.btnSave_Lai.Click += new System.EventHandler(this.btnSave_Lai_Click);
            // 
            // btnNew_Lai
            // 
            this.btnNew_Lai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew_Lai.Image = ((System.Drawing.Image)(resources.GetObject("btnNew_Lai.Image")));
            this.btnNew_Lai.Location = new System.Drawing.Point(815, 3);
            this.btnNew_Lai.Name = "btnNew_Lai";
            this.btnNew_Lai.Size = new System.Drawing.Size(102, 40);
            this.btnNew_Lai.TabIndex = 0;
            this.btnNew_Lai.Text = "Tạo";
            this.btnNew_Lai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew_Lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew_Lai.UseVisualStyleBackColor = true;
            this.btnNew_Lai.Click += new System.EventHandler(this.btnNew_Lai_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnNam);
            this.panel6.Controls.Add(this.btnHocKy);
            this.panel6.Controls.Add(this.btnMonLai);
            this.panel6.Controls.Add(this.cbNam);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.cbHocKy);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.cbMonLai);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(5, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1042, 107);
            this.panel6.TabIndex = 3;
            // 
            // btnNam
            // 
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.Image = ((System.Drawing.Image)(resources.GetObject("btnNam.Image")));
            this.btnNam.Location = new System.Drawing.Point(996, 14);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(29, 28);
            this.btnNam.TabIndex = 10;
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnHocKy
            // 
            this.btnHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocKy.Image = ((System.Drawing.Image)(resources.GetObject("btnHocKy.Image")));
            this.btnHocKy.Location = new System.Drawing.Point(480, 62);
            this.btnHocKy.Name = "btnHocKy";
            this.btnHocKy.Size = new System.Drawing.Size(29, 28);
            this.btnHocKy.TabIndex = 9;
            this.btnHocKy.UseVisualStyleBackColor = true;
            this.btnHocKy.Click += new System.EventHandler(this.btnHocKy_Click);
            // 
            // btnMonLai
            // 
            this.btnMonLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonLai.Image = ((System.Drawing.Image)(resources.GetObject("btnMonLai.Image")));
            this.btnMonLai.Location = new System.Drawing.Point(480, 14);
            this.btnMonLai.Name = "btnMonLai";
            this.btnMonLai.Size = new System.Drawing.Size(29, 28);
            this.btnMonLai.TabIndex = 8;
            this.btnMonLai.UseVisualStyleBackColor = true;
            this.btnMonLai.Click += new System.EventHandler(this.btnMon_Click);
            // 
            // cbNam
            // 
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(629, 14);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(361, 28);
            this.cbNam.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Năm Học:";
            // 
            // cbHocKy
            // 
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(108, 63);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(361, 28);
            this.cbHocKy.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Học Kỳ:";
            // 
            // cbMonLai
            // 
            this.cbMonLai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonLai.FormattingEnabled = true;
            this.cbMonLai.Location = new System.Drawing.Point(108, 14);
            this.cbMonLai.Name = "cbMonLai";
            this.cbMonLai.Size = new System.Drawing.Size(361, 28);
            this.cbMonLai.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Môn Học:";
            // 
            // tbDanhSach
            // 
            this.tbDanhSach.Controls.Add(this.panel4);
            this.tbDanhSach.Controls.Add(this.panel3);
            this.tbDanhSach.Location = new System.Drawing.Point(4, 25);
            this.tbDanhSach.Name = "tbDanhSach";
            this.tbDanhSach.Padding = new System.Windows.Forms.Padding(3);
            this.tbDanhSach.Size = new System.Drawing.Size(1053, 172);
            this.tbDanhSach.TabIndex = 2;
            this.tbDanhSach.Text = "Danh sách Folder";
            this.tbDanhSach.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDanhSach);
            this.panel4.Location = new System.Drawing.Point(6, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1041, 108);
            this.panel4.TabIndex = 1;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, -3);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(1038, 105);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.DoubleClick += new System.EventHandler(this.dgvDanhSach_DoubleClick);
            this.dgvDanhSach.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvDanhSach_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 46);
            this.panel3.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(881, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(513, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(362, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 220);
            this.Controls.Add(this.tcAdmin);
            this.MaximizeBox = false;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bảng Điểm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAdmin_FormClosing);
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tpHocChinh.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbLanHoc.ResumeLayout(false);
            this.gbLanHoc.PerformLayout();
            this.tbHocLai.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tbDanhSach.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpHocChinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbLanHoc;
        private System.Windows.Forms.RadioButton rbtnLan2;
        private System.Windows.Forms.RadioButton rbtnLan1;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbHocLai;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave_Lai;
        private System.Windows.Forms.Button btnNew_Lai;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMonLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnHocKy;
        private System.Windows.Forms.Button btnMonLai;
        private System.Windows.Forms.TextBox txbUrlChinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbUrlLai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tbDanhSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnSearch;
    }
}