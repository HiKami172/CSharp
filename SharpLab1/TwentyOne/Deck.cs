using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Deck
    {
        Card[,] cards;

        public Deck()
        {
            cards = new Card[9, 4];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 4; j++)
                    cards[i, j] = new Card((Type)i, (Suit)j);

        }

        public void DeleteCard(int typeId, int suitId)
        {
            cards[typeId, suitId] = null;
        }
        public Card GetCard()
        {
            Random random = new Random();
            int typeId = random.Next() % 9;
            int suitId = random.Next() % 4;
            while (cards[typeId, suitId] == null)
            {
                typeId = random.Next() % 9;
                suitId = random.Next() % 4;
            }
            Card ThisCard = cards[typeId, suitId];
            DeleteCard(typeId, suitId);
            return ThisCard;
        }
    }
}
