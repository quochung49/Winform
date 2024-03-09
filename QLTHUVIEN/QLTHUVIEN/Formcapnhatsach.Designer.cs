namespace WindowsFormsApplication1
{
    partial class Formcapnhatsach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.ramasach = new System.Windows.Forms.RadioButton();
            this.ratensach = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.commatacgia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comtheloai = new System.Windows.Forms.ComboBox();
            this.comnhaxb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.ramasach);
            this.groupBox1.Controls.Add(this.ratensach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(16, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1097, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sách";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 54);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(263, 54);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(389, 30);
            this.txttimkiem.TabIndex = 2;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // ramasach
            // 
            this.ramasach.AutoSize = true;
            this.ramasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ramasach.Location = new System.Drawing.Point(80, 31);
            this.ramasach.Margin = new System.Windows.Forms.Padding(4);
            this.ramasach.Name = "ramasach";
            this.ramasach.Size = new System.Drawing.Size(123, 33);
            this.ramasach.TabIndex = 1;
            this.ramasach.TabStop = true;
            this.ramasach.Text = "Mã sách";
            this.ramasach.UseVisualStyleBackColor = true;
            // 
            // ratensach
            // 
            this.ratensach.AutoSize = true;
            this.ratensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ratensach.Location = new System.Drawing.Point(80, 75);
            this.ratensach.Margin = new System.Windows.Forms.Padding(4);
            this.ratensach.Name = "ratensach";
            this.ratensach.Size = new System.Drawing.Size(133, 33);
            this.ratensach.TabIndex = 0;
            this.ratensach.TabStop = true;
            this.ratensach.Text = "Tên sách";
            this.ratensach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.luu);
            this.groupBox2.Controls.Add(this.thoat);
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Controls.Add(this.sua);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Controls.Add(this.commatacgia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comtheloai);
            this.groupBox2.Controls.Add(this.comnhaxb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtnamxb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txttensach);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmasach);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(29, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1097, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật sách";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(775, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "Import ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // luu
            // 
            this.luu.Enabled = false;
            this.luu.Location = new System.Drawing.Point(613, 156);
            this.luu.Margin = new System.Windows.Forms.Padding(4);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(100, 38);
            this.luu.TabIndex = 36;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(912, 158);
            this.thoat.Margin = new System.Windows.Forms.Padding(4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(100, 38);
            this.thoat.TabIndex = 35;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(451, 156);
            this.xoa.Margin = new System.Windows.Forms.Padding(4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(100, 38);
            this.xoa.TabIndex = 34;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(279, 156);
            this.sua.Margin = new System.Windows.Forms.Padding(4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(100, 36);
            this.sua.TabIndex = 33;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(135, 156);
            this.them.Margin = new System.Windows.Forms.Padding(4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(97, 36);
            this.them.TabIndex = 32;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // commatacgia
            // 
            this.commatacgia.FormattingEnabled = true;
            this.commatacgia.Location = new System.Drawing.Point(868, 108);
            this.commatacgia.Margin = new System.Windows.Forms.Padding(4);
            this.commatacgia.Name = "commatacgia";
            this.commatacgia.Size = new System.Drawing.Size(176, 33);
            this.commatacgia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(725, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã tác giả";
            // 
            // comtheloai
            // 
            this.comtheloai.FormattingEnabled = true;
            this.comtheloai.Location = new System.Drawing.Point(868, 46);
            this.comtheloai.Margin = new System.Windows.Forms.Padding(4);
            this.comtheloai.Name = "comtheloai";
            this.comtheloai.Size = new System.Drawing.Size(176, 33);
            this.comtheloai.TabIndex = 9;
            this.comtheloai.SelectedIndexChanged += new System.EventHandler(this.comtheloai_SelectedIndexChanged);
            // 
            // comnhaxb
            // 
            this.comnhaxb.FormattingEnabled = true;
            this.comnhaxb.Location = new System.Drawing.Point(519, 102);
            this.comnhaxb.Margin = new System.Windows.Forms.Padding(4);
            this.comnhaxb.Name = "comnhaxb";
            this.comnhaxb.Size = new System.Drawing.Size(160, 33);
            this.comnhaxb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(355, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhà XB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(725, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã thể loại";
            // 
            // txtnamxb
            // 
            this.txtnamxb.Location = new System.Drawing.Point(519, 46);
            this.txtnamxb.Margin = new System.Windows.Forms.Padding(4);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(160, 30);
            this.txtnamxb.TabIndex = 5;
            this.txtnamxb.TextChanged += new System.EventHandler(this.txtnamxb_TextChanged);
            this.txtnamxb.Enter += new System.EventHandler(this.txtnamxb_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(341, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm xuất bản";
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(147, 101);
            this.txttensach.Margin = new System.Windows.Forms.Padding(4);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(163, 30);
            this.txttensach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(147, 44);
            this.txtmasach.Margin = new System.Windows.Forms.Padding(4);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(163, 30);
            this.txtmasach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(29, 393);
            this.luoi.Margin = new System.Windows.Forms.Padding(4);
            this.luoi.Name = "luoi";
            this.luoi.RowHeadersWidth = 51;
            this.luoi.Size = new System.Drawing.Size(1044, 214);
            this.luoi.TabIndex = 23;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // Formcapnhatsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 668);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formcapnhatsach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.Formcapnhatsach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ratensach;
        private System.Windows.Forms.RadioButton ramasach;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comnhaxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnamxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comtheloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox commatacgia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}