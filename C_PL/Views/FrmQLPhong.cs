using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class FrmQLPhong : Form
    {
        private IQLPhongTroService _iQLPhongTroService;
        private IQLChuTroService _iQLChuTroService;
        Guid _id;
        int _count = 0;
        public Guid _idChuTro { get; set; }
        public FrmQLPhong()
        {
            InitializeComponent();
            _iQLPhongTroService = new QLPhongTroService();
            _iQLChuTroService = new QLChuTroService();
        }

        private void LoadDGriView()
        {
            try
            {
                dtg_Show.Rows.Clear();

                foreach (var item in _iQLPhongTroService.GetAll(_idChuTro))
                {
                    dtg_Show.Rows.Add(item.Id,
                        item.MaPhong,
                        item.SoNguoi,
                        item.DienTich,
                        item.DiaChi,
                        item.DonGiaPhong,
                        item.TrangThai == 0 ? "Đã thuê" : "Còn trống");
                }
                var x = _iQLChuTroService.GetAll().FirstOrDefault(p => p.Id == _idChuTro);
                txt_DiaChi.Text = x.Diachi;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r = dtg_Show.Rows[e.RowIndex];
                    _id = Guid.Parse(r.Cells[0].Value.ToString());
                    var x = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
                    txt_MaPhong.Text = x.MaPhong;
                    txt_SoNguoi.Text = Convert.ToString(x.SoNguoi);
                    txt_DienTich.Text = Convert.ToString(x.DienTich);
                    txt_DiaChi.Text = x.DiaChi;
                    txt_Gia.Text = Convert.ToString(x.DonGiaPhong);
                    rd_DaThue.Checked = x.TrangThai == 0 ? true : false;
                    rd_ConTrong.Checked = x.TrangThai == 1 ? true : false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private PhongTroView GetDataFromGui()
        {
            PhongTroView v = new PhongTroView();
            v.ChuTroId = _idChuTro;
            v.MaPhong = txt_MaPhong.Text;
            v.SoNguoi = Convert.ToInt32(txt_SoNguoi.Text);
            v.DienTich = Convert.ToDouble(txt_DienTich.Text);
            v.DiaChi = txt_DiaChi.Text;
            v.DonGiaPhong = Convert.ToDouble(txt_Gia.Text);
            v.TrangThai = rd_DaThue.Checked == true ? 0 : 1;
            return v;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var x = _iQLChuTroService.GetAll().FirstOrDefault(p => p.Id == _idChuTro);
            txt_DiaChi.Text = x.Diachi;
            txt_MaPhong.Text = "";
            txt_SoNguoi.Text = "";
            txt_DienTich.Text = "";
            txt_Gia.Text = "";
            rd_DaThue.Checked = false;
            rd_ConTrong.Checked = false;
            txt_SoNguoi.Enabled = true;
            txt_DienTich.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_Gia.Enabled = true;
            rd_DaThue.Enabled = true;
            rd_ConTrong.Enabled = true;
            _count = 1;
        }

        private PhongTroView UpdateDataFromGui()
        {
            var x = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
            x.MaPhong = txt_MaPhong.Text;
            x.SoNguoi = Convert.ToInt32(txt_SoNguoi.Text);
            x.DienTich = Convert.ToDouble(txt_DienTich.Text);
            x.DiaChi = txt_DiaChi.Text;
            x.DonGiaPhong = Convert.ToDouble(txt_Gia.Text);
            x.TrangThai = rd_DaThue.Checked == true ? 0 : 1;
            return x;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            txt_SoNguoi.Enabled = true;
            txt_DienTich.Enabled = true;
            txt_DiaChi.Enabled = true;
            txt_Gia.Enabled = true;
            rd_DaThue.Enabled = true;
            rd_ConTrong.Enabled = true;
            var x = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
            if (x == null)
                MessageBox.Show("Phòng không tồn tại", "Message");
            else
                _count = 2;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xóa phòng?", "Message", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    _iQLPhongTroService.Delete(_id);
                    LoadDGriView();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_count == 1)
                {
                    if (txt_MaPhong.Text == "" || txt_SoNguoi.Text == "" || txt_DienTich.Text == "" || txt_DiaChi.Text == "" || txt_Gia.Text == "" || (rd_DaThue.Checked == true && rd_ConTrong.Checked == true))
                        MessageBox.Show("Không được để trống thông tin", "Message");
                    else if (_iQLPhongTroService.GetAll(_idChuTro).Any(p => p.MaPhong == txt_MaPhong.Text))
                        MessageBox.Show("Phòng đã tồn tại", "Message");
                    else
                    {
                        _iQLPhongTroService.Add(GetDataFromGui());
                    }
                }
                else if (_count == 2)
                {
                    if (txt_MaPhong.Text == "" || txt_SoNguoi.Text == "" || txt_DienTich.Text == "" || txt_DiaChi.Text == "" || txt_Gia.Text == "" || (rd_DaThue.Checked == true && rd_ConTrong.Checked == true))
                        MessageBox.Show("Không được để trống thông tin", "Message");
                    else
                    {
                        _iQLPhongTroService.Update(UpdateDataFromGui());
                    }
                }
                LoadDGriView();
                txt_SoNguoi.Enabled = false;
                txt_DienTich.Enabled = false;
                txt_DiaChi.Enabled = false;
                txt_Gia.Enabled = false;
                rd_DaThue.Enabled = false;
                rd_ConTrong.Enabled = false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            try
            {
                var x = _iQLPhongTroService.GetAll(_idChuTro).Where(p => p.MaPhong.Contains(txt_MaPhong.Text));
                if (txt_MaPhong.Text == "")
                {
                    MessageBox.Show("Nhập mã trước", "Message");
                }
                else if (x == null)
                {
                    MessageBox.Show("Phòng không tồn tại", "Message");
                }
                else
                {
                    dtg_Show.Rows.Clear();

                    foreach (var item in x)
                    {
                        dtg_Show.Rows.Add(item.Id,
                            item.MaPhong,
                            item.SoNguoi,
                            item.DienTich,
                            item.DiaChi,
                            item.DonGiaPhong,
                            item.TrangThai == 0 ? "Đã thuê" : "Còn trống");
                        txt_SoNguoi.Text = Convert.ToString(item.SoNguoi);
                        txt_DienTich.Text = Convert.ToString(item.DienTich);
                        txt_DiaChi.Text = item.DiaChi;
                        txt_Gia.Text = Convert.ToString(item.DonGiaPhong);
                        rd_DaThue.Checked = item.TrangThai == 0 ? true : false;
                        rd_ConTrong.Checked = item.TrangThai == 1 ? true : false;
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void txt_SoNguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_Gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_DienTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FrmQLPhong_Load(object sender, EventArgs e)
        {
            LoadDGriView();
        }

        private void txt_SoNguoi_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoNguoi.Text == "0")
                rd_ConTrong.Checked = true;
            else
                rd_DaThue.Checked = true;
        }
    }
}
