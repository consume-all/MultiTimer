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
        private MainForm _MainForm;
        public SettingsForm(MainForm main_form)
        {
            InitializeComponent();

            _MainForm = main_form;
            ApplyDefaultSettings();
        }

        private void ApplyDefaultSettings()
        {
            t1_mins_numeric.Maximum = 60;
            t1_mins_numeric.Minimum = 0;
            t1_mins_numeric.Value = 0;
            t1_secs_numeric.Maximum = 60;
            t1_secs_numeric.Minimum = 0;
            t1_secs_numeric.Value = 15;
            t1_name_tbox.Text = "Timer 1 Label";


            t2_mins_numeric.Maximum = 60;
            t2_mins_numeric.Minimum = 0;
            t2_mins_numeric.Value = 0;
            t2_secs_numeric.Maximum = 60;
            t2_secs_numeric.Minimum = 0;
            t2_secs_numeric.Value = 15;
            t2_name_tbox.Text = "Timer 2 Label";

            t3_mins_numeric.Maximum = 60;
            t3_mins_numeric.Minimum = 0;
            t3_mins_numeric.Value = 0;
            t3_secs_numeric.Maximum = 60;
            t3_secs_numeric.Minimum = 0;
            t3_secs_numeric.Value = 15;
            t3_name_tbox.Text = "Timer 3 Label";
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

        private void t1_updt_btn_Click(object sender, EventArgs e)
        {
            _MainForm.UpdateLabelt1(t1_name_tbox.Text);
        }

        private void t2_updt_btn_Click(object sender, EventArgs e)
        {
            _MainForm.UpdateLabelt2(t2_name_tbox.Text);
        }

        private void t3_updt_btn_Click(object sender, EventArgs e)
        {
            _MainForm.UpdateLabelt3(t3_name_tbox.Text);
        }
    }
}
