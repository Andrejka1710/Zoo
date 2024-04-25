namespace TestTask
{
    public class Lion: IAnimal //лев
    {
        public int DailyCalories { get; } = 10000;
        public FoodType[] Foods { get; } = { FoodType.MEAT };
    }
}
