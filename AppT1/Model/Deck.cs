using AppT1.Handler;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppT1.Model
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        private int index = 0;

        public Deck(int index)
        {
            this.index = index;

            for(int s = 0; s < 4; s++)
            {
                cards.Add(new Card("2", (Suit) s, 2));
                cards.Add(new Card("3", (Suit)s, 3));
                cards.Add(new Card("4", (Suit)s, 4));
                cards.Add(new Card("5", (Suit)s, 5));
                cards.Add(new Card("6", (Suit)s, 6));
                cards.Add(new Card("7", (Suit)s, 7));
                cards.Add(new Card("8", (Suit)s, 8));
                cards.Add(new Card("9", (Suit)s, 9));
                cards.Add(new Card("10", (Suit)s, 10));
                cards.Add(new Card("J", (Suit)s, 11));
                cards.Add(new Card("Q", (Suit)s, 12));
                cards.Add(new Card("K", (Suit)s, 13));
                cards.Add(new Card("A", (Suit)s, 14));
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            
            for(int i = 0; i < cards.Count; i++)
            {
                int pos = random.Next(0, 52);
                Card other = cards[pos];
                cards[pos] = cards[i];
                cards[i] = other;
            }
        }

        public void Print()
        {
            foreach(var card in cards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public Card Deal()
        {
            if(index >= cards.Count)
            {
                throw new CardsNotAvailableException();
            }

            Card card = cards[index++];
            return card;
        }

        public Hand DealHand()
        {
            List<Card> hand = new List<Card>();

            for(int i = 0; i < 5; i++)
            {
                hand.Add(this.Deal());
            }

            return new Hand(hand);
        }
    }
}
