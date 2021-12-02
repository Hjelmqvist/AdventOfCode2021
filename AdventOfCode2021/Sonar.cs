using System.Collections.Generic;

namespace AdventOfCode2021
{
    public static class Sonar
    {
        public static int GetIncreasedCount(int[] numbers)
        {
            int current = numbers[0];
            int increasedCount = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (current < numbers[i])
                    increasedCount++;
                current = numbers[i];
            }
            return increasedCount;
        }

        public static int[] GetTripletSums(int[] numbers)
        {
            List<int> sums = new List<int>();
            for (int i = 0; i + 2 < numbers.Length; i++)
                sums.Add( numbers[i] + numbers[i + 1] + numbers[i + 2] );
            return sums.ToArray();
        }
    }
}