using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    class Combination
    {
        public static IEnumerable<IList<T>> Combinations<T>(
            IList<T> sequence,
            int choose)
        {
            return Combinations(sequence, 0, sequence.Count, choose);
        }

        private static void RotateLeft<T>(IList<T> sequence, int start, int count)
        {
            T tmp = sequence[start];
            sequence.RemoveAt(start);
            sequence.Insert(start + count - 1, tmp);
        }

        public static IEnumerable<IList<T>> Combinations<T>(IList<T> sequence, int start, int count, int choose)
        {
            if (choose == 0) yield return sequence;
            else
            {
                for (int i = 0; i < count; i++)
                {
                    foreach (var perm in Combinations(sequence, start + 1, count - 1 - i, choose - 1))
                        yield return perm;
                    RotateLeft(sequence, start, count);
                }
            }
        }
    }
}
