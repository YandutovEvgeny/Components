using System;
using System.Windows.Forms;

namespace PathToWork
{
    public partial class Form1 : Form
    {
        delegate void Way();
        Way myWay;
        public Form1()
        {
            InitializeComponent();
            myWay = new Way(Home);
        }
        
        void Home()
        {
            MessageBox.Show("Я выехал из дома!");
        }
        void Eat()
        {
            MessageBox.Show("Я поел по дороге!");
        }
        void Call()
        {
            MessageBox.Show("Я побеседовал по телефону!");
        }
        void Oil()
        {
            MessageBox.Show("Я заправил свой автомобиль!");
        }
        void Work()
        {
            MessageBox.Show("Я приехал на работу!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myWay += Eat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myWay += Oil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myWay += Call;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myWay += Work;
            myWay();
            myWay = new Way(Home);
        }
    }
}
