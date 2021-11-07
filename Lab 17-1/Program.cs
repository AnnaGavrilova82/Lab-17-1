using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Номера счета ");
            string str = Console.ReadLine();
            Console.Write("Введите баланс ");
            double balanse = Convert.ToDouble( Console.ReadLine());
            Console.Write("Введите ФИО ");
            string name = Console.ReadLine();
            Bank<string> bank1 = new Bank<string>();
            bank1.Enter(ref str, balanse, name);
            bank1.Print();
            Console.WriteLine("");
            Console.Write("Введите Номера счета ");
            int str2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите баланс ");
            balanse = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ФИО ");
            name = Console.ReadLine();
            Bank<int> bank2 = new Bank<int>();
            bank2.Enter(ref str2, balanse, name);
            bank2.Print();
            
            Console.ReadKey();
        }

        class Bank<T>
        {
            private T Id;
            private double Balance;
            private string Name;

            public void Enter(ref T str, double balance, string name)
            {
                Id = str;
                Balance = balance;
                Name = name;


            }
            public void Print()
            {
                Console.WriteLine($"Номера счета {Id}");
                Console.WriteLine($"Баланс {Balance}");
                Console.WriteLine($"ФИО {Name}");
            }
        }
    }
}
