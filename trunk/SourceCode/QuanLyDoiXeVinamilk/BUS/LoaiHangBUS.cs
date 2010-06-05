using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class LoaiHangBUS
    {
        //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
        public static int GetMaLoaiHang(String strLoaiHang)
        {
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
    }
}
