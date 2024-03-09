﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Formmuontra : Form
    {

        public DateTime date1, date2;
        public TimeSpan time;
        public int day;
        public Formmuontra()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa(); public int dem;
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from phieumuon");
            //l.Text = dt.Rows.Count.ToString();
            loadcombo();
            if (dt != null)
            {
                list_phieumuon.DataSource = dt;
            }
            list_phieumuon.Columns[0].HeaderText = "Mã phiếu mượn";
            list_phieumuon.Columns[1].HeaderText = "Mã độc giả";
            list_phieumuon.Columns[2].HeaderText = "Mã nhân viên";
            list_phieumuon.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
            btn_xoa.Enabled = true;
            btn_sua.Text = "Sửa";
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            list_phieumuon.Enabled = true;

        }

        private void loadcombo()
        {
            DataTable dt = t.docdulieu("select * from docgia");
            DataTable dt1 = t.docdulieu("select * from nhanvien");
            DataTable dt2 = t.docdulieu("select * from phieumuon");
            DataTable dt3 = t.docdulieu("select * from sach");
            


            comdocgia.DataSource = dt;
            comdocgia.DisplayMember = "hoten";
            comdocgia.ValueMember = "madg";
          
            comnhanvien.DataSource = dt1;
            comnhanvien.DisplayMember = "hoten";
            comnhanvien.ValueMember = "manv";

            commaphieumuon.DataSource = dt2;
            commaphieumuon.DisplayMember = "maphieu";
            commaphieumuon.ValueMember = "maphieu";

            commasach.DataSource = dt3;
            commasach.DisplayMember = "masach";
            commasach.ValueMember = "masach";
            

        }
        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select * from chitietmuon");
            l.Text = dt.Rows.Count.ToString();
            //l.Text = dt.Rows.Count.ToString();
            //loadcombo();
            if (dt != null)
            {
                list_chitietmuon.DataSource = dt;
            }
            list_chitietmuon.Columns[0].HeaderText = "Mã phiếu mượn";
            list_chitietmuon.Columns[1].HeaderText = "Mã sách";
            list_chitietmuon.Columns[2].HeaderText = "Ngày mượn";
            list_chitietmuon.Columns[3].HeaderText = "Ngày trả";
            list_chitietmuon.Columns[4].HeaderText = "Ghi chú";
            

            xoa1.Enabled = true;
            sua1.Text = "Gia hạn";
            them1.Enabled = true;
            sua1.Enabled = true;
            xoa1.Enabled = true;
            luu1.Enabled = false;
            list_chitietmuon.Enabled = true;

        }
        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void Formmuontra_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();

        }

        private void tab2_Click(object sender, EventArgs e)
        {
            

        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmaphieu.Text = list_phieumuon.CurrentRow.Cells[0].Value.ToString();
            comdocgia.Text = list_phieumuon.CurrentRow.Cells[1].Value.ToString();
            comnhanvien.Text = list_phieumuon.CurrentRow.Cells[2].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {

            DataTable dt = t.docdulieu("select * from phieumuon");
        
           dem = dt.Rows.Count;
            dem = dem + 1;
            txtmaphieu.Text = dem.ToString();
            //l.Text = dt.Rows.Count.ToString();
            btn_luu.Enabled = true;
            //sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Text = "hủy";
            btn_them.Enabled = false;
            list_phieumuon.Enabled = false;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void luu_Click(object sender, EventArgs e)
        {


            if (t.thucthidulieu("INSERT INTO phieumuon VALUES (N'" + dem + "','" + comdocgia.SelectedValue.ToString() + "','" + comnhanvien.SelectedValue.ToString() + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm");



               

            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "hủy")
            {
                btn_luu.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_xoa.Text = "Xóa";
                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                loaddata();
                list_phieumuon.Enabled = true;
            }
            else
            {

                if (comdocgia.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã độc giả");

                }
                else if (comnhanvien.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
               


                }
                else if (t.thucthidulieu("update  phieumuon set madg=N'" + comdocgia.Text + "', manv=N'" + comnhanvien.Text +  "'where maphieu=N'" + txtmaphieu.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }


            
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (btn_xoa.Text == "hủy")
            {

                btn_luu.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_xoa.Text = "Xóa";
                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                loaddata();
                list_phieumuon.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txtmaphieu.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from phieumuon where maphieu='" + txtmaphieu.Text + "'");
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

        private void luoi1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luoi1_SelectionChanged(object sender, EventArgs e)
        {
            
            commaphieumuon.Text = list_chitietmuon.CurrentRow.Cells[0].Value.ToString();
            commasach.Text = list_chitietmuon.CurrentRow.Cells[1].Value.ToString();
            ngaymuon.Text = list_chitietmuon.CurrentRow.Cells[2].Value.ToString();
            ngaytra.Text = list_chitietmuon.CurrentRow.Cells[3].Value.ToString();
            ghichu.Text = list_chitietmuon.CurrentRow.Cells[4].Value.ToString();
        }

        private void them1_Click(object sender, EventArgs e)
        {
            ngaymuon.Text = "";
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(-3));//lay ngay hien tai tang them 3 ngay
            ngaytra.Value = result;

           
              luu1.Enabled = true;
       
            xoa1.Enabled = false;
            sua1.Text = "hủy";
            them1.Enabled = false;
            list_chitietmuon.Enabled = false;
        }

        private void luu1_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaymuon.Value.ToString("yyyy/MM/dd");//dịnh dạng ngày để insert vào sql
            string ngayhhh = ngaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(ngaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
            DataTable dt = t.docdulieu("select * from chitietmuon where masach= N'"+ commasach.Text+ "'");
            
            if (dt.Rows.Count==1)
            {
                MessageBox.Show("Sách đã được mượn, vui lòng chọn cuốn khác", "Thông báo");
                commasach.Focus();
            } 
            else if (day<0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                ngaytra.Focus();

            }
            else if (t.thucthidulieu("INSERT INTO chitietmuon VALUES (N'" + commaphieumuon.SelectedValue.ToString() + "','" + commasach.SelectedValue.ToString() + "','" + ngayhh + "','" + ngayhhh + "','" + ghichu.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata1();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thực hiện được");
  

            }
        }

        private void sua1_Click(object sender, EventArgs e)
        {
            string ngayhhh = ngaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(ngaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
            if (sua1.Text == "hủy")
            {
                luu1.Enabled = false;
                sua1.Enabled = true;
                xoa1.Enabled = true;
                xoa1.Text = "Xóa";
                sua1.Text = "Gia hạn";
                them1.Enabled = true;
                loaddata1();
                list_chitietmuon.Enabled = true;
            } else if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                ngaytra.Focus();

            }
            else if (t.thucthidulieu("update  chitietmuon set ngaytra=N'" + ngayhhh + "'where masach=N'" + commasach.Text + "'") == true)
                {

                    MessageBox.Show("Gia hạn thành công");
                    loaddata1();


                }
            else MessageBox.Show("Không thể gia hạn sách");


            
        }

        private void xoa1_Click(object sender, EventArgs e)
        {
            if (xoa1.Text == "hủy")
            {

                luu1.Enabled = false;
                sua1.Enabled = true;
                xoa1.Enabled = true;
                xoa1.Text = "Trả sách";
                sua1.Text = "Gia hạn";
                them1.Enabled = true;
                loaddata1();
                list_chitietmuon.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa trả sách có mã " + commasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from chitietmuon where masach='" + commasach.Text + "'");
                        MessageBox.Show("Đã trả sach"+ commasach.Text +"", "Thông báo");
                        loaddata1();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else loaddata1();





            }
        }
    }
}









