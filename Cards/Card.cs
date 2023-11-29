namespace Cards;

/// <summary>
/// Игральная карта
/// </summary>
public class Card 
{
    private CardColor Color;
    
    public Card(CardColor Color)
    {
        this.Color = Color;
    }
    public override string ToString()
    {
        return Color == CardColor.Black ? "♠️" : "♦️";
    }

    public CardColor getColor()
    {
        return Color;
    }
    
    public override bool Equals(object obj)
    {
        Card otherCard = (Card)obj;
        return this.Color == otherCard.Color;
    }
}