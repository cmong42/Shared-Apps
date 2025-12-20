using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Project_Euler_Console_App
{

    // By considering the terms in the Fibonacci sequence whose values
    // do not exceed four million, find the sum of the even-valued terms.
    public class EvenFibonacciNumbers
    {
        public List<int> GenerateFibonacciSequence(int limit)
        {
            List<int> sequence = [1, 2, 3];

            int lastIndex = sequence.Count;

            int index1 = lastIndex - 1;
            int index2 = lastIndex - 2;

            while (sequence[lastIndex] < limit)
            {
                sequence.Add(index1+index2);

                lastIndex++;
                index1++;
                index2++;
            }

            return sequence;
        }

        public int SumEvenNumbers(List<int> sequence)
        {
            return sequence.Where(i => i % 2 == 0).Sum();
        }
    }
}
