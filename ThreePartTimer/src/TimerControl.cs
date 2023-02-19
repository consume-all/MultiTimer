using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ThreePartTimer.src
{
    class TimerControl
    {
        private MainForm _MainForm;
        private SettingsForm _SettingsForm;
        private int timer;
        private int min;
        private int sec;
        public bool enabled = false;

        public event EventHandler ThresholdReached;

        public TimerControl(int timer_inst, MainForm main_form, SettingsForm settings_form)
        {
            timer = timer_inst;
            _MainForm = main_form;
            _SettingsForm = settings_form;
        }

        public void Start()
        {
            switch(timer)
            {
                case 1:
                    min = _SettingsForm.GetT1Mins();
                    sec = _SettingsForm.GetT1Secs();
                    enabled = true;
                    break;
                case 2:
                    min = _SettingsForm.GetT2Mins();
                    sec = _SettingsForm.GetT2Secs();
                    enabled = true;
                    break;
                case 3:
                    min = _SettingsForm.GetT3Mins();
                    sec = _SettingsForm.GetT3Secs();
                    enabled = true;
                    break;
                default:
                    enabled = false;
                    return;
            }
        }

        public void Stop()
        {
            enabled = false;
        }

        public void Continue()
        {
            enabled = true;
        }

        private void UpdateDisplay()
        {
            switch(timer)
            {
                case 1:
                    _MainForm.UpdateLabelt1(String.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0')));
                    break;
                case 2:
                    _MainForm.UpdateLabelt2(String.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0')));
                    break;
                case 3:
                    _MainForm.UpdateLabelt3(String.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0')));
                    break;
                default:
                    return;
            }
            
        }

        private void UpdateCountdown()
        {
            //figure out then add logic for end of countdown event
            if (sec == 0)
            {
                if (min == 0)
                {
                    Stop();
                    ThresholdReached?.Invoke(this, EventArgs.Empty);
                    return;
                }
                min--;
                sec = 59;
            } else
            {
                sec--;
            }
        }

        public void Update()
        {
            UpdateCountdown();
            UpdateDisplay();
        }

        public void Reset()
        {
            Stop();
            switch (timer)
            {
                case 1:
                    min = _SettingsForm.GetT1Mins();
                    sec = _SettingsForm.GetT1Secs();
                    break;
                case 2:
                    min = _SettingsForm.GetT2Mins();
                    sec = _SettingsForm.GetT2Secs();
                    break;
                case 3:
                    min = _SettingsForm.GetT3Mins();
                    sec = _SettingsForm.GetT3Secs();
                    break;
                default:
                    return;
            }
            UpdateDisplay();
        }



    }
}
