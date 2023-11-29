using Cards;

namespace Strategies;

public class RandomCardStrategy : ICardPickStrategy
{
    public int Pick(Card[] cards)
    {
        Random rnd = new Random();
        return rnd.Next(0, cards.Length - 1);
    }

    public void WriteStrategyDescription()
    {
        System.Console.WriteLine("Назвать случайный номер карты.");
    }
}