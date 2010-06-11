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

        #region 4.Select
        #endregion
    }
}
