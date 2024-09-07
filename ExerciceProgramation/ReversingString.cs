using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceProgramation
{
    public class ReversingString
    {   
        public void Reversing(string world)
        {
            char[] chars = world.ToCharArray();
            char[] charsInvers = new char[chars.Length];
            var i = 0;                 
                for (int j = chars.Length-1; j >= 0; j--)
                {
                    charsInvers [i] = chars [j];
                    i++;
                }

            var result = new string (charsInvers);
            Console.WriteLine(result);         
        }

    }
}
