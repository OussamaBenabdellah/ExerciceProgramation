using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExerciceProgramation
{
    class SecondHightNumber
    {
        public int resulte { get; set; }


        public int SecondNumber(int[] seizure)
        {


           
            Array.Sort(seizure);
            foreach (int i in seizure)
            {
                Console.WriteLine(i);

            }

               resulte = seizure[seizure.Length-2];

            Console.WriteLine();

            return resulte;

        }
    }
}
