using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    enum Suit
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs,

        none
    }

    static class SuitMethods
    {
        public static string GetName(this Suit suit)
        {
            switch (suit)
            {
                case Suit.Spades:
                    return "Spades";
                case Suit.Hearts:
                    return "Hearts";
                case Suit.Diamonds:
                    return "Diamonds";
                case Suit.Clubs:
                    return "Clubs";
                default:
                    return "";
            }
        }
    }
}
