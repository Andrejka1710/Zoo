namespace TestTask
{
    public class Monkey: IAnimal //обезьяна
    {
        public int DailyCalories { get; } = 1000;
        public FoodType[] Foods { get; } = { FoodType.BANANAS };
    }
}
