using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceProgramation
{
    internal class Palindrome
    {
        public string World { get; set; }
        public string Reversing(string world)
        {
            char[] chars = world.ToCharArray();
            char[] charsInvers = new char[chars.Length];
            var i = 0;
            for (int j = chars.Length - 1; j >= 0; j--)
            {
                charsInvers[i] = chars[j];
                i++;
            }

            World = new string(charsInvers);
            Console.WriteLine(World);
            return World;
        }

        public void Verification(string world)
        {
            var reversWorld = Reversing(world);

            if ( reversWorld == world) { Console.WriteLine($"{world} is a Palindrom"); }
        }
    }
}
