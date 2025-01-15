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
    public partial class FrmReserveSans : Form
    {
        DesignForm designForm;
        public FrmReserveSans()
        {
            InitializeComponent();
            designForm = new DesignForm();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            designForm.Sendkeys(e);
        }
    }
}
