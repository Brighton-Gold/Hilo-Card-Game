class CheckPoints
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

}