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

        /*Custom Controls*/
        private src.CustomNumericUpDown t1_mins_customNumeric = new src.CustomNumericUpDown();
        private src.CustomNumericUpDown t2_mins_customNumeric = new src.CustomNumericUpDown();
        private src.CustomNumericUpDown t3_mins_customNumeric = new src.CustomNumericUpDown();
        private src.CustomNumericUpDown t1_secs_customNumeric = new src.CustomNumericUpDown();
        private src.CustomNumericUpDown t2_secs_customNumeric = new src.CustomNumericUpDown();
        private src.CustomNumericUpDown t3_secs_customNumeric = new src.CustomNumericUpDown();
        public SettingsForm(MainForm main_form)
        {
            InitializeComponent();

            _MainForm = main_form;
            NumericUpDownSettings();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            t1_mins_customNumeric.Location = new Point(76, 57);
            t1_mins_customNumeric.Size = new Size(85, 20);

            t1_secs_customNumeric.Location = new Point(76, 80);
            t1_secs_customNumeric.Size = new Size(85, 20);

            t2_mins_customNumeric.Location = new Point(290, 57);
            t2_mins_customNumeric.Size = new Size(85, 20);

            t2_secs_customNumeric.Location = new Point(290, 80);
            t2_secs_customNumeric.Size = new Size(85, 20);

            t3_mins_customNumeric.Location = new Point(506, 57);
            t3_mins_customNumeric.Size = new Size(85, 20);

            t3_secs_customNumeric.Location = new Point(506, 80);
            t3_secs_customNumeric.Size = new Size(85, 20);

            this.Controls.Add(t1_mins_customNumeric);
            this.Controls.Add(t1_secs_customNumeric);
            this.Controls.Add(t2_mins_customNumeric);
            this.Controls.Add(t2_secs_customNumeric);
            this.Controls.Add(t3_mins_customNumeric);
            this.Controls.Add(t3_secs_customNumeric);
        }

        private void NumericUpDownSettings()
        {
            t1_mins_customNumeric.Maximum = 1000;
            t1_mins_customNumeric.Minimum = 0;
            t1_mins_customNumeric.Value = 0;
            t1_secs_customNumeric.Maximum = 60;
            t1_secs_customNumeric.Minimum = 0;
            t1_secs_customNumeric.Value = 15;
            t1_name_tbox.Text = "Timer 1 Label";


            t2_mins_customNumeric.Maximum = 1000;
            t2_mins_customNumeric.Minimum = 0;
            t2_mins_customNumeric.Value = 0;
            t2_secs_customNumeric.Maximum = 60;
            t2_secs_customNumeric.Minimum = 0;
            t2_secs_customNumeric.Value = 15;
            t2_name_tbox.Text = "Timer 2 Label";

            t3_mins_customNumeric.Maximum = 1000;
            t3_mins_customNumeric.Minimum = 0;
            t3_mins_customNumeric.Value = 0;
            t3_secs_customNumeric.Maximum = 60;
            t3_secs_customNumeric.Minimum = 0;
            t3_secs_customNumeric.Value = 15;
            t3_name_tbox.Text = "Timer 3 Label";
        }

        public void UpdateTimerSettings()
        {
            /*Timer 1*/
            if (_MainForm.GetTimerStatus(1))
            {
                if (TimerUpdateWarning(1))
                {
                    _MainForm.t1UpdateLabel(t1_name_tbox.Text);
                    _MainForm.t1UpdateTime(Decimal.ToInt32(t1_mins_customNumeric.Value), Decimal.ToInt32(t1_secs_customNumeric.Value));
                    _MainForm.TimerReset(1);
                }
            }
            else
            {
                _MainForm.t1UpdateLabel(t1_name_tbox.Text);
                _MainForm.t1UpdateTime(Decimal.ToInt32(t1_mins_customNumeric.Value), Decimal.ToInt32(t1_secs_customNumeric.Value));
                _MainForm.TimerReset(1);
            }
            /*Timer 2*/
            if (_MainForm.GetTimerStatus(2))
            {
                if (TimerUpdateWarning(2))
                {
                    _MainForm.t2UpdateLabel(t2_name_tbox.Text);
                    _MainForm.t2UpdateTime(Decimal.ToInt32(t2_mins_customNumeric.Value), Decimal.ToInt32(t2_secs_customNumeric.Value));
                    _MainForm.TimerReset(2);
                }
            }
            else
            {
                _MainForm.t2UpdateLabel(t2_name_tbox.Text);
                _MainForm.t2UpdateTime(Decimal.ToInt32(t2_mins_customNumeric.Value), Decimal.ToInt32(t2_secs_customNumeric.Value));
                _MainForm.TimerReset(2);
            }
            /*Timer 3*/
            if (_MainForm.GetTimerStatus(3))
            {
                if (TimerUpdateWarning(3))
                {
                    _MainForm.t3UpdateLabel(t3_name_tbox.Text);
                    _MainForm.t3UpdateTime(Decimal.ToInt32(t3_mins_customNumeric.Value), Decimal.ToInt32(t3_secs_customNumeric.Value));
                    _MainForm.TimerReset(3);
                }
            }
            else
            {
                _MainForm.t3UpdateLabel(t3_name_tbox.Text);
                _MainForm.t3UpdateTime(Decimal.ToInt32(t3_mins_customNumeric.Value), Decimal.ToInt32(t3_secs_customNumeric.Value));
                _MainForm.TimerReset(3);
            }
        }

        private void updt_btn_Click(object sender, EventArgs e)
        {
            UpdateTimerSettings();
        }

        private bool TimerUpdateWarning(int timer)
        {
            DialogResult dr = MessageBox.Show(String.Format( "Timer {0} is currently active! Continuing will reset the timer. Would you like to continue?", timer),
                            "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch(dr)
            {
                case DialogResult.Yes:
                    return true;
                case DialogResult.No:
                    return false;
                default:
                    return false;
            }
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





    }
}
