class Program
{

    static void Main(string[] args)
    {
        int Points = 300;
        int FinalPoints = 300;

        AddOrSubbtractPoints AddOrSub = new AddOrSubbtractPoints();
        
        Deck deck = new Deck();
        CheckPoints PointsCheck = new CheckPoints();


        Console.WriteLine("Hello welcome to Hilo! The game is simple, you start with 300 points ");
        Console.WriteLine("the system will show you card and you have to guess if the next card is higher or lower.");
        Console.WriteLine("If you are correct, you win points! Enter H if you think it's higher or L if lower. Get ready to play! ");

        /// filler until we make call class for card. After info has passed to here, display card. 
        /// Call card deck. Card deck will give a card and value will be added to show it has been drawn.

        int DisplayCard = deck.DrawCard();
        int PreviousCard = DisplayCard;


        while (FinalPoints != 0)
        {
            // Display Card. 
            Console.WriteLine($"{DisplayCard}");
            // Get New Card. 

            PreviousCard = DisplayCard;
            int NewCard = deck.DrawCard();


            int UpdatedPoints = AddOrSub.ScoreCard(Points, NewCard, PreviousCard);
            FinalPoints = PointsCheck.KeepTheGameLooping(UpdatedPoints);

            DisplayCard = NewCard;
            Points = FinalPoints;
        }

    }
}