using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        string user = "admin";
        string pass = "123";
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (taikhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                taikhoan.Focus();


            }
            else if (matkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                matkhau.Focus();
            }
            else if (user.Equals(taikhoan.Text) && pass.Equals(matkhau.Text))
            {

                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Form f = new Formchinh();
                f.Show();


            }
            else { MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai"); }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}


