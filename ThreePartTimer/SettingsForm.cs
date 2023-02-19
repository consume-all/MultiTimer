using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreePartTimer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            ApplyDefaultSettings();
        }

        private void ApplyDefaultSettings()
        {
            t1_mins_numeric.Maximum = 60;
            t1_mins_numeric.Minimum = 0;
            t1_mins_numeric.Value = 5;
            t1_secs_numeric.Maximum = 60;
            t1_secs_numeric.Minimum = 0;
            t1_secs_numeric.Value = 0;
            t1_name_tbox.Text = "Timer 1";


            t2_mins_numeric.Maximum = 60;
            t2_mins_numeric.Minimum = 0;
            t2_mins_numeric.Value = 5;
            t2_secs_numeric.Maximum = 60;
            t2_secs_numeric.Minimum = 0;
            t2_secs_numeric.Value = 0;
            t2_name_tbox.Text = "Timer 2";

            t3_mins_numeric.Maximum = 60;
            t3_mins_numeric.Minimum = 0;
            t3_mins_numeric.Value = 5;
            t3_secs_numeric.Maximum = 60;
            t3_secs_numeric.Minimum = 0;
            t3_secs_numeric.Value = 0;
            t3_name_tbox.Text = "Timer 3";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public int GetT1Mins()
        {
            return Decimal.ToInt32(t1_mins_numeric.Value);
        }

        public int GetT1Secs()
        {
            return Decimal.ToInt32(t1_secs_numeric.Value);
        }

        public int GetT2Mins()
        {
            return Decimal.ToInt32(t2_mins_numeric.Value);
        }

        public int GetT2Secs()
        {
            return Decimal.ToInt32(t2_secs_numeric.Value);
        }

        public int GetT3Mins()
        {
            return Decimal.ToInt32(t3_mins_numeric.Value);
        }

        public int GetT3Secs()
        {
            return Decimal.ToInt32(t3_secs_numeric.Value);
        }





    }
}
