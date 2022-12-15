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
    public partial class FrmQLKhachHang : Form
    {
        private IQLKhachHangService _iQLKhachHangService;
        private IQLHopDongService _iQLHopDongService;
        private IQLCTHopDongService _iQLCTHopDongService;
        private IQLPhongTroService _iQLPhongTroService;
        Guid _id;
        int _count = 0;
        public Guid _idChuTro { get; set; }
        public FrmQLKhachHang()
        {
            InitializeComponent();
            _iQLKhachHangService = new QLKhachHangService();
            _iQLHopDongService = new QLHopDongService();
            _iQLCTHopDongService = new QLCTHopDongService();
            _iQLPhongTroService = new QLPhongTroService();
        }

        private void LoadCBB()
        {
            cbb_MaHopDong.Items.Clear();
            foreach (var item in _iQLHopDongService.GetAll(_idChuTro))
            {
                cbb_MaHopDong.Items.Add(item.MaHopDong);
            }
        }

        private void LoadDGriView()
        {
            try
            {
                dtg_Show.Rows.Clear();

                foreach (var item in _iQLKhachHangService.GetAll(_idChuTro))
                {
                    dtg_Show.Rows.Add(item.KhachHang.Id,
                        item.KhachHang.Ten,
                        item.HopDong.MaHopDong,
                        item.KhachHang.GioiTinh == 0 ? "Nam" : "Nữ",
                        item.KhachHang.Sdt,
                        item.KhachHang.Email,
                        item.KhachHang.Quequan,
                        item.KhachHang.CMND);
                }
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
                    var x = _iQLKhachHangService.GetAll(_idChuTro).FirstOrDefault(p => p.KhachHang.Id == _id);
                    txt_Ten.Text = x.KhachHang.Ten;
                    cbb_MaHopDong.Text = x.HopDong.MaHopDong;
                    rd_Nam.Checked = x.KhachHang.GioiTinh == 0 ? true : false;
                    rd_Nu.Checked = x.KhachHang.GioiTinh == 1 ? true : false;
                    txt_Sdt.Text = x.KhachHang.Sdt;
                    txt_Email.Text = x.KhachHang.Email;
                    txt_Quequan.Text = x.KhachHang.Quequan;
                    txt_CMND.Text = x.KhachHang.CMND;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private CreateKhachHangView GetDataFromGui()
        {
            var x = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.MaHopDong == cbb_MaHopDong.Text);
            CreateKhachHangView v = new CreateKhachHangView()
            {
                HopDongId = x.Id,
                Ten = txt_Ten.Text,
                GioiTinh = rd_Nam.Checked ? 0 : 1,
                Sdt = txt_Sdt.Text,
                Email = txt_Email.Text,
                Quequan = txt_Quequan.Text,
                CMND = txt_CMND.Text
            };
            return v;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_Ten.Text = "";
            cbb_MaHopDong.Text = "";
            rd_Nam.Checked = false;
            rd_Nu.Checked = false;
            txt_Sdt.Text = "";
            txt_Email.Text = "";
            txt_Quequan.Text = "";
            txt_CMND.Text = "";
            cbb_MaHopDong.Enabled = true;
            rd_Nam.Enabled = true;
            rd_Nu.Enabled = true;
            txt_Sdt.Enabled = true;
            txt_Email.Enabled = true;
            txt_Quequan.Enabled = true;
            txt_CMND.Enabled = true;
            _count = 1;
        }

        private UpdateKhachHangView UpdateDataFromGui()
        {
            var a = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.MaHopDong == cbb_MaHopDong.Text);
            var x = _iQLKhachHangService.GetAll(_idChuTro).FirstOrDefault(p => p.KhachHang.Id == _id);
            UpdateKhachHangView v = new UpdateKhachHangView()
            {
                Id = x.KhachHang.Id,
                HopDongId = a.Id,
                Ten = txt_Ten.Text,
                GioiTinh = rd_Nam.Checked ? 0 : 1,
                Sdt = txt_Sdt.Text,
                Email = txt_Email.Text,
                Quequan = txt_Quequan.Text,
                CMND = txt_CMND.Text
            };
            return v;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            cbb_MaHopDong.Enabled = true;
            rd_Nam.Enabled = true;
            rd_Nu.Enabled = true;
            txt_Sdt.Enabled = true;
            txt_Email.Enabled = true;
            txt_Quequan.Enabled = true;
            txt_CMND.Enabled = true;
            var x = _iQLKhachHangService.GetAll(_idChuTro).FirstOrDefault(p => p.KhachHang.Id == _id);
            if (x == null)
                MessageBox.Show("Khách hàng không tồn tại", "Message");
            else
                _count = 2;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xóa khách hàng?", "Message", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    _iQLKhachHangService.Delete(_id);
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
                    if (txt_Ten.Text == "" || cbb_MaHopDong.Text == "" || txt_Sdt.Text == "" || txt_Email.Text == "" || txt_Quequan.Text == "" || txt_CMND.Text == "" || (rd_Nam.Checked == true && rd_Nu.Checked == true))
                        MessageBox.Show("Không được để trống thông tin", "Message");
                    else if (_iQLKhachHangService.GetAll(_idChuTro).Any(p => p.KhachHang.Ten == txt_Ten.Text))
                        MessageBox.Show("Khách hàng đã tồn tại", "Message");
                    else
                    {
                        _iQLKhachHangService.Add(GetDataFromGui());
                        var a = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.MaHopDong == cbb_MaHopDong.Text);
                        var b = _iQLCTHopDongService.GetAll(a.Id).FirstOrDefault(p => p.CTHopDong.HopDongId == a.Id);
                        var c = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == b.CTHopDong.PhongTroId);
                        c.SoNguoi++;
                        _iQLPhongTroService.Update(c);
                        LoadDGriView();
                    }
                }
                else if (_count == 2)
                {
                    if (txt_Ten.Text == "" || cbb_MaHopDong.Text == "" || txt_Sdt.Text == "" || txt_Email.Text == "" || txt_Quequan.Text == "" || txt_CMND.Text == "" || (rd_Nam.Checked == true && rd_Nu.Checked == true))
                        MessageBox.Show("Không được để trống thông tin", "Message");
                    else
                    {
                        var x = _iQLKhachHangService.GetAll(_idChuTro).FirstOrDefault(p => p.KhachHang.Id == _id);
                        var a = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.MaHopDong == cbb_MaHopDong.Text);
                        if (x.KhachHang.HopDongId != a.Id)
                        {
                            var b = _iQLCTHopDongService.GetAll(a.Id).FirstOrDefault(p => p.CTHopDong.HopDongId == a.Id);
                            var c = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == b.CTHopDong.PhongTroId);
                            c.SoNguoi++;
                            _iQLPhongTroService.Update(c);

                            var d = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == x.KhachHang.HopDongId);
                            var f = _iQLCTHopDongService.GetAll(d.Id).FirstOrDefault(p => p.CTHopDong.HopDongId == d.Id);
                            var g = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == f.CTHopDong.PhongTroId);
                            g.SoNguoi--;
                            _iQLPhongTroService.Update(g);
                        }
                        _iQLKhachHangService.Update(UpdateDataFromGui());
                        LoadDGriView();
                    }
                }
                rd_Nam.Enabled = false;
                rd_Nu.Enabled = false;
                txt_Sdt.Enabled = false;
                txt_Email.Enabled = false;
                txt_Quequan.Enabled = false;
                txt_CMND.Enabled = false;
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
                var x = _iQLKhachHangService.GetAll(_idChuTro).Where(p => p.KhachHang.Ten.Contains(txt_Ten.Text));
                if (x == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại", "Message");
                }
                else
                {
                    dtg_Show.Rows.Clear();

                    foreach (var item in x)
                    {
                        dtg_Show.Rows.Add(item.KhachHang.Id,
                            item.KhachHang.Ten,
                            item.HopDong.MaHopDong,
                            item.KhachHang.GioiTinh == 0 ? "Nam" : "Nữ",
                            item.KhachHang.Sdt,
                            item.KhachHang.Email,
                            item.KhachHang.Quequan,
                            item.KhachHang.CMND);
                        cbb_MaHopDong.Text = item.HopDong.MaHopDong;
                        txt_Sdt.Text = item.KhachHang.Sdt;
                        txt_Email.Text = item.KhachHang.Email;
                        txt_Quequan.Text = item.KhachHang.Quequan;
                        txt_CMND.Text = item.KhachHang.CMND;
                        rd_Nam.Checked = item.KhachHang.GioiTinh == 0 ? true : false;
                        rd_Nu.Checked = item.KhachHang.GioiTinh == 1 ? true : false;
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void FrmQLKhachHang_Load(object sender, EventArgs e)
        {
            LoadCBB();
            LoadDGriView();
        }
    }
}
