
class Deck
{
    IDictionary<int, int> deck = new Dictionary<int, int>();
    public int DrawCard()
    {
        Random rnd = new Random();
        int card = rnd.Next(1, 14);
        return card;
    }
    public IDictionary<int, int> GetNewDeck()
    {
        IDictionary<int, int> deck = new Dictionary<int, int>();
        for (int i = 0; i < 14; i++)
        {
            deck.Add(i, 0);
        }
        return deck;

    }
    public Deck() 
    {
        BuildDeck();
    }
}
