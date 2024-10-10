using HomeWork.Interfaces;
using HomeWork.Parts.Engines.Base;


namespace HomeWork.Cars.Base
{
    // Класс описыват абстрактное представлеие автомобиля,
    // его базовых характеристик и методов.

    abstract class Car : IMyCloneable<Car>, ICloneable
    {
        public string Name { get; set; }        // Название
        public int MaxSpeed { get; }            // Макс.скорость
        public Engine Engine { get; set; }      // Двигатель


        public Car(string name, int maxSpeed, Engine engine)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Engine = engine;
        }

        // Получение описание характеристик объекта, в конкретной реализации.
        public abstract string GetInfo();

        // Создание глубокой копии объекта, реализуя дженерик интерфейс IMyCloneable
        public abstract Car MyClone();

        // Создание копии объекта с помощью реализацию стандартного интерфейса ICloneable
        public abstract object Clone();
    }
}
