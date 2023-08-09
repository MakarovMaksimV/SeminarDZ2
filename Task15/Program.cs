using System;

namespace SEMINARDZ2
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("Введите число от 1 до 7 обозначающий день недели: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 & number <= 7)
            {
                if (number == 6 || number == 7)
                {
                    Console.WriteLine ("Этот день является выходным");
                }
                else
                {
                    System.Console.WriteLine("Этот день не выходной");
                }
            }
            else
            {
                System.Console.WriteLine("Введено не корректное число!");
            }
        }
    }
}