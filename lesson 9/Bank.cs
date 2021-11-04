using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Bank_account
    {
        private string type_bank_number;
        private int balance;
        private Guid id;
        public int sum;
        public Bank_account(int Balance)
        {
            balance = Balance;
            Account_number();
            Console.WriteLine("Текущий баланс: " + balance);
        }
        public Bank_account(string Type_bank_number)
        {
            type_bank_number = Type_bank_number;
            Account_number();
            Console.WriteLine("Тип банковского счета: " + Type_bank_number);
        }
        public void Account_number()
        {
            id = Guid.NewGuid();
            Console.WriteLine(id);
        }
        public void Transfer(Bank_account num1, int sum)
        {
            if (balance > sum)
            {
                int newbalance1 = num1.Take_away(balance, sum);
                Console.WriteLine("Баланс 1-го осле перевода " + newbalance1);
                BankTransaction transf = new BankTransaction(sum);
                string change = Connection(transf);
                Push(change);
            }
            else { Console.WriteLine("На счету недостаточно средств"); }
            
        }
        public int Take_away(int balanc, int money)
        {
            return balanc - money;
        }
        public int Put(int balanc, int money)
        {
            return balanc + money;
        }
        private Queue<string> Myqueue = new Queue<string>();
        public string Connection(BankTransaction a) 
        {
            string Item_sum = a.ToString(); 
            return Item_sum;
        }
        public void Push(string word) 
        {
            Myqueue.Enqueue(word);
            foreach (string item in Myqueue) 
            {
                Console.WriteLine(item);
            }
        }       
        public void Dispose() 
        {
            
            File.WriteAllLines("transaction.txt",Myqueue);
            GC.SuppressFinalize(this); //очистка и освобождение ресурсов
        }
            
            


        
        

    }
    
}
