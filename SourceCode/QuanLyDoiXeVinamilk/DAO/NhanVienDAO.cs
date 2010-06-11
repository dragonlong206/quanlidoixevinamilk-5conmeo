using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        #region Select
        public static List<NhanVienDTO> LayDanhSachNhanVien()
        {
            List<NhanVienDTO> lstDanhSachNhanVien = null;
            try
            {
                String strCommand = "Select * from NHAN_VIEN order by TenNhanVien";
                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);
                if (table.Rows.Count > 0)
                {
                    lstDanhSachNhanVien = new List<NhanVienDTO>();
                    foreach (DataRow aRow in table.Rows)
                    {
                        NhanVienDTO aNhanVien = new NhanVienDTO();
                        aNhanVien.MaNhanVien = int.Parse(aRow["MaNhanVien"].ToString());
                        aNhanVien.TenNhanVien = aRow["TenNhanVien"].ToString();
                        aNhanVien.SoDienThoai = aRow["SoDienThoai"].ToString();

                        lstDanhSachNhanVien.Add(aNhanVien);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstDanhSachNhanVien;
        }
        #endregion
    }
}
