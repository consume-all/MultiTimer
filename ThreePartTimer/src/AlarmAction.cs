using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreePartTimer.src
{
    class AlarmAction
    {
        public void FlickerBackground (Form form, int interval_milliseconds, Color color)
        {
            var current_color = form.BackColor;
            form.BackColor = color;
            Thread.Sleep(interval_milliseconds);
            form.BackColor = current_color;

        }
    }
}
