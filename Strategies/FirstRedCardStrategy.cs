using Cards;

namespace Strategies;

public class FirstRedCardStrategy : ICardPickStrategy
{
    public int Pick(Card[] cards)
    {
        int firstRedCard = 0;
        foreach (var card in cards)
        {
            if (card.getColor() == CardColor.Red)
            {
                return firstRedCard;
            }

            firstRedCard++;
        }
        return 0;
    }

    public void WriteStrategyDescription()
    {
        System.Console.WriteLine("Назвать номер первой красной карты в своей колоде");
    }
}