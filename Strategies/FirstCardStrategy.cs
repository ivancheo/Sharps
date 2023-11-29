using Cards;

namespace Strategies;

public class FirstCardStrategy : ICardPickStrategy
{
    public int Pick(Card[] cards)
    {
        return 0;
    }

    public void WriteStrategyDescription()
    {
        System.Console.WriteLine("Назвать номер первой карты");
    }
}