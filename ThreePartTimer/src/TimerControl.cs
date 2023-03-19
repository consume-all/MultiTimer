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

        private readonly int timer;

        private int min;
        private int sec;

        public bool enabled = false;
        public int init_min;
        public int init_sec;
        public event EventHandler ThresholdReached;

        public TimerControl(int timer_inst, MainForm main_form)
        {
            timer = timer_inst;
            _MainForm = main_form;
        }

        public void Start()
        {

            min = init_min;
            sec = init_sec;
            enabled = true;
            return;
            
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
                    _MainForm.t1UpdateDynamLabel(String.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0')));
                    break;
                case 2:
                    _MainForm.t2UpdateDynamLabel(String.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0')));
                    break;
                case 3:
                    _MainForm.t3UpdateDynamLabel(String.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0')));
                    break;
                default:
                    return;
            }
            
        }

        private void UpdateCountdown()
        {
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

            min = init_min;
            sec = init_sec;

            UpdateDisplay();
        }


    }
}
