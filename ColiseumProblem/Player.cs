using Cards;

namespace ColiseumProblem;

public class Player
{
    private ICardPickStrategy _strategy;
    public Player(ICardPickStrategy strategy)
    {
        _strategy = strategy;
    }

    public ICardPickStrategy GetStrategy()
    {
        return _strategy;
    }
    

    public int PickCard(Card[] cards)
    {
        return  _strategy.Pick(cards);
    }
}