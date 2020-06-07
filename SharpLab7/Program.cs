using System;

namespace RationalRepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational rational1, rational2, rational3;
            Rational.TryParse("2/7", out rational2);
            Rational.TryParse("4/9", out rational1);
            Rational rational4 = Rational.Parse("2/3");
            Rational.TryParse("2c/3", out rational3);
            Console.WriteLine("Conversion to string:");
            Console.WriteLine(rational1.ToString());
            Console.WriteLine(rational2.ToString());
            Console.WriteLine(rational3.ToString());
            Console.WriteLine(rational4.ToString());

            Console.WriteLine("Operations with 4/9 and 2/7 :");
            Console.WriteLine("Addition:" + (rational1 + rational2).ToString());
            Console.WriteLine("Subtraction:" + (rational1 - rational2).ToString());
            Console.WriteLine("Division:" + (rational1 / rational2).ToString());
            Console.WriteLine("Multiplication:" + (rational1 * rational2).ToString());
            Console.WriteLine("Percent:" + (rational1 % rational2).ToString());
            Console.WriteLine("Greater:" + (rational1 > rational2).ToString());
            Console.WriteLine("Less:" + (rational1 < rational2).ToString());
            Console.WriteLine("Greater or equal:" + (rational1 >= rational2).ToString());
            Console.WriteLine("Less or equal:" + (rational1 <= rational2).ToString());
            Console.WriteLine("Equal:" + (rational1 == rational2).ToString());
            Console.WriteLine("Not equal:" + (rational1 != rational2).ToString());

            Console.WriteLine("Increments and Decrements:");
            Console.WriteLine("()++ " + (rational1++).ToString());
            Console.WriteLine("++() " + (++rational1).ToString());
            Console.WriteLine("()-- " + (rational1--).ToString());
            Console.WriteLine("--() " + (--rational1).ToString());
            Console.WriteLine("-() " + (-rational1).ToString());
            Console.WriteLine("+() " + (+rational1).ToString());

            Console.WriteLine("Square root: " + Rational.Pow(rational1, 0.5).ToString());
            rational1.Pow(2);
            Console.WriteLine("After raising to power of 2: " + rational1.ToString());
            rational1 %= rational2;
            Console.WriteLine(rational1.ToStringFormat(6));
        }
    }
}
