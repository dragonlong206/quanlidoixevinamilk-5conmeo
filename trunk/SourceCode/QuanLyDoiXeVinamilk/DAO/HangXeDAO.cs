using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;
using System.Data;

namespace DAO
{
   public class HangXeDAO
    {
       #region 1.Insert
       public static Boolean ThemHangXe(HangXeDTO HangXe)
       {
           Boolean blnKetQua = false;
           try
           {
               List<OleDbParameter> arrParams = new List<OleDbParameter>();
               //arrParams.Add(new OleDbParameter("@MaHang",HangXe.MaHang));
               arrParams.Add(new OleDbParameter("@TenHang",HangXe.TenHang));
               String strCommand = @"Insert into HANG_XE (TenHang)
                                   Values(?)";

               int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
               if (nRecord == 1)
               {
                   blnKetQua = true;
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
           return blnKetQua;
       }
        #endregion

       #region 2.Delete
       public static Boolean XoaHangXeDAO(HangXeDTO aHangXe)
       {
           Boolean blnKetQua = false;

           try
           {
               List<OleDbParameter> arrParams = new List<OleDbParameter>();
               arrParams.Add(new OleDbParameter("@MaHang", aHangXe.MaHang));
               String strCommand = @"Delete from HANG_XE
                                     Where MaHang = ?";

               int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
               if (nRecord == 1)
               {
                   blnKetQua = true;
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }

           return blnKetQua;
       }
        #endregion

       #region 3.Update

       public static bool CapNhatHangXe(HangXeDTO aHangXe)
       {
           Boolean blnKetQua = false;
           try
           {
               List<OleDbParameter> arrParams = new List<OleDbParameter>();
               arrParams.Add(new OleDbParameter("@TenHang", aHangXe.TenHang));
               arrParams.Add(new OleDbParameter("@MaHang", aHangXe.MaHang));
               String strCommand = @"Update HANG_XE 
                                     Set TenHang = ? 
                                     Where MaHang = ?";

               int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
               if (nRecord == 1)
               {
                   blnKetQua = true;
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
           return blnKetQua;
       }

       #endregion

       #region 4.Select 

        public static List<DTO.HangXeDTO> DocDanhSachHangXe(String strTieuChiTimKiem)
        {
           List<DTO.HangXeDTO> lstHangXe = new List<DTO.HangXeDTO>();

           String strCommand = "Select * from HANG_XE" + strTieuChiTimKiem;
           DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

           foreach (DataRow aDong in table.Rows)
           {
               lstHangXe.Add(KhoiTao(aDong));
           }

           return lstHangXe;                      
        }      
 
        public static DTO.HangXeDTO KhoiTao(DataRow aDong)
        {
            DTO.HangXeDTO aHangXe = new DTO.HangXeDTO();
            
            aHangXe.MaHang = int.Parse(aDong["MaHang"].ToString());
            aHangXe.TenHang = aDong["TenHang"].ToString();            

            return aHangXe;
        }

       #endregion
    }
}
