using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");// Ввод первой строки
            string str1 = Console.ReadLine();

            Console.Write("Введите вторую строку: ");// Ввод второй строки
            string str2 = Console.ReadLine();

            if (str1.Contains(str2))// Проверка, является ли вторая строка подстрокой первой
            {
                Console.WriteLine("Вторая строка является подстрокой первой.");
            }
            else
            {
                Console.WriteLine("Вторая строка не является подстрокой первой.");
            }
            Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");// Задержка перед закрытием консоли
            Console.ReadLine();
        }
    }
}
