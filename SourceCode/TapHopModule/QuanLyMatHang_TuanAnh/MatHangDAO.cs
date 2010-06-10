using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;
using System.Data;


namespace DAO
{
   public class MatHangDAO
   {
       #region 1.Insert
       public static Boolean ThemMatHang(MatHangDTO MatHang)
       {
           Boolean blnKetQua = false;
           try
           {
               List<OleDbParameter> arrParams = new List<OleDbParameter>();
               //arrParams.Add(new OleDbParameter("@MaHang",HangXe.MaHang));
               arrParams.Add(new OleDbParameter("@TenMatHang", MatHang.TenMatHang));
               arrParams.Add(new OleDbParameter("@SoLuong", MatHang.SoLuong));
               arrParams.Add(new OleDbParameter("@DonViTinh", MatHang.DonViTinh));
               arrParams.Add(new OleDbParameter("@MaLoai", MatHang.MaLoai));
               String strCommand = @"Insert into MAT_HANG (TenMatHang,SoLuong,DonViTinh,MaLoai)
                                   Values(?,?,?,?)";

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
       public static Boolean XoaMatHang(MatHangDTO aMH)
       {
           Boolean blnKetQua = false;

           try
           {
               List<OleDbParameter> arrParams = new List<OleDbParameter>();
               arrParams.Add(new OleDbParameter("@TenMatHang", aMH.TenMatHang));
               String strCommand = @"Delete from MAT_HANG
                                      Where TenMatHang = ?";

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

       public static List<MatHangDTO> DocDanhSachMatHang(String strTieuChiTimKiem)
       {
           List<MatHangDTO> lstMH = new List<MatHangDTO>();

           String strCommand = "Select * from MAT_HANG" + strTieuChiTimKiem;
           DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

           foreach (DataRow aDong in table.Rows)
           {
               lstMH.Add(KhoiTao(aDong));
               
           }

           return lstMH;
       }

       public static MatHangDTO KhoiTao(DataRow aDong)
       {
           MatHangDTO aMH = new MatHangDTO();
           aMH.MaMatHang = int.Parse(aDong["MaMatHang"].ToString());
           aMH.TenMatHang = aDong["TenMatHang"].ToString();
           aMH.SoLuong = int.Parse(aDong["SoLuong"].ToString());
           aMH.DonViTinh = aDong["DonViTinh"].ToString();
           aMH.MaLoai = int.Parse(aDong["MaLoai"].ToString());

           return aMH;
       }
       #endregion


   }
}
