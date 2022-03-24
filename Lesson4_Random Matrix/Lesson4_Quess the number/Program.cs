using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Quess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальное число диапозона: ");
            int Number= int.Parse(Console.ReadLine());
            Random random = new Random();
            int GuessNumber = random.Next(Number);
            string Next;
            int UserNumber;
            while (true)
            {
                Console.Write("Введите число: ");
                Next = Console.ReadLine();
                if (Next == "")
                {
                    Console.WriteLine($"\nЗагаданное число:{GuessNumber}");
                    Console.ReadKey();
                    break;
                }
                else
                {
                     UserNumber = Convert.ToInt32(Next);
                    if (UserNumber > GuessNumber)
                        Console.WriteLine("Введенное число больше загадого.");
                    else if (UserNumber < GuessNumber)
                        Console.WriteLine("Введенное число меньше заданого.");
                    else
                    {
                        Console.WriteLine("\nПоздравляю, вы угадали!!!!");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}
