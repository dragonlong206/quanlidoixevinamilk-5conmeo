using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
   public class MatHangDTO
   {
       #region ThuocTinhMatHang
       private int m_nMaMatHang;     
       private string m_strTenMatHang;      
       private int m_nSoLuong;      
       private string m_strDonViTinh;      
       private int m_nMaLoai;    
       #endregion
       #region TruyXuat
       public int MaMatHang
       {
           get { return m_nMaMatHang; }
           set { m_nMaMatHang = value; }
       }      
       public int SoLuong
       {
           get { return m_nSoLuong; }
           set { m_nSoLuong = value; }
       }
       public string DonViTinh
       {
           get { return m_strDonViTinh; }
           set { m_strDonViTinh = value; }
       }
       public int MaLoai
       {
           get { return m_nMaLoai; }
           set { m_nMaLoai = value; }
       }
       public string TenMatHang
       {
           get { return m_strTenMatHang; }
           set { m_strTenMatHang = value; }
       }
       #endregion
        #region KhoiGan
        public MatHangDTO()
        {
            m_nMaLoai = -1;
            m_nMaMatHang = -1;
            m_nSoLuong = -1;
            m_strDonViTinh = String.Empty;
            m_strTenMatHang = String.Empty;
        }

        #endregion

   }
}
