using Cards;

namespace CardShuffler;

public  class SimpleCardShuffler : ICardsShuffler
{
    private Random _random;

    public SimpleCardShuffler()
    {
        _random = new Random();
    }

    // Реализация метода Shuffle интерфейса ICardsShuffler
    public Card[] Shuffle(Card[] cards)
    {
        int n = cards.Length;
        while (n > 1)
        {
            n--;
            int k = _random.Next(n + 1);
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
        return cards;
    }
}