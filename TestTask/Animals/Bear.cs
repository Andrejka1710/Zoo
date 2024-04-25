namespace TestTask
{
    public class Bear: IAnimal //медведь
    {
        public int DailyCalories { get; } = 15000;
        public FoodType[] Foods { get; } = { FoodType.MEAT, FoodType.BANANAS };
    }
}
