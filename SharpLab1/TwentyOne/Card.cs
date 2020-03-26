using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Card
    {
        Type type;
        Suit suit;
        public string Name { get { return type.GetName() + " of " + suit.GetName(); } }
        public Card(Type type, Suit suit)
        {
            this.type = type;
            this.suit = suit;
        }
        public int GetCost()
        {
            return type.GetCost();
        }
        public int GetTypeIndex()
        {
            return (int)type;
        }
    }
}
