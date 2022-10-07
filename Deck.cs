class Deck 
{
    static Dictionary<int, int> DrawCard()
    {
        Random rnd = new Random();
        int card = rnd.Next(1, 14);
        return card;
    }
    static Dictionary<int, int> BuildDeck()
    {
        IDictionary<int, int> deck = new Dictionary<int, int>();
        for (int i = 0; i < 14; i++)
        {
            deck.Add(i,0);
        }
        return deck;
        // deck.Add(1,0);
        // deck.Add(2,0);
        // deck.Add(3,0);
        // deck.Add(4,0);
        // deck.Add(5,0);
        // deck.Add(6,0);
        // deck.Add(7,0);
        // deck.Add(8,0);
        // deck.Add(9,0);
        // deck.Add(10,0);
        // deck.Add(11,0);
        // deck.Add(12,0);
        // deck.Add(13,0);
    }
}
Deck.GetNewDeck();
Console.WriteLine(deck);