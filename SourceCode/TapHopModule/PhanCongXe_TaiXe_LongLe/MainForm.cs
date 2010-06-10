using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

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
            LoaiDiaDiemGUI frm = new LoaiDiaDiemGUI();
            frm.Show();
        }

        private void quảnLýtrọngTảiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTrongTaiGUI frm = new QuanLyTrongTaiGUI();
            frm.Show();
        }

        private void quảnLýLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLoaiHangGUI frm = new QuanLyLoaiHangGUI();
            frm.Show();
        }

        private void nhậpMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThemMatHang frm = new frm_ThemMatHang();
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

        private void ShowMaster_TabPhanCong()
        {
            int nSoDong = this.dtgv_DanhSachPhanCong.Rows.Count;
            for (int i = 0; i < nSoDong; i++)
            {
                this.dtgv_DanhSachPhanCong.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void tabPhanCong_Enter(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách nhân viên phân công và tài xế
                List<NhanVienDTO> lstDanhSachNhanVien = NhanVienBUS.LayDanhSachNhanVien();
                if (lstDanhSachNhanVien.Count > 0)
                {
                    this.cbo_NhanVienPhanCong.DataSource = lstDanhSachNhanVien;
                    this.cbo_NhanVienPhanCong.ValueMember = "MaNhanVien";
                    this.cbo_NhanVienPhanCong.DisplayMember = "TenNhanVien";

                    DataGridViewComboBoxColumn clmTaiXe = (DataGridViewComboBoxColumn)this.dtgv_DanhSachPhanCong.Columns["TaiXe_PhanCong"];
                    clmTaiXe.DataSource = lstDanhSachNhanVien;
                    clmTaiXe.ValueMember = "MaNhanVien";
                    clmTaiXe.DisplayMember = "TenNhanVien";
                }

                // Lấy danh sách xe
                DataTable tblDanhSachXe = XeBUS.LayDanhSachXeCoThePhanCong();
                if (tblDanhSachXe.Rows.Count > 0)
                {
                    DataGridViewComboBoxColumn clmXe = (DataGridViewComboBoxColumn)this.dtgv_DanhSachPhanCong.Columns["Xe_PhanCong"];
                    clmXe.DataSource = tblDanhSachXe;
                    clmXe.DisplayMember = "BienSo";
                    clmXe.ValueMember = "BienSo";
                }

                ShowMaster_TabPhanCong();
                this.btn_Luu_PhanCong.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_DanhSachPhanCong_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ShowMaster_TabPhanCong();
        }

        private void btn_Thoat_PhanCong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_DanhSachPhanCong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.btn_Luu_PhanCong.Enabled == false)
            {
                this.btn_Luu_PhanCong.Enabled = true;
            }
        }

        private void btn_Luu_PhanCong_Click(object sender, EventArgs e)
        {

        }
    }
}
