using AppT1;
using AppT1.Handler;
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
            List<Player> players = new List<Player>();

            Assert.Throws(typeof(NotEnoughPlayersException), () => PokerGame.Start(players));
        }
        [Test]
        public void Case02()
        {
            List<Player> players = new List<Player>(new Player[6]);

            Assert.Throws(typeof(ReachMaxPlayersException), () => PokerGame.Start(players));
        }
    }

}