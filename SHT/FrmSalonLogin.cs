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
    public partial class FrmSalonLogin : Form
    {
        public FrmSalonLogin()
        {
            InitializeComponent();
        }

        private void MySalonAccount_Btn_Click(object sender, EventArgs e)
        {
            FrmSalonEnter frmSalonEnter = new FrmSalonEnter();
            frmSalonEnter.ShowDialog();
        }

        private void NewSalonAccount_Btn_Click(object sender, EventArgs e)
        {
            FrmSalonRequest frmSalonRequest = new FrmSalonRequest();
            frmSalonRequest.ShowDialog();
        }

        private void Manage_Btn_Click(object sender, EventArgs e)
        {
            FrmSalonManagement frmSalonManagement = new FrmSalonManagement();
            frmSalonManagement.ShowDialog();
        }

        private void FrmSalonLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
