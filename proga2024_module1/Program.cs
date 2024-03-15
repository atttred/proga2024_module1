using System;

namespace proga2024_module1
{
    class Program
    {
        static void Main()
        {
            ArrayManipulator.GenerateRandomArray(10, 0, 100);
            Console.WriteLine("Max: " + ArrayManipulator.FindMax());
            ArrayManipulator.SortArray();
            Console.WriteLine("Sorted array:");
            foreach (int i in ArrayManipulator.MyArray)
            {
                Console.Write(i + " ");
            }
            
            Console.ReadKey();
        }
    }
}