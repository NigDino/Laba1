using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{

    public class Receipt
    {
        int number;
        string date;
        float amount;

        public Receipt()
        {
            number = 0;
            date = "12/12/2012";
            amount = 1;
        }
        public void show()
        {
            Console.WriteLine($"Номер квитанции: {number}");
            Console.WriteLine($"Дата:{date}");
            Console.WriteLine($"Сумма: {amount}");








        }

        static void Main(string[] args)
        {
            Receipt one = new Receipt();
            one.number = 12;
            one.date = "13/12/2012";
            one.amount = 2;
            one.show();

        }
    }
}
