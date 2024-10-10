using HomeWork;
using HomeWork.Cars;
using HomeWork.Parts;
using HomeWork.Parts.Engines;
using HomeWork.Parts.Engines.Base;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 1:
            // Реализация шаблона "Прототип" со стандартным интерфейсом ICloneable

            // Создадим экземпляр класса Tesla:
            Tesla Cybertruck = new Tesla("Tesla Cybertruck AT", 240, new ElectricEngine("TDG-H6", 1500, 450, FuelType.Electricity, 500),1200);

            // Сделаем его копию:
            Tesla Cybertruck_new = (Tesla)Cybertruck.Clone();

            // Изменим характеристики у родительского объекта:
            Cybertruck.Engine.Name += "_New";

            // Выведем общее состояние созданных объектов:
            Console.WriteLine($"Оригинал           : {Cybertruck.GetInfo()}");
            Console.WriteLine($"Копия (ICloneable) : {Cybertruck_new.GetInfo()}");
            Console.WriteLine();

            /*--------------------------------------------------------------------------------------------------------*/

            // Пример 2:
            // Реализация шаблона "Прототип" используя частную реализацию клонирования  (интерфейс IMyCloneable)

            // Создадим экземпляр класса Kamaz:
            Kamaz Kamaz_4308 = new Kamaz("KAMAZ-4308-81 (N5)", 180, new СombustionEngine("K-740", 3500, 670, FuelType.Diesel, 6000), 30000);

            // Сделаем его копию:
            Kamaz Kamaz_4308_new = Kamaz_4308.MyClone();

            // Изменим характеристики у родительского объекта:
            Kamaz_4308.Engine.Name += "_New";

            // Выведем общее состояние созданных объектов:
            Console.WriteLine($"Оригинал             : {Kamaz_4308.GetInfo()}");
            Console.WriteLine($"Копия (IMyCloneable) : {Kamaz_4308_new.GetInfo()}");
            /*--------------------------------------------------------------------------------------------------------*/

            Console.ReadLine();
        }
    }
}

