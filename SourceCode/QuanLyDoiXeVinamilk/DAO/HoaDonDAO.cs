using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class HoaDonDAO
    {
        #region 1.Insert

        public static bool ThemHoaDon(HoaDonDTO aHoaDon)
        {
            bool blnDaThemDuoc = false;
            try
            {
                String strCommand = @"Insert into HOA_DON(NgayGiaoHang, NgayLap, XeGiaoHang)
                                        values(?, ?, ?)";
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@NgayGiaoHang", aHoaDon.NgayGiaoHang));
                lstParams.Add(new OleDbParameter("@NgayLap", aHoaDon.NgayLap));
                lstParams.Add(new OleDbParameter("@XeGiaoHang", aHoaDon.XeGiaoHang));

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
//        public static HoaDonDTO LayHoaDonTheoNgay(DateTime NgayGiaoHang)
//        {
//            HoaDonDTO aHoaDon = null;

//            try
//            {
//                String strCommand = @"Select * from HOA_DON
//                                      where NgayGiaoHang = ?";

//                List<OleDbParameter> lstParams = new List<OleDbParameter>();
//                lstParams.Add(new OleDbParameter("@NgayGiaoHang", NgayGiaoHang));

//                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, lstParams);
//                if (table.Rows.Count > 0)
//                {
//                    aHoaDon = new HoaDonDTO();
//                    aHoaDon.Ma = int.Parse(table.Rows[0]["MaHoaDon"].ToString());
//                    aHoaDon.NgayGiaoHang = DateTime.Parse(table.Rows[0]["NgayGiaoHang"].ToString());
//                    aHoaDon.MaNhanVienHoaDon = int.Parse(table.Rows[0]["MaNhanVienHoaDon"].ToString());
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//            return aHoaDon;
//        }

        public static HoaDonDTO LayHoaDonTheoNgayGiaoVaBienSoXe(DateTime NgayGiaoHang, String strBienSoXe)
        {
            HoaDonDTO aHoaDon = null;

            try
            {
                String strCommand = @"Select * from HOA_DON
                                      where NgayGiaoHang = ?
                                      and XeGiaoHang = ?";

                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@NgayGiaoHang", NgayGiaoHang));
                lstParams.Add(new OleDbParameter("@XeGiaoHang", strBienSoXe));

                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, lstParams);
                if (table.Rows.Count > 0)
                {
                    aHoaDon = new HoaDonDTO();
                    aHoaDon.Ma = int.Parse(table.Rows[0]["MaHoaDon"].ToString());
                    aHoaDon.NgayGiaoHang = DateTime.Parse(table.Rows[0]["NgayGiaoHang"].ToString());
                    aHoaDon.XeGiaoHang = table.Rows[0]["XeGiaoHang"].ToString();
                    aHoaDon.NgayLap = DateTime.Parse(table.Rows[0]["NgayLap"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return aHoaDon;
        }

        //public static DataTable LayDanhSachNgayGiaoHang()
        //{
        //    DataTable KetQua = null;

        //    try
        //    {
        //        String strCommand = "Select MaHoaDon, NgayGiaoHang from HOA_DON";

        //        KetQua = SqlDataAccessHelper.ExcuteQuery(strCommand, null);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return KetQua;
        //}
        #endregion
    }
}
