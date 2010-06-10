using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;


namespace GUI
{
    public partial class NhapMatHangFrm : Form
    {
        public NhapMatHangFrm()
        {
            InitializeComponent();
        }

        private void NhapMatHangFrm_Load(object sender, EventArgs e)
        {

        }

        private MatHangDTO NhapMatHang()
        {
            MatHangDTO aMH = new MatHangDTO();

            #region Gan gia tri tu giao dien vao aXe
            aMH.TenMatHang = txt_TenNhanVien.Text;
            aMH.SoLuong = int.Parse(txt_SoLuong.Text);
            aMH.DonViTinh = textBox1.Text;
            aMH.MaLoai = this.comboBox1.SelectedIndex;           
            #endregion

            return aMH;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            MatHangDTO aMH = NhapMatHang();
            try
            {

                Boolean blnDaThemDuoc = MatHangBUS.ThemMatHang(aMH);
                if (blnDaThemDuoc == true)
                {
                    MessageBox.Show("Thêm mặt hàng thành công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }

      

        

    

}
