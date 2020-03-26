using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    enum Type
    {
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace,

        none
    }

    static class TypeMethods
    {
        public static string GetName(this Type type)
        {
            switch (type)
            {
                case Type.Six:
                    return "Six";
                case Type.Seven:
                    return "Seven";
                case Type.Eight:
                    return "Eight";
                case Type.Nine:
                    return "Nine";
                case Type.Ten:
                    return "Ten";
                case Type.Jack:
                    return "Jack";
                case Type.Queen:
                    return "Queen";
                case Type.King:
                    return "King";
                case Type.Ace:
                    return "Ace";
                default:
                    return "";
            }
        }
        public static int GetCost(this Type type)
        {
            switch (type)
            {
                case Type.Six:
                    return 6;
                case Type.Seven:
                    return 7;
                case Type.Eight:
                    return 8;
                case Type.Nine:
                    return 9;
                case Type.Ten:
                    return 10;
                case Type.Jack:
                    return 2;
                case Type.Queen:
                    return 3;
                case Type.King:
                    return 4;
                case Type.Ace:
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
