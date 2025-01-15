using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHT
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void make_but_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            this.Hide();
            frmRegister.ShowDialog();
        }

        private void enter_but_Click(object sender, EventArgs e)
        {
            FrmEnter frmEnter = new FrmEnter();
            this.Hide();
            frmEnter.ShowDialog();
        }

        private void Salons_Btn_Click(object sender, EventArgs e)
        {
            FrmSalonLogin frmSalonLogin = new FrmSalonLogin();
            this.Hide();
            frmSalonLogin.ShowDialog();
        }


    }
}
