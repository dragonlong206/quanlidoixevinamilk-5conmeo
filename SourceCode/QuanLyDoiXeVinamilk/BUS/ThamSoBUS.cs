using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class ThamSoBUS
    {
        public static int GetSoNamToiDa()
        {
            return 10;
        }

        public static DataTable LayThamSo(String strTenThamSo)
        {
            DataTable KetQua = null;

            try
            {
                KetQua = ThamSoDAO.LayThamSo(strTenThamSo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }
    }
}
