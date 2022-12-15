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
    public partial class FrmMain : Form
    {
        private IQLChuTroService _iQLChuTroService;
        public Guid _id { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            _iQLChuTroService = new QLChuTroService();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var x = _iQLChuTroService.GetAll().FirstOrDefault(p => p.Id == _id);
            lb_Ten.Text = x.Ten.ToString();
            lb_Sdt.Text = x.Sdt.ToString();
            lb_Diachi.Text = x.Diachi.ToString();
            lb_Email.Text = x.Email.ToString();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmQLKhachHang form = new FrmQLKhachHang();
                form._idChuTro = _id;
                form.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmQLThanhToan form = new FrmQLThanhToan();
                form._idChuTro = _id;
                form.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void lb_LogOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmDangNhap form = new FrmDangNhap();
                form.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_HopDong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmQLHopDong form = new FrmQLHopDong();
                form._idChuTro = _id;
                form.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmQLDichVu form = new FrmQLDichVu();
                form._idChuTro = _id;
                form.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmQLPhong form = new FrmQLPhong();
                form._idChuTro = _id;
                form.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void lb_LogOut_MouseHover(object sender, EventArgs e)
        {
            lb_LogOut.Font = new Font(lb_LogOut.Font, FontStyle.Underline);
        }

        private void lb_LogOut_MouseLeave(object sender, EventArgs e)
        {
            lb_LogOut.Font = new Font(lb_LogOut.Font, FontStyle.Regular);
        }
    }
}
