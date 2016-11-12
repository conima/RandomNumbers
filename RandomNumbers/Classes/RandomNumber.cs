using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    internal class RandomNumber
    {
        static Random random = new Random();

        public List<int> GenerateRandom(int count)
        {
            HashSet<int> numberSet = new HashSet<int>();

            for (int top = 1; top <= count; top++)
            {
                // create set of unique numbers in range from 1 to 'count'
                if (!numberSet.Add(random.Next(1, top + 1)))
                {
                    numberSet.Add(top);
                }
            }

            // create random order list
            List<int> result = numberSet.ToList();
            for (int i = result.Count - 1; i >= 0; i--)
            {
                int x = random.Next(i + 1);
                int temp = result[x];
                result[x] = result[i];
                result[i] = temp;
            }

            return result;
        }
    }
}