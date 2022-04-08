using System;
using System.Drawing;
using System.Windows.Forms;

namespace FrameClock
{
    public class Frame_Clock : Label
    {
        private DateTime time;
        private Timer timer;

        public Frame_Clock()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += TimerTick;
        }
        public void Start()
        {
            timer.Enabled = true;
        }
        public void Stop()
        {
            timer.Enabled = false;
        }
        void TimerTick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            Text = $"{Convert.ToString(time.Hour)} : {Convert.ToString(time.Minute)} : {Convert.ToString(time.Second)}";
        }
    }
}
