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
    public partial class Formthongkesach : Form
    {
        public Formthongkesach()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select sach.masach, sach.tensach, nhaxb.tennxb,sach.namxb,theloai.tentheloai from sach, nhaxb, theloai where (sach.manxb=nhaxb.manxb and sach.matheloai=theloai.matheloai)");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
           luoi.Columns[4].HeaderText = "Thể loại";
          //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select sach.masach,sach.tensach, nhaxb.tennxb,sach.namxb,theloai.tentheloai from sach, nhaxb,chitietmuon, theloai where (sach.manxb=nhaxb.manxb and sach.matheloai=theloai.matheloai and sach.masach=chitietmuon.masach)");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
            luoi.Columns[4].HeaderText = "Thể loại";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select sach.masach,sach.tensach, nhaxb.tennxb,sach.namxb,theloai.tentheloai from sach, nhaxb,chitietmuon, theloai where (sach.manxb=nhaxb.manxb and sach.matheloai=theloai.matheloai and sach.masach=chitietmuon.masach and chitietmuon.ngaytra<GETDATE())");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
            luoi.Columns[4].HeaderText = "Thể loại";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void Formthongkesach_Load(object sender, EventArgs e)
        {
            tuychon.Text = "Tất cả sách";

            loaddata();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tuychon.Text == "Tất cả sách")
                loaddata();
            else if (tuychon.Text == "Sách đang mượn")
                loaddata1();
            else loaddata2();


            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            
            DataTable dt = (DataTable)luoi.DataSource;
            excel.Export(dt, "Sách", "Thống kê sách");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }
    }
}
