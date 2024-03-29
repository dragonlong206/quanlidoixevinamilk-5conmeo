﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.OleDb;
using System.Configuration;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //this.dtgv_DanhSachPhanCong.Columns["ThoiGianBatDau_PhanCong"].DefaultCellStyle.
        }

        private void pbThongKe_MainTab_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapNhanVienGUI frm = new NhapNhanVienGUI();
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
            CapNhatDiaDiemGUI frm = new CapNhatDiaDiemGUI();
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
            NhapMatHangGUI frm = new NhapMatHangGUI();
            frm.Show();
        }

        private void chỉnhSửaThôngTinMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatMatHangGUI frm = new CapNhatMatHangGUI();
            frm.Show();
        }

        private void xóaMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaMatHangGUI frm = new XoaMatHangGUI();
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
                DataTable DanhSachQuanLy = PhanCongXeTaiXeBUS.LayDanhSachNhanVienPhanCong();
                this.cbo_NhanVienPhanCong.DataSource = DanhSachQuanLy;
                this.cbo_NhanVienPhanCong.ValueMember = "MaNhanVien";
                this.cbo_NhanVienPhanCong.DisplayMember = "TenNhanVien";

                DataTable DanhSachTaiXe = PhanCongXeTaiXeBUS.LayDanhSachTaiXeCoThePhanCong();
                DataGridViewComboBoxColumn clmTaiXe = (DataGridViewComboBoxColumn)this.dtgv_DanhSachPhanCong.Columns["TaiXe_PhanCong"];
                clmTaiXe.DataSource = DanhSachTaiXe;
                clmTaiXe.ValueMember = "MaNhanVien";
                clmTaiXe.DisplayMember = "TenNhanVien";

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

        private void dtgv_DanhSachPhanCong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.btn_Luu_PhanCong.Enabled == false)
            {
                this.btn_Luu_PhanCong.Enabled = true;
            }
        }

        private void btn_Luu_PhanCong_Click(object sender, EventArgs e)
        {            
            try
            {
                // Kiểm tra phân công cho ngày này đã tồn tại hay chưa
                DateTime temp = this.dtp_NgayPhanCong.Value;
                TimeSpan ts = temp.TimeOfDay;   // Lấy giờ hiện tại
                DateTime NgayPhanCong = temp.Subtract(ts);  // Cho giờ = 00:00:00 để đảm bảo so sánh đúng
                bool blnLuuThanhCong = false;

                int iMaNhanVien = int.Parse(this.cbo_NhanVienPhanCong.SelectedValue.ToString());
                PhanCongXeTaiXeDTO aPhanCong =
                    PhanCongXeTaiXeBUS.LayPhanCongTheoNgay(NgayPhanCong);

                if (aPhanCong != null)
                {
                    DialogResult LuaChon = MessageBox.Show("Đã có phân công cho ngày này\r\nBạn có muốn bổ sung?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (LuaChon == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        // Nếu phân công đã có cho ngày này thì bổ sung thêm các chi tiết phân công mới
                        blnLuuThanhCong = LuuChiTietPhanCong(aPhanCong.Ma);
                    }
                }
                else
                {
                    // Nếu chưa có phân công thì tạo phân công mới
                    aPhanCong = new PhanCongXeTaiXeDTO();
                    aPhanCong.MaNhanVienPhanCong = iMaNhanVien;
                    aPhanCong.NgayPhanCong = NgayPhanCong;

                    blnLuuThanhCong = PhanCongXeTaiXeBUS.ThemPhanCong(aPhanCong);
                    if (blnLuuThanhCong == true)
                    {
                        // Do mã phát sinh tự động nên phải select từ CSDL để lấy lại mã
                        PhanCongXeTaiXeDTO PhanCongVuaThem =
                            PhanCongXeTaiXeBUS.LayPhanCongTheoNgayVaNhanVienPC(NgayPhanCong, iMaNhanVien);

                        int iMaPhanCong = PhanCongVuaThem.Ma;

                        blnLuuThanhCong = LuuChiTietPhanCong(iMaPhanCong);
                    }
                }

                if (blnLuuThanhCong == true)
                {
                    MessageBox.Show("Đã lưu thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private ChiTietPCXe_TaiXeDTO TaoChiTietPhanCongDTO(int iMaPhanCong, DataGridViewRow aRow)
        {
            ChiTietPCXe_TaiXeDTO KetQua = null;
            ChiTietPCXe_TaiXeDTO aChiTietPhanCong = new ChiTietPCXe_TaiXeDTO();
            bool blnCoTheParse = false;

            try
            {                
                aChiTietPhanCong.MaPhanCong = iMaPhanCong;
                if (aRow.Cells["Xe_PhanCong"].Value != null)
                {
                    aChiTietPhanCong.BienSoXe = aRow.Cells["Xe_PhanCong"].Value.ToString();
                }
                else
                {
                    throw new Exception("Dòng " + (aRow.Index + 1) + ":\r\nBạn chưa chọn xe");
                }

                if (aRow.Cells["TaiXe_PhanCong"].Value != null)
                {
                    aChiTietPhanCong.MaTaiXe = int.Parse(aRow.Cells["TaiXe_PhanCong"].Value.ToString());
                }
                else
                {
                    throw new Exception("Dòng " + (aRow.Index + 1) + ":\r\nBạn chưa chọn tài xế");
                }
                
                TimeSpan ThoiGianBatDau = new TimeSpan();
                DialogResult LuaChon = new DialogResult();

                if (aRow.Cells["ThoiGianBatDau_PhanCong"].Value != null)
                {
                    // Kiểm tra xem có nhập đúng định dạng hh:mm
                    blnCoTheParse = TimeSpan.TryParse(aRow.Cells["ThoiGianBatDau_PhanCong"].Value.ToString(), out ThoiGianBatDau);
                    if (blnCoTheParse == false)
                    {
                        throw new Exception("Dòng " + (aRow.Index + 1) + ":\r\nThời gian bắt đầu nhập sai định dạng");
                    }
                    else
                    {
                        aChiTietPhanCong.ThoiGianBatDau = ThoiGianBatDau.ToString();
                    }
                }
                else
                {
                    LuaChon = MessageBox.Show("Bạn chưa chọn thời gian bắt đầu\r\nBạn có muốn tiếp tục?",
                        "Dòng " + (aRow.Index + 1), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (LuaChon == DialogResult.No)
                    {
                        return null;
                    }                    
                }

                if (aRow.Cells["ThoiGianKetThuc_PhanCong"].Value != null)
                {
                    TimeSpan ThoiGianKetThuc = new TimeSpan();
                    blnCoTheParse = TimeSpan.TryParse(aRow.Cells["ThoiGianKetThuc_PhanCong"].Value.ToString(), out ThoiGianKetThuc);
                    if (blnCoTheParse == false)
                    {
                        throw new Exception("Dòng " + (aRow.Index + 1) + ":\r\nThời gian kết thúc nhập sai định dạng");
                    }
                    else
                    {
                        if (ThoiGianKetThuc < ThoiGianBatDau)
                        {
                            throw new Exception("Dòng " + (aRow.Index + 1) + ":\r\nThời gian kết thúc phải lớn hơn thời gian bắt đầu");
                        }
                        aChiTietPhanCong.ThoiGianKetThuc = ThoiGianKetThuc.ToString();
                        KetQua = new ChiTietPCXe_TaiXeDTO();
                        KetQua = aChiTietPhanCong;
                    }
                }
                else
                {
                    LuaChon = MessageBox.Show("Bạn chưa chọn thời gian kết thúc\r\nBạn có muốn tiếp tục?",
                        "Dòng " + (aRow.Index + 1), MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (LuaChon == DialogResult.No)
                    {
                        return null;
                    }
                    else
                    {
                        KetQua = new ChiTietPCXe_TaiXeDTO();
                        KetQua = aChiTietPhanCong;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return KetQua;
        }

        private bool LuuChiTietPhanCong(int iMaPhanCong)
        {
            bool blnLuuThanhCong = false;

            // Thêm lần lượt từng chi tiết phân công vào CSDL
            ChiTietPCXe_TaiXeDTO aChiTiet;
            int iSoDongThucSu = this.dtgv_DanhSachPhanCong.Rows.Count - 1;
            for (int i = 0; i < iSoDongThucSu; i++)
            {
                try
                {
                    aChiTiet = TaoChiTietPhanCongDTO(iMaPhanCong, this.dtgv_DanhSachPhanCong.Rows[i]);
                    if (aChiTiet != null)
                    {
                        blnLuuThanhCong = ChiTietPCXe_TaiXeBUS.ThemChiTiet(aChiTiet);
                    }
                }
                catch (Exception ex)
                {
                    blnLuuThanhCong = false;
                }
            }

            return blnLuuThanhCong;
        }

        private void btn_Thoat_PhanCong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabMainTab.SelectedTab = this.tabPhanCong;
        }

        private void cậpNhậtPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CapNhatPhanCong frm = new frm_CapNhatPhanCong();
            frm.Show();
        }

        private void xóaPhâncôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_XoaPhanCong frm = new frm_XoaPhanCong();
            frm.Show();
        }

        private void btn_XemBaoCao_BaoCaoGiaoHang_Click(object sender, EventArgs e)
        {
            Db_QuanLyDoiXeVinamilkDataSet QLDX = new Db_QuanLyDoiXeVinamilkDataSet();
            String connString = ConfigurationManager.ConnectionStrings["GUI.Properties.Settings.Db_QuanLyDoiXeVinamilkConnectionString"].ToString();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                String strCommand1 = "Select * from Hoa_Don where DatePart('m', NgayLap) = ?";
                int iThangBaoCao = this.dtp_Thang_BaoCaoGiaoHang.Value.Month;
                OleDbParameter param = new OleDbParameter("@Thang", iThangBaoCao);
                OleDbCommand command = new OleDbCommand(strCommand1, conn);
                command.Parameters.Add(param);
                String strCommand2 = "Select * from ChiTiet_HoaDon";
                String strCommand3 = "Select * from Trang_Thai";
                String strCommand4 = "Select * from Mat_Hang";
                
                OleDbDataAdapter HoaDonAdapter = new OleDbDataAdapter(command);
                OleDbDataAdapter ChiTietHoaDonAdapter = new OleDbDataAdapter(strCommand2, conn);
                OleDbDataAdapter TrangThaiAdapter = new OleDbDataAdapter(strCommand3, conn);
                OleDbDataAdapter MatHangAdapter = new OleDbDataAdapter(strCommand4, conn);

                HoaDonAdapter.Fill(QLDX, "Hoa_Don");
                if (QLDX.HOA_DON.Count > 0)
                {
                    ChiTietHoaDonAdapter.Fill(QLDX, "ChiTiet_HoaDon");
                    TrangThaiAdapter.Fill(QLDX, "Trang_Thai");
                    MatHangAdapter.Fill(QLDX, "Mat_Hang");

                    BaoCao BaoCaoGiaoHang = new BaoCao();
                    BaoCaoGiaoHang.SetDataSource(QLDX);
                    BaoCaoGiaoHang.SetParameterValue("@Thang", this.dtp_Thang_BaoCaoGiaoHang.Value);
                    this.crv_BaoCaoGiaoHang.ReportSource = BaoCaoGiaoHang;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho tháng này");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nhậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhapHoaDon frm = new frm_NhapHoaDon();
            frm.Show();
        }

        private void quảnLýLoạiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiNhanVienGUI frm = new LoaiNhanVienGUI();
            frm.Show();
        }

        private void quảnLýThamSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThamSoGUI frm = new QuanLyThamSoGUI();
            frm.Show();
        }
    }
}
