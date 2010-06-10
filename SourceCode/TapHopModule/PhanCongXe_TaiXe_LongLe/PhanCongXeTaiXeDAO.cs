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
                String strCommand = @"Insert into PHANCONGXE_TAIXE(MaPhanCong, NgayPhanCong, MaNhanVienPhanCong
                                        values(@MaPhanCong, @NgayPhanCong, @MaNhanVienPhanCong)";
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@MaPhanCong", aPhanCong.Ma));
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
    }
}
