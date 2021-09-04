using System;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Z;
            int P = 0; int L = 0;
            string word, EX;
            bool Выход = false;
            Console.WriteLine("Камень - Ножницы - Бумага!");

            while (!Выход)
            {
                Console.WriteLine("Выберите (ножницы / бумага / камень) ? Для выхода наберите(выход).");
                word = Console.ReadLine();
                word = word.ToLower().Trim();
                if (word == "выход" || P == 20 || L == 20) goto FINISH;

                Random random = new Random();
                Z = random.Next(3);
                switch (Z)
                {
                    case 0: Console.WriteLine("ПК выбрал — камень!"); break;
                    case 1: Console.WriteLine("ПК выбрал — ножницы!"); break;
                    default: Console.WriteLine("ПК выбрал — бумага!"); break;
                }
                if (word == "камень")
{
                    Console.WriteLine("Ваш выбор — " +word);
                    if (Z == 0) {  Console.WriteLine("Ничья"); }
                    else if (Z == 1) {  Console.WriteLine("Победили"); P++; }
                    else {  Console.WriteLine("Проигрыш"); L++; }
                }
else if (word == "ножницы")
{
                    Console.WriteLine("Ваш выбор — " +word);
                    if (Z == 1) {  Console.WriteLine("Ничья"); }
                    else if (Z == 2) {  Console.WriteLine("Победили"); P++; }
                    else {  Console.WriteLine("Проигрыш"); L++; }
                }
else if (word == "бумага")
{
                    Console.WriteLine("Ваш выбор — " +word);
                    if (Z == 2) {  Console.WriteLine("Ничья"); }
                    else if (Z == 0) {  Console.WriteLine("Победили"); P++; }
                    else {  Console.WriteLine("Проигрыш"); L++; }
                }
else
                {
                    Console.WriteLine("Ваш выбор — неизвестен программе.Хотите выйти(да / нет) ?");
                    EX = Console.ReadLine();
                    EX = EX.ToLower().Trim();
                    if (EX == "да") Выход = true;
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }

        FINISH:
            Console.WriteLine("Вы победили " +P + " раз!");
            Console.WriteLine("Вы проиграли " +L + " раз!");
            Console.WriteLine("Осуществляется выход, нажмите любую клавишу. . .");
            Console.ReadKey();
        }
    }
}
