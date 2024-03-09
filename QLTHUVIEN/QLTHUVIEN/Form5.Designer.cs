namespace WindowsFormsApplication1
{
    partial class Formnhaxb
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
            this.luu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.txttennhaxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmanhaxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // luu
            // 
            this.luu.Enabled = false;
            this.luu.Location = new System.Drawing.Point(549, 486);
            this.luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(100, 28);
            this.luu.TabIndex = 31;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(719, 486);
            this.thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(100, 28);
            this.thoat.TabIndex = 30;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(383, 486);
            this.xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(100, 28);
            this.xoa.TabIndex = 29;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(216, 486);
            this.sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(100, 28);
            this.sua.TabIndex = 28;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(49, 486);
            this.them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(100, 28);
            this.them.TabIndex = 27;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // txttennhaxb
            // 
            this.txttennhaxb.Location = new System.Drawing.Point(561, 103);
            this.txttennhaxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttennhaxb.Name = "txttennhaxb";
            this.txttennhaxb.Size = new System.Drawing.Size(192, 22);
            this.txttennhaxb.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(396, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên nhà XB";
            // 
            // txtmanhaxb
            // 
            this.txtmanhaxb.Location = new System.Drawing.Point(192, 103);
            this.txtmanhaxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanhaxb.Name = "txtmanhaxb";
            this.txtmanhaxb.Size = new System.Drawing.Size(123, 22);
            this.txtmanhaxb.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã nhà XB";
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(43, 220);
            this.luoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.luoi.Name = "luoi";
            this.luoi.RowHeadersWidth = 51;
            this.luoi.Size = new System.Drawing.Size(776, 214);
            this.luoi.TabIndex = 22;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(299, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "CẬP NHẬT NHÀ XUẤT BẢN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(44, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(192, 172);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(273, 22);
            this.txtdiachi.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(517, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(608, 172);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(145, 22);
            this.txtphone.TabIndex = 36;
            // 
            // Formnhaxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 529);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txttennhaxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmanhaxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.luoi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formnhaxb";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Formnhaxb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox txttennhaxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmanhaxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtphone;
    }
}