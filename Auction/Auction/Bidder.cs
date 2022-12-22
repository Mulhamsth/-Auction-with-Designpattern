using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    internal class Bidder
    {
        public string Name { get; set; } //the Name of the Bidder
        Actioneer actioneer;            //the Subject
        public Bidder(string Name, Actioneer actioneer) //initialize the variables 
        {
            this.Name = Name;
            this.actioneer = actioneer;
            actioneer.NotifyLastBid += LastAcceptedBid; //the bidder is now an Observer of Actioneer and can get information from Actioneer
        }
        public int LastAcceptedBid(int amount)      // this method is used to get the last accepted bid from the Actioneer
        {
            return amount;
        }
        public void Bid(int amount)
        {
            actioneer.Bid(Name, amount);
        }
    }
}
