using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceProgramation
{
    public class Anagram
    {
        public string result { get; private set; }

        public string  AnagramVerification(string world1, string world2)
        {
            char[] firstworld = world1.ToCharArray();
            char[] secondworld = world2.ToCharArray();

            char [] sortword1 = SortFusion(firstworld);
            char[] sortword2 = SortFusion(secondworld);

            var worldOne = new string(sortword1);
            var worldTow = new string(sortword2);

            if (worldOne == worldTow) { return result = "is a anagram"; }

            return result = "these two world aren't a anagram";
        }
        public char[] SortFusion(char[] tab)
        {
            if (tab.Length <= 1)
            {
                return tab;
            }

            int midel = tab.Length / 2;
            char[] left = new char[midel];
            char[] right = new char[tab.Length - midel];

            Array.Copy(tab, 0, left, 0, midel);
            Array.Copy(tab, midel, right, 0, tab.Length - midel);

            left = SortFusion(left);
            right = SortFusion(right);

            return Fusion(left, right);
        }
        public char[] Fusion(char[] left, char[] right)
        {
            char[] tabelFusioned = new char[left.Length + right.Length];
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
    }
}
