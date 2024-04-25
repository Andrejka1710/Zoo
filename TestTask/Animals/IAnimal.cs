namespace TestTask
{
    public interface IAnimal //интерфейс для всех животных
    {
        int DailyCalories { get; } //калорий в день
        FoodType[] Foods { get; } //типы пищи
    }
}
