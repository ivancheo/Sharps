using Cards;
using CardShuffler;
using Strategies;

namespace ColiseumProblem;

class Program
{
    static void Main(string[] args)
    {

        Card[] cards = new Card[Constants.CARDS_IN_DECK_COUNT];

        //init deck
        for (int i = 0; i < cards.Length; i++)
        {
            if (i % 2 == 0)
            {
                cards[i] = new Card(CardColor.Black);
            }
            else
                cards[i] = new Card(CardColor.Red);
        }

        Player player1 = new Player(new FirstRedCardStrategy());
        Player player2 = new Player(new FirstRedCardStrategy());

        int winCount = 0;
        for (int i = 0; i < Constants.EXPERIMENTS_COUNT; i++)
        {
            var shuffler = new SimpleCardShuffler();
            cards = shuffler.Shuffle(cards);
            if (GodsGame.Play(player1, player2, cards))
            {
                winCount++;
            }
        }

        Console.Write("Илон Маск использовал стратегию: ");
        player1.GetStrategy().WriteStrategyDescription();
        Console.Write("Марк Цукерберг использовал стратегию: ");
        player2.GetStrategy().WriteStrategyDescription();
        Console.Write("Отношение количества успехов к общему числу экспериментов: ");
        Console.WriteLine((double)winCount / Constants.EXPERIMENTS_COUNT);
    }
    
}