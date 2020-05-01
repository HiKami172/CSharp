/*Дана строка, состоящая из строчных английских букв.
  Заменить в ней все буквы, стоящие после гласных,
  на следующие по алфавиту (z заменяется на a).*/

using System;
using System.Text;

namespace SharpLab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            for (int i = str.Length - 1; i > 0; i--)
            {
                if (str[i - 1] == 'a' || str[i - 1] == 'e' || str[i - 1] == 'i' || str[i - 1] == 'o' || str[i - 1] == 'u' || str[i - 1] == 'y')
                {
                    if (str[i] == 'z')
                    {
                        str[i] = 'a';
                        continue;
                    }
                    str[i]++;
                }
            }
            Console.WriteLine("Result: " + str.ToString());
            Console.ReadKey();
        }
    }
}
