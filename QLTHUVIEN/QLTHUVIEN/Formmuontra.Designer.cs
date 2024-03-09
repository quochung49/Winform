namespace WindowsFormsApplication1
{
    partial class Formmuontra
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.list_phieumuon = new System.Windows.Forms.DataGridView();
            this.comnhanvien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comdocgia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.luu1 = new System.Windows.Forms.Button();
            this.xoa1 = new System.Windows.Forms.Button();
            this.sua1 = new System.Windows.Forms.Button();
            this.them1 = new System.Windows.Forms.Button();
            this.list_chitietmuon = new System.Windows.Forms.DataGridView();
            this.ghichu = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.commasach = new System.Windows.Forms.ComboBox();
            this.commaphieumuon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_phieumuon)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_chitietmuon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(32, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 622);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btn_luu);
            this.tab1.Controls.Add(this.btn_thoat);
            this.tab1.Controls.Add(this.btn_xoa);
            this.tab1.Controls.Add(this.btn_sua);
            this.tab1.Controls.Add(this.btn_them);
            this.tab1.Controls.Add(this.list_phieumuon);
            this.tab1.Controls.Add(this.comnhanvien);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.comdocgia);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.txtmaphieu);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Margin = new System.Windows.Forms.Padding(4);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(4);
            this.tab1.Size = new System.Drawing.Size(928, 593);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Lập phiếu mượn";
            this.tab1.UseVisualStyleBackColor = true;
            this.tab1.Click += new System.EventHandler(this.tab1_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Location = new System.Drawing.Point(648, 60);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(100, 38);
            this.btn_luu.TabIndex = 46;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(648, 127);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 38);
            this.btn_thoat.TabIndex = 45;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(504, 197);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 38);
            this.btn_xoa.TabIndex = 44;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(501, 124);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 36);
            this.btn_sua.TabIndex = 43;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(504, 57);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 36);
            this.btn_them.TabIndex = 42;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.them_Click);
            // 
            // list_phieumuon
            // 
            this.list_phieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_phieumuon.Location = new System.Drawing.Point(55, 264);
            this.list_phieumuon.Margin = new System.Windows.Forms.Padding(4);
            this.list_phieumuon.Name = "list_phieumuon";
            this.list_phieumuon.RowHeadersWidth = 51;
            this.list_phieumuon.Size = new System.Drawing.Size(634, 210);
            this.list_phieumuon.TabIndex = 26;
            this.list_phieumuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.list_phieumuon.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // comnhanvien
            // 
            this.comnhanvien.FormattingEnabled = true;
            this.comnhanvien.Location = new System.Drawing.Point(280, 209);
            this.comnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.comnhanvien.Name = "comnhanvien";
            this.comnhanvien.Size = new System.Drawing.Size(160, 24);
            this.comnhanvien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(41, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Người lập phiếu";
            // 
            // comdocgia
            // 
            this.comdocgia.FormattingEnabled = true;
            this.comdocgia.Location = new System.Drawing.Point(280, 139);
            this.comdocgia.Margin = new System.Windows.Forms.Padding(4);
            this.comdocgia.Name = "comdocgia";
            this.comdocgia.Size = new System.Drawing.Size(160, 24);
            this.comdocgia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(41, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã độc giả";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Location = new System.Drawing.Point(280, 75);
            this.txtmaphieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(160, 22);
            this.txtmaphieu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(41, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(275, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TẠO PHIẾU MƯỢN";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.label12);
            this.tab2.Controls.Add(this.l);
            this.tab2.Controls.Add(this.luu1);
            this.tab2.Controls.Add(this.xoa1);
            this.tab2.Controls.Add(this.sua1);
            this.tab2.Controls.Add(this.them1);
            this.tab2.Controls.Add(this.list_chitietmuon);
            this.tab2.Controls.Add(this.ghichu);
            this.tab2.Controls.Add(this.label11);
            this.tab2.Controls.Add(this.ngaytra);
            this.tab2.Controls.Add(this.label6);
            this.tab2.Controls.Add(this.ngaymuon);
            this.tab2.Controls.Add(this.commasach);
            this.tab2.Controls.Add(this.commaphieumuon);
            this.tab2.Controls.Add(this.label8);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.label10);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Margin = new System.Windows.Forms.Padding(4);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(4);
            this.tab2.Size = new System.Drawing.Size(928, 593);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Chi tiết mượn-trả";
            this.tab2.UseVisualStyleBackColor = true;
            this.tab2.Click += new System.EventHandler(this.tab2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 382);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tổng số quyển sách độc giả đang mượn";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.ForeColor = System.Drawing.Color.Red;
            this.l.Location = new System.Drawing.Point(380, 382);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(55, 16);
            this.l.TabIndex = 23;
            this.l.Text = "soluong";
            // 
            // luu1
            // 
            this.luu1.Location = new System.Drawing.Point(616, 304);
            this.luu1.Margin = new System.Windows.Forms.Padding(4);
            this.luu1.Name = "luu1";
            this.luu1.Size = new System.Drawing.Size(100, 39);
            this.luu1.TabIndex = 22;
            this.luu1.Text = "Lưu";
            this.luu1.UseVisualStyleBackColor = true;
            this.luu1.Click += new System.EventHandler(this.luu1_Click);
            // 
            // xoa1
            // 
            this.xoa1.Location = new System.Drawing.Point(471, 304);
            this.xoa1.Margin = new System.Windows.Forms.Padding(4);
            this.xoa1.Name = "xoa1";
            this.xoa1.Size = new System.Drawing.Size(100, 39);
            this.xoa1.TabIndex = 21;
            this.xoa1.Text = "Trả sách";
            this.xoa1.UseVisualStyleBackColor = true;
            this.xoa1.Click += new System.EventHandler(this.xoa1_Click);
            // 
            // sua1
            // 
            this.sua1.Location = new System.Drawing.Point(323, 304);
            this.sua1.Margin = new System.Windows.Forms.Padding(4);
            this.sua1.Name = "sua1";
            this.sua1.Size = new System.Drawing.Size(100, 39);
            this.sua1.TabIndex = 20;
            this.sua1.Text = "Gia hạn";
            this.sua1.UseVisualStyleBackColor = true;
            this.sua1.Click += new System.EventHandler(this.sua1_Click);
            // 
            // them1
            // 
            this.them1.Location = new System.Drawing.Point(161, 304);
            this.them1.Margin = new System.Windows.Forms.Padding(4);
            this.them1.Name = "them1";
            this.them1.Size = new System.Drawing.Size(100, 39);
            this.them1.TabIndex = 19;
            this.them1.Text = "Thêm ";
            this.them1.UseVisualStyleBackColor = true;
            this.them1.Click += new System.EventHandler(this.them1_Click);
            // 
            // list_chitietmuon
            // 
            this.list_chitietmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_chitietmuon.Location = new System.Drawing.Point(109, 405);
            this.list_chitietmuon.Margin = new System.Windows.Forms.Padding(4);
            this.list_chitietmuon.Name = "list_chitietmuon";
            this.list_chitietmuon.RowHeadersWidth = 51;
            this.list_chitietmuon.Size = new System.Drawing.Size(737, 185);
            this.list_chitietmuon.TabIndex = 18;
            this.list_chitietmuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi1_CellContentClick);
            this.list_chitietmuon.SelectionChanged += new System.EventHandler(this.luoi1_SelectionChanged);
            // 
            // ghichu
            // 
            this.ghichu.Location = new System.Drawing.Point(223, 225);
            this.ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.ghichu.Name = "ghichu";
            this.ghichu.Size = new System.Drawing.Size(548, 57);
            this.ghichu.TabIndex = 17;
            this.ghichu.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(8, 225);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tình trạng sách";
            // 
            // ngaytra
            // 
            this.ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaytra.Location = new System.Drawing.Point(601, 172);
            this.ngaytra.Margin = new System.Windows.Forms.Padding(4);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(160, 22);
            this.ngaytra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(424, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày hẹn trả";
            // 
            // ngaymuon
            // 
            this.ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaymuon.Location = new System.Drawing.Point(219, 170);
            this.ngaymuon.Margin = new System.Windows.Forms.Padding(4);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(160, 22);
            this.ngaymuon.TabIndex = 13;
            this.ngaymuon.Value = new System.DateTime(2020, 8, 11, 23, 36, 38, 0);
            // 
            // commasach
            // 
            this.commasach.FormattingEnabled = true;
            this.commasach.Location = new System.Drawing.Point(601, 106);
            this.commasach.Margin = new System.Windows.Forms.Padding(4);
            this.commasach.Name = "commasach";
            this.commasach.Size = new System.Drawing.Size(160, 24);
            this.commasach.TabIndex = 12;
            // 
            // commaphieumuon
            // 
            this.commaphieumuon.FormattingEnabled = true;
            this.commaphieumuon.Location = new System.Drawing.Point(220, 108);
            this.commaphieumuon.Margin = new System.Windows.Forms.Padding(4);
            this.commaphieumuon.Name = "commaphieumuon";
            this.commaphieumuon.Size = new System.Drawing.Size(160, 24);
            this.commaphieumuon.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(8, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày mượn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(424, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mã sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(4, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã phiếu mượn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(364, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chi tiết mượn - trả  sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(407, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lí Mượn Trả Sách";
            // 
            // Formmuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 698);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formmuontra";
            this.Text = "Mượn trả sách";
            this.Load += new System.EventHandler(this.Formmuontra_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_phieumuon)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_chitietmuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comnhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comdocgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.DataGridView list_phieumuon;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox commasach;
        private System.Windows.Forms.ComboBox commaphieumuon;
        private System.Windows.Forms.DateTimePicker ngaytra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ngaymuon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox ghichu;
        private System.Windows.Forms.Button them1;
        private System.Windows.Forms.DataGridView list_chitietmuon;
        private System.Windows.Forms.Button sua1;
        private System.Windows.Forms.Button xoa1;
        private System.Windows.Forms.Button luu1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label12;
    }
}