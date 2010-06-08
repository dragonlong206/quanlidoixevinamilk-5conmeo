using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;


namespace GUI
{
    public partial class frm_QuanLyHangXe : Form
    {
        public frm_QuanLyHangXe()
        {
            InitializeComponent();
        }

        private void frm_QuanLyHangXe_Load(object sender, EventArgs e)
        {
           try
            {
                List<HangXeDTO> listHangXe = HangXeBUS.LayDanhSachTatCaCacHangXe();
                XuatDanhSachHangXe(listHangXe);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
      

        private void XuatDanhSachHangXe(List<HangXeDTO> listHangXe)
        {
            
            HangXeDTO hx = listHangXe[0];
            if (hx != null)
            {
                XuatChiTietHangXe(hx);
            }            
            lv_DanhSachHangXe.Items.Clear();
            foreach (HangXeDTO HangXeTam in listHangXe)
            {
                lv_DanhSachHangXe.Items.Add(TheHienListItem(HangXeTam));
            }
        }

        private ListViewItem TheHienListItem(HangXeDTO hx)
        {
            ListViewItem itemKetQua = new ListViewItem(hx.MaHang.ToString());
            itemKetQua.SubItems.Add(hx.TenHang);
            itemKetQua.Tag = hx;
            return itemKetQua;
        }
        private void XuatChiTietHangXe(HangXeDTO hx)
        {
            txb_MaHang.Text = hx.MaHang.ToString();
            txb_HangXe.Text = hx.TenHang;
           
        }
       private void lv_DanhSachHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_DanhSachHangXe.SelectedItems.Count>0)
            {
                ListViewItem itemHangXe =lv_DanhSachHangXe.SelectedItems[0];
                HangXeDTO hx =(HangXeDTO) itemHangXe.Tag;
                XuatChiTietHangXe(hx);
            }
        
        }


    

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lv_DanhSachHangXe.CheckedItems.Count>0)
    
            {
                try
                {
                    foreach (ListViewItem itemHangXe in lv_DanhSachHangXe.CheckedItems)
                    {
                        HangXeDTO HangXe =(HangXeDTO) itemHangXe.Tag;
                        if (HangXeBUS.XoaHangXeBUS(HangXe))
                        {
                            lv_DanhSachHangXe.Items.Remove(itemHangXe);
                          
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chua co hang xe nao duoc chon");
            }
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHangXe_Click(object sender, EventArgs e)
        {
            try
            {

                HangXeDTO hx = new HangXeDTO();
                hx.MaHang = int.Parse(this.txb_MaHang.Text.ToString());
                hx.TenHang = this.txb_HangXe.Text;


                bool result = HangXeBUS.ThemHangXeBus(hx);
                if (result == true)
                {
                    MessageBox.Show("Successful!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // this.ShowMaster();
                }
                else
                {
                    MessageBox.Show("Fail!\r\nChoose new EmployeeID,Please!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Chua co hang xe nao duoc them");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
               HangXeDTO hx = new HangXeDTO();

               hx.MaHang =int.Parse(this.txb_MaHang.Text.ToString());
               hx.TenHang = this.txb_HangXe.Text;
              
                bool result =HangXeBUS.CapNhatHangXe(hx);
                if (result == true)
                {
                    MessageBox.Show("Successful!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  //  this.ShowMaster();
                }
                else
                {
                    MessageBox.Show("Fail!\r\nCheck EmployeeID,Please!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }
            catch
            {
                MessageBox.Show("Chua co hang xe nao duoc sửa");
            }
            


        }
        
    }
}
