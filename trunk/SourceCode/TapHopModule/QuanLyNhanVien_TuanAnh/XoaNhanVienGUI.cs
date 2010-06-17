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
    public partial class XoaNhanVienGUI : Form
    {
        public XoaNhanVienGUI()
        {
            InitializeComponent();
        }

        private void XoaNhanVienGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<NhanVienDTO> lstNV = NhanVienBUS.DocDanhSachNhanVien(String.Empty);
                XuatDanhSachNV(lstNV);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
        private void XuatDanhSachNV(List<NhanVienDTO> lstNV)
        {
            if (lstNV == null)
                return;     //khong lam gi ca.
            
            int nSoThuTu = 1;
            lsv_DanhSachNhanVien.Items.Clear();
          
            foreach (NhanVienDTO aNV in lstNV)
            {
                lsv_DanhSachNhanVien.Items.Add(TheHienListItem(nSoThuTu,aNV));
                
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, NhanVienDTO aNV)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aNV.TenNhanVien);
            itemKetQua.SubItems.Add(aNV.SoDienThoai.ToString());
            itemKetQua.Tag = aNV;

            return itemKetQua;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(lsv_DanhSachNhanVien.CheckedItems.Count >0)
            
            {
                try
                {
                    foreach (ListViewItem itemNV in lsv_DanhSachNhanVien.CheckedItems)
                    {
                        NhanVienDTO NV = (NhanVienDTO)itemNV.Tag;
                       
                        if (NhanVienBUS.XoaNhanVien(NV))
                        {
                            lsv_DanhSachNhanVien.Items.Remove(itemNV);
                            

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

        private void lsv_DanhSachNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsv_DanhSachNhanVien.SelectedItems.Count>0)
         
            {
                ListViewItem itemNV = lsv_DanhSachNhanVien.SelectedItems[0];
                NhanVienDTO aNV = (NhanVienDTO)itemNV.Tag;
                
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
       
       
       
     


        

     
     
      
    }
}
