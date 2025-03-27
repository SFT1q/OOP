using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace test.Абстракция
{
    public abstract class CoffeeMachine
    {
        public void PourWater() => Console.WriteLine("Заливаем воду");

        public void AddBeans() => Console.WriteLine("Засыпаем Зерна");
        public abstract void BrewCoffer();
    }

    public class EspressoMachine : CoffeeMachine
    {
        public override void BrewCoffer()
        {
            Console.WriteLine("Варим с использованием пара под высоким давлением...");
        }
    }

    public class DripCoffeeMachine : CoffeeMachine
    {
        public override void BrewCoffer()
        {
            Console.WriteLine("Пропускаем горячую воду через зерна...");
        }
    }
}
