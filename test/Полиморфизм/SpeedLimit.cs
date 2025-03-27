using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Полиморфизм
{
    public class SpeedLimit
    {
        public virtual void Speed()
        {
            Console.WriteLine("Разрешенная скорость 80 км.ч");
        }
    }

    public class SpeedLimit60 : SpeedLimit 
    { 
        public override void Speed()
        {
            Console.WriteLine("Разрешенная скорость 60 км.ч");
        }
    }

    public class SpeedLimit40 : SpeedLimit
    {
        public override void Speed()
        {
            Console.WriteLine("Разрешенная скорость 40 км.ч");
        }
    }

    public class SpeedLimit110 : SpeedLimit
    {
        public override void Speed()
        {
            Console.WriteLine("Разрешенная скорость 110 км.ч");
        }
    }
}
