
class hilo
{
    static void Main(string[] arg)
    {
        int Points = 300;
        int FinalPoints = 300;

        Console.WriteLine("Hello welcome to Hilo! The game is simple, you start with 300 points ",
        "the system will show you card and you have to guess if the next card is higher or lower.",
        "If you are correct, you win points! Enter H if you think it's higher or L if lower. Get ready to play! ");

        while (FinalPoints != 0)
        {
            int UpdatedPoints = AddOrSubtractPoints(Points);
            FinalPoints = KeepTheGameLooping(UpdatedPoints);
        }

    }


    public static int AddOrSubtractPoints(int Points)
    {

        /// filler until we make call class for card. After info has passed to here, display card. 
        /// Might need another function and simply pass the values to this function. 
        /// PreviousCard <- DisplayCard

        Console.WriteLine("-");
        string UserGuess = Console.ReadLine();
        UserGuess = UserGuess.ToUpper();

        /// Get new card. 

        switch (UserGuess)
        {
            case "L":
                if (NewCard < PreviousCard)
                {
                    Points = Points + 100;
                }
                else
                {
                    Points = Points - 75;
                }

                break;


            case "H":

                if (NewCard > Previous)
                {
                    Points = Points + 100;
                }

                else
                {
                    Points = Points - 75;
                }

                break;

            default:

                Console.WriteLine("Input does not work. Try again.");
                break;
        }
        /// previous card <- new card

        return Points;

    }


    public static int KeepTheGameLooping(int Points)
    {
        Console.WriteLine($"Currently you have {Points} points.");
        Console.WriteLine("Keep playing? Y/N");

        string ContinueGame = Console.ReadLine();
        ContinueGame = ContinueGame.ToUpper();

        /// If player does not wish to continue the points will equal zero, thus ending the while loop. 

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

}










