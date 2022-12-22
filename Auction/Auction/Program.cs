namespace Auction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialzing the Bidders and give them a Name
            Bidder bidder1 = new Bidder("Mulham", Actioneer.GetInstance);
            Bidder bidder2 = new Bidder("Christian", Actioneer.GetInstance);
            Bidder bidder3 = new Bidder("Martin", Actioneer.GetInstance);

            //starting to bid
            bidder1.Bid(100);
            bidder2.Bid(50); // won't be accepted, because it is lower than the last accepted bid
            bidder3.Bid(200);
            bidder2.Bid(300);

        }
    }
}