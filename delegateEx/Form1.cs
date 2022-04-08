using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegateEx
{
    public partial class Form1 : Form
    {
        delegate void myDelegate();
        myDelegate test;
        //Action - это частный случай делегата, который заранее известен системе. Не имеет return.
        //Не возвращает значение!!!
        Action<int,int,double> action;
        //Func - частный случай делегата, который должен возвращать значения
        Func<int,int,int> func;

        Func<int, double> Half; //Последнее знаение в <> это возвращаемого значения
                                //double - тип возвращаемого значения!!!
        public Form1()
        {
            InitializeComponent();
            test = new myDelegate(Message);
            action = new Action<int,int,double>(Sum);
            func = new Func<int,int,int>(Summ);
            Half = new Func<int, double>(x05);
        }

       /* void buttonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Нажал!");
        }*/
        void Sum(int a, int b, double c)
        {
            MessageBox.Show("Ответ: " + (a + b + c).ToString());
        }
        double x05(int a)
        {
            return a * 0.5;
        }
        int Summ(int a, int b)
        {
            return a + b;
        }
        void Message()
        {
            MessageBox.Show("Привет мир!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Button button = new Button();
            button.Text = "Делегат";
            button.Left = 100;
            button.Top = 100;
            button.Click += buttonClick;
            Controls.Add(button);*/   //Добавляет кнопку на форму
            test();
            action(10, 15, 10.5);

            int x = func(10, 5);    //Func можно присвоить в переменную, action - нет
            MessageBox.Show(x.ToString());

            double y = Half(10);
            MessageBox.Show(y.ToString());
        }
    }
}
