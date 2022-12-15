using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class FrmQLThanhToan : Form
    {
        private IQLHopDongService _iQLHopDongService;
        private IQLCTHopDongService _iQLCTHopDongService;
        private IQLPhongTroService _iQLPhongTroService;
        private IQLDichVuService _iQLDichVuService;
        private IQLKhachHangService _iQLKhachHangService;
        private List<DichVuView> _lstDichVu;
        Guid _id;
        double _gia = 0;
        double _giaPhong = 0;
        int _dem = 0;
        string _dv = "";
        public Guid _idChuTro { get; set; }
        public FrmQLThanhToan()
        {
            InitializeComponent();
            _iQLHopDongService = new QLHopDongService();
            _iQLCTHopDongService = new QLCTHopDongService();
            _iQLPhongTroService = new QLPhongTroService();
            _iQLDichVuService = new QLDichVuService();
            _iQLKhachHangService = new QLKhachHangService();
            _lstDichVu = new List<DichVuView>();
        }

        private void loadCBB()
        {
            cbb_MaHopDong.Items.Clear();
            cbb_MaPhong.Items.Clear();
            cbb_DichVu.Items.Clear();
            foreach (var item in _iQLHopDongService.GetAll(_idChuTro).Where(p => p.TrangThai == 1))
            {
                cbb_MaHopDong.Items.Add(item.MaHopDong);
            }
            foreach (var item in _iQLPhongTroService.GetAll(_idChuTro))
            {
                cbb_MaPhong.Items.Add(item.MaPhong);
            }
            foreach (var item in _iQLDichVuService.GetAll(_idChuTro))
            {
                cbb_DichVu.Items.Add(item.Ten);
            }
        }

        private void LoadDGriViewHD()
        {
            dtg_Showhd.Rows.Clear();

            var x = _iQLHopDongService.GetAll(_idChuTro);
            foreach (var item in x)
            {
                if (DateTime.Compare(DateTime.Now, item.NgayThanhToan) > 30)
                {
                    item.TrangThai = 1;
                    _iQLHopDongService.Update(item);
                }
            }
            foreach (var item in _iQLHopDongService.GetAll(_idChuTro))
            {
                dtg_Showhd.Rows.Add(item.Id,
                    item.MaHopDong,
                    item.NgayTao,
                    item.NgayThanhToan,
                    item.TongTien,
                    item.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }

        private void LoadDGriViewHDCho()
        {
            dtg_Showhdcho.Rows.Clear();

            var x = _iQLHopDongService.GetAll(_idChuTro);
            foreach (var g in x)
            {
                var hdCho = (from a in _iQLHopDongService.GetAll(_idChuTro)
                             join b in _iQLCTHopDongService.GetAll(g.Id) on a.Id equals b.CTHopDong.HopDongId
                             join c in _iQLPhongTroService.GetAll(_idChuTro) on b.CTHopDong.PhongTroId equals c.Id
                             where a.TrangThai == 1
                             select new { a, c }).Distinct();
                foreach (var item in hdCho)
                {
                    dtg_Showhdcho.Rows.Add(item.a.Id, item.a.MaHopDong, item.c.MaPhong);
                }
            }
        }

        private void LoadDGriViewDSHD()
        {
            dtg_Showdshd.Rows.Clear();

            foreach (var item in _iQLPhongTroService.GetAll(_idChuTro).Where(x => x.TrangThai == 1))
            {
                dtg_Showdshd.Rows.Add(item.Id,
                    item.MaPhong,
                    item.DienTich,
                    item.DiaChi,
                    item.DonGiaPhong,
                    item.TrangThai == 0 ? "Đã thuê" : "Còn trống");
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            dtg_Showdshd.Rows.Clear();

            foreach (var item in _iQLPhongTroService.GetAll(_idChuTro).Where(x => x.MaPhong.ToLower().Contains(txt_Findma.Text.ToLower()) && x.TrangThai == 1))
            {
                dtg_Showdshd.Rows.Add(item.Id,
                    item.MaPhong,
                    item.DienTich,
                    item.DiaChi,
                    item.DonGiaPhong,
                    item.TrangThai == 0 ? "Đã thuê" : "Còn trống");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _dem = 1;
            _lstDichVu.Clear();
            _gia = 0;
            _giaPhong = 0;
            _dv = "";
            txt_Cdv.Text = "";
            txt_Ma.Enabled = true;
            cbb_MaPhong.Enabled = true;
            cbb_DichVu.Enabled = true;
            cbb_TT.Enabled = true;
            btn_Adddv.Enabled = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            _dem = 2;
            txt_Ma.Enabled = true;
            cbb_MaPhong.Enabled = true;
            cbb_DichVu.Enabled = true;
            cbb_TT.Enabled = true;
            btn_Adddv.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Hủy hợp đồng?", "Message", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    var a = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(x => x.Id == _id);
                    var b = _iQLCTHopDongService.GetAll(a.Id);
                    var c = _iQLKhachHangService.GetAll(_idChuTro).Where(x => x.KhachHang.HopDongId == _id);
                    if (a == null)
                    {
                        MessageBox.Show("Phải chọn hợp đồng trước", "Message");
                    }
                    else
                    {
                        foreach (var item in c)
                        {
                            _iQLKhachHangService.Delete(item.KhachHang.Id);
                        }
                        foreach (var item in b)
                        {
                            var d = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(x => x.Id == item.CTHopDong.PhongTroId);
                            d.TrangThai = 1;
                            _iQLPhongTroService.Update(d);
                            _iQLCTHopDongService.Delete(item.CTHopDong.Id);
                        }
                        _iQLHopDongService.Delete(a.Id);
                        LoadDGriViewHD();
                        LoadDGriViewHDCho();
                        LoadDGriViewDSHD();
                        loadCBB();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                var x = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
                if (cbb_TrangThai.Text == "Trả phòng")
                {
                    var a = _iQLKhachHangService.GetAll(_idChuTro).Where(p => p.HopDong.Id == _id);
                    foreach (var item in a)
                    {
                        _iQLKhachHangService.Delete(item.KhachHang.Id);
                    }
                    var b = _iQLCTHopDongService.GetAll(x.Id);
                    foreach (var item in b)
                    {
                        var c = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == item.PhongTro.Id);
                        c.TrangThai = 1;
                        _iQLPhongTroService.Update(c);
                        _iQLCTHopDongService.Delete(item.HopDong.Id);
                    }
                    _iQLHopDongService.Delete(x.Id);
                }
                else
                {
                    x.NgayThanhToan = DateTime.Now;
                    x.TrangThai = 0;
                    _iQLHopDongService.Update(x);
                }
                MessageBox.Show("Thanh toán thành công", "Message");
                cbb_MaHopDong.Text = "";
                lb_Tongtien.Text = "0";
                cbb_TrangThai.Text = "";
                LoadDGriViewHD();
                LoadDGriViewHDCho();
                LoadDGriViewDSHD();
                loadCBB();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void FrmQLThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDGriViewHD();
                LoadDGriViewHDCho();
                LoadDGriViewDSHD();
                loadCBB();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dtg_Showhdcho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r = dtg_Showhdcho.Rows[e.RowIndex];
                    _id = Guid.Parse(r.Cells[0].Value.ToString());
                    var x = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
                    cbb_MaHopDong.Text = r.Cells[1].Value.ToString();
                    lb_Tongtien.Text = x.TongTien.ToString();
                    cbb_TrangThai.Text = x.TrangThai == 0 ? "Thuê tiếp" : "Trả phòng";
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dtg_Showhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    _lstDichVu.Clear();
                    _dv = "";
                    txt_Cdv.Text = "";
                    DataGridViewRow r = new DataGridViewRow();
                    r = dtg_Showhd.Rows[e.RowIndex];
                    _id = Guid.Parse(r.Cells[0].Value.ToString());
                    txt_Ma.Text = r.Cells[1].Value.ToString();
                    var a = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
                    var b = _iQLCTHopDongService.GetAll(a.Id);
                    foreach (var item in b)
                    {
                        var c = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == item.CTHopDong.PhongTroId);
                        cbb_MaPhong.Text = c.MaPhong;
                        var x = _iQLDichVuService.GetAll(_idChuTro).Where(p => p.Id == item.CTHopDong.DichVuId);
                        _lstDichVu.AddRange(x);
                    }
                    cbb_TT.Text = a.TrangThai == 0 ? "Đã thanh toán" : "Chưa thanh toán";
                    lb_Tong.Text = a.TongTien.ToString();
                    foreach (var item in _lstDichVu)
                        _dv += item.Ten + ", ";
                    txt_Cdv.Text = _dv;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void cbb_MaPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            var a = _iQLPhongTroService.GetAll(_idChuTro).Where(p => p.MaPhong.Contains(cbb_MaPhong.Text));
            foreach (var item in a)
            {
                _giaPhong = item.DonGiaPhong;
            }
            lb_Tong.Text = (_giaPhong + _gia).ToString();
        }

        private void GetDataFromGui()
        {
            HopDongView v = new HopDongView()
            {
                Id = Guid.NewGuid(),
                ChuTroId = _idChuTro,
                MaHopDong = txt_Ma.Text,
                NgayTao = DateTime.Now,
                NgayThanhToan = DateTime.Now.AddDays(30),
                TongTien = _giaPhong + _gia,
                TrangThai = cbb_TT.Text == "Đã thanh toán" ? 0 : 1
            };
            _iQLHopDongService.Add(v);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dem == 1)
                {
                    GetDataFromGui();
                    var v = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.MaHopDong == txt_Ma.Text);
                    var a = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.MaPhong == cbb_MaPhong.Text);
                    a.TrangThai = 0;
                    _iQLPhongTroService.Update(a);
                    foreach (var item in _lstDichVu)
                    {
                        CreateCTHopDongView x = new CreateCTHopDongView()
                        {
                            HopDongId = v.Id,
                            PhongTroId = a.Id,
                            DichVuId = item.Id
                        };
                        _iQLCTHopDongService.Add(x);
                    }
                }
                else if (_dem == 2)
                {
                    var order = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
                    var odd = _iQLCTHopDongService.GetAll(order.Id);
                    foreach (var item in odd)
                    {
                        _iQLCTHopDongService.Delete(item.CTHopDong.Id);
                    }
                    var a = _iQLPhongTroService.GetAll(_idChuTro).FirstOrDefault(p => p.MaPhong == cbb_MaPhong.Text);
                    a.TrangThai = 0;
                    _iQLPhongTroService.Update(a);
                    foreach (var items in _lstDichVu)
                    {
                        CreateCTHopDongView x = new CreateCTHopDongView()
                        {
                            HopDongId = _id,
                            PhongTroId = a.Id,
                            DichVuId = items.Id
                        };
                        _iQLCTHopDongService.Add(x);
                    }
                    order.MaHopDong = txt_Ma.Text;
                    order.TongTien = _giaPhong + _gia;
                    order.TrangThai = cbb_TT.Text == "Đã thanh toán" ? 0 : 1;
                    _iQLHopDongService.Update(order);
                }
                LoadDGriViewHD();
                LoadDGriViewDSHD();
                LoadDGriViewHDCho();
                loadCBB();
                _lstDichVu.Clear();
                _gia = 0;
                _giaPhong = 0;
                _dv = "";
                txt_Cdv.Text = "";
                txt_Ma.Enabled = false;
                cbb_MaPhong.Enabled = false;
                cbb_DichVu.Enabled = false;
                cbb_TT.Enabled = false;
                btn_Adddv.Enabled = false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /*private void btn_Removedv_Click(object sender, EventArgs e)
        {
            try
            {
                if (_count > 0)
                {
                    var x = _iQLDichVuService.GetAll(_idChuTro).FirstOrDefault(p => p.Ten.ToLower() == cbb_DichVu.Text.ToLower());
                    if (x != null)
                    {
                        string[] a = _dv.Split(", ");
                        List<DichVuView> b = new List<DichVuView>();
                        for (int i = 0; i < _count; i++)
                        {
                            if (a[i] == x.Ten)
                            {
                                var c = _iQLDichVuService.GetAll(_idChuTro).FirstOrDefault(p => p.Ten == a[i]);
                                DichVuView d = new DichVuView()
                                {
                                    Id = c.Id,
                                    ChuTroId = c.ChuTroId,
                                    Ten = c.Ten,
                                    DonGia = c.DonGia
                                };
                                b.Add(d);
                            }
                        }
                        _lstDichVu.Clear();
                        _lstDichVu.AddRange(b);
                        _dv = "";
                        _count--;
                        _gia -= x.DonGia;
                        foreach (var item in _lstDichVu)
                            _dv += item.Ten + ", ";
                        txt_Sodv.Text = _count.ToString() + " : " + _dv;
                        lb_Tong.Text = (_giaPhong + _gia).ToString();
                    }
                    else
                        MessageBox.Show("Chọn dịch vụ trước", "Message");
                }
                else
                {
                    _dv = "";
                    _lstDichVu.Clear();
                    txt_Sodv.Text = "0";
                    lb_Tong.Text = "0";
                    _gia = 0;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }*/

        private void btn_Adddv_Click(object sender, EventArgs e)
        {
            try
            {
                var x = _iQLDichVuService.GetAll(_idChuTro).FirstOrDefault(p => p.Ten == cbb_DichVu.Text);
                if (x != null)
                {
                    _dv = "";
                    _gia += x.DonGia;
                    _lstDichVu.Add(x);
                    foreach (var item in _lstDichVu)
                        _dv += item.Ten + ", ";
                    txt_Cdv.Text = _dv;
                    lb_Tong.Text = (_giaPhong + _gia).ToString();
                }
                else
                    MessageBox.Show("Chọn dịch vụ trước", "Message");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dtg_Showdshd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r = dtg_Showdshd.Rows[e.RowIndex];
                    cbb_MaPhong.Text = r.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
