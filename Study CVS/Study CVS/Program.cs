using System;

namespace Study_CVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string x = Console.ReadLine();
            Console.WriteLine($"Привет, {x}!");
            Console.WriteLine("Чтобы продолжить введите ваш IQ ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y > 150) 
            {
                Console.WriteLine("Вы можете продолжить...");
            }
            else if (y < 150)
            {
                Console.WriteLine("Для продолжения необходимо иметь более выской показатель, тренеруйтесь!");
            }

        }
    }
}
