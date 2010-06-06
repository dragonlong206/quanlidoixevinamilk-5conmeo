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
                case "hàng thường":
                    return 1;
                case "hàng nóng":
                    return 2;
                case "hàng lạnh":
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
                    return "hàng thường";
                case 2:
                    return "hàng nóng";
                case 3:
                    return "hàng lạnh";
                default:
                    return "erorr!";
            }
        }
    }
}
