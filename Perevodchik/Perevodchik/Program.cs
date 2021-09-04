using System;

namespace Perevodchik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для перевода: ");
            try
            {
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                    Console.WriteLine("Число должно быть больше ноля");          
                Console.Write("Введите СС: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(Convert.ToString(a, b));             
            }
            catch (FormatException)
            {
                Console.WriteLine("Это не число");
            }

        }
    }
}

