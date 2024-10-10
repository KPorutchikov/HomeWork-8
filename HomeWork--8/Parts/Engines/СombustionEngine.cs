using HomeWork.Interfaces;
using HomeWork.Parts.Engines.Base;

namespace HomeWork.Parts.Engines
{
    // Класс СombustionEngine, наследующий и расширяющий базовый функционал от класса Engine.
    internal class СombustionEngine : Engine, IMyCloneable<Engine>, ICloneable
    {
        public FuelType FuelType { get; }   // Тип топлива
        public int EngineCapacity { get; }  // Объем двигателя

        public СombustionEngine(string name, decimal power, decimal weight, FuelType fuelType, int engineCapacity) : base(name, power, weight)
        {
            FuelType = fuelType;
            EngineCapacity = engineCapacity;
        }

        // Вывод описания характеристик объекта, в конкретной реализации.
        public override string GetInfo()
        {
            return $"Объект: {Name}; Тип топлива : {FuelType}; Вес : {Weight}; Мощность: {Power}; Объем двигателя:{EngineCapacity}";
        }

        // Создание "глубокой" копии объекта, для реализации шаблона "Прототип"
        public override СombustionEngine MyClone()
        {
            return new СombustionEngine(Name, Power, Weight, FuelType, EngineCapacity);
        }

        // Создание копии объекта, в качестве стандартного интрефейса ICloneable
        public override object Clone()
        {
            return MemberwiseClone();
        }
    }
}
