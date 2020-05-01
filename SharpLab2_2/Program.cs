/*Рассчитать максимальную степень двойки, на которую делится произведение подряд идущих чисел от a до b (числа целые 64-битные без знака)*/

using System;

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

            bool Even = a % 2 == 0 ? true : false; //checking if lower boundary is an even number
            long EvenNum = (b - a + 1) % 2 == 0 ? (b - a + 1) / 2 : Even ? (b - a + 1) / 2 + 1 : (b - a + 1) / 2; //amount of even numbers within the interval
            long Degree = 0;
            long FirstEven = Even ? a : a + 1; //the smallest even number within the interval
            for (int i = 0; i < EvenNum; i++)
            {
                long CheckNum = 2 * i + FirstEven; //even number to check
                while(CheckNum % 2 != 1)           //setting degree of 2 in CheckNum canonic representation
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
