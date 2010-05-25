using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pbThongKe_MainTab_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.lblThongKe_MainTab.BackColor = Color.LightGreen;
        }

        private void ptbThongKe_MainTab_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.lblThongKe_MainTab.BackColor = Color.White;
        }

        private void ptbThongTinHopDen_MainTab_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            this.lblHopDen_MainTab.BackColor = Color.LightGreen;
        }

        private void ptbThongTinHopDen_MainTab_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            this.lblHopDen_MainTab.BackColor = Color.White;
        }

        private void ptbThongTinHopDen_MainTab_Click(object sender, EventArgs e)
        {
            tabMainTab.SelectedTab = tabHopDen;
        }

        private void xóaHộpĐenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaHopDenFrm frm = new XoaHopDenFrm();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void thêmThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabMainTab.SelectedTab = tabHopDen;
        }

        private void xóaĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaDaiLyFrm frm = new XoaDaiLyFrm();
            frm.Show();
        }

        private void tìmKiếmĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemDaiLyFrm frm = new TimKiemDaiLyFrm();
            frm.Show();
        }

        private void xeviPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeViPhamFrm frm = new ThongKeViPhamFrm();
            frm.Show();
        }

        private void thêmHộpĐenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemHopDenFrm frm = new ThemHopDenFrm();
            frm.Show();
        }

        private void cậpNhậtThôngTinHộpĐenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatHopDenFrm frm = new CapNhatHopDenFrm();
            frm.Show();
        }

        private void thêmĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemDaiLyFrm frm = new ThemDaiLyFrm();
            frm.Show();
        }

        private void cậpNhậtThôngTinĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatThongTinDaiLyFrm frm = new CapNhatThongTinDaiLyFrm();
            frm.Show();
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNhanVienFrm frm = new ThemNhanVienFrm();
            frm.Show();
        }

        private void cậpNhậtThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatThongTinNhanVienFrm frm = new CapNhatThongTinNhanVienFrm();
            frm.Show();
        }

        private void tabPhanCong_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NgayChay_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grb_DanhSachQuangDuong_Enter(object sender, EventArgs e)
        {

        }
    }
}
