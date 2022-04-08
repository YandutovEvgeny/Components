using System.Drawing;
using System.Windows.Forms; //Нужна для наследования от PictureBox
using System;

namespace Clocks
{
    class AnalogClock:PictureBox
    {
        public Color BackGroundColor { get; set; }  //Цвет фона
        public Color HourArrowColor { get; set; }   //Цвет стрелок
        public Color MinuteArrowColor { get; set; }
        public Color SecondArrowColor { get; set; }
        public int HourArrowWidth { get; set; } //Ширина стрелок
        public int MinuteArrowWidth { get; set; }
        public int SecondArrowWidth { get; set; }
        public Image BackGroundClockImage { get; set; }  //Картинка фона
        public bool UseImage { get; set; }

        private DateTime time;
        private Timer timer;
        private Graphics graphics;

        public AnalogClock()    //Конструктор по умолчанию
        {
            BackGroundColor = Color.White;
            HourArrowColor = Color.Green;
            MinuteArrowColor = Color.Red;
            SecondArrowColor = Color.Blue;
            HourArrowWidth = 6;
            MinuteArrowWidth = 4;
            SecondArrowWidth = 2;
            Width = 250;
            Height = 250;
            UseImage = false;
            timer = new Timer();
            timer.Interval = 1000;  //Таймер обновляется раз в секунду(1000 мс)
            timer.Tick += TimerTick;
            graphics = CreateGraphics();
        }

        private void DrawCircle()
        {
            SolidBrush brush = new SolidBrush(BackGroundColor);
            graphics.FillEllipse(brush, 0, 0, Width, Height);
        }
        private void DrawArrow(Color arrowColor, int width, int length, float angle)
        {
            angle -= 90;
            float x = Width / 2;
            float y = Height / 2;

            float x1 = (float)Math.Cos((Math.PI / 180) * angle) * length + x;
            float y1 = (float)Math.Sin((Math.PI / 180) * angle) * length + y;
            Pen pen = new Pen(arrowColor, width);
            graphics.DrawLine(pen, x, y, x1, y1);
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
            int arrowsLenght = Width > Height ? Height : Width; //Берём по меньшей стороне
            arrowsLenght /= 3;
            graphics = CreateGraphics();
            if(UseImage == true && BackGroundClockImage != null)
            {
                graphics.DrawImage(BackGroundClockImage, 0, 0, Width, Height);
            }
            else
            {
                DrawCircle();
            }
            time = DateTime.Now;
            DrawArrow(HourArrowColor, HourArrowWidth, (int)(arrowsLenght * 0.5), time.Hour * 30 + time.Minute/2);
            DrawArrow(MinuteArrowColor, MinuteArrowWidth, (int)(arrowsLenght * 0.7), time.Minute * 6);
            DrawArrow(SecondArrowColor, SecondArrowWidth, (int)(arrowsLenght * 0.9), time.Second * 6);
        }
    }
}
