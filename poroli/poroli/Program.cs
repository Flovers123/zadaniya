using System;

namespace poroli
{
    class Program
    {
            static void Main(string[] args)
            {
            m:
                Console.WriteLine("Выберите сложность пароля: легкий, средний, сложный");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "легкий":
                        int x;
                        Random rnd = new Random();
                        x = rnd.Next(1000, 9999);
                        Console.WriteLine($"Ваш пароль: {x}");
                        goto m;
                case "средний":
                    int y;
                    Random rrb = new Random();
                    y = rrb.Next(10000000, 99999999);
                    Console.WriteLine($"Ваш пароль: {y}");
                    goto m;
                case "сложный":
                        string iPass = "";
                        string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
                        Random rnd1 = new Random();
                        for (int i = 0; i < 16; i = i + 1)
                        {
                            iPass = iPass + arr[rnd1.Next(0, 57)];
                        }
                        Console.WriteLine(iPass);
                        goto m;
                }
            }
    }
}
    

