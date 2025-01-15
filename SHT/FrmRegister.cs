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
    public partial class FrmRegister : Form
    {
        DesignForm designform;
        public FrmRegister()
        {
            InitializeComponent();
            designform = new DesignForm();
            string message = "پسورد حد اکثر ده کاراکنر است و تاریخ را با - از " +
                             "یکدیگر جدا کنید و بقیه حداکثر هشتاد کاراکتر است";
            MessageBox.Show(message);
        }

        private void FrmRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            designform.Sendkeys(e);
        }

        private async void register_but_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = TxtName.Text,
                Age = TxtAge.Text,
                LastName = TxtLastName.Text,
                Password = TxtPassword.Text,
                Phone = TxtPhone.Text,
                UserName = TxtUserName.Text,
                SportField = field()
            };
            bool message = await Task.Run(() =>
            user.InsertUser()
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
                    "مقادیر را درست وارد کنید","خطا"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error
                                );
            }
        }

        private void FrmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private string field()
        {
            string field = "";
            if (ChFootball.Checked)
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
            if (ChBasketball.Checked)
            {
                field += "1";
            }
            else
                field += "0";
            if (ChHandball.Checked)
            {
                field += "1";
            }
            else
                field += "0";
            return field;
        }
    }
}
