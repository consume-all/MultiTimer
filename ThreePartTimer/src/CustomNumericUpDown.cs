using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreePartTimer.src
{
    class CustomNumericUpDown:System.Windows.Forms.NumericUpDown
    {
        protected override void OnTextBoxTextChanged(object source, EventArgs e)
        {
            TextBox tb = source as TextBox;
            int val = 0;
            if (int.TryParse(tb.Text, out val))
            {
                if (val < 10)
                {
                    tb.Text = String.Concat("0", val.ToString());
                }
            } else
            {
                base.OnTextBoxTextChanged(source, e);
            }
        }

    }
}
