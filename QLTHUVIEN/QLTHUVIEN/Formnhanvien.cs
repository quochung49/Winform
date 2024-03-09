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
    public partial class Formnhanvien : Form
    {
        public Formnhanvien()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select manv,hoten,ngaysinh,gioitinh,diachi,dienthoai from nhanvien");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã nhân viên";
            luoi.Columns[1].HeaderText = "Họ và tên";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới tính";
            luoi.Columns[4].HeaderText = "Địa chỉ";
            luoi.Columns[5].HeaderText = "Điện thoại";
            
        
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void Formnhanvien_Load(object sender, EventArgs e)
        {
            loaddata();
            ///tongso.Text = luoi.CurrentRow.Cells[0].Value.ToString();

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmanhanvien.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttennhanvien.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = luoi.CurrentRow.Cells[4].Value.ToString();
            txtdienthoai.Text = luoi.CurrentRow.Cells[5].Value.ToString();

        }

        private void luu_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                txtmanhanvien.Focus();

            }
            else if (txttennhanvien.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                txttennhanvien.Focus();


            }
            else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtdiachi.Focus();


            }
            else if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Chưa nhập điện thoại");
                txtdienthoai.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO nhanvien(manv,hoten,ngaysinh,diachi,dienthoai,gioitinh) VALUES (N'" + txtmanhanvien.Text + "','" + txttennhanvien.Text + "','" + ngayhh + "','" + txtdiachi.Text + "','" + txtdienthoai.Text + "','" + comgioitinh.Text+ "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else
            {
                MessageBox.Show("Lỗi trùng khhóa");



            txtmanhanvien.Focus();

            }
        }

        private void sua_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {

        }

        private void xoa_Click_1(object sender, EventArgs e)
        {
            if (xoa.Text == "hủy")
            {

                luu.Enabled = false;
                sua.Enabled = true;
                xoa.Enabled = true;
                xoa.Text = "Xóa";
                sua.Text = "Sửa";
                them.Enabled = true;
                loaddata();
                luoi.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txtmanhanvien.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from nhanvien where manv='" + txtmanhanvien.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo");


                       
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else loaddata();





            }
        }

        private void sua_Click_1(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");
            
            if (sua.Text == "hủy")
            {
                luu.Enabled = false;
                sua.Enabled = true;
                xoa.Enabled = true;
                xoa.Text = "Xóa";
                sua.Text = "Sửa";
                them.Enabled = true;
                loaddata();
                luoi.Enabled = true;
            }
            else
            {

                if (txttennhanvien.Text == "")
                {
                    txttennhanvien.Focus();

                }
                else if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtdiachi.Focus();


                }
                else if (txtdienthoai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại");
                    txtdienthoai.Focus();

                    
                }
                else if (t.thucthidulieu("update  nhanvien set hoten=N'" + txttennhanvien.Text + "', ngaysinh=N'" + ngayhh + "', diachi=N'" + txtdiachi.Text + "', dienthoai='" + txtdienthoai.Text +  "'where manv=N'" + txtmanhanvien.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                  

                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }
    }
}
