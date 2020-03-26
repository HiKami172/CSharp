/*Рассчитать максимальную степень двойки, на которую делится произведение подряд идущих чисел от a до b (числа целые 64-битные без знака)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lower boundary: ");
            long a = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter upper boundary: ");
            long b = Convert.ToInt64(Console.ReadLine());

            bool Even = a % 2 == 0 ? true : false;
            long EvenNum = (b - a + 1) % 2 == 0 ? (b - a + 1) / 2 : Even ? (b - a + 1) / 2 + 1 : (b - a + 1) / 2;
            long Degree = 0;
            long FirstEven = Even ? a : a + 1;
            for (int i = 0; i < EvenNum; i++)
            {
                long CheckNum = 2 * i + FirstEven;
                while(CheckNum % 2 != 1)
                {
                    Degree++;
                    CheckNum /= 2;
                }
            }

            Console.WriteLine("Result: " + Convert.ToString(Degree));
            Console.ReadKey();
        }
    }
}
