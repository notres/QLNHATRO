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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C_PL.Views
{
    public partial class FrmDangKy : Form
    {
        private IQLChuTroService _iQLChuTroService;
        public FrmDangKy()
        {
            InitializeComponent();
            _iQLChuTroService = new QLChuTroService();
        }
        private ChuTroView GetDataFromGui()
        {
            ChuTroView v = new ChuTroView()
            {
                Username = txt_Username.Text,
                Password = txt_Password.Text,
                Ten = txt_Ten.Text,
                Sdt = txt_Sdt.Text,
                Diachi = txt_Diachi.Text,
                Email = txt_Email.Text
            };
            return v;
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" || txt_Password.Text == "" || txt_Ten.Text == "" || txt_Sdt.Text == "" || txt_Diachi.Text == "" || txt_Email.Text == "")
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Message");
            else if(_iQLChuTroService.GetAll().Any(p => p.Username == txt_Username.Text))
                MessageBox.Show("Tên tài khoản đã tồn tại", "Message");
            else
            {
                _iQLChuTroService.Add(GetDataFromGui());
                MessageBox.Show("Bạn đã đăng ký tài khoản thành công", "Message");
                FrmDangNhap form = new FrmDangNhap();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void txt_Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
