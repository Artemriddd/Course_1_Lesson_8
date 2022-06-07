using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_8_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Hello);
            if (string.IsNullOrEmpty(Properties.Settings.Default.Fio))
            {
                Console.Write("Введите имя пользователя: ");
                Properties.Settings.Default.Fio = Console.ReadLine();
                Console.Write("Введите Возраст: ");
                Properties.Settings.Default.Age = Int32.Parse(Console.ReadLine());
                Console.Write("Введите профессию: ");
                Properties.Settings.Default.Profession = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.Write("Имя пользователя: ");
                Console.WriteLine(Properties.Settings.Default.Fio);
                Console.Write("Возраст: ");
                Console.WriteLine(Properties.Settings.Default.Age);
                Console.Write("Профессия: ");
                Console.WriteLine(Properties.Settings.Default.Profession);
            }
            Console.ReadKey(true);
        }
    }
}
