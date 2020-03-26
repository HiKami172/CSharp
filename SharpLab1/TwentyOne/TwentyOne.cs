using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOne
    {
        Deck deck;
        Player AI;
        Player player;
        public TwentyOne()
        {
            deck = new Deck();
            player = new Player();
            AI = new Player();
            player.TakeCard(ref deck);
            AI.TakeCard(ref deck);
        }

        public void PlayerInfo()
        {
            Console.WriteLine("Player's Cards: " + player.cards[0].Name);
            for(int i = 1; i < player.cardsAmount; i++)
                Console.WriteLine("                " + player.cards[i].Name);
            Console.WriteLine("Player's score: " + player.score);
        }
        public void FullInfo()
        {
            PlayerInfo();
            Console.WriteLine("AI's Cards: " + AI.cards[0].Name);
            for (int i = 1; i < AI.cardsAmount; i++)
                Console.WriteLine("            " + AI.cards[i].Name);
            Console.WriteLine("AI's score: " + AI.score);
        }
        public void TakeCard()
        {
            player.TakeCard(ref deck);
        }
        public int CondCheck1()
        {
            if (player.score > 21)
                return 1;
            else if (player.score == 21)
                return 2;
            else
                return 3;
        }
        public int CondCheck2()
        {
            if (AI.score > 21)
                return 1;
            else if (AI.score == 21)
                return 2;
            else
            {
                if (AI.score < player.score)
                    return 3;
                else if (AI.score > player.score)
                    return 4;
                else
                    return 5;
            }
        }
        public void Finish()
        {
            float WinPos = 1f;
            while (WinPos > 0.5f && AI.score < 21)
            {
                AI.TakeCard(ref deck);
                int[] CardsArr = { 4, 4, 4, 4, 4, 4, 4, 4, 4 };
                for(int i = 0; i < AI.cardsAmount; i++ )
                {
                    CardsArr[AI.cards[i].GetTypeIndex()]--;
                }
                int RelevantCards = 0;
                for (int i = 0; i < 9; i++)
                {
                    if (((Type)i).GetCost() <= 21 - AI.score)
                    {
                        RelevantCards += CardsArr[i];
                    }
                }
                WinPos = (RelevantCards) / (36f - CardsArr[0]);
            }
        }
    }
}
