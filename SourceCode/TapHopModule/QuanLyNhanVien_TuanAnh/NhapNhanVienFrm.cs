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
    public partial class NhapNhanVienFrm : Form
    {
        public NhapNhanVienFrm()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {

                NhanVienDTO nv = new NhanVienDTO();
                nv.TenNhanVien = this.txt_TenNhanVien.Text;
                nv.SoDienThoai = int.Parse(this.txt_SoDienThoai.Text.ToString());
              

                bool result =NhanVienBUS.ThemNhanVien(nv);
                if (result == true)
                {
                    MessageBox.Show("Successful!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        }
    }

