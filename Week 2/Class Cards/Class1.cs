using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Demo.OODemo
{
    public class CardShoe
    {
        private Card[] cards;
        public bool IsShuffled = false;
        private Queue<Card> queueOfCards;
        public int NumberOfCards => this.cards.Length;

        public CardShoe(int numberOfDecks)
        {
            cards = new Card[numberOfDecks * 52];
            for (int i = 0; i < numberOfDecks; i++)
            {
                Deck deck = new Deck();
                Array.Copy(deck.Cards, 0, cards, i * 52, deck.Cards.Length);
            }
            queueOfCards = new Queue<Card>(cards);

        }
        public void ShuffleCards(int howManyTimes = 1)
        {

            for (int i = 0; i < howManyTimes; i++)
            {
                _shuffleCards();
            }

            IsShuffled = true;
            _loadShuffledCardsIntoQueue();
        }

        public Card DealOneCard() => queueOfCards.Dequeue();

        public IEnumerable<Card> DealMultipleCards(int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                yield return queueOfCards.Dequeue();
            }
        }
        private void _loadShuffledCardsIntoQueue()
        {
            this.queueOfCards = new Queue<Card>(this.cards);
        }

        private void _shuffleCards()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                int randomNumber = Random.Shared.Next(0, cards.Length);
                Card tempCard = cards[randomNumber];
                cards[randomNumber] = cards[i];
                cards[i] = tempCard;
            }
        }
    }
}