using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Полиморфизм
{
    public class MusicPlayer
    {
        public virtual void Play()
        {
            Console.WriteLine("Воспроизвести аудио в стандартном режиме");
        }
    }

    public class Mp3Player : MusicPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Воспроизвести аудио в MP3");
        }
    }

    public class WavPlayer : MusicPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Воспроизвести аудио в Wav");
        }
    }

    public class FlacPlayer : MusicPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Воспроизвести аудио в Flac");
        }
    }

}
