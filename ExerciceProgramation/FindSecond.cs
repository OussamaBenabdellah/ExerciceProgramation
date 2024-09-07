using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceProgramation
{
    public class FindSecond
    {
        public int[] SortFusion(int[] tab)
        {
            if (tab.Length <= 1)
            {
                return tab;
            }

            int midel = tab.Length / 2;
            int[] left = new int[midel];
            int[] right = new int[tab.Length - midel];

            Array.Copy(tab, 0, left, 0, midel);
            Array.Copy(tab, midel, right, 0, tab.Length - midel);

            left = SortFusion(left);
            right = SortFusion(right);

            return Fusion(left, right);
        }
        public int[] Fusion(int[] left, int[] right)
        {
            int[] tabelFusioned = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    tabelFusioned[k++] = left[i++];
                }
                else
                {
                    tabelFusioned[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                tabelFusioned[k++] = left[i++];
            }

            while (j < right.Length)
            {
                tabelFusioned[k++] = right[j++];
            }

            return tabelFusioned;
        }

        public void ViewTable(int[] tab)
        {
            foreach (int item in tab)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void ViewSecond(int[] tab)
        {
            var result = tab[tab.Length - 2]; Console.WriteLine(result + " ");
        }
    }
}
