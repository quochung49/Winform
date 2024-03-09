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
    public partial class Formnhaxb : Form
    {
        public Formnhaxb()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from nhaxb");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã nhà XB";
            luoi.Columns[1].HeaderText = "Tên nhà XB";
            luoi.Columns[2].HeaderText = "Địa chỉ";
            luoi.Columns[3].HeaderText = "Điện thoại";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void Formnhaxb_Load(object sender, EventArgs e)
        {
            loaddata();

        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmanhaxb.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttennhaxb.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            txtphone.Text = luoi.CurrentRow.Cells[3].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmanhaxb.Text = "";
            txttennhaxb.Text = "";
            txtdiachi.Text = "";
            txtphone.Text = "";
            luu.Enabled = true;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (txtmanhaxb.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà xuất bản");
                txtmanhaxb.Focus();

            }else if (txttennhaxb.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhà xuất bản");
                txttennhaxb.Focus();


            }else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtdiachi.Focus();


            }
            else if (txtphone.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txtphone.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO nhaxb VALUES (N'" + txtmanhaxb.Text + "','" + txttennhaxb.Text + "','" + txtdiachi.Text + "','" + txtphone.Text +  "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        }

        private void sua_Click(object sender, EventArgs e)
        {
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


                if (txttennhaxb.Text == "")
                {
                    MessageBox.Show("Nhà xuất bản chưa có thông tin");
                    txttennhaxb.Focus();

                }
                else if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtdiachi.Focus();


                }
                else if (t.thucthidulieu("update  nhaxb set tennxb=N'" + txttennhaxb.Text + "', diachi=N'" + txtdiachi.Text + "', dienthoai='" + txtphone.Text + "'where manxb=N'" + txtmanhaxb.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtmanhaxb.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from nhaxb where manxb='" + txtmanhaxb.Text + "'")==true)
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
