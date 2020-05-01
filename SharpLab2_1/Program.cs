/*В заданной строке поменять порядок слов на обратный (слова разделены пробелами)*/

using System;
using System.Text;

namespace SharpLab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            StringBuilder str = new StringBuilder(Console.ReadLine(), 50); //string to be reversed
            StringBuilder word = new StringBuilder(); //object for keeping words temporary
            int i = str.Length - 1;
          
            while(str[i+1] != ' ')
            {
                i--;
            }   //setting i to position before last word
            int RemoveLength = i + 2;   //setting length of future remove

            while (i >= 0)
            {
                while (i >= 0 && str[i] != ' ')
                {
                    word.Append(str[i]);
                    i--;
                }   //setting word in reverse order

                for (int k = word.Length - 1; k >= 0; k--)
                {
                    word.Append(word[k]);
                }   //adding straight order of word in temporal object
                word.Remove(0, word.Length / 2);    //removing reverse order from object
                str.Append(" " + word.ToString());  //adding word to resulting string
                word.Remove(0, word.Length);    //zeroing temporal object
                i--;    //skipping remaining space
            }   //reiteration until letters end
            str.Remove(0, RemoveLength);    //removing initial string

            Console.WriteLine("Result: " + str.ToString()); //output
            Console.ReadKey();
        }
    }
}
