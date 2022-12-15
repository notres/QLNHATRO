using B_BUS.IServices;
using B_BUS.Services;
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
    public partial class FrmQLHopDong : Form
    {
        private IQLHopDongService _iQLHopDongService;
        private IQLCTHopDongService _iQLCTHopDongService;
        private IQLKhachHangService _iQLKhachHangService;
        public Guid _id;
        public Guid _idChuTro { get; set; }
        public FrmQLHopDong()
        {
            InitializeComponent();
            _iQLHopDongService = new QLHopDongService();
            _iQLCTHopDongService = new QLCTHopDongService();
            _iQLKhachHangService = new QLKhachHangService();
        }

        private void LoadDGriViewHoaDon()
        {
            try
            {
                dtg_HoaDon.Rows.Clear();

                foreach (var item in _iQLHopDongService.GetAll(_idChuTro))
                {
                    dtg_HoaDon.Rows.Add(item.Id,
                        item.MaHopDong,
                        item.NgayTao,
                        item.TongTien,
                        item.TrangThai == 0 ? "Đã thanh toán" : "Chờ thanh toán");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void LoadDGriViewCTHoaDon(Guid id)
        {
            try
            {
                dtg_CTHoaDon.Rows.Clear();

                foreach (var item in _iQLCTHopDongService.GetAll(id))
                {
                    dtg_CTHoaDon.Rows.Add(item.CTHopDong.Id,
                        item.PhongTro.MaPhong,
                        item.DichVu.Ten);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dtg_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r = dtg_HoaDon.Rows[e.RowIndex];
                    _id = Guid.Parse(r.Cells[0].Value.ToString());
                    LoadDGriViewCTHoaDon(_id);
                }
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
                dtg_HoaDon.Rows.Clear();
                dtg_CTHoaDon.Rows.Clear();
                if (txt_MaHopDong.Text != "")
                {
                    var x = _iQLHopDongService.GetAll(_idChuTro).Where(p => p.MaHopDong.Contains(txt_MaHopDong.Text));
                    if (x == null)
                        MessageBox.Show("Mã hợp đồng này không tồn tại", "Message");
                    else
                    {
                        foreach (var item in x)
                        {
                            dtg_HoaDon.Rows.Add(item.Id,
                                item.MaHopDong,
                                item.NgayTao,
                                item.TongTien,
                                item.TrangThai == 0 ? "Đã thanh toán" : "Chờ thanh toán");
                            foreach (var items in _iQLCTHopDongService.GetAll(item.Id))
                            {
                                dtg_CTHoaDon.Rows.Add(items.CTHopDong.Id,
                                    items.PhongTro.MaPhong,
                                    items.DichVu.Ten);
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Phải nhập mã hóa đơn trước", "Message");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xóa hợp đồng?", "Message", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    var x = _iQLHopDongService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
                    if (x == null)
                        MessageBox.Show("Mã hợp đồng này không tồn tại", "Message");
                    else if (x.TrangThai == 0)
                        MessageBox.Show("Chỉ xóa được những hợp đồng chưa thanh toán", "Message");
                    else
                    {
                        var a = _iQLKhachHangService.GetAll(_idChuTro).FirstOrDefault(p => p.KhachHang.HopDongId == _id);
                        _iQLKhachHangService.Delete(a.KhachHang.Id);
                        var b = _iQLCTHopDongService.GetAll(_id);
                        foreach (var item in b)
                        {
                            _iQLCTHopDongService.Delete(item.CTHopDong.Id);
                        }
                        _iQLHopDongService.Delete(_id);
                        MessageBox.Show("Xóa thành công", "Message");
                        LoadDGriViewHoaDon();
                        dtg_CTHoaDon.Rows.Clear();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void FrmQLHopDong_Load(object sender, EventArgs e)
        {
            LoadDGriViewHoaDon();
        }
    }
}
