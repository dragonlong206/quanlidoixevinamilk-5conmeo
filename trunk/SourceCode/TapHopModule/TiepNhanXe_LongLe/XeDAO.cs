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
        #region 1.Insert

        public static Boolean ThemXe(XeDTO xe)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@BienSo", xe.BienSo));
                arrParams.Add(new OleDbParameter("@DinhMuc", xe.DinhMuc));
                arrParams.Add(new OleDbParameter("@DungTichBinh", xe.DungTichBinh));
                arrParams.Add(new OleDbParameter("@HieuXe", xe.HieuXe));
                arrParams.Add(new OleDbParameter("@MaHangXe", xe.MaHangXe));
                arrParams.Add(new OleDbParameter("@MaLoaiHang", xe.MaLoaiHang));
                arrParams.Add(new OleDbParameter("@MaNhanVienTiepNhan", xe.MaNhanVienTiepNhan));
                arrParams.Add(new OleDbParameter("@MaTrongTai", xe.MaTrongTai));
                arrParams.Add(new OleDbParameter("@NamSanXuat", xe.NamSanXuat));
                arrParams.Add(new OleDbParameter("@NgayDangKiem", xe.NgayDangKiem));
                arrParams.Add(new OleDbParameter("@NgayTiepNhan", xe.NgayTiepNhan));
                arrParams.Add(new OleDbParameter("@SoKhung", xe.SoKhung));
                arrParams.Add(new OleDbParameter("@SoMay", xe.SoMay));

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

        #region 2.Delete
        #endregion

        #region 3.Update
        #endregion

        #region 4.Select

        public static List<XeDTO> LayDanhSachTatCaCacXe()
        {
            List<XeDTO> dsXe = new List<XeDTO>();

            String strCommand = "Select * from XE";
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow row in table.Rows)
            {
                XeDTO xe = new XeDTO();
                xe.BienSo = row["BienSo"].ToString();
                xe.DinhMuc = double.Parse(row["DinhMuc"].ToString());
                xe.DungTichBinh = double.Parse(row["DungTichBinh"].ToString());
                xe.HieuXe = row["HieuXe"].ToString();
                xe.MaHangXe = int.Parse(row["MaHangXe"].ToString());
                xe.MaLoaiHang = int.Parse(row["MaLoaiHang"].ToString());
                xe.MaNhanVienTiepNhan = int.Parse(row["MaNhanVienTiepNhan"].ToString());
                xe.MaTrongTai = int.Parse(row["MaTrongTai"].ToString());
                xe.NamSanXuat = int.Parse(row["NamSanXuat"].ToString());
                xe.NgayDangKiem = DateTime.Parse(row["NgayDangKiem"].ToString());
                xe.NgayTiepNhan = DateTime.Parse(row["NgayTiepNhan"].ToString());
                xe.SoKhung = row["SoKhung"].ToString();
                xe.SoMay = row["SoMay"].ToString();

                dsXe.Add(xe);
            }

            return dsXe;
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
                xe.DinhMuc = double.Parse(table.Rows[0]["DinhMuc"].ToString());
                xe.DungTichBinh = double.Parse(table.Rows[0]["DungTichBinh"].ToString());
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
