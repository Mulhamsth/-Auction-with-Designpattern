using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    internal class Actioneer
    {
        /* Applying SingleTon Designpattern
        so there can't be more than one bid at a time 
        that way every bid could be processed before determin whether the bid is valid or not*/

        private static Actioneer Instance = null;
        public static Actioneer GetInstance
        {
            get
            {
                if (Instance == null)
                    Instance = new Actioneer();

                return Instance;
            }
        }

        private Actioneer() { } // the constructor is private so it can't be more than one instance (SingleTon)

        public delegate int Notify(int number);
        public event Notify NotifyLastBid; //Applying the Observer Designpattern
        int LastAcceptedBid;    // Last Bid that got accepted after evaluating it

        public void Bid(string name, int amount)    // throw this Method the Bidders can bid
        {
            if (amount > LastAcceptedBid)
                LastAcceptedBid = amount;
            NotifyAll(name);
        }

        public void NotifyAll(string name)  //Notity all the Bidders of the last Accepted Bid
        {
            if (NotifyLastBid == null)
                return;

            NotifyLastBid(LastAcceptedBid);
            Console.WriteLine($"{name} has bidded on ${LastAcceptedBid}");
        }
    }
}
