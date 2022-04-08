using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace one
{
    class ButtonMove
    {
        Form form;
        Button button1;
        delegate void Path();
        Path path;

        public ButtonMove(Button button, Form form)
        {
            button1 = button;
            this.form = form;
            path = new Path(ButtonLeft);
        }

        public void Run()
        {
            path();
        }
        void ButtonLeft()
        {
            button1.Left += 5;
            if (button1.Left > form.Width - button1.Width)
            {
                button1.Left = form.Width - button1.Width;
                path = new Path(ButtonDown);
            }
        }
        void ButtonDown()
        {
            button1.Top += 5;
            if (button1.Top > form.Height - button1.Height - 45)
            {
                button1.Top = form.Height - button1.Height - 45;
                path = new Path(ButtonRight);
            }
        }
        void ButtonRight()
        {
            button1.Left -= 5;
            if (button1.Left < 0)
            {
                button1.Left = 0;
                path = new Path(ButtonUp);
            }
        }
        void ButtonUp()
        {
            button1.Top -= 5;
            if (button1.Top < 15)
            {
                button1.Top = 15;
                path = new Path(ButtonLeft);
            }
        }
    }
}
