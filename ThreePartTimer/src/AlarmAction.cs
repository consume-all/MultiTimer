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
        private MainForm _MainForm;
        public AlarmAction(MainForm main_form)
        {
            _MainForm = main_form;
        }
        public void FlickerBackground (int interval_milliseconds, Color color)
        {
            var current_color = _MainForm.BackColor;
            _MainForm.BackColor = color;
            Thread.Sleep(interval_milliseconds);
            _MainForm.BackColor = current_color;

        }
    }
}
