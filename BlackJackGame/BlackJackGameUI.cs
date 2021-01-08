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

            DisplayDealersHand();
            Console.WriteLine();
            Console.WriteLine();
            DisplayPlayersHand();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n" +
                   "1. To hit \n" +
                   "2. To stand \n" +
                   "3. To exit the program");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Hit();
                        break;
                    case "2":
                        Stand();
                        break;

                    //case "3":
                    //    RemoveAMenuItem();
                    //    break;
                    //case "3":
                    //isRunning = false;
                    //break;
                    default:
                        break;
                }


            }
        }

        private void Stand()
        {
            List<int> dealer = repoWindow.DisplayDealerHand();
            int total;
            total = EvaluateHand(dealer);
            //evaluate dealer's hand and keep adding cards until total >= 17.
            while (total < 17)
            {

                total = EvaluateHand(dealer);
                int hitCard = repoWindow.DealACard();
                repoWindow.AssignToDealerHand(hitCard);
            }
            DisplayPlayersHand();
            DisplayDealersHand();


            
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

        private void DisplayDealersHand()
        {
            List<int> dealer = repoWindow.DisplayDealerHand();
            Console.WriteLine("Dealers Hand ");
            bool firstTime = true;
            foreach (int card in dealer)
            {
                if (firstTime == true)
                {
                    Console.Write("X ");
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
        }
    }
}
