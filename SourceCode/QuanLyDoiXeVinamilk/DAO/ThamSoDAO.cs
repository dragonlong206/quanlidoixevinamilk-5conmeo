using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class ThamSoDAO
    {
        #region 4.Select
        public static DataTable LayThamSo(String strTenThamSo)
        {
            DataTable KetQua = null;

            try
            {
                String strCommand = @"Select GiaTri from ThamSo
                                      where TenThamSo = ?";
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@TenThamSo", strTenThamSo));

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
