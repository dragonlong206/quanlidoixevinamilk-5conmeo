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

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TiepNhanNhanVien frm = new frm_TiepNhanNhanVien();
            frm.Show();
        }

        private void cậpNhậtThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CapNhatThongTinNhanVien frm = new frm_CapNhatThongTinNhanVien();
            frm.Show();
        }

        private void cậpNhậtThôngTinXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatThongTinXeGUI frm = new CapNhatThongTinXeGUI();
            frm.Show();
        }

        private void xóaXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaXeGUI frm = new XoaXeGUI();
            frm.Show();
        }

        private void tiếpNhậnXeMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiepNhanXeGUI frm = new TiepNhanXeGUI();
            frm.Show();
        }

        private void quảnLýThôngTinhãngXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyHangXe frm = new frm_QuanLyHangXe();
            frm.Show();
        }

        private void thêmĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TiepNhanDiaDiem frm = new frm_TiepNhanDiaDiem();
            frm.Show();
        }

        private void cậpNhậtThôngTinĐịaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CapNhatDiaDiem frm = new frm_CapNhatDiaDiem();
            frm.Show();
        }

        private void xóaĐịaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_XoaDiaDiem frm = new frm_XoaDiaDiem();
            frm.Show();
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_XoaNhanVien frm = new frm_XoaNhanVien();
            frm.Show();
        }

        private void quảnLýLoạiĐịaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LoaiDiaDiem frm = new frm_LoaiDiaDiem();
            frm.Show();
        }
    }
}
