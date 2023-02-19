using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ThreePartTimer
{
    public partial class MainForm : Form
    {
        public SettingsForm settings;
        private src.TimerControl timer1; //why does this not work with public but works with private?
        private System.Timers.Timer tick_timer;

        public delegate void UpdateT1Delegate();
        Action<Control, string> UpdateControlTextCallback = (control, text) => control.Text = text;
        public MainForm()
        {
            InitializeComponent();

            settings = new ThreePartTimer.SettingsForm();

            CreateProgramMenu();

            timer1 = new src.TimerControl(1, this, settings);
            timer1.ThresholdReached += Timer1_ThresholdReached;

        }

        private void Timer1_ThresholdReached(object sender, EventArgs e)
        {
            timer1.Reset();

            if (InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, t1_startstop_btn, "Start");
            } else
            {
                t1_startstop_btn.Text = "Start";
            }
            
            MessageBox.Show("Timer 1 has elapsed!", "Ding Ding Ding!", MessageBoxButtons.OK);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tick_timer = new System.Timers.Timer();
            tick_timer.Interval = 1000;
            tick_timer.Elapsed += Tick_timer_Elapsed;
            tick_timer.Start();
        }

        private void Tick_timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (timer1.enabled)
            {
                timer1.Update();
            }
        }

        private void CreateProgramMenu()
        {
            MainMenu m = new MainMenu();

            m.MenuItems.Add(new MenuItem("&Settings", new EventHandler((o, i) =>
            { settings.Show(); settings.WindowState = FormWindowState.Normal; settings.Activate();}), Shortcut.CtrlS) );

            this.Menu = m;
        }

        public void UpdateLabelt1(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, dynam_t1_label, text);
            } else
            {
                dynam_t1_label.Text = text;
            }
        }

        public void UpdateLabelt2(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, dynam_t2_label, text);
            }
            else
            {
                dynam_t2_label.Text = text;
            }
        }
        public void UpdateLabelt3(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, dynam_t3_label, text);
            }
            else
            {
                dynam_t3_label.Text = text;
            }
        }

        private void t1_startstop_btn_Click(object sender, EventArgs e)
        {
            if (t1_startstop_btn.Text.Equals("Start"))
            {
                timer1.Start();
                t1_startstop_btn.Text = "Stop";
            } else if (t1_startstop_btn.Text.Equals("Stop"))
            {
                timer1.Stop();
                t1_startstop_btn.Text = "Continue";
            } else if (t1_startstop_btn.Text.Equals("Continue"))
            {
                timer1.Continue();
                t1_startstop_btn.Text = "Stop";
            } else
            {
                MessageBox.Show("Timer button state error.", "State Error", MessageBoxButtons.OK);
            }
        }

        private void t1_reset_btn_Click(object sender, EventArgs e)
        {
            timer1.Reset();
            t1_startstop_btn.Text = "Start";
        }
    }
}
