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

            //this.dtgv_DanhSachPhanCong.Columns["ThoiGianBatDau_PhanCong"].DefaultCellStyle.
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
                // Lấy danh sách nhân viên phân công và tài xế
                List<NhanVienDTO> lstDanhSachNhanVien = NhanVienBUS.LayDanhSachNhanVien();
                if (lstDanhSachNhanVien.Count > 0)
                {
                    this.cbo_NhanVienPhanCong.DataSource = lstDanhSachNhanVien;
                    this.cbo_NhanVienPhanCong.ValueMember = "MaNhanVien";
                    this.cbo_NhanVienPhanCong.DisplayMember = "TenNhanVien";

                    // Ở đây không phân loại tài xế hay nhân viên nên dùng chung dữ liệu
                    List<NhanVienDTO> lstDanhSachTaiXe = new List<NhanVienDTO>(lstDanhSachNhanVien);
                    DataGridViewComboBoxColumn clmTaiXe = (DataGridViewComboBoxColumn)this.dtgv_DanhSachPhanCong.Columns["TaiXe_PhanCong"];
                    clmTaiXe.DataSource = lstDanhSachTaiXe;
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
                    throw new Exception("Bạn chưa chọn xe");
                }

                if (aRow.Cells["TaiXe_PhanCong"].Value != null)
                {
                    aChiTietPhanCong.MaTaiXe = int.Parse(aRow.Cells["TaiXe_PhanCong"].Value.ToString());
                }
                else
                {
                    throw new Exception("Bạn chưa chọn tài xế");
                }
                
                TimeSpan ThoiGianBatDau = new TimeSpan();
                DialogResult LuaChon = new DialogResult();

                if (aRow.Cells["ThoiGianBatDau_PhanCong"].Value != null)
                {
                    // Kiểm tra xem có nhập đúng định dạng hh:mm
                    blnCoTheParse = TimeSpan.TryParse(aRow.Cells["ThoiGianBatDau_PhanCong"].Value.ToString(), out ThoiGianBatDau);
                    if (blnCoTheParse == false)
                    {
                        throw new Exception("Thời gian bắt đầu nhập sai định dạng");
                    }
                    else
                    {
                        aChiTietPhanCong.ThoiGianBatDau = ThoiGianBatDau.ToString();
                    }
                }
                else
                {
                    LuaChon = MessageBox.Show("Bạn chưa chọn thời gian bắt đầu\r\nBạn có muốn tiếp tục?",
                        "Thieu du lieu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        throw new Exception("Thời gian kết thúc nhập sai định dạng");
                    }
                    else
                    {
                        if (ThoiGianKetThuc < ThoiGianBatDau)
                        {
                            throw new Exception("Thời gian kết thúc phải lớn hơn thời gian bắt đầu");
                        }
                        aChiTietPhanCong.ThoiGianKetThuc = ThoiGianKetThuc.ToString();
                        KetQua = new ChiTietPCXe_TaiXeDTO();
                        KetQua = aChiTietPhanCong;
                    }
                }
                else
                {
                    LuaChon = MessageBox.Show("Bạn chưa chọn thời gian kết thúc\r\nBạn có muốn tiếp tục?",
                        "Thieu du lieu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (LuaChon == DialogResult.No)
                    {
                        return null;
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
                    MessageBox.Show("Dòng " + (i + 1) + " bị lỗi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return blnLuuThanhCong;
        }

        private void btn_Thoat_PhanCong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
