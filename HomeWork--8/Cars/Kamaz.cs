using HomeWork.Interfaces;
using HomeWork.Cars.Base;
using HomeWork.Parts.Engines.Base;

namespace HomeWork.Cars
{
    // Класс Kamaz, наследующий и расширяющий базовый функционал от класса Car.
    internal class Kamaz : Car, IMyCloneable<Kamaz>, ICloneable
    {
        public int LoadCapacity { get; }    // Макс.грузоподъемность

        public Kamaz(string name, int maxSpeed, Engine engine, int loadCapacity) : base(name, maxSpeed, engine)
        {
            LoadCapacity = loadCapacity;
        }

        // Вывод описания характеристик объекта, в конкретной реализации.
        public override string GetInfo()
        {
            return $"Объект: {Name}; Макс.Скорость: {MaxSpeed}; Двигатель: {Engine.Name}; Грузоподъемность:{LoadCapacity}";
        }

        // Создание "глубокой" копии объекта, для реализации шаблона "Прототип"
        public override Kamaz MyClone()
        {
            return new Kamaz(Name, MaxSpeed, this.Engine.MyClone(), LoadCapacity);
        }

        // Создание копии объекта, используя в качестве стандартного интрефейса ICloneable для реализации шаблона "Прототип"
        public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}
