
class AddOrSubbtractPoints
{
    public int ScoreCard(int Points, int NewCard, int PreviousCard)
    {

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

                if (NewCard > PreviousCard)
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





}