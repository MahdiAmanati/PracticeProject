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
    public partial class FrmRemoveAccount : Form
    {
        DesignForm designform;
        public FrmRemoveAccount()
        {
            InitializeComponent();
            designform = new DesignForm();
        }

        private void FrmRemoveAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            designform.Sendkeys(e);
        }

        private async void UserDelete_Btn_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Password = TxtPassword.Text,
                UserName = TxtUserName.Text,
            };
            bool message = await Task.Run(() =>
            user.DeleteUser()
            );
            if (message)
            {
                MessageBox.Show("با موفقیت حذف شد");
                Application.Exit();
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
    }
}
