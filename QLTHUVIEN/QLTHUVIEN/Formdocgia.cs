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
    public partial class Formdocgia : Form
    {
        public Formdocgia()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void Formdocgia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from docgia");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã độc giả";
            luoi.Columns[1].HeaderText = "Họ và tên";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới tính";
            luoi.Columns[4].HeaderText = "Lớp";
            


            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmadocgia.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttendocgia.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            txtlop.Text = luoi.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmadocgia.Text = "";
            txttendocgia.Text = "";
           
            luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");
            if (txtmadocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã độc giả");
                txtmadocgia.Focus();

            }
            else if (txttendocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên độc giả");
                txttendocgia.Focus();


            }
            else if (txtlop.Text == "")
            {
                MessageBox.Show("Chưa nhập lớp");
                txtlop.Focus();


            }

            else if (t.thucthidulieu("INSERT INTO docgia VALUES (N'" + txtmadocgia.Text + "','" + txttendocgia.Text + "','" + ngayhh + "','" + comgioitinh.Text + "','" + txtlop.Text +"')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else
            {
                MessageBox.Show("Lỗi trùng khhóa");



                txtmadocgia.Focus();

            }
        }

        private void sua_Click(object sender, EventArgs e)
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

                if (txttendocgia.Text == "")
                {
                    txttendocgia.Focus();

                }
                else if (txtlop.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtlop.Focus();


                }
                else if (t.thucthidulieu("update  docgia set hoten=N'" + txttendocgia.Text + "', ngaysinh=N'" + ngayhh + "', gioitinh=N'" + comgioitinh.Text + "', thongtin='" + txtlop.Text + "'where madocgia=N'" + txtmadocgia.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void xoa_Click(object sender, EventArgs e)
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa độc giả có mã số " + txtmadocgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from docgia where madocgia='" + txtmadocgia.Text + "'") == true)
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
    }
}
