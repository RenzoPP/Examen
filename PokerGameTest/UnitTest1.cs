using AppT1;
using AppT1.Handler;
using AppT1.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PokerGameTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Case01()
        {
            Assert.Throws(typeof(NegativeNumberException), () => Program.VerifyNumPlayers(-2));
        }

        [Test]
        public void Case02()
        {
            Assert.Throws(typeof(NotEnoughPlayersException), () => Program.VerifyNumPlayers(0));
        }

        [Test]
        public void Case03()
        {
            Assert.Throws(typeof(ReachMaxPlayersException), () => Program.VerifyNumPlayers(6));
        }

        [Test]
        public void Case04()
        {
            String card = "8 Diamonds";

            Card diamondCard = new Card("8", Suit.Diamonds);
            Assert.AreEqual(card, diamondCard.ToString());
        }

        [Test]
        public void Case05()
        {
            Deck deck = new Deck(54);
            Assert.Throws(typeof(CardsNotAvailableException), () => deck.Deal());
        }

        [Test]
        public void Case06()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card("10", Suit.Spades, 10));
            cards.Add(new Card("10", Suit.Diamonds, 10));
            cards.Add(new Card("10", Suit.Clubs, 10));
            cards.Add(new Card("J", Suit.Spades, 11));
            cards.Add(new Card("J", Suit.Clubs, 11));

            Hand hand = new Hand(cards);
            Assert.IsTrue(hand.isFullHouse());
        }

        [Test]
        public void Case07()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card("10", Suit.Spades, 10));
            cards.Add(new Card("10", Suit.Diamonds, 10));
            cards.Add(new Card("10", Suit.Clubs, 10));
            cards.Add(new Card("J", Suit.Spades, 11));
            cards.Add(new Card("Q", Suit.Clubs, 12));

            Hand hand = new Hand(cards);
            Assert.IsFalse(hand.isFullHouse());
        }

        [Test]
        public void Case08()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card("10", Suit.Spades, 10));
            cards.Add(new Card("2", Suit.Spades, 2));
            cards.Add(new Card("4", Suit.Spades, 4));
            cards.Add(new Card("A", Suit.Spades, 14));
            cards.Add(new Card("Q", Suit.Spades, 12));

            Hand hand = new Hand(cards);
            Assert.IsTrue(hand.isFlushed());
        }

        [Test]
        public void Case09()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card("10", Suit.Spades, 10));
            cards.Add(new Card("2", Suit.Diamonds, 2));
            cards.Add(new Card("4", Suit.Spades, 4));
            cards.Add(new Card("A", Suit.Spades, 14));
            cards.Add(new Card("Q", Suit.Spades, 12));

            Hand hand = new Hand(cards);
            Assert.IsFalse(hand.isFlushed());
        }

        [Test]
        public void Case10()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card("A", Suit.Clubs, 14));
            cards.Add(new Card("6", Suit.Clubs, 6));
            cards.Add(new Card("8", Suit.Clubs, 8));
            cards.Add(new Card("J", Suit.Clubs, 11));
            cards.Add(new Card("Q", Suit.Clubs, 12));

            Hand hand = new Hand(cards);
            Assert.IsTrue(hand.isFlushed());
        }

    }
}