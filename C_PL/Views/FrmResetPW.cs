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
    public partial class FrmResetPW : Form
    {
        private IQLChuTroService _iQLChuTroService;
        Guid _id;
        public FrmResetPW()
        {
            InitializeComponent();
            _iQLChuTroService = new QLChuTroService();
        }

        public FrmResetPW(Guid id) : this()
        {
            _id = id;
        }

        private void btn_RePassword_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text == "" || txt_RePassword.Text == "")
                MessageBox.Show("Không được để trống mật khẩu và xác nhận", "Message");
            else if (txt_Password.Text != txt_RePassword.Text)
                MessageBox.Show("Mật khẩu và xác nhận phải trùng nhau", "Message");
            else
            {
                var x = _iQLChuTroService.GetAll().FirstOrDefault(p => p.Id == _id);
                x.Password = txt_Password.Text;
                _iQLChuTroService.Update(x);
                MessageBox.Show("Đổi mật khẩu thành công", "Message");
                FrmDangNhap form = new FrmDangNhap();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
