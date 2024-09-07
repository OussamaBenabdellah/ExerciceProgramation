using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceProgramation
{
    internal class ReversingString
    {   
        public void Reversing(string result)
        {
            char[] chars = result.ToCharArray();
            char[] charsInvers = new char[chars.Length];
            var i = 0;                 
                for (int j = chars.Length-1; j >= 0; j--)
                {
                    charsInvers [i] = chars [j];
                    i++;
                }

            var resu = new string (charsInvers);
            Console.WriteLine(resu);         
        }

    }
}
