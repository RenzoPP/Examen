using System;
using System.Collections.Generic;
using System.Text;

namespace AppT1.Model
{
    public class Hand
    {
        private List<Card> cards;

        public Hand(List<Card> cards)
        {
            this.cards = cards;
        }

        public void Print()
        {
            foreach(var card in cards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public bool isFullHouse()
        {
            if(cards[0].value == cards[1].value && cards[1].value == cards[2].value
                && cards[3].value == cards[4].value && cards[0].value != cards[3].value)
            {
                return true;
            }

            return false;
        }

        public bool isFlushed()
        {
            if (cards[0].symbol == Suit.Spades && cards[1].symbol == Suit.Spades
                && cards[2].symbol == Suit.Spades && cards[3].symbol == Suit.Spades 
                && cards[4].symbol == Suit.Spades )
            {
                return true;
            }

            if (cards[0].symbol == Suit.Diamonds && cards[1].symbol == Suit.Diamonds
                && cards[2].symbol == Suit.Diamonds && cards[3].symbol == Suit.Diamonds
                && cards[4].symbol == Suit.Diamonds)
            {
                return true;
            }

            if (cards[0].symbol == Suit.Clubs && cards[1].symbol == Suit.Clubs
                && cards[2].symbol == Suit.Clubs && cards[3].symbol == Suit.Clubs
                && cards[4].symbol == Suit.Clubs)
            {
                return true;
            }

            if (cards[0].symbol == Suit.Hearts && cards[1].symbol == Suit.Hearts
                && cards[2].symbol == Suit.Hearts && cards[3].symbol == Suit.Hearts
                && cards[4].symbol == Suit.Hearts)
            {
                return true;
            }

            return false;
        }
    }
}
