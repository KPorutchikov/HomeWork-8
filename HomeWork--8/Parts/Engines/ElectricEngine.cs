using HomeWork.Interfaces;
using HomeWork.Parts.Engines.Base;

namespace HomeWork.Parts.Engines
{
    // Класс ElectricEngine, наследующий и расширяющий базовый функционал от класса Engine.
    internal class ElectricEngine : Engine, IMyCloneable<Engine>, ICloneable
    {
        public FuelType FuelType { get; }   // Тип топлива
        public int MaxCharge { get; }       // Макс.заряд

        public ElectricEngine(string name, decimal power, decimal weight, FuelType fuelType, int maxCharge) : base(name, power, weight)
        {
            FuelType = fuelType;
            MaxCharge = maxCharge;
        }

        // Вывод описания характеристик объекта, в конкретной реализации.
        public override string GetInfo()
        {
            return $"Объект: {Name}; Тип топлива : {FuelType}; Вес : {Weight}; Мощность: {Power}; Макс.заряд:{MaxCharge}";
        }

        // Создание "глубокой" копии объекта, для реализации шаблона "Прототип"
        public override ElectricEngine MyClone()
        {
            return new ElectricEngine(Name, Power, Weight, FuelType, MaxCharge);
        }

        // Создание копии объекта, в качестве стандартного интрефейса ICloneable
        public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}
