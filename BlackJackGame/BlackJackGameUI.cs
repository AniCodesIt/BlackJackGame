using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackGameRepo;

namespace BlackJackGame
{
    class BlackJackGameUI
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

            List<int> dealer = repoWindow.DisplayDealerHand();
            List<int> player = repoWindow.DisplayPlayerHand();
            bool firstTime = true;
            foreach   (int card in dealer)
            {
                if (firstTime == true)
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine(card);
                }
               
            }
            foreach (int card in player)
            {
                Console.WriteLine(card);
            }
            
            
            

                bool isRunning = true;
                while (isRunning)
                {
                    Console.WriteLine("Welcome to Black Jack!\n" +
                        "1. \n" +
                        "2. Create a new menu item\n" +
                        "3. Delete an item from the menu\n" +
                        "20. Closes the program");

                    var userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            getAllMenuItems();
                            break;
                        case "2":
                            CreateAMenuItem();
                            break;
                        case "3":
                            RemoveAMenuItem();
                            break;
                        case "20":
                            isRunning = false;
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("Hit 'Enter' to continue ");
                    Console.ReadLine();
                    Console.Clear();
                }
}
