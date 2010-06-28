using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class PhanCongXeTaiXeDAO
    {
        #region 1.Insert

        public static bool ThemPhanCong(PhanCongXeTaiXeDTO aPhanCong)
        {
            bool blnDaThemDuoc = false;
            try
            {
                String strCommand = @"Insert into PHANCONGXE_TAIXE(NgayPhanCong, MaNhanVienPhanCong)
                                        values(?, ?)";
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@NgayPhanCong", aPhanCong.NgayPhanCong));
                lstParams.Add(new OleDbParameter("@MaNhanVienPhanCong", aPhanCong.MaNhanVienPhanCong));

                int nSoDongThemDuoc = SqlDataAccessHelper.ExcuteNonQuery(strCommand, lstParams);
                if (nSoDongThemDuoc == 1)
                {
                    blnDaThemDuoc = true;
                }
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
                String strCommand = @"Select * from PHANCONGXE_TAIXE
                                      where NgayPhanCong = ?";

                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@NgayPhanCong", NgayPhanCong));

                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, lstParams);
                if (table.Rows.Count > 0)
                {
                    aPhanCong = new PhanCongXeTaiXeDTO();
                    aPhanCong.Ma = int.Parse(table.Rows[0]["MaPhanCong"].ToString());
                    aPhanCong.NgayPhanCong = DateTime.Parse(table.Rows[0]["NgayPhanCong"].ToString());
                    aPhanCong.MaNhanVienPhanCong = int.Parse(table.Rows[0]["MaNhanVienPhanCong"].ToString());
                }
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
                String strCommand = @"Select * from PHANCONGXE_TAIXE
                                      where NgayPhanCong = ?
                                      and MaNhanVienPhanCong = ?";

                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@NgayPhanCong", NgayPhanCong));
                lstParams.Add(new OleDbParameter("@MaNhanVienPhanCong", iMaNhanVien));

                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, lstParams);
                if (table.Rows.Count > 0)
                {
                    aPhanCong = new PhanCongXeTaiXeDTO();
                    aPhanCong.Ma = int.Parse(table.Rows[0]["MaPhanCong"].ToString());
                    aPhanCong.NgayPhanCong = DateTime.Parse(table.Rows[0]["NgayPhanCong"].ToString());
                    aPhanCong.MaNhanVienPhanCong = int.Parse(table.Rows[0]["MaNhanVienPhanCong"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aPhanCong;
        }

        public static DataTable LayDanhSachPhanCongLinhHoat(String strCommand, List<OleDbParameter> lstParams)
        {
            DataTable KetQua = null;

            try
            {
                KetQua = SqlDataAccessHelper.ExcuteQuery(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }

        public static DataTable LayDanhSachNgayPhanCong()
        {
            DataTable KetQua = null;

            try
            {
                String strCommand = "Select MaPhanCong, NgayPhanCong from PHANCONGXE_TAIXE";

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
