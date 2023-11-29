using Cards;


/// <summary>
/// Стратегия выбора карты
/// </summary>
public interface ICardPickStrategy
{
    /// <summary>
    /// Возвращает номер карты в стопке другой жертвы согласно алгоритма
    /// </summary>
    /// <param name="cards">Стопка карт</param>
    /// <returns>Номер карты начиная с 0</returns>
    
    public int Pick(Card[] cards);

    /// <summary>
    /// Выводит описание работы стратегии выбора карты в консоль
    /// </summary>
    public void WriteStrategyDescription();
}