using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {
        Bank bank;
        delegate int SomeMath(int a, int b);
        SomeMath test;
        public Form1()
        {
            InitializeComponent();
            bank = new Bank();
            test = new SomeMath(Plus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bank.AddMoney(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank.GetMoney(100);
        }
        void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }
        void ShowInConsole(string message)
        {
            Console.WriteLine(message);
        }
        void ShowMessageWithADS(string message)
        {
            message += " <Купите наших котят!>";
            MessageBox.Show(message);
        }

        int Plus(int a, int b)
        {
            return a + b;
        }
        int Minus(int a, int b)
        {
            return a - b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bank.GetInfo(ShowMessageWithADS);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(test(5, 6).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(test(5, 6).ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                test = new SomeMath(Plus);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                test = new SomeMath(Minus);
            }
        }
        int Multy(int a, int b)
        {
            MessageBox.Show((a + b).ToString());
            return 0;
        }

        int A = 0;
        int TEST(int a, int b)
        {
            A += b;
            return 0; 
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                test = new SomeMath(TEST);
                test += TEST;
                test += TEST;
                test(0, 10);
                MessageBox.Show(A.ToString());
            }
        }
    }
}
