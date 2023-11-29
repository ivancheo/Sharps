using Cards;

namespace CardShuffler;

public interface  ICardsShuffler {
    Card[] Shuffle(Card[] cards);
}