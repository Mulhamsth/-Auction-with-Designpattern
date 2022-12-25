namespace Auction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Actioneer actioneer = Actioneer.GetInstance;

            //initialzing the Bidders and give them a Name
            Bidder bidder1 = new Bidder("Mulham", actioneer);
            Bidder bidder2 = new Bidder("Christian", actioneer);
            Bidder bidder3 = new Bidder("Martin", actioneer);

            //starting to bid
            bidder1.Bid(100);
            bidder2.Bid(50); // won't be accepted, because it is lower than the last accepted bid
            bidder3.Bid(200);
            bidder2.Bid(300);

        }
    }
}