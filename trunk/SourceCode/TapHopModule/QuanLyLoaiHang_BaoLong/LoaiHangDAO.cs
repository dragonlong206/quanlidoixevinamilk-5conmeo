using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class LoaiHangDAO
    {
        #region 1.Insert
        public static Boolean ThemLoaiHang(LoaiHangDTO LoaiHang)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenLoai", LoaiHang.TenLoai));
                arrParams.Add(new OleDbParameter("@MaLoai", LoaiHang.MaLoaiHang));

                String strCommand = @"Insert TenLoai, MaLoai
                                into LOAI_HANG
                                values ?, ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    return blnDaThemDuoc = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return blnDaThemDuoc;
        }
        #endregion

        #region 2.Delete
        public static Boolean XoaLoaiHang(LoaiHangDTO LoaiHang)
        {
            Boolean blnKetQua = false;
            
            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaLoai", LoaiHang.MaLoaiHang));
                String strCommand = @"Delete from LOAI_HANG
                                      Where Maloai = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    blnKetQua = true;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }
        #endregion

        #region 3.Update
        public static Boolean UpDateLoaiHang(LoaiHangDTO LoaiHang)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenLoai", LoaiHang.TenLoai));
                arrParams.Add(new OleDbParameter("@MaLoai", LoaiHang.MaLoaiHang));

                String strCommand = @"Insert TenLoai, MaLoai
                                into LOAI_HANG
                                values ?, ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    return blnDaUpdate = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaUpdate;
        }
        #endregion

        #region 4.Select
        public static List<LoaiHangDTO> LayDanhSachLoaiHang()
        {
            List<LoaiHangDTO> dsLoaiHang = new List<LoaiHangDTO>();

            String strCommand = "Select * from LOAI_HANG";
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow row in table.Rows)
            {
                LoaiHangDTO LoaiHang = new LoaiHangDTO();
                LoaiHang.MaLoaiHang = int.Parse(row["Maloai"].ToString());
                LoaiHang.TenLoai = row["TenLoai"].ToString();

                dsLoaiHang.Add(LoaiHang);
            }

            return dsLoaiHang;
        }
        #endregion
    }
}
