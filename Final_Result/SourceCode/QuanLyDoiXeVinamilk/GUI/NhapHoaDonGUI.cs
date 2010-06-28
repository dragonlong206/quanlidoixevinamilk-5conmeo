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
    public partial class frm_NhapHoaDon : Form
    {
        bool blnCoTheLuu;

        public DateTime LoaiBoGio(DateTime NgayCu)
        {
            DateTime temp = NgayCu;
            TimeSpan ts = temp.TimeOfDay;   // Lấy giờ hiện tại
            temp = temp.Subtract(ts);  // Cho giờ = 00:00:00 để đảm bảo so sánh đúng
            return temp;
        }

        public frm_NhapHoaDon()
        {
            InitializeComponent();
            blnCoTheLuu = false;
        }

        private void frm_NhapHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                List<DiaDiemDTO> DanhSachDiaDiem = DiaDiemBUS.DocDanhSachDiaDiem(String.Empty);
                if (DanhSachDiaDiem.Count > 0)
                {
                    clnDiaDiem.DataSource = DanhSachDiaDiem;
                    clnDiaDiem.DisplayMember = "TenDiaDiem";
                    clnDiaDiem.ValueMember = "MaDiaDiem";
                }

                List<MatHangDTO> DanhSachMatHang = MatHangBUS.DocDanhSachMatHang(String.Empty);
                if (DanhSachMatHang.Count > 0)
                {
                    clnMatHang.DataSource = DanhSachMatHang;
                    clnMatHang.DisplayMember = "TenMatHang";
                    clnMatHang.ValueMember = "MaMatHang";
                }

                List<TrangThaiDTO> DanhSachTrangThai = TrangThaiBUS.DocDanhSachTrangThai(String.Empty);
                if (DanhSachTrangThai.Count > 0)
                {
                    clnTrangThai.DataSource = DanhSachTrangThai;
                    clnTrangThai.DisplayMember = "TenTrangThai";
                    clnTrangThai.ValueMember = "MaTrangThai";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtp_NgayGiaoHang_ValueChanged(object sender, EventArgs e)
        {
            DataTable DanhSachPhanCong = PhanCongXeTaiXeBUS.LayChiTietPhanCongTheoNgay(LoaiBoGio(this.dtp_NgayGiaoHang.Value));
            if (DanhSachPhanCong.Rows.Count > 0)
            {
                this.cbo_XeGiaoHang.DataSource = DanhSachPhanCong;
                this.cbo_XeGiaoHang.DisplayMember = "BienSoXe";
                this.cbo_XeGiaoHang.ValueMember = "BienSoXe";
                blnCoTheLuu = true;
            }
            else
            {
                blnCoTheLuu = false;
                MessageBox.Show("Không có phân công giao hàng vào ngày bạn chọn\r\nXin hãy chọn một ngày khác");
            }
        }

        private void btn_Thoat_PhanCong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_DanhSachPhanCong_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (btn_Luu.Enabled == false)
            {
                btn_Luu.Enabled = true;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (blnCoTheLuu == true)
            {
                if (this.cbo_XeGiaoHang.Text != String.Empty)
                {
                    try
                    {
                        bool blnLuuThanhCong = true;

                        HoaDonDTO aHoaDon = HoaDonBUS.LayHoaDonTheoNgayGiaoVaBienSoXe(LoaiBoGio(this.dtp_NgayGiaoHang.Value),
                            this.cbo_XeGiaoHang.Text);

                        if (aHoaDon != null)
                        {
                            DialogResult LuaChon = MessageBox.Show("Đã có hóa đơn của xe bạn chọn trong ngày này\r\nBạn có muốn bổ sung?", "",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (LuaChon == DialogResult.No)
                            {
                                return;
                            }
                            else
                            {
                                blnLuuThanhCong &= LuuChiTietHoaDon(aHoaDon.Ma);
                            }
                        }
                        else
                        {
                            aHoaDon = new HoaDonDTO();
                            aHoaDon.NgayGiaoHang = LoaiBoGio(this.dtp_NgayGiaoHang.Value);
                            aHoaDon.NgayLap = LoaiBoGio(this.dtp_NgayLapHoaDon.Value);
                            aHoaDon.XeGiaoHang = this.cbo_XeGiaoHang.SelectedValue.ToString();

                            blnLuuThanhCong &= HoaDonBUS.ThemHoaDon(aHoaDon);
                            if (blnLuuThanhCong == true)
                            {
                                // Do mã phát sinh tự động nên phải select từ CSDL để lấy lại mã
                                HoaDonDTO HoaDonVuaThem =
                                    HoaDonBUS.LayHoaDonTheoNgayGiaoVaBienSoXe(aHoaDon.NgayGiaoHang, aHoaDon.XeGiaoHang);

                                int iMaHoaDon = HoaDonVuaThem.Ma;

                                blnLuuThanhCong &= LuuChiTietHoaDon(iMaHoaDon);
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
                else
                {
                    MessageBox.Show("Bạn chưa chọn xe giao hàng");
                }
            }
        }

        private bool LuuChiTietHoaDon(int iMaHoaDon)
        {
            bool blnLuuThanhCong = false;

            // Thêm lần lượt từng chi tiết phân công vào CSDL
            ChiTietHoaDonDTO aChiTietHoaDon;
            int iSoDongThucSu = this.dtgv_DanhSachPhanCong.Rows.Count - 1;
            for (int i = 0; i < iSoDongThucSu; i++)
            {
                try
                {
                    aChiTietHoaDon = TaoChiTietHoaDonDTO(iMaHoaDon, this.dtgv_DanhSachPhanCong.Rows[i]);
                    if (aChiTietHoaDon != null)
                    {
                        blnLuuThanhCong = ChiTietHoaDonBUS.ThemChiTiet(aChiTietHoaDon);
                    }
                }
                catch (Exception ex)
                {
                    blnLuuThanhCong = false;
                    throw ex;
                }
            }

            return blnLuuThanhCong;
        }

        private ChiTietHoaDonDTO TaoChiTietHoaDonDTO(int iMaHoaDon, DataGridViewRow aRow)
        {
            ChiTietHoaDonDTO KetQua = null;
            ChiTietHoaDonDTO aChiTietHoaDon = new ChiTietHoaDonDTO();
            bool blnCoTheParse = false;

            try
            {
                aChiTietHoaDon.MaHoaDon = iMaHoaDon;
                if (aRow.Cells["clnDiaDiem"].Value != null)
                {
                    aChiTietHoaDon.MaDiaDiem = int.Parse(aRow.Cells["clnDiaDiem"].Value.ToString());
                }
                else
                {
                    throw new Exception("Dòng " + aRow.Index + 1 + ":\r\nBạn chưa chọn địa điểm");
                }

                if (aRow.Cells["clnMatHang"].Value != null)
                {
                    aChiTietHoaDon.MaMatHang = int.Parse(aRow.Cells["clnMatHang"].Value.ToString());
                }
                else
                {
                    throw new Exception("Dòng " + aRow.Index + 1 + ":\r\nBạn chưa chọn mặt hàng");
                }

                if (aRow.Cells["clnSoLuong"].Value != null)
                {
                    aChiTietHoaDon.SoLuong = int.Parse(aRow.Cells["clnSoLuong"].Value.ToString());
                }
                else
                {
                    throw new Exception("Dòng " + aRow.Index + 1 + ":\r\nBạn chưa nhập số lượng");
                }

                if (aRow.Cells["clnTrangThai"].Value != null)
                {
                    aChiTietHoaDon.MaTrangThai = int.Parse(aRow.Cells["clnTrangThai"].Value.ToString());
                }
                else
                {
                    aChiTietHoaDon.MaTrangThai = 2; // Mặc định là chưa giao
                }

                KetQua = aChiTietHoaDon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return KetQua;
        }
    }
}
