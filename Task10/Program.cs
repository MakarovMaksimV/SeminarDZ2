using System;
namespace SEMINARDZ2
{
    class Program
    {
        static void Main()
        {
            
            int numberRnd = new Random().Next(100, 1000);
            System.Console.WriteLine("Рандомное 3-х значное число: " + numberRnd);
            int number = (numberRnd % 100) / 10; 
            System.Console.WriteLine("Вторая цифра этого числа: " + number);
        }
    }    
}