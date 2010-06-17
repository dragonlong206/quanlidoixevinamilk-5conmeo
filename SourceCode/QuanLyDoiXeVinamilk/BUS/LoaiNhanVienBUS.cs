using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class LoaiNhanVienBUS
    {
        public static int GetMaLoaiNhanVien(String strLoaiNhanVien)
        {
            switch(strLoaiNhanVien)
            {
                case "Quản lý":
                    return 2;
                case "Tài xế":
                    return 3;
                default:
                    return -1;
            }
        }

        public static String GetTenLoaiNhanVien(int nMaLoaiNhanVien)
        {
            switch(nMaLoaiNhanVien)
            {
                case 2:
                    return "Quản lý";                    
                case 3:
                    return "Tài xế";
                default:
                    return "Erorr!";                    
            }
        }
    }
}
