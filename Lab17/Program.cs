using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<byte> account1 = new Account<byte>();
            account1.Num = 1;
            account1.Balance = 1000000;
            account1.Name = "Иванов Иван Иванович";
            account1.ShowInfo();
            Account<string> account2 = new Account<string>();
            account2.Num = "007";
            account2.Balance = 777;
            account2.Name = "James Bond";
            Console.WriteLine(account2.Num);
            Console.WriteLine(account2.Balance);
            Console.WriteLine(account2.Name);
            Account<int> account3 = new Account<int>();
            account3.Num = 100000;
            account3.Balance = 100;
            account3.Name = "Скрудж Макдак";
            account3.ShowInfo();
            Console.ReadKey();
        }
    }
}
