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
    public partial class FrmCheangSalon : Form
    {
        DesignForm designform;
        public FrmCheangSalon()
        {
            InitializeComponent();
            designform = new DesignForm();
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            designform.Sendkeys(e);
        }
    }
}
