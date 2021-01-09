using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJackGameRepo;
using System.Collections.Generic;

namespace BlackJackUnitTest
{
    [TestClass]
    public class UnitTest
    {
        GameRepo repoWindow = new GameRepo();


        [TestMethod]
        public void DealACardTest()
        {
            int testCard = repoWindow.DealACard();
            Assert.IsTrue(testCard >= 1 && testCard <= 13);
        }
        [TestMethod]
        public void AssignToDealerHandTest()
        {
            int card = 9;
            int dealerHand1 = repoWindow.DealerHand.Count;
            repoWindow.AssignToDealerHand(card);
            int dealerHand2 = repoWindow.DealerHand.Count;

            Assert.AreNotEqual(dealerHand2, dealerHand1);
        }
        [TestMethod]
        public void AssignToPlayerHandTest()
        {
            int card = 9;
            int playerHand1 = repoWindow.PlayerHand.Count;
            repoWindow.AssignToPlayerHand(card);
            int playerHand2 = repoWindow.PlayerHand.Count;

            Assert.AreNotEqual(playerHand2, playerHand1);
        }
        [TestMethod]
        public void DisplayDealerHandTest()
        {
            int card = 9;
            List<int> dealerHand1 = new List<int>();
            List<int> dealerHand2 = new List<int>();
            dealerHand1 = repoWindow.DisplayDealerHand();
            int hand1Count = repoWindow.DealerHand.Count;
            repoWindow.AssignToDealerHand(card);
            dealerHand2 = repoWindow.DisplayDealerHand();
            int hand2Count = repoWindow.DealerHand.Count;
            Assert.AreNotEqual(hand2Count, hand1Count);

        }
        [TestMethod]
        public void DisplayplayerHandTest()
        {
            int card = 9;
            List<int> playerHand1 = new List<int>();
            List<int> playerHand2 = new List<int>();
            playerHand1 = repoWindow.DisplayPlayerHand();
            int hand1Count = repoWindow.PlayerHand.Count;
            repoWindow.AssignToPlayerHand(card);
            playerHand2 = repoWindow.DisplayPlayerHand();
            int hand2Count = repoWindow.PlayerHand.Count;
            Assert.AreNotEqual(hand2Count, hand1Count);

        }
    }

}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJackGameRepo;
using System.Collections.Generic;

namespace BlackJackUnitTest
{
    [TestClass]
    public class UnitTest
    {
        GameRepo repoWindow = new GameRepo();


        [TestMethod]
        public void DealACardTest()
        {
            int testCard = repoWindow.DealACard();
            Assert.IsTrue(testCard >= 1 && testCard <= 13);
        }
        [TestMethod]
        public void AssignToDealerHandTest()
        {
            int card = 9;
            int dealerHand1 = repoWindow.DealerHand.Count;
            repoWindow.AssignToDealerHand(card);
            int dealerHand2 = repoWindow.DealerHand.Count;

            Assert.AreNotEqual(dealerHand2, dealerHand1);
        }
        [TestMethod]
        public void AssignToPlayerHandTest()
        {
            int card = 9;
            int playerHand1 = repoWindow.PlayerHand.Count;
            repoWindow.AssignToPlayerHand(card);
            int playerHand2 = repoWindow.PlayerHand.Count;

            Assert.AreNotEqual(playerHand2, playerHand1);
        }
        [TestMethod]
        public void DisplayDealerHandTest()
        {
            int card = 9;
            List<int> dealerHand1 = new List<int>();
            List<int> dealerHand2 = new List<int>();
            dealerHand1 = repoWindow.DisplayDealerHand();
            int hand1Count = repoWindow.DealerHand.Count;
            repoWindow.AssignToDealerHand(card);
            dealerHand2 = repoWindow.DisplayDealerHand();
            int hand2Count = repoWindow.DealerHand.Count;
            Assert.AreNotEqual(hand2Count, hand1Count);

        }
        [TestMethod]
        public void DisplayplayerHandTest()
        {
            int card = 9;
            List<int> playerHand1 = new List<int>();
            List<int> playerHand2 = new List<int>();
            playerHand1 = repoWindow.DisplayPlayerHand();
            int hand1Count = repoWindow.PlayerHand.Count;
            repoWindow.AssignToPlayerHand(card);
            playerHand2 = repoWindow.DisplayPlayerHand();
            int hand2Count = repoWindow.PlayerHand.Count;
            Assert.AreNotEqual(hand2Count, hand1Count);

        }
    }

}
