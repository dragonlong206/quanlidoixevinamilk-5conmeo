using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class ChiTietPCXe_TaiXeDAO
    {
        #region 1.Insert
        public static int ThemChiTiet(ChiTietPCXe_TaiXeDTO aChiTiet)
        {
            int nSoDongThemDuoc = -1;

            try
            {
                String strCommand = @"Insert into CHITIETPCXE_TAIXE
                                    (MaPhanCong, BienSoXe, MaTaiXe, ThoiGianBatDau, ThoiGianKetThuc)
                                    values(?, ?, ?, ?, ?)";

                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@MaPhanCong", aChiTiet.MaPhanCong));
                lstParams.Add(new OleDbParameter("@BienSoXe", aChiTiet.BienSoXe));
                lstParams.Add(new OleDbParameter("@MaTaiXe", aChiTiet.MaTaiXe));
                lstParams.Add(new OleDbParameter("@ThoiGianBatDau", aChiTiet.ThoiGianBatDau));
                lstParams.Add(new OleDbParameter("ThoiGianKetThuc", aChiTiet.ThoiGianKetThuc));

                nSoDongThemDuoc = SqlDataAccessHelper.ExcuteNonQuery(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nSoDongThemDuoc;
        }
        #endregion

        #region 2.Update
        public static int CapNhatChiTiet(ChiTietPCXe_TaiXeDTO aChiTiet)
        {
            int nSoDongDuocCapNhat = 0;

            try
            {
                String strCommand = @"Update ChiTietPCXe_TaiXe
                                      set BienSoXe = ?,
                                      MaTaiXe = ?,
                                      ThoiGianBatDau = ?,
                                      ThoiGianKetThuc = ?
                                      where Ma = ?";
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@BienSoXe", aChiTiet.BienSoXe));
                lstParams.Add(new OleDbParameter("@MaTaiXe", aChiTiet.MaTaiXe));
                lstParams.Add(new OleDbParameter("@ThoiGianBatDau", aChiTiet.ThoiGianBatDau));
                lstParams.Add(new OleDbParameter("@ThoiGianKetThuc", aChiTiet.ThoiGianKetThuc));
                lstParams.Add(new OleDbParameter("@Ma", aChiTiet.Ma));

                nSoDongDuocCapNhat = SqlDataAccessHelper.ExcuteNonQuery(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nSoDongDuocCapNhat;
        }
        #endregion

        #region 3.Delete
        public static int XoaChiTiet(int iMaChiTiet)
        {
            int nSoDongXoaDuoc = 0;

            try
            {
                String strCommand = @"Delete from ChiTietPCXe_TaiXe
                                    Where Ma = ?";
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@MaChiTiet", iMaChiTiet));
                nSoDongXoaDuoc = SqlDataAccessHelper.ExcuteNonQuery(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nSoDongXoaDuoc;
        }
        #endregion

        #region 4.Select

        public static DataTable LayDanhSachChiTietTheoMaPhanCong(int iMaPhanCong)
        {
            DataTable KetQua = null;

            try
            {
                String strCommand = @"Select Ma, BienSoXe, TenNhanVien as TaiXe, ThoiGianBatDau, ThoiGianKetThuc
                                    From ChiTietPCXe_TaiXe CT, Nhan_Vien NV
                                    Where MaPhanCong = ?
                                    And CT.MaTaiXe = NV.MaNhanVien";
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@MaPhanCong", iMaPhanCong));

                KetQua = SqlDataAccessHelper.ExcuteQuery(strCommand, lstParams);
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
