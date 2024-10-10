using HomeWork.Cars.Base;
using HomeWork.Interfaces;

namespace HomeWork.Parts.Engines.Base
{
    enum FuelType
    {   Petrol,
        Electricity,
        Diesel
    }

    // Класс описыват абстрактное представлеие двигателя,
    // его базовых характеристик и методов.
    abstract class Engine : IMyCloneable<Engine>, ICloneable
    {
        public string Name { get; set; }        // Название
        public decimal Power { get; set; }      // Мощность
        public decimal Weight { get; set; }     // Вес

        public Engine(string name, decimal power, decimal weight)
        {
            Name = name;
            Power = power;
            Weight = weight;
        }

        // Получение описание характеристик объекта, в конкретной реализации.
        public abstract string GetInfo();

        // Создание глубокой копии объекта, реализуя дженерик интерфейс IMyCloneable
        public abstract Engine MyClone();

        // Создание копии объекта с помощью реализацию стандартного интерфейса ICloneable
        public abstract object Clone();

    }
}
