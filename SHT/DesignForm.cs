using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHT
{
    public class DesignForm
    {
        public void Sendkeys (KeyPressEventArgs Key)
        {
            if (Key.KeyChar == (char)Keys.Enter)
            {
                Key.Handled = true;
                SendKeys.Send("{Tab}");
            }
           
        }
    }
}
