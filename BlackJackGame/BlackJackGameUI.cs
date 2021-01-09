using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackGameRepo;

namespace BlackJackGame

{
    public class BlackJackGameUI

    {

        bool isRunning = true;
        GameRepo repoWindow = new GameRepo();
        public void RunMenu()
        {
            int dealtCard = repoWindow.DealACard();
            repoWindow.AssignToDealerHand(dealtCard);
            dealtCard = repoWindow.DealACard();
            repoWindow.AssignToPlayerHand(dealtCard);
            dealtCard = repoWindow.DealACard();
            repoWindow.AssignToDealerHand(dealtCard);
            dealtCard = repoWindow.DealACard();
            repoWindow.AssignToPlayerHand(dealtCard);

            DisplayDealersHand(true);
            Console.WriteLine();
            Console.WriteLine();
            DisplayPlayersHand();


            while (isRunning)
            {
                Console.WriteLine("\n" +
                   "1. To hit \n" +
                   "2. To stand \n" +
                   "3. To exit the program ");
                Console.WriteLine();


                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Hit();
                        break;
                    case "2":
                        Stand();
                        break;
                    case "3":
                        isRunning = false;
                        break;
                    default:
                        break;
                }


            }
        }

        private void Stand()
        {
            List<int> dealer = repoWindow.DisplayDealerHand();
            int dealerTotal;
            dealerTotal = EvaluateHand(dealer);          
            while (dealerTotal < 17)
            {

                int hitCard = repoWindow.DealACard();
                repoWindow.AssignToDealerHand(hitCard);
                dealerTotal = EvaluateHand(dealer);
            }
            DisplayPlayersHand();
            DisplayDealersHand(false);
            if (dealerTotal > 21)
            {
                Console.WriteLine("The dealer busts at " + dealerTotal + ".\n" +
                    " You win! ");
                isRunning = false;
            }
            else
            {
                int playerTotal;
                List<int> player = repoWindow.DisplayPlayerHand();
                playerTotal = EvaluateHand(player);

                if (dealerTotal > playerTotal)
                {
                    Console.WriteLine("The dealer has won! ");
                    isRunning = false;
                }
                if (playerTotal > dealerTotal)
                {
                    Console.WriteLine("The player has won! ");
                    isRunning = false;
                }
                if (playerTotal == dealerTotal)
                {
                    Console.WriteLine("There is a draw! ");
                    isRunning = false;
                }

            }
            Console.ReadLine();
        }
        private int EvaluateHand(List<int> Hand)
        {
            int total = 0;

            foreach (int card in Hand)
            {
                switch (card)
                {

                    case 11:
                        total += 10;
                        break;
                    case 12:
                        total += 10;
                        break;
                    case 13:
                        total += 10;
                        break;

                    default:
                        total += card;
                        break;
                }
            }
            return total;
        }

        private void Hit()
        {
            int hitCard = repoWindow.DealACard();
            repoWindow.AssignToPlayerHand(hitCard);
            DisplayPlayersHand();
            List<int> player = repoWindow.DisplayPlayerHand();
            int playerTotal;
            playerTotal = EvaluateHand(player);
            if (playerTotal > 21)
            {
                Console.WriteLine("The player busts at " + playerTotal + ". The dealer wins! ");
                DisplayDealersHand(false);
                Console.ReadLine();
                isRunning = false;
            }


        }
        private void DisplayPlayersHand()
        {
            List<int> player = repoWindow.DisplayPlayerHand();
            Console.WriteLine("Players Hand ");
            foreach (int card in player)
            {
                switch (card)
                {
                    case 1:
                        Console.Write("A ");
                        break;
                    case 11:
                        Console.Write("J ");
                        break;
                    case 12:
                        Console.Write("Q ");
                        break;
                    case 13:
                        Console.Write("K ");
                        break;

                    default:
                        Console.Write(card + " ");
                        break;
                }
            }
            Console.WriteLine();
        }

        private void DisplayDealersHand(bool SuppressFirstCard)
        {
            List<int> dealer = repoWindow.DisplayDealerHand();
            Console.WriteLine("Dealers Hand ");
            bool firstTime = true;
            if (SuppressFirstCard == false)
            {
                firstTime = false;
            }
            foreach (int card in dealer)
            {
                if (firstTime == true)
                {
                    Console.Write("* ");


                    firstTime = false;
                }

                else
                {
                    switch (card)
                    {
                        case 1:
                            Console.Write("A ");
                            break;
                        case 11:
                            Console.Write("J ");
                            break;
                        case 12:
                            Console.Write("Q ");
                            break;
                        case 13:
                            Console.Write("K ");
                            break;

                        default:
                            Console.Write(card + " ");
                            break;
                    }

                }

            }
            Console.WriteLine();
        }
    }
}
