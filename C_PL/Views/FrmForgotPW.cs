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
    public partial class FrmForgotPW : Form
    {
        private IQLChuTroService _iQLChuTroService;
        public FrmForgotPW()
        {
            InitializeComponent();
            _iQLChuTroService = new QLChuTroService();
        }

        private void btn_FindAcc_Click(object sender, EventArgs e)
        {
            var x = _iQLChuTroService.GetAll().FirstOrDefault(p => p.Username == txt_Username.Text && p.Sdt == txt_Sdt.Text && p.Email == txt_Email.Text);
            if (x == null)
                MessageBox.Show("Mời bạn kiểm tra lại thông tin", "Message");
            else
            {
                FrmResetPW form = new FrmResetPW(x.Id);
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
