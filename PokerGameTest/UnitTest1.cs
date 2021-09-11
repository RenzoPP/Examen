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

    }
}