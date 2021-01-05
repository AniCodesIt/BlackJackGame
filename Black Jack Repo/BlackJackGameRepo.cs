using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGameRepo

{
    public class GameRepo
    {
        public List<int> DealerHand = new List<int>();

        public List<int> PlayerHand = new List<int>();

        //add the deck later, use random number assingment for now

               
        Random random = new Random(DateTime.Now.Millisecond);
        public int DealACard()
        {
            int thisRandomNumber = random.Next(1, 14);
            return thisRandomNumber;
        }

        public void AssignToDealerHand(int card)
        {
            DealerHand.Add(card);
        }
        public void AssignToPlayerHand(int card)
        {
            PlayerHand.Add(card);
        }
        public List<int> DisplayDealerHand()
        {
            return DealerHand;
        }
        public List<int> DisplayPlayerHand()
        {
            return PlayerHand;
        }
        public void FinishDealersHand()
        {
            int count = 0;
            foreach (int card in DealerHand)
            {
                count += card;
            }
        }




    }
}
