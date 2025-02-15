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
    public partial class FrmEnter : Form
    {
        DesignForm designform;
        public FrmEnter()
        {
            InitializeComponent();
            designform = new DesignForm();
        }

        private void ShowPassword_Check_KeyPress(object sender, KeyPressEventArgs e)
        {
            designform.Sendkeys(e);
        }

        private async void enter_but_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Password = TxtPassword.Text,
                UserName = TxtUserName.Text,
            };
            bool message = await Task.Run(() =>
            user.Select_EnrerUser()
            );
            if (message)
            {
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                this.Hide();
                frmMainMenu.ShowDialog();
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

        private void FrmEnter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
