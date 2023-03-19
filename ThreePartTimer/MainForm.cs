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
        private src.TimerControl timer1;//why does this not work with public but works with private?
        private src.TimerControl timer2;
        private src.TimerControl timer3;
        private System.Timers.Timer tick_timer;

        public delegate void UpdateT1Delegate();
        Action<Control, string> UpdateControlTextCallback = (control, text) => control.Text = text;

        public MainForm()
        {
            InitializeComponent();

            settings = new ThreePartTimer.SettingsForm(this);

            CreateProgramMenu();

            timer1 = new src.TimerControl(1, this);
            timer1.ThresholdReached += Timer1_ThresholdReached;

            timer2 = new src.TimerControl(2, this);
            timer2.ThresholdReached += Timer2_ThresholdReached;

            timer3 = new src.TimerControl(3, this);
            timer3.ThresholdReached += Timer3_ThresholdReached;

            /* Aesthetics Bug "Fix": Without the below label text updates, the
             * "Label" part gets cut off upon the program loading...
             * This occured after changing some of the label properties; I changed
             * the properties so when a user updates the labels text, the new text
             * stays centered.
             */
            t1_label.Text = "Timer 1 Label";
            t2_label.Text = "Timer 2 Label";
            t3_label.Text = "Timer 3 Label";

        }

        private void Timer3_ThresholdReached(object sender, EventArgs e)
        {
            timer3.Reset();

            if (InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, t3_startstop_btn, "Start");
            }
            else
            {
                t3_startstop_btn.Text = "Start";
            }

            MessageBox.Show("Timer 3 has elapsed!", "Ding Ding Ding!", MessageBoxButtons.OK);
        }

        private void Timer2_ThresholdReached(object sender, EventArgs e)
        {
            timer2.Reset();

            if (InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, t2_startstop_btn, "Start");
            }
            else
            {
                t2_startstop_btn.Text = "Start";
            }

            MessageBox.Show("Timer 2 has elapsed!", "Ding Ding Ding!", MessageBoxButtons.OK);

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

            settings.UpdateTimerSettings();
            timer1.Reset();
            timer2.Reset();
            timer3.Reset();
        }

        private void Tick_timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (timer1.enabled)
            {
                timer1.Update();
            }
            if (timer2.enabled)
            {
                timer2.Update();
            }
            if (timer3.enabled)
            {
                timer3.Update();
            }
            return;
        }

        private void CreateProgramMenu()
        {
            MainMenu m = new MainMenu();

            m.MenuItems.Add(new MenuItem("&Settings", new EventHandler((o, i) =>
            { settings.Show(); settings.WindowState = FormWindowState.Normal; settings.Activate();}), Shortcut.CtrlS) );

            this.Menu = m;
        }

        public void t1UpdateDynamLabel(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, dynam_t1_label, text);
            } else
            {
                dynam_t1_label.Text = text;
            }
        }

        public void t2UpdateDynamLabel(string text)
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
        public void t3UpdateDynamLabel(string text)
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

        public void t1UpdateLabel(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, t1_label, text);
            }
            else
            {
                t1_label.Text = text;
            }
        }

        public void t2UpdateLabel(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, t2_label, text);
            }
            else
            {
                t2_label.Text = text;
            }
        }
        public void t3UpdateLabel(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(UpdateControlTextCallback, t3_label, text);
            }
            else
            {
                t3_label.Text = text;
            }
        }

        public void t1UpdateTime(int mins, int secs)
        {
            timer1.init_min = mins;
            timer1.init_sec = secs;
        }

        public void t2UpdateTime(int mins, int secs)
        {
            timer2.init_min = mins;
            timer2.init_sec = secs;
        }

        public void t3UpdateTime(int mins, int secs)
        {
            timer3.init_min = mins;
            timer3.init_sec = secs;
        }

        public bool GetTimerStatus(int timer)
        {
            switch(timer)
            {
                case 0:
                    return false;
                case 1:
                    return timer1.enabled;
                case 2:
                    return timer2.enabled;
                case 3:
                    return timer3.enabled;
                default:
                    return false;
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
                MessageBox.Show("Timer 1 button state error.", "State Error", MessageBoxButtons.OK);
            }
        }

        private void t1_reset_btn_Click(object sender, EventArgs e)
        {
            timer1.Reset();
            t1_startstop_btn.Text = "Start";
        }

        private void t2_startstop_btn_Click(object sender, EventArgs e)
        {
            if (t2_startstop_btn.Text.Equals("Start"))
            {
                timer2.Start();
                t2_startstop_btn.Text = "Stop";
            }
            else if (t2_startstop_btn.Text.Equals("Stop"))
            {
                timer2.Stop();
                t2_startstop_btn.Text = "Continue";
            }
            else if (t2_startstop_btn.Text.Equals("Continue"))
            {
                timer2.Continue();
                t2_startstop_btn.Text = "Stop";
            }
            else
            {
                MessageBox.Show("Timer 2 button state error.", "State Error", MessageBoxButtons.OK);
            }
        }

        private void t2_reset_btn_Click(object sender, EventArgs e)
        {
            timer2.Reset();
            t2_startstop_btn.Text = "Start";
        }

        private void t3_startstop_btn_Click(object sender, EventArgs e)
        {
            if (t3_startstop_btn.Text.Equals("Start"))
            {
                timer3.Start();
                t3_startstop_btn.Text = "Stop";
            }
            else if (t3_startstop_btn.Text.Equals("Stop"))
            {
                timer3.Stop();
                t3_startstop_btn.Text = "Continue";
            }
            else if (t3_startstop_btn.Text.Equals("Continue"))
            {
                timer3.Continue();
                t3_startstop_btn.Text = "Stop";
            }
            else
            {
                MessageBox.Show("Timer 3 button state error.", "State Error", MessageBoxButtons.OK);
            }
        }

        private void t3_reset_btn_Click(object sender, EventArgs e)
        {
            timer3.Reset();
            t3_startstop_btn.Text = "Start";
        }
        public void TimerReset(int timer)
        {
            switch (timer)
            {
                case 1:
                    timer1.Reset();
                    break;
                case 2:
                    timer2.Reset();
                    break;
                case 3:
                    timer3.Reset();
                    break;
            }
        }

    }
}
