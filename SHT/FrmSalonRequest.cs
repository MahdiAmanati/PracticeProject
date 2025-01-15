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
    public partial class FrmSalonRequest : Form
    {
        DesignForm designform;
        public FrmSalonRequest()
        {
            InitializeComponent();
            designform = new DesignForm();
        }

        private void TypeOfSalon_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            designform.Sendkeys(e);
        }
    }
}
