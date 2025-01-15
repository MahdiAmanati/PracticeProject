using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHT.SHTBLL;

namespace SHT
{
    public partial class FrmCheangAccount : Form
    {
        DesignForm designForm;
        public FrmCheangAccount()
        {
            InitializeComponent();
            designForm = new DesignForm();
        }

        private void OldUserName_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            designForm.Sendkeys(e);
        }

        private async void change_btn_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Age = TxtAge.Text,
                LastName = TxtLastName.Text,
                Name = TxtName.Text,
                OldPassword = TxtOldPassword.Text,
                OldUserName = TxtOldUserName.Text,
                Password = TxtPassword.Text,
                Phone = TxtPhone.Text,
                UserName = TxtUserName.Text,
                SportField = field()
            };
            bool message = await Task.Run(() =>
            user.UpdateUser()
            );
            if (message)
            {
                MessageBox.Show("با موفقیت تغییر کرد");
            }
            else
            {
                MessageBox.Show(
                    "مقادیر را درست وارد کنید", "خطا"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error
                                );
            }
        }
        private string field()
        {
            string field = "";
            if (ChFootBall.Checked)
            {
                field += "1";
            }
            else
                field += "0";
            if (ChVolayball.Checked)
            {
                field += "1";
            }
            else
                field += "0";
            if (ChBasketBall.Checked)
            {
                field += "1";
            }
            else
                field += "0";
            if (ChHandBall.Checked)
            {
                field += "1";
            }
            else
                field += "0";
            return field;
        }
    }
}
