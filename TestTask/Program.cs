using System; //системная библиотека для вывода и ввода данных
using System.Collections.Generic; //библиотека для словаря

namespace TestTask //название модуля
{
    public class Program //основной класс программы
    {
        public static void Main() //главная функция
        {
            Dictionary<AnimalType, int> animals = new Dictionary<AnimalType, int>(); //словарь количества животных
            try
            {
                Console.WriteLine("Введите количество медведей в зоопарке:"); //вывод данных на экран
                animals[AnimalType.BEAR] = Convert.ToInt32(Console.ReadLine()); //ввод количества животных с клавиатуры
                Console.WriteLine("Введите количество львов в зоопарке:");
                animals[AnimalType.LION] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество обезьян в зоопарке:");
                animals[AnimalType.MONKEY] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            Dictionary<FoodType, double> calories = new Dictionary<FoodType, double> //словарь калорийности пищи (в 1 г)
            {
                { FoodType.MEAT, 1.5 },
                { FoodType.BANANAS, 0.89 }
            };
            Dictionary<FoodType, int> total = new Dictionary<FoodType, int> //словарь общего количества граммов пищи, необходимой для животных в течение месяца
            {
                { FoodType.MEAT, 0 },
                { FoodType.BANANAS, 0 }
            };
            foreach (var key in animals) //для каждого животного
            {
                var animal = AnimalFactory.createAnimal(key.Key); //создание объекта животного (паттерн Фабрика)
                foreach (FoodType food in animal.Foods) //подсчёт количества пищи (для каждого типа еды)
                {
                    if (calories[food] != 0 && animal.Foods.Length != 0)
                        total[food] += (int)Math.Ceiling(animal.DailyCalories / animal.Foods.Length / calories[food]) * key.Value * 30;
                }
            }
            Console.WriteLine("Мясо: " + (double)total[FoodType.MEAT]/1000 + " кг"); //вывод результатов на экран
            Console.WriteLine("Бананы: " + (double)total[FoodType.BANANAS]/1000 + " кг");
            Console.Read(); //ожидание клавиши до закрытия окна
        }
    }
}
