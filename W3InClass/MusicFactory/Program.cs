using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer=Console.ReadLine();
            Console.WriteLine($"My answer is: {answer}");
            if (answer == "Yes")
            {
                Console.WriteLine("Play music");

                using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\1b_A\PU_IntroCSharp_inClass_1801681027\W3InClass\MusicFactory\Music\music.mp3"))
                {

                    player.Play();

                }
            }
            else if (answer == "No")
            {
                Console.WriteLine("Goodbye!");
            }
            else if (answer == "Fuck")
            {
                Console.WriteLine("Yes, fuck you too!!!");
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

        }
    }
}
