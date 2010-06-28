using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class TrangThaiDAO
    {
        #region Select
        public static List<TrangThaiDTO> DocDanhSachTrangThai(String strTieuChiTimKiem)
        {
            List<TrangThaiDTO> lstTrangThai = new List<TrangThaiDTO>();

            String strCommand = "Select * from TRANG_THAI" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstTrangThai.Add(KhoiTao(aDong));
            }

            return lstTrangThai;
        }

        public static TrangThaiDTO KhoiTao(DataRow aDong)
        {
            TrangThaiDTO aTrangThai = new TrangThaiDTO();
            aTrangThai.MaTrangThai = int.Parse(aDong["MaTrangThai"].ToString());
            aTrangThai.TenTrangThai = aDong["TenTrangThai"].ToString();

            return aTrangThai;
        }

        #endregion
    }
}
