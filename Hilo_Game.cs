class hilo
{
    public int KeepTheGameLooping(int Points)
    {
        Console.WriteLine($"Currently you have {Points} points.");
        Console.WriteLine("Keep playing? Y/N");

        string ContinueGame = Console.ReadLine();
        ContinueGame = ContinueGame.ToUpper();

        // If player does not wish to continue the points will equal zero, thus ending the while loop. 
        // If none of the requirements are met, points should be returned as normal. 

        if (ContinueGame == "N")
        {
            Points = 0;
        }

        else if (ContinueGame == "Y" && Points == 0)
        {
            Console.WriteLine("Since you have 0 points left, they have been reset to 300");
            Points = 300;
        }

        return Points;

    }


    void Main(string[] arg)
    {
        int Points = 300;
        int FinalPoints = 300;

        AddOrSubbtractPoints AddOrSub = new AddOrSubbtractPoints();

        Deck deck = new Deck();


        Console.WriteLine("Hello welcome to Hilo! The game is simple, you start with 300 points ",
        "the system will show you card and you have to guess if the next card is higher or lower.",
        "If you are correct, you win points! Enter H if you think it's higher or L if lower. Get ready to play! ");

        /// filler until we make call class for card. After info has passed to here, display card. 
        /// Call card deck. Card deck will give a card and value will be added to show it has been drawn.

        int DisplayCard = deck.DrawCard();
        int PreviousCard = DisplayCard;


        while (FinalPoints != 0)
        {
            // Display Card. 
            // Get New Card.         
            Console.WriteLine($"{DisplayCard}");

            int NewCard = deck.DrawCard();

            int UpdatedPoints = AddOrSub.ScoreCard(Points, NewCard, PreviousCard);
            FinalPoints = KeepTheGameLooping(UpdatedPoints);

            DisplayCard = NewCard;
            PreviousCard = NewCard;

        }

    }

}










