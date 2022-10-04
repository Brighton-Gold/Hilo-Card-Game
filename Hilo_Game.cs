
class hilo{
    static void Main(string [] arg)
    {
        int Points = 300;

        Console.WriteLine("Hello welcome to Hilo! The game is simple, you start with 300 points ",
        "the system will show you card and you have to guess if the next card is higher or lower.",
        "If you are correct, you win points! Enter H if you think it's higher or L if lower. Get ready to play! ");


        while (Points != 0);

        /// filler until we make call class for card. After info has passed to here, display card. 

        /// PreviousCard = DisplayCard
            Console.WriteLine("-");
            string UserGuess = Console.ReadLine();
            UserGuess = UserGuess.ToUpper();

        /// Get new card. 

                switch(UserGuess)
                {
                    case "L":
                    // if (NewCard < Previous){ 
                        Points = Points + 100;
                    
                    // else
                       Points = Points - 75;
                        
                        break;


                    case "H":

                    // if (NewCard > Previous){ 
                        Points = Points + 100;
                    // else
                       Points = Points - 75;

                        break;

                    default:
                       break;
                }

        /// pass UserGuess into Points class where it will add or subtract points

        /// previous card <- new card






    }


}

