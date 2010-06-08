using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class LoaiHangBUS
    {        
        public static int GetMaLoaiHang(String strLoaiHang)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch(strLoaiHang)
            {
                case "Hàng Thường":
                    return 1;
                case "Hàng Nóng":
                    return 2;
                case "Hàng Lạnh":
                    return 3;
                default:
                    return -1;
            }
        }

        public static String GetTenLoaiHang(int nMaLoaiHang)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch(nMaLoaiHang)
            {
                case 1:
                    return "Hàng Thường";
                case 2:
                    return "Hàng Nóng";
                case 3:
                    return "Hàng Lạnh";
                default:
                    return "Erorr!";
            }
        }
    }
}
