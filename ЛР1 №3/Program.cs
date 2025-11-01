using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пол: ");
            string g = Console.ReadLine().ToLower();
            //первый комментарий
            if (g == "м")
            {
                Console.WriteLine("Возможные мужские имена: ");
                Console.WriteLine("Алексей");
                Console.WriteLine("Владимир");
                Console.WriteLine("Кирилл");
            }
            else if(g == "ж")
            {
                Console.WriteLine("Возможные женские имена: ");
                Console.WriteLine("Анастасия");
                Console.WriteLine("Екатирина");
                Console.WriteLine("Татьяна");
            }
            //вывод сообщения в неккоректном вводе
            else
            {
                Console.WriteLine("Некорректный ввод. Введите 'м' или 'ж' ");
                
            }
        }
    }
}
