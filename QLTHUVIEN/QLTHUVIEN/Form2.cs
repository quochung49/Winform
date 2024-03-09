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
    public partial class Formchinh : Form
    {
        public Formchinh()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Form m = new Formchinh();
            //m.Hide();
            Form f = new dangnhap();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new theloaisach();
            f.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formtacgia();
            f.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form f = new Formnhaxb();
            f.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formcapnhatsach();
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formnhanvien();
            f.Show();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formdocgia();
            f.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formmuontra();
            f.Show();
        }


        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formthongkesach();
            f.Show();
        }

        private void Formchinh_Load(object sender, EventArgs e)
        {

        }
    }
}
