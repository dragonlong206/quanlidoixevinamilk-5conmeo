using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        #region 1.Insert
        public static int ThemChiTiet(ChiTietHoaDonDTO aChiTiet)
        {
            int nSoDongThemDuoc = -1;

            try
            {
                String strCommand = @"Insert into CHITIET_HOADON
                                    (MaHoaDon, MaDiaDiem, MaMatHang, SoLuong, MaTrangThai)
                                    values(?, ?, ?, ?, ?)";

                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@MaHoaDon", aChiTiet.MaHoaDon));
                lstParams.Add(new OleDbParameter("@MaDiaDiem", aChiTiet.MaDiaDiem));
                lstParams.Add(new OleDbParameter("@MaMatHang", aChiTiet.MaMatHang));
                lstParams.Add(new OleDbParameter("@SoLuong", aChiTiet.SoLuong));
                lstParams.Add(new OleDbParameter("@MaTrangThai", aChiTiet.MaTrangThai));

                nSoDongThemDuoc = SqlDataAccessHelper.ExcuteNonQuery(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return nSoDongThemDuoc;
        }
        #endregion
    }
}
