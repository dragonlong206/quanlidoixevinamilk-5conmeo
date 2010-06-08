using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;


namespace DAO
{
    public class XeDAO
    {
        #region 1.Thêm

        public static Boolean ThemXe(DTO.XeDTO aXe)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@BienSo", aXe.BienSo));
                arrParams.Add(new OleDbParameter("@DinhMuc", aXe.DinhMuc));
                arrParams.Add(new OleDbParameter("@DungTichBinh", aXe.DungTichBinh));
                arrParams.Add(new OleDbParameter("@HieuXe", aXe.HieuXe));
                arrParams.Add(new OleDbParameter("@MaHangXe", aXe.MaHangXe));
                arrParams.Add(new OleDbParameter("@MaLoaiHang", aXe.MaLoaiHang));
                arrParams.Add(new OleDbParameter("@MaNhanVienTiepNhan", aXe.MaNhanVienTiepNhan));
                arrParams.Add(new OleDbParameter("@MaTrongTai", aXe.MaTrongTai));
                arrParams.Add(new OleDbParameter("@NamSanXuat", aXe.NamSanXuat));
                arrParams.Add(new OleDbParameter("@NgayDangKiem", aXe.NgayDangKiem));
                arrParams.Add(new OleDbParameter("@NgayTiepNhan", aXe.NgayTiepNhan));
                arrParams.Add(new OleDbParameter("@SoKhung", aXe.SoKhung));
                arrParams.Add(new OleDbParameter("@SoMay", aXe.SoMay));

                String strCommand = @"Insert into XE(BienSo, DinhMuc, DungTichBinh, HieuXe, MaHangXe, MaLoaiHang, MaNhanVienTiepNhan, 
                                    MaTrongTai, NamSanXuat, NgayDangKiem, NgayTiepNhan, SoKhung, SoMay)
                                    values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1) // Số dòng insert được
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

        #region 2.Xoá
        public static Boolean XoaXe(DTO.XeDTO aXe)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@BienSo", aXe.BienSo));                
                String strCommand = @"Delete from XE
                                      Where BienSo = ?";

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

        #region 3.Cập nhật.

        public static Boolean CapNhatXe(DTO.XeDTO aXe)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();                                
                arrParams.Add(new OleDbParameter("@DinhMuc", aXe.DinhMuc));
                arrParams.Add(new OleDbParameter("@DungTichBinh", aXe.DungTichBinh));
                arrParams.Add(new OleDbParameter("@HieuXe", aXe.HieuXe));
                arrParams.Add(new OleDbParameter("@MaHangXe", aXe.MaHangXe));
                arrParams.Add(new OleDbParameter("@MaLoaiHang", aXe.MaLoaiHang));
                arrParams.Add(new OleDbParameter("@MaNhanVienTiepNhan", aXe.MaNhanVienTiepNhan));
                arrParams.Add(new OleDbParameter("@MaTrongTai", aXe.MaTrongTai));
                arrParams.Add(new OleDbParameter("@NamSanXuat", aXe.NamSanXuat));
                arrParams.Add(new OleDbParameter("@NgayDangKiem", aXe.NgayDangKiem));
                arrParams.Add(new OleDbParameter("@NgayTiepNhan", aXe.NgayTiepNhan));
                arrParams.Add(new OleDbParameter("@SoKhung", aXe.SoKhung));
                arrParams.Add(new OleDbParameter("@SoMay", aXe.SoMay));
                arrParams.Add(new OleDbParameter("@BienSo", aXe.BienSo));

                String strCommand = @"Update XE
                                      Set DinhMuc = ?, DungTichBinh = ?, HieuXe = ?, MaHangXe = ?, MaLoaiHang = ?,
                                          MaNhanVienTiepNhan = ?, MaTrongTai = ?, NamSanXuat = ?, NgayDangKiem = ?,
                                          NgayTiepNhan = ?, SoKhung = ?, SoMay = ?
                                      Where BienSo = aXe.BienSo";   

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1) // Số dòng insert được
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

        #region 4.Select

        public static List<XeDTO> DocDanhSachXe()
        {
            List<XeDTO> dsXe = new List<XeDTO>();

            String strCommand = "Select * from XE";
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {                
                dsXe.Add(KhoiTao(aDong));
            }

            return dsXe;
        }

        public static DTO.XeDTO KhoiTao(DataRow aDong)
        {
            DTO.XeDTO aXe = new DTO.XeDTO();
            
            aXe.BienSo = aDong["BienSo"].ToString();
            aXe.DinhMuc = float.Parse(aDong["DinhMuc"].ToString());
            aXe.DungTichBinh = float.Parse(aDong["DungTichBinh"].ToString());
            aXe.HieuXe = aDong["HieuXe"].ToString();
            aXe.MaHangXe = int.Parse(aDong["MaHangXe"].ToString());
            aXe.MaLoaiHang = int.Parse(aDong["MaLoaiHang"].ToString());
            aXe.MaNhanVienTiepNhan = int.Parse(aDong["MaNhanVienTiepNhan"].ToString());
            aXe.MaTrongTai = int.Parse(aDong["MaTrongTai"].ToString());
            aXe.NamSanXuat = int.Parse(aDong["NamSanXuat"].ToString());
            aXe.NgayDangKiem = DateTime.Parse(aDong["NgayDangKiem"].ToString());
            aXe.NgayTiepNhan = DateTime.Parse(aDong["NgayTiepNhan"].ToString());
            aXe.SoKhung = aDong["SoKhung"].ToString();
            aXe.SoMay = aDong["SoMay"].ToString();

            return aXe;
        }

        public static XeDTO LayXeTheoBienSo(String strBienSo)
        {
            XeDTO xe = null;

            String strCommand = "Select * from XE where BienSo = ?";
            OleDbParameter param = new OleDbParameter("@BienSo", strBienSo);
            List<OleDbParameter> arrParams = new List<OleDbParameter>();
            arrParams.Add(param);

            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, arrParams);

            if (table.Rows.Count > 0)
            {
                xe = new XeDTO();
                xe.BienSo = table.Rows[0]["BienSo"].ToString();
                xe.DinhMuc = float.Parse(table.Rows[0]["DinhMuc"].ToString());
                xe.DungTichBinh = float.Parse(table.Rows[0]["DungTichBinh"].ToString());
                xe.HieuXe = table.Rows[0]["HieuXe"].ToString();
                xe.MaHangXe = int.Parse(table.Rows[0]["MaHangXe"].ToString());
                xe.MaLoaiHang = int.Parse(table.Rows[0]["MaLoaiHang"].ToString());
                xe.MaNhanVienTiepNhan = int.Parse(table.Rows[0]["MaNhanVienTiepNhan"].ToString());
                xe.MaTrongTai = int.Parse(table.Rows[0]["MaTrongTai"].ToString());
                xe.NamSanXuat = int.Parse(table.Rows[0]["NamSanXuat"].ToString());
                xe.NgayDangKiem = DateTime.Parse(table.Rows[0]["NgayDangKiem"].ToString());
                xe.NgayTiepNhan = DateTime.Parse(table.Rows[0]["NgayTiepNhan"].ToString());
                xe.SoKhung = table.Rows[0]["SoKhung"].ToString();
                xe.SoMay = table.Rows[0]["SoMay"].ToString();
            }

            return xe;
        }

        #endregion
    }
}
