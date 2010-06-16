using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;
using DAO;

namespace BUS
{
    public class PhanCongXeTaiXeBUS
    {
        #region 1.Insert

        public static bool ThemPhanCong(PhanCongXeTaiXeDTO aPhanCong)
        {
            bool blnDaThemDuoc = false;

            try
            {
                blnDaThemDuoc = PhanCongXeTaiXeDAO.ThemPhanCong(aPhanCong);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }

        #endregion

        #region 2.Select
        public static PhanCongXeTaiXeDTO LayPhanCongTheoNgay(DateTime NgayPhanCong)
        {
            PhanCongXeTaiXeDTO aPhanCong = null;
            try
            {
                aPhanCong = PhanCongXeTaiXeDAO.LayPhanCongTheoNgay(NgayPhanCong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return aPhanCong;
        }

        public static PhanCongXeTaiXeDTO LayPhanCongTheoNgayVaNhanVienPC(DateTime NgayPhanCong, int iMaNhanVien)
        {
            PhanCongXeTaiXeDTO aPhanCong = null;
            try
            {
                aPhanCong = PhanCongXeTaiXeDAO.LayPhanCongTheoNgayVaNhanVienPC(NgayPhanCong, iMaNhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return aPhanCong;
        }

        public static DataTable LayChiTietPhanCongTheoNgay(DateTime NgayPhanCong)
        {
            DataTable dtKetQua = null;

            try
            {
                String strCommand = @"Select CT.Ma as MaChiTiet, BienSoXe, TX.TenNhanVien as TaiXe, ThoiGianBatDau, ThoiGianKetThuc, NVPC.TenNhanVien as NhanVienPhanCong
                                      from PhanCongXe_TaiXe as PC, ChiTietPCXe_TaiXe as CT, Nhan_Vien as TX, Nhan_Vien as NVPC
                                      where NgayPhanCong = ?
                                      and PC.MaPhanCong = CT.MaPhanCong
                                      and CT.MaTaiXe = TX.MaNhanVien
                                      and PC.MaNhanVienPhanCong = NVPC.MaNhanVien";

                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@NgayPhanCong", NgayPhanCong));

                dtKetQua = PhanCongXeTaiXeDAO.LayDanhSachPhanCongLinhHoat(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtKetQua;
        }

        public static DataTable LayDanhSachNgayPhanCong()
        {
            DataTable KetQua = null;

            try
            {
                KetQua = PhanCongXeTaiXeDAO.LayDanhSachNgayPhanCong();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }

        public static DataTable LayDanhSachTaiXeCoThePhanCong()
        {
            DataTable KetQua = null;
            try
            {
                // Tài xế phải có trên 5 năm kinh nghiệm
                String strCommand = @"Select MaNhanVien, TenNhanVien
                                    From Nhan_Vien NV, Loai_Nhan_Vien LNV
                                    Where NV.MaLoaiNhanVien = LNV.Ma
                                    And LNV.TenLoai = 'Tài xế'
                                    And DateDiff('YYYY', NV.NgayVaoCongTy, Now()) >= ?";

                DataTable SoNamKinhNghiemToiThieu = ThamSoBUS.LayThamSo("SoNamKinhNghiemToiThieu");
                int iSoNamKinhNghiemToiThieu = int.Parse(SoNamKinhNghiemToiThieu.Rows[0][0].ToString());
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@SoNamKinhNghiemToiThieu", iSoNamKinhNghiemToiThieu));

                KetQua = SqlDataAccessHelper.ExcuteQuery(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }

        public static DataTable LayDanhSachNhanVienPhanCong()
        {
            DataTable KetQua = null;

            try
            {
                String strCommand = @"Select MaNhanVien, TenNhanVien
                                    From Nhan_Vien NV, Loai_Nhan_Vien LNV
                                    Where NV.MaLoaiNhanVien = LNV.Ma
                                    And LNV.TenLoai = 'Quản lý'";

                KetQua = SqlDataAccessHelper.ExcuteQuery(strCommand, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }
        #endregion
    }
}
