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
    public partial class FrmRequest : Form
    {
        DesignForm designform;
        public FrmRequest()
        {
            InitializeComponent();
            designform = new DesignForm(); 
        }

        private void targetusername_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            designform.Sendkeys(e);
        }
    }
}
