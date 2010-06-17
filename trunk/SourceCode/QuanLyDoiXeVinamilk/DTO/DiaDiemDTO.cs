using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DiaDiemDTO
    {
        #region Thuoc tinh cua DiaDiemDTO
        private int m_nMaDiaDiem;
        private String m_strTenDiaDiem;
        private int m_nMaLoaiDiaDiem;
        private String m_strNguoiLienHe;        
        private String m_strDiaChi;        
        private String m_strEmail;        
        private String m_strDienThoai;       
        private String m_strToaDo;        
        #endregion

        #region Ham khoi tao DiaDiemDTO
        public DiaDiemDTO()
        {
            m_nMaDiaDiem = -1;
            m_strTenDiaDiem = String.Empty;
            m_nMaLoaiDiaDiem = -1;
            m_strNguoiLienHe = String.Empty;
            m_strDiaChi = String.Empty;
            m_strEmail = String.Empty;
            m_strDienThoai = String.Empty;
            m_strToaDo = "(-1,-1)";
        }
        #endregion

        #region Cac phuong thuc truy xuat den DiaDiemDTO
        public int MaDiaDiem
        {
            get { return m_nMaDiaDiem; }
            set { m_nMaDiaDiem = value; }
        }
        public String TenDiaDiem
        {
            get { return m_strTenDiaDiem; }
            set { m_strTenDiaDiem = value; }
        }
        public int MaLoaiDiaDiem
        {
            get { return m_nMaLoaiDiaDiem; }
            set { m_nMaLoaiDiaDiem = value; }
        }
        public String NguoiLienHe
        {
            get { return m_strNguoiLienHe; }
            set { m_strNguoiLienHe = value; }
        }
        public String DiaChi
        {
            get { return m_strDiaChi; }
            set { m_strDiaChi = value; }
        }
        public String Email
        {
            get { return m_strEmail; }
            set { m_strEmail = value; }
        }
        public String DienThoai
        {
            get { return m_strDienThoai; }
            set { m_strDienThoai = value; }
        }
        public String ToaDo
        {
            get { return m_strToaDo; }
            set { m_strToaDo = value; }
        }
        #endregion
    }
}
