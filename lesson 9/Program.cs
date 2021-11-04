using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Program
    {
        static int Verification() //проверка на int исключения
        {
            int n = 0;
            if (int.TryParse(Console.ReadLine(), out n)) { }
            else { Console.WriteLine("Вы ввели неверный формат"); }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("9.1");
            Console.WriteLine("Введите баланс 1-го");
            int Balance = Verification();
            Bank_account p = new Bank_account(Balance);
            Console.WriteLine("Введите тип банковского счета");
            Bank_account P = new Bank_account(Console.ReadLine());
            //9.2
            Console.WriteLine("9.2");
            Bank_account num1 = new Bank_account(Balance);
            Console.WriteLine("Введите баланс 2-го");
            int Balance2 = Verification();
            Bank_account num2 = new Bank_account(Balance2);
            Console.WriteLine("Сумма которую вы хотите перевести");
            int money = Verification();
            num1.Transfer( num1, money);
            int new_balance2= num2.Put(Balance2, money);
            Console.WriteLine("Баланс 2 после зачисления " + new_balance2);
            Console.WriteLine("hw 9.1");
            List<Song> songs = new List<Song>();
            songs.Add(new Song("Корабли", null,"Лизер"));
            songs.Add(new Song("Пачка сигарет", "Лизер", songs[0]));
            songs.Add(new Song("На луне", "Фараон", songs[1]));
            songs.Add(new Song("На луне", "Фараон", songs[2]));
            foreach (Song line in songs)
            {
                Console.WriteLine(line.Title());
            }
            Console.WriteLine(songs[0].Equals(songs[1]));





        }
    }
}
