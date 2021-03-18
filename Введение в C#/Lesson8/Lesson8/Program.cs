using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {            
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.Write("Введите имя пользователя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.Write("Введите возраст пользователя: ");
                Properties.Settings.Default.UserAge = Console.ReadLine();
                Console.Write("Введите род деятельности пользователя: ");
                Properties.Settings.Default.UserCareer = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            Console.WriteLine($"{String.Format(Properties.Settings.Default.Greeting, Properties.Settings.Default.UserName, Properties.Settings.Default.UserAge, Properties.Settings.Default.UserCareer)}");
            Console.ReadKey();
        }
    }
}
