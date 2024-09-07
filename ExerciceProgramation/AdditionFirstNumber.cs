using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceProgramation
{
    public  class AdditionFirstNumber
    {
        public int result { get; private set; } = 0;

        public int AdditionFirst(int number) 
        {
            var tab = new int [number];
            
            for (var i = tab.Length-1; i >= 0 ; i--)
            {
                tab [i] = i+1;
                result = tab [i]+ result;
                
            }


            return result; 
        }
    }
}
