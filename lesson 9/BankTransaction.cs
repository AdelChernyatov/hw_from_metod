using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class BankTransaction
    {
        readonly int Sum;
        public BankTransaction(int sum) 
        {
            Sum = sum;
            Console.WriteLine("Сумма с которой произвели операцию " + Sum);
            Console.WriteLine(DateTime.Now);
        }   
    }
}
