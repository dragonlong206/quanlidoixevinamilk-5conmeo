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
                arrParams.Add(new OleDbParameter("@TenLoai", LoaiHang.TenLoaiHang));
                String strCommand = @"Insert Into LOAI_HANG(TenLoai)
                                      Values(?)";

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
        public static Boolean CapNhatLoaiHang(LoaiHangDTO aLoaiHang)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenLoai", aLoaiHang.TenLoaiHang));
                arrParams.Add(new OleDbParameter("@MaLoai", aLoaiHang.MaLoaiHang));

                String strCommand = @"Update LOAI_HANG
                                     Set TenLoai = ?
                                     Where MaLoai = ?";                

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
        public static List<LoaiHangDTO> DocDanhSachLoaiHang(String strTieuChiTimKiem)
        {
            List<LoaiHangDTO> lstLoaiHang = new List<LoaiHangDTO>();

            String strCommand = "Select * from LOAI_HANG" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstLoaiHang.Add(KhoiTao(aDong));
            }            

            return lstLoaiHang;
        }

        public static DTO.LoaiHangDTO KhoiTao(DataRow aDong)
        {
            DTO.LoaiHangDTO aLoaiHang = new DTO.LoaiHangDTO();

            aLoaiHang.MaLoaiHang = int.Parse(aDong["MaLoai"].ToString());
            aLoaiHang.TenLoaiHang = aDong["TenLoai"].ToString();
             
            return aLoaiHang;
        }

        #endregion
    }
}
