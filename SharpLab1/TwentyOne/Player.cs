using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Player
    {
        public Card[] cards { get; private set; }
        public int cardsAmount { get; private set; }
        public int score { get; private set; }
        
        public Player()
        {
            cards = new Card[1];
            cardsAmount = 0;
        }
        public void TakeCard(ref Deck deck)
        {
            if (cardsAmount > 0)
            {
                Card[] cardsTemp = new Card[cardsAmount + 1];
                for (int i = 0; i < cardsAmount; i++)
                    cardsTemp[i] = cards[i];
                cardsTemp[cardsAmount] = deck.GetCard();
                cards = cardsTemp;
                cardsAmount++;
                SetScore();
                return;
            }
            cards[cardsAmount] = deck.GetCard();
            cardsAmount++;
            SetScore();
        }
        void SetScore()
        {
            score = 0;
            int i = 0;
            do
            {
                score += cards[i].GetCost();
                i++;
            } while (i < cardsAmount);
        }
    }
}
