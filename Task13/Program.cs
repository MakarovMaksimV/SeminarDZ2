using System;
namespace SEMINARDZ2
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("Введите положительное целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 100);
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                if (number > 99 & number < 1000)
                {
                    number = number % 10;
                    System.Console.WriteLine("Третья цифра в данном числе: " + number);
                }
                else
                System.Console.WriteLine("В данном числе нет третьей цифры");
            }
        }
    }
}