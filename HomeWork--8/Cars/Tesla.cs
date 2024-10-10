using HomeWork.Interfaces;
using HomeWork.Cars.Base;
using HomeWork.Parts.Engines.Base;

namespace HomeWork.Cars
{
    // Класс Tesla, наследующий и расширяющий базовый функционал от класса Car.
    internal class Tesla : Car, IMyCloneable<Tesla>, ICloneable
    {
        public int ChargeCapacity { get; }   // Макс.заряд

        public Tesla(string name, int maxSpeed, Engine engine, int сhargeCapacity) : base(name, maxSpeed, engine) 
        { 
            ChargeCapacity = сhargeCapacity; 
        }

        // Вывод описания характеристик объекта, в конкретной реализации.
        public override string GetInfo()
        {
            return $"Объект: {Name}; Макс.Скорость: {MaxSpeed}; Двигатель: {Engine.Name}; Емкость батареи:{ChargeCapacity}";
        }

        // Создание "глубокой" копии объекта, для реализации шаблона "Прототип"
        public override Tesla MyClone()
        {
            return new Tesla(Name, MaxSpeed, this.Engine.MyClone(), ChargeCapacity);
        }

        // Создание копии объекта, используя в качестве стандартного интрефейса ICloneable для реализации шаблона "Прототип"
        public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}
