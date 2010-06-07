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
       public static Boolean ThemHangXeDAO(HangXeDTO HangXe)
       {
           Boolean blnDaThemDuoc = false;
           try
           {
               List<OleDbParameter> arrParams = new List<OleDbParameter>();
               arrParams.Add(new OleDbParameter("@MaHang",HangXe.MaHang));
               arrParams.Add(new OleDbParameter("@TenHang",HangXe.TenHang));
               String strCommand = @"Insert into HANG_XE (MaHang,TenHang)values(?,?)";
               int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
               if (nRecord == 1)
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
        #region 2.Delete
       public static Boolean XoaHangXeDAO(HangXeDTO hx)
       {
           Boolean blnKetQua = false;

           try
           {
               List<OleDbParameter> arrParams = new List<OleDbParameter>();
               arrParams.Add(new OleDbParameter("@MaHang", hx.MaHang));
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
       public static bool CapNhatHangXeDAO(HangXeDTO hx)
       {
           bool result = false;
           try
           {
               // Create List Sql Parameter
               List<OleDbParameter> arrParams = new List<OleDbParameter>();
               arrParams.Add(new OleDbParameter("@MaHang", hx.MaHang));
               arrParams.Add(new OleDbParameter("@TenHang", hx.TenHang));
              
              //chi cap nhat lai ten hang xe 
               String strCommand = @"Update HANG_XE set TenHang = ? where MaHang = @MaHang";
               int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
               if (nRecord == 1)
               {
                   result = true;

               }
           }
           catch (Exception ex)
           {
               throw ex;
           }
           return result;
       }
        #endregion
        #region 4.Select 
       public static List<HangXeDTO> LayDanhSachTatCaCacHangXe()
       {
           List<HangXeDTO> dsHangXe = new List<HangXeDTO>();

           String strCommand = "Select * from Hang_Xe";
           DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

           foreach (DataRow row in table.Rows)
           {
               HangXeDTO hangxe = new HangXeDTO();
               hangxe.MaHang = int.Parse(row["MaHang"].ToString());
               hangxe.TenHang = row["TenHang"].ToString();
               dsHangXe.Add(hangxe);
           }

           return dsHangXe;
       }

       public static HangXeDTO LayHangXeTheoMaHang(int MaHang)
       {
           HangXeDTO hangxe = null;

           String strCommand = "Select * from Hang_Xe where MaHang = ?";
           OleDbParameter param = new OleDbParameter("@MaHang", MaHang);
           List<OleDbParameter> arrParams = new List<OleDbParameter>();
           arrParams.Add(param);

           DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, arrParams);

           if (table.Rows.Count > 0)
           {
               hangxe = new HangXeDTO();
               hangxe.MaHang = int.Parse(table.Rows[0]["MaHang"].ToString());
               hangxe.TenHang = table.Rows[0]["TenHang"].ToString();
             
           }

           return hangxe;
       }
       public static bool KiemTraMaHangXe(int MaHangXe)
       {
           try
           {
               HangXeDTO hangxe = HangXeDAO.LayHangXeTheoMaHang(MaHangXe);

               if (hangxe != null)
               {
                   return true;
               }
           }
           catch (Exception ex)
           {
               throw ex;
           }

           return false;
       }

        #endregion
    }
}
