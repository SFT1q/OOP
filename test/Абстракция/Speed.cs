using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Абстракция
{
    public abstract class Speed
    {
        public abstract int MoveSpeed { get; set; }
    }

    public class Carr : Speed
    {
        int speed;
        public override int MoveSpeed { get => speed; set => speed = value; }
    }

    public class AirCraft : Speed
    {
        public override int MoveSpeed { get; set; }
    }
}
