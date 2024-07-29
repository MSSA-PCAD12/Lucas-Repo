using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Demo.OODemo
{
    public class Deck
    {
        public Card[] Cards = new Card[52];

        public Deck()
        {
            int cardPosition = 0;
            foreach (var suit in Enum.GetValues<Suit>())
            {
                foreach (var rank in Enum.GetValues<Rank>())
                {
                    Cards[cardPosition] = new Card { Rank = rank, Suit = suit };
                    cardPosition++;
                }
            }
        }

    }
}