using System;

namespace proga2024_module1
{
    internal class ArrayManipulator
    {
        public static int[]? MyArray { get; set; }

        public static void GenerateRandomArray(int length, int min, int max)
        {
            Random random = new Random();
            MyArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                MyArray[i] = random.Next(min, max);
            }

        }

        public static int FindMax()
        {
            if (MyArray == null)
            {
                throw new InvalidOperationException("MyArray is not initialized");
            }
            int max = MyArray[0];
            for (int i = 1; i < MyArray.Length; i++)
            {
                if (MyArray[i] > max)
                {
                    max = MyArray[i];
                }
            }
            return max;
        }

        public static void SortArray()
        {
            if (MyArray == null)
            {
                throw new InvalidOperationException("MyArray is not initialized");
            }
            Array.Sort(MyArray);
        }
    }
}
