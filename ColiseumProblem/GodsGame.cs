using Cards;

namespace ColiseumProblem;

public static class GodsGame
{
    public static bool Play(Player player1, Player player2, in Card[] cards)
    {
        Card[] firstHalf;
        Card[] secondHalf;
        SplitDeckInHalf(cards, out firstHalf, out secondHalf);

        int firstPlayerNumber = player1.PickCard(firstHalf);
        int secondPlayerNumber = player2.PickCard(secondHalf);
        return firstHalf[secondPlayerNumber].Equals(secondHalf[firstPlayerNumber]);
    }
    
    
    private static void SplitDeckInHalf(in Card[] cards, out Card[] firstHalf, out Card[] secondHalf)
    {
        int halfLength = cards.Length / 2;
        firstHalf = new Card[halfLength];
        secondHalf = new Card[halfLength];
        Array.Copy(cards, 0, firstHalf, 0, halfLength);
        Array.Copy(cards, cards.Length / 2, secondHalf, 0, halfLength);
    }

}