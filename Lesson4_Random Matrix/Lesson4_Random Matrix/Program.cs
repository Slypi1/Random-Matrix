using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Random_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите количество строк: ");
            int String = int.Parse(Console.ReadLine());
            Console.Write("Ввидите количество столбцов: ");
            int Column = int.Parse(Console.ReadLine());

            int[,] Matrix = new int[String, Column];

            int SumNumber = 0;

            Random random = new Random();
            for (int i = 0; i < String; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Matrix[i, j] = random.Next(100);
                    SumNumber=SumNumber + Matrix[i, j];
                    Console.Write($"{Matrix[i, j]} ");
                    
                }
                    
                Console.WriteLine();
            }
          

            Console.WriteLine($"Сумма: {SumNumber}");
            Console.ReadKey(); 
        }
    }
}
