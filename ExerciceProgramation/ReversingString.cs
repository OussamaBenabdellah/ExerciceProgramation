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
            char[] c = new char[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {                 
                for (int j = chars.Length-1; j >= 0; j--)
                {
                    c [i] = chars [j];
                    i++;
                }
            }
            foreach (char item in c)
            {
                Console.Write(item + " ");
            }          
        }

    }
}
