using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class NhanVienBUS
    {
        //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
        public static int GetMaNhanVien(String strTenNhanVien)
        {
            switch(strTenNhanVien)
            {
                case "Bùi Kim Hoa":
                    return 1;
                case "Nguyễn Anh":
                    return 2;
                case "Nguyễn Khuyến":
                    return 3;
                default:
                    return -1;
            }
        }

        public static String GetTenNhanVien(int nMaNhanVien)
        {
            switch(nMaNhanVien)
            {
                case 1:
                    return "Bùi Kim Hoa";
                case 2:
                    return "Nguyễn Anh";
                case 3:
                    return "Nguyễn Khuyến";
                default:
                    return "Erorr!";
            }
        }
    }
}
