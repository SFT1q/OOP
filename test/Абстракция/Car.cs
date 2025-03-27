using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Абстракция
{
    public abstract class Car
    {
        public void Accelerate() => Console.WriteLine("Разгоняемся...");

        public void Break() => Console.WriteLine("Тормозим....");

        public abstract void TurnOnEngine();
    }

    public class ElectroCat : Car
    {
        public override void TurnOnEngine()
        {
            Console.WriteLine("Запускаем электро двигатель");
        }
    }

    public class DieselCar : Car
    {
        public override void TurnOnEngine()
        {
            Console.WriteLine("Запускем дизельный двигатель");
        }
    }
}
