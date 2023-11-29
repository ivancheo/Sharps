using Cards;

namespace Strategies;

public class FirstBlackCardStrategy : ICardPickStrategy
{
    public int Pick(Card[] cards)
    {
        int firstBlackCard = 0;
        foreach (var card in cards)
        {
            if (card.getColor() == CardColor.Black)
            {
                return firstBlackCard;
            }

            firstBlackCard++;
        }
        return 0;
    }

    public void WriteStrategyDescription()
    {
        System.Console.WriteLine("Назвать номер первой черной карты в своей колоде");
    }
}