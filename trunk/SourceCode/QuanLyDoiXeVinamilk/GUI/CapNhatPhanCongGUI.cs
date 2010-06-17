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
    public partial class frm_CapNhatPhanCong : Form
    {
        private bool blnCoTheLuu;
        private int iDongDuocChon;

        public frm_CapNhatPhanCong()
        {
            InitializeComponent();
            blnCoTheLuu = false;
            iDongDuocChon = 0;
        }

        private void btn_XemPhanCong_Click(object sender, EventArgs e)
        {
            bool blnTonTaiPhanCong = ShowMaster();
            if (blnTonTaiPhanCong == true)
            {
                // Load biển số xe và nhân viên lên CSDL
                DataTable DSXe = XeBUS.LayDanhSachXeCoThePhanCong();
                this.cbo_BienSoXe.DataSource = DSXe;
                this.cbo_BienSoXe.DisplayMember = "BienSo";
                this.cbo_BienSoXe.ValueMember = "BienSo";

                List<NhanVienDTO> DSNhanVien = NhanVienBUS.DocDanhSachNhanVien(String.Empty);
                this.cbo_TaiXe.DataSource = DSNhanVien;
                this.cbo_TaiXe.DisplayMember = "TenNhanVien";
                this.cbo_TaiXe.ValueMember = "MaNhanVien";
                this.cbo_TaiXe.Text = this.dtgv_ChiTietPhanCong.SelectedRows[0].Cells["TaiXe"].Value.ToString();
                blnCoTheLuu = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                int iMaChiTiet = int.Parse(this.dtgv_ChiTietPhanCong.Rows[iDongDuocChon].Tag.ToString());
                ChiTietPCXe_TaiXeDTO aChiTiet = new ChiTietPCXe_TaiXeDTO();
                aChiTiet.Ma = iMaChiTiet;
                aChiTiet.MaTaiXe = int.Parse(this.cbo_TaiXe.SelectedValue.ToString());
                aChiTiet.BienSoXe = this.cbo_BienSoXe.SelectedValue.ToString();
                aChiTiet.ThoiGianBatDau = this.dtp_ThoiGianBatDau.Text;
                aChiTiet.ThoiGianKetThuc = this.dtp_ThoiGianKetThuc.Text;

                bool blnCapNhatThanhCong = ChiTietPCXe_TaiXeBUS.CapNhatChiTiet(aChiTiet);
                if (blnCapNhatThanhCong == true)
                {
                    MessageBox.Show("Cập nhật thành công");
                    btn_Luu.Enabled = false;
                    ShowMaster();
                    blnCoTheLuu = true;
                    this.dtgv_ChiTietPhanCong.Refresh();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_CapNhatPhanCong_Load(object sender, EventArgs e)
        {
            DateTime tam = this.dtp_ThoiGianBatDau.Value;
            TimeSpan gio = tam.TimeOfDay;
            tam = tam.Subtract(gio);
            this.dtp_ThoiGianBatDau.Value = tam;

            gio = this.dtp_ThoiGianKetThuc.Value.TimeOfDay;
            tam = this.dtp_ThoiGianKetThuc.Value.Subtract(gio);
            this.dtp_ThoiGianKetThuc.Value = tam;
        }

        private void dtp_ThoiGianBatDau_ValueChanged(object sender, EventArgs e)
        {
            EnableBtnLuu();
        }

        private void dtp_ThoiGianKetThuc_ValueChanged(object sender, EventArgs e)
        {
            EnableBtnLuu();
        }

        private void EnableBtnLuu()
        {
            if (blnCoTheLuu == true && btn_Luu.Enabled == false)
            {
                btn_Luu.Enabled = true;
            }
        }

        private void cbo_BienSoXe_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableBtnLuu();
        }

        private void cbo_TaiXe_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableBtnLuu();
        }

        private void dtp_NgayPhanCong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btn_XemPhanCong_Click(null, null);
            }
        }

        private void dtgv_ChiTietPhanCong_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dtgv_ChiTietPhanCong.SelectedRows.Count > 0)
            {
                if (this.btn_Luu.Enabled == true)
                {
                    DialogResult LuaChon = MessageBox.Show("Dữ liệu đã bị thay đổi\r\nBạn có muốn lưu lại?", String.Empty,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (LuaChon == DialogResult.Yes)
                    {
                        this.btn_Luu_Click(sender, e);
                    }
                    else
                    {
                        btn_Luu.Enabled = false;
                    }
                }
                blnCoTheLuu = false;
                DataGridViewRow SelectedRow = this.dtgv_ChiTietPhanCong.SelectedRows[0];
                if (SelectedRow.Index != this.dtgv_ChiTietPhanCong.Rows.Count - 1)
                {
                    this.iDongDuocChon = SelectedRow.Index;

                    this.cbo_BienSoXe.Text = SelectedRow.Cells["BienSo"].Value.ToString();
                    this.cbo_TaiXe.Text = SelectedRow.Cells["TaiXe"].Value.ToString();

                    DateTime tam = new DateTime();
                    TimeSpan gio = this.dtp_ThoiGianBatDau.Value.TimeOfDay;
                    tam = this.dtp_ThoiGianBatDau.Value.Subtract(gio);
                    tam = tam.Add(TimeSpan.Parse(SelectedRow.Cells["ThoiGianBatDau"].Value.ToString()));
                    this.dtp_ThoiGianBatDau.Value = tam;

                    gio = this.dtp_ThoiGianKetThuc.Value.TimeOfDay;
                    tam = this.dtp_ThoiGianKetThuc.Value.Subtract(gio);
                    tam = tam.Add(TimeSpan.Parse(SelectedRow.Cells["ThoiGianKetThuc"].Value.ToString()));
                    this.dtp_ThoiGianKetThuc.Value = tam;
                    blnCoTheLuu = true;
                }
            }
        }

        private bool ShowMaster()
        {
            DateTime Temp = this.dtp_NgayPhanCong.Value;
            TimeSpan Gio = Temp.TimeOfDay;
            DateTime NgayPhanCong = Temp.Subtract(Gio);

            DataTable DanhSachPhanCong = PhanCongXeTaiXeBUS.LayChiTietPhanCongTheoNgay(NgayPhanCong);
            if (DanhSachPhanCong.Rows.Count == 0)
            {
                MessageBox.Show("Không có phân công của ngày này trong CSDL");
                return false;
            }
            else
            {
                this.dtgv_ChiTietPhanCong.AutoGenerateColumns = false;
                this.dtgv_ChiTietPhanCong.DataSource = DanhSachPhanCong;

                blnCoTheLuu = false;
                int iSoDong = this.dtgv_ChiTietPhanCong.Rows.Count - 1;
                for (int i = 0; i < iSoDong; i++)
                {
                    this.dtgv_ChiTietPhanCong.Rows[i].Tag = DanhSachPhanCong.Rows[i]["MaChiTiet"].ToString();
                }
                return true;
            }
        }
    }
}
