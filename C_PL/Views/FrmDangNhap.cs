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
    public partial class FrmDangNhap : Form
    {
        private IQLChuTroService _iQLChuTroService;
        public FrmDangNhap()
        {
            InitializeComponent();
            _iQLChuTroService = new QLChuTroService();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            {
                var x = _iQLChuTroService.GetAll().FirstOrDefault(p => p.Username == txt_Username.Text);
                if (x == null)
                    MessageBox.Show("Login Failed!", "Message");
                else if (txt_Username.Text == x.Username && txt_Password.Text == x.Password)
                {
                    FrmMain form = new FrmMain();
                    form._id = x.Id;
                    this.Hide();
                    MessageBox.Show("Login succesfully!", "Message");
                    form.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Login Failed!", "Message");
            }
        }

        private void lb_Signup_Click(object sender, EventArgs e)
        {
            FrmDangKy form = new FrmDangKy();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void lb_Forgot_Click(object sender, EventArgs e)
        {
            FrmForgotPW form = new FrmForgotPW();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
