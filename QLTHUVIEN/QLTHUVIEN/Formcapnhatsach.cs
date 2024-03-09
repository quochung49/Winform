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
    public partial class Formcapnhatsach : Form
    {
        public Formcapnhatsach()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from sach");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách ";
            luoi.Columns[0].Width = 80;
            luoi.Columns[3].Width = 180;


            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Năm xuất bản";
            luoi.Columns[3].HeaderText = "Mã nhà xuất bản";
            luoi.Columns[4].HeaderText = "Mã thể loại";
            luoi.Columns[5].HeaderText = "Mã tác giả";
            //luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void loadcombo() {
            DataTable dt = t.docdulieu("select * from nhaxb");
            DataTable dt1 = t.docdulieu("select * from theloai");
            DataTable dt2 = t.docdulieu("select * from tacgia");

           
                comnhaxb.DataSource = dt;
                comnhaxb.DisplayMember = "tennxb";
                comnhaxb.ValueMember = "manxb";
                //comnhaxb.DisplayMember = "tennxb";
                //comnhaxb.ValueMember = "manxb";
                comtheloai.DataSource = dt1;
                comtheloai.DisplayMember = "tentheloai";
                comtheloai.ValueMember = "matheloai";
                commatacgia.DataSource = dt2;
                commatacgia.DisplayMember = "tentacgia";
                commatacgia.ValueMember = "matacgia";
        
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formcapnhatsach_Load(object sender, EventArgs e)
        {
            loaddata();

        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmasach.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttensach.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            txtnamxb.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            comnhaxb.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            comtheloai.Text = luoi.CurrentRow.Cells[4].Value.ToString();
            commatacgia.Text = luoi.CurrentRow.Cells[5].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txttensach.Text = "";
         
            luu.Enabled = true;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;
            loadcombo();

        }

        private void luu_Click(object sender, EventArgs e)
        {
           
            if (txtmasach.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sách");
                txtmasach.Focus();

            }
            else if (txttensach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sách");
                txttensach.Focus();


            }
            else if (txtnamxb.Text == "")
            {
                MessageBox.Show("Chưa nhập năm xuất bản");
                txtnamxb.Focus();


            }

            else if (t.thucthidulieu("INSERT INTO SACH VALUES (N'" + txtmasach.Text + "','" + txttensach.Text + "','" + txtnamxb.Text + "','" + comnhaxb.SelectedValue.ToString() + "','" + comtheloai.SelectedValue.ToString() + "','" + commatacgia.SelectedValue.ToString() + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        }

        private void txtnamxb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnamxb_Enter(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(txtnamxb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");

            }
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
                txtmasach.Enabled = false;


                if (txttensach.Text == "")
                {
                    txttensach.Focus();

                }
                else if (txtnamxb.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtnamxb.Focus();

                    // else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.Text + "', matheloai='" + comtheloai.SelectedValue.ToString() + "', matacgia='" + commatacgia.SelectedValue.ToString() + "'where masach=N'" + txtmasach.Text + "'") == true)
                }
                else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.Text + "', matheloai='" + comtheloai.Text + "', matacgia='" + commatacgia.Text + "'where masach=N'" + txtmasach.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                    txtmasach.Enabled = true;

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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa sách có mã số " + txtmasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from sach where masach='" + txtmasach.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
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

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from sach where masach like '%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from sach where tensach like '%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                luoi.DataSource = dt5;
            }
            else luoi.DataSource = dt6;
        }

        private void comtheloai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
