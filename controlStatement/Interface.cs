using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace batch16opps
{
    internal interface Iplayable
    {
        void play();

    }
    internal class Videoplayer : Iplayable
    {
        public void play()
        {

            Console.WriteLine("Play the video.....");
        }


    }
    internal class MusicPlayer : Iplayable
    {
      public  void play()
        {
            Console.WriteLine("play the music.....");
        }



    }
    internal class IInterface
    {
        static void Main()
        {
            Videoplayer videoplayer = new Videoplayer();
            videoplayer.play();
            MusicPlayer musicplayer = new MusicPlayer();
            musicplayer.play();


        }
    }

}
