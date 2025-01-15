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
    public partial class FrmSalonEnter : Form
    {
        DesignForm designform;
        public FrmSalonEnter()
        {
            InitializeComponent();
            designform = new DesignForm();
        }

        private void Enter_Btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            designform.Sendkeys(e);
        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            FrmCheangSalon frmCheangSalon = new FrmCheangSalon();
            frmCheangSalon.ShowDialog();
        }
    }
}
