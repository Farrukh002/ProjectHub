// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Homework__Data_types___C__Syntax_
{
    /// <summary>
    /// Our main program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Our entry point.
        /// </summary>
        /// <param name="args">The argument.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter the larger integer number: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the smaller integer number: ");
            int min = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }

            Console.WriteLine("Original array:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            int midpoint = (max - min) / 2;
            int count = CountElementsGreaterThanMidpoint(array, midpoint);
            Console.WriteLine("Number of elements that are greater than the midpoint: {0}", count);
            int[] arrayGreaterThanMidpoint = CreateArrayGreaterThanMidpoint(array, midpoint);
            Console.WriteLine("Array with elements greater than midpoint");
            foreach (int i in arrayGreaterThanMidpoint)
            {
                Console.WriteLine(i);
            }

            SortingArrayInAscendingOrder(arrayGreaterThanMidpoint);
            Console.WriteLine("Sorted array with elements greater than midpoint in ascending order");
            foreach (int i in arrayGreaterThanMidpoint)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Counts the elements which are greater than midpoint.
        /// </summary>
        /// <param name="array">Stores the array.</param>
        /// <param name="midpoint">Stores midpoint value.</param>
        /// <returns>An int.</returns>
        public static int CountElementsGreaterThanMidpoint(int[] array, int midpoint)
        {
            int count = 0;
            foreach (int i in array)
            {
                if (i > midpoint)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Creates the array which is greater than midpoint.
        /// </summary>
        /// <param name="array">Stores the array.</param>
        /// <param name="midpoint">Stores midpoint value.</param>
        /// <returns>An int.</returns>
        public static int[] CreateArrayGreaterThanMidpoint(int[] array, int midpoint)
        {
            int[] result = new int[array.Length];
            int index = 0;
            foreach (int i in array)
            {
                if (i > midpoint)
                {
                    result[index++] = i;
                }
            }

            Array.Resize(ref result, index);
            return result;
        }

        /// <summary>
        /// Creates the array which is greater than midpoint.
        /// </summary>
        /// <param name="arr">Stores the array.</param>
        public static void SortingArrayInAscendingOrder(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}