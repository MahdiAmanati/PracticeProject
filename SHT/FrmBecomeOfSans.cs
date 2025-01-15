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
    public partial class FrmBecomeOfSans : Form
    {
        DesignForm designForm;
        public FrmBecomeOfSans()
        {
            InitializeComponent();
            designForm =new DesignForm();
        }

        private void mainmenu_but_Click(object sender, EventArgs e)
        {

        }

        private void salonname_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            designForm.Sendkeys(e);
        }
    }
}
