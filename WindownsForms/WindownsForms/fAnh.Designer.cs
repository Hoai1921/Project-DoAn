namespace WindownsForms
{
    partial class fAnh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAnh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvImage = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConverted = new System.Windows.Forms.Button();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvImage);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 580);
            this.panel1.TabIndex = 0;
            // 
            // lvImage
            // 
            this.lvImage.HideSelection = false;
            this.lvImage.Location = new System.Drawing.Point(3, 3);
            this.lvImage.Name = "lvImage";
            this.lvImage.Size = new System.Drawing.Size(394, 574);
            this.lvImage.TabIndex = 0;
            this.lvImage.UseCompatibleStateImageBehavior = false;
            this.lvImage.Click += new System.EventHandler(this.lvImage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConverted);
            this.panel2.Controls.Add(this.txtConverted);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 49);
            this.panel2.TabIndex = 1;
            // 
            // btnConverted
            // 
            this.btnConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverted.Image = ((System.Drawing.Image)(resources.GetObject("btnConverted.Image")));
            this.btnConverted.Location = new System.Drawing.Point(270, 3);
            this.btnConverted.Name = "btnConverted";
            this.btnConverted.Size = new System.Drawing.Size(127, 42);
            this.btnConverted.TabIndex = 1;
            this.btnConverted.Text = "Chuyển Đổi";
            this.btnConverted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConverted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConverted.UseVisualStyleBackColor = true;
            this.btnConverted.Click += new System.EventHandler(this.btnConverted_Click);
            // 
            // txtConverted
            // 
            this.txtConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConverted.Location = new System.Drawing.Point(3, 9);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(261, 30);
            this.txtConverted.TabIndex = 0;
            // 
            // fAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách File";
            this.Load += new System.EventHandler(this.fAnh_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConverted;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.ListView lvImage;
    }
}