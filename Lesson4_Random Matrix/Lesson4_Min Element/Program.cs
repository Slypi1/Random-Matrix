using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Min_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите длину последовательности: ");
            int Leght= int.Parse(Console.ReadLine());
            int[] Facts = new int[Leght];
            Console.WriteLine("Ввидите целое число: ");
            int MinElement = int.MaxValue;
            for (int i = 0; i < Leght; i++)
            {
                Facts[i] = int.Parse(Console.ReadLine());
                if (Facts[i] < MinElement)
                    MinElement = Facts[i];
            }
            
            Console.WriteLine($"Минимальное значение: {MinElement}");
            Console.ReadKey();  



        }
    }
}
