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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void Member_Btn_Click(object sender, EventArgs e)
        {
            FrmBecomeOfSans frmBecomeOfSans = new FrmBecomeOfSans();
            frmBecomeOfSans.ShowDialog();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            FrmRemoveSans frmRemoveSans = new FrmRemoveSans();
            frmRemoveSans.ShowDialog();
        }

        private void Place_Btn_Click(object sender, EventArgs e)
        {
            FrmReserveSans frmReserveSans = new FrmReserveSans();   
            frmReserveSans.ShowDialog();
        }

        private void UserOfMySans_Btn_Click(object sender, EventArgs e)
        {
            FrmSansMember frmSansMember = new FrmSansMember();
            frmSansMember.ShowDialog();
        }

        private void Request_Btn_Click(object sender, EventArgs e)
        {
            FrmRequest frmRequest = new FrmRequest();
            frmRequest.ShowDialog();
        }

        private void DeleteAccount_Btn_Click(object sender, EventArgs e)
        {
            FrmRemoveAccount frmRemoveAccount = new FrmRemoveAccount(); 
            frmRemoveAccount.ShowDialog();
        }

        private void UserUpdate_Btn_Click(object sender, EventArgs e)
        {
            FrmCheangAccount frmCheangAccount = new FrmCheangAccount();
            frmCheangAccount.ShowDialog();
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
