﻿using System;
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
            TiepNhanNhanVienGUI frm = new TiepNhanNhanVienGUI();
            frm.Show();
        }

        private void cậpNhậtThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatThongTinNhanVienGUI frm = new CapNhatThongTinNhanVienGUI();
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
            QuanLyHangXeGUI frm = new QuanLyHangXeGUI();
            frm.Show();
        }

        private void thêmĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiepNhanDiaDiemGUI frm = new TiepNhanDiaDiemGUI();
            frm.Show();
        }

        private void cậpNhậtThôngTinĐịaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CapNhatDiaDiem frm = new frm_CapNhatDiaDiem();
            frm.Show();
        }

        private void xóaĐịaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaDiaDiemGUI frm = new XoaDiaDiemGUI();
            frm.Show();
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaNhanVienGUI frm = new XoaNhanVienGUI();
            frm.Show();
        }

        private void quảnLýLoạiĐịaĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LoaiDiaDiem frm = new frm_LoaiDiaDiem();
            frm.Show();
        }

        private void quảnLýtrọngTảiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyTrongTai frm = new frm_QuanLyTrongTai();
            frm.Show();
        }

        private void quảnLýLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LoaiHang frm = new frm_LoaiHang();
            frm.Show();
        }

        private void nhậpMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapMatHangFrm frm = new NhapMatHangFrm();
            
            frm.Show();
        }

        private void chỉnhSửaThôngTinMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CapNhatMatHang frm = new frm_CapNhatMatHang();
            frm.Show();
        }

        private void xóaMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_XoaMatHang frm = new frm_XoaMatHang();
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
