namespace TestTask
{
    public class AnimalFactory //Класс создания объекта животного (паттерн Фабрика)
    {
        public static IAnimal createAnimal(AnimalType type) //Функция создания объекта (зависит от типа животного)
        {
            IAnimal animal = null; //переменная объекта класса животного, возвращаемая функцией
            switch (type) //выбор типа животного, в зависимости от параметра
            {
                case AnimalType.LION: //лев
                    animal = new Lion(); //создание объекта класса определённого животного
                    break; //перейти к возвращению значения
                case AnimalType.MONKEY: //обезьяна
                    animal = new Monkey();
                    break;
                case AnimalType.BEAR: //медведь
                    animal = new Bear();
                    break;
            }
            return animal; //возвращение получившегося объекта
        }
    }
}
