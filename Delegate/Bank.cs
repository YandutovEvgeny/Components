using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    //Делегат - ссылка на функцию, благодаря делегатам мы можем в качестве аргументов писать функцию
    //которая нам нужна
    class Bank
    {
        int money;
        public delegate void MessageType(string message);

        public Bank()
        {
            money = 0;
        }

        public void AddMoney(int sum)
        {
            money += sum;
        }
        public void GetInfo(MessageType messageType)
        {
            messageType($"Остаток на вашем счету {money} рублей");
        }

        public int GetMoney(int sum)
        {
            if(money - sum >=0)
            {
                money -= sum;
                return sum;
            }
            else
            {
                return 0;
            }
        }
    }
}
