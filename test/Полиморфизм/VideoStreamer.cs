using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace test.Полиморфизм
{
    public class VideoStreamer
    {
        public virtual void Stream()
        {
            Console.WriteLine("Показываем в обычно качестве");
        }
    }

    public class VideoStreamer480 : VideoStreamer
    {
        public override void Stream()
        {
            Console.WriteLine("Показываем в 480 качестве");
        }
    }

    public class VideoStreamer720 : VideoStreamer
    {
        public override void Stream()
        {
            Console.WriteLine("Показываем в 720 качестве");
        }
    }

    public class VideoStreamer1080 : VideoStreamer
    {
        public override void Stream()
        {
            Console.WriteLine("Показываем в 1080 качестве");
        }
    }
}
