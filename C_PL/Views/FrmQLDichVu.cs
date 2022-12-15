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
    public partial class FrmQLDichVu : Form
    {
        private IQLDichVuService _iQLDichVuService;
        Guid _id;
        int _count = 0;
        public Guid _idChuTro { get; set; }
        public FrmQLDichVu()
        {
            InitializeComponent();
            _iQLDichVuService = new QLDichVuService();
        }

        private void LoadDGriView()
        {
            try
            {
                dtg_Show.Rows.Clear();

                foreach (var item in _iQLDichVuService.GetAll(_idChuTro))
                {
                    dtg_Show.Rows.Add(item.Id, item.Ten, item.DonGia);
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
                    var x = _iQLDichVuService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
                    txt_Ten.Text = x.Ten;
                    txt_DonGia.Text = Convert.ToString(x.DonGia);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private DichVuView GetDataFromGui()
        {
            try
            {
                DichVuView v = new DichVuView();
                v.ChuTroId = _idChuTro;
                v.Ten = txt_Ten.Text;
                v.DonGia = Convert.ToDouble(txt_DonGia.Text);
                return v;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_Ten.Text = "";
            txt_DonGia.Text = "";
            txt_DonGia.Enabled = true;
            _count = 1;
        }

        private DichVuView UpdateDataFromGui()
        {
            var x = _iQLDichVuService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
            x.Ten = txt_Ten.Text;
            x.DonGia = Convert.ToDouble(txt_DonGia.Text);
            return x;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            txt_DonGia.Enabled = true;
            var x = _iQLDichVuService.GetAll(_idChuTro).FirstOrDefault(p => p.Id == _id);
            if (x == null)
                MessageBox.Show("Dịch vụ không tồn tại", "Message");
            else
                _count = 2;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xóa dịch vụ?", "Message", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    _iQLDichVuService.Delete(_id);
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
                    if (txt_Ten.Text == "" || txt_DonGia.Text == "")
                        MessageBox.Show("Không được để trống thông tin", "Message");
                    else if (_iQLDichVuService.GetAll(_idChuTro).Any(p => p.Ten == txt_Ten.Text))
                        MessageBox.Show("Dịch vụ đã tồn tại", "Message");
                    else
                    {
                        _iQLDichVuService.Add(GetDataFromGui());
                        LoadDGriView();
                    }
                }
                else if (_count == 2)
                {
                    if (txt_Ten.Text == "" || txt_DonGia.Text == "")
                        MessageBox.Show("Không được để trống thông tin", "Message");
                    else
                    {
                        _iQLDichVuService.Update(UpdateDataFromGui());
                        LoadDGriView();
                    }
                }
                txt_DonGia.Enabled = false;
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
                var x = _iQLDichVuService.GetAll(_idChuTro).Where(p => p.Ten.Contains(txt_Ten.Text));
                if (x == null)
                {
                    MessageBox.Show("Dịch vụ không tồn tại", "Message");
                }
                else
                {
                    dtg_Show.Rows.Clear();

                    foreach (var item in x)
                    {
                        dtg_Show.Rows.Add(item.Id, item.Ten, item.DonGia);
                        txt_DonGia.Text = Convert.ToString(item.DonGia);
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FrmQLDichVu_Load(object sender, EventArgs e)
        {
            LoadDGriView();
        }
    }
}
