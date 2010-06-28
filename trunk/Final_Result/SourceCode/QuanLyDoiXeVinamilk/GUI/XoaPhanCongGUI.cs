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
    public partial class frm_XoaPhanCong : Form
    {
        private bool blnDaLoadDanhSachXong;
        private bool blnChonTatCa;
        public frm_XoaPhanCong()
        {
            InitializeComponent();
            blnDaLoadDanhSachXong = false;
            blnChonTatCa = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_XoaPhanCong_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable DanhSachNgayPhanCong = PhanCongXeTaiXeBUS.LayDanhSachNgayPhanCong();
                if (DanhSachNgayPhanCong.Rows.Count > 0)
                {
                    blnDaLoadDanhSachXong = false;
                    lst_DanhSachNgay.DataSource = DanhSachNgayPhanCong;
                    lst_DanhSachNgay.DisplayMember = "NgayPhanCong";
                    lst_DanhSachNgay.ValueMember = "MaPhanCong";
                    blnDaLoadDanhSachXong = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lst_DanhSachNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_DanhSachNgay.SelectedItems.Count > 0 && blnDaLoadDanhSachXong == true)
            {
                try
                {
                    int iMaPhanCong = int.Parse(this.lst_DanhSachNgay.SelectedValue.ToString());
                    DataTable DanhSachChiTiet = ChiTietPCXe_TaiXeBUS.LayDanhSachChiTietTheoMaPhanCong(iMaPhanCong);
                    if (DanhSachChiTiet.Rows.Count > 0)
                    {
                        this.dtgv_ChiTietPhanCong.AutoGenerateColumns = false;
                        this.dtgv_ChiTietPhanCong.DataSource = DanhSachChiTiet;

                        int iSoDong = DanhSachChiTiet.Rows.Count;
                        for (int i = 0; i < iSoDong; i++)
                        {
                            this.dtgv_ChiTietPhanCong.Rows[i].Tag = DanhSachChiTiet.Rows[i]["Ma"].ToString();
                            ((DataGridViewCheckBoxCell)this.dtgv_ChiTietPhanCong.Rows[i].Cells["Chon"]).TrueValue = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_BoChon_Click(object sender, EventArgs e)
        {
            int i = 0;
            int nRow = this.dtgv_ChiTietPhanCong.Rows.Count;
            if (nRow > 0)
            {
                if (blnChonTatCa == true)
                {
                    for (i = 0; i < nRow; i++)
                    {
                        this.dtgv_ChiTietPhanCong.Rows[i].Cells["Chon"].Value = false;
                    }
                    this.btn_BoChon.Text = "Chọn tất cả";
                    this.blnChonTatCa = false;
                }
                else
                {
                    for (i = 0; i < nRow; i++)
                    {
                        this.dtgv_ChiTietPhanCong.Rows[i].Cells["Chon"].Value = true;
                    }
                    this.btn_BoChon.Text = "Bỏ chọn tất cả";
                    this.blnChonTatCa = true;
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            List<int> lstCacDongDuocChon = new List<int>();
            int i;
            Chon.TrueValue = true;
            for (i = 0; i < this.dtgv_ChiTietPhanCong.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell CheckBoxCell = (DataGridViewCheckBoxCell)this.dtgv_ChiTietPhanCong.Rows[i].Cells["Chon"];
                if (CheckBoxCell.Value != null && CheckBoxCell.Value.ToString() == bool.TrueString)
                {
                    lstCacDongDuocChon.Add(i);
                }
            }

            bool blnDaXoaXong = true;

            if (lstCacDongDuocChon.Count > 0)
            {
                int iMaChiTiet;
                for (i = 0; i < lstCacDongDuocChon.Count; i++)
                {
                    iMaChiTiet = int.Parse(this.dtgv_ChiTietPhanCong.Rows[lstCacDongDuocChon[i]].Tag.ToString());
                    blnDaXoaXong &= ChiTietPCXe_TaiXeBUS.XoaChiTiet(iMaChiTiet);
                }

                if (blnDaXoaXong == true)
                {
                    MessageBox.Show("Đã xóa thành công");
                    for (i = 0; i < lstCacDongDuocChon.Count; i++)
                    {
                        this.dtgv_ChiTietPhanCong.Rows.RemoveAt(lstCacDongDuocChon[i]);
                    }
                }
                else 
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                DialogResult LuaChon = MessageBox.Show("Bạn chưa chọn chi tiết nào\r\nBạn có muốn xóa hết các chi tiết của ngày này?",
                    "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (LuaChon == DialogResult.Yes)
                {
                    this.btn_XoaTatCa_Click(null, null);
                }
            }
        }

        private void btn_XoaTatCa_Click(object sender, EventArgs e)
        {

        }
    }
}
