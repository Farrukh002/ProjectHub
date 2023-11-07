namespace HomeworkDataTypesAndCSharpSyntax
{
    /// <summary>
    /// Our program.cs.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Our entry point.
        /// </summary>
        public static void Main()
        {
            const string userPromptSize = "Enter the size of the array with positive integer value: ";
            const string userPromptMax = "Enter the larger integer number: ";
            const string userPromptMin = "Enter the smaller integer number: ";
            int n = GetValidIntegerInput(userPromptSize);
            while (n <= 1)
            {
                Console.WriteLine("Invalid input. The array can't be less than 1");
                n = GetValidIntegerInput(userPromptSize);
            }

            int[] array = new int[n];
            int max = GetValidIntegerInput(userPromptMax);
            int min = GetValidIntegerInput(userPromptMin);

            while (min >= max)
            {
                Console.WriteLine("Invalid input. The smaller integer must be less than the larger integer.");
                min = GetValidIntegerInput("Enter the smaller integer number:");
            }

            var rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }

            Console.WriteLine();
            Console.WriteLine("Original array:");
            CreateMatrixOutOfArray(array, n);
            int midpoint = (max - min) / 2;
            int count = CountElementsGreaterThanMidpoint(array, midpoint);
            Console.WriteLine("Number of elements that are greater than the midpoint: {0}", count);
            Console.WriteLine();
            Console.WriteLine("Array with elements greater than midpoint:");
            int[] arrayGreaterThanMidpoint = CreateArrayGreaterThanMidpoint(array, midpoint);
            Console.WriteLine();
            SortingArrayInAscendingOrder(arrayGreaterThanMidpoint);
            Console.WriteLine("Sorted array with elements greater than midpoint in ascending order:");
            CreateMatrixOutOfArray(arrayGreaterThanMidpoint, arrayGreaterThanMidpoint.Length);
            Console.WriteLine();
        }

        /// <summary>
        /// Gets the int value from user.
        /// </summary>
        /// <param name="message">The message prompt asking for user input.</param>
        /// /// <returns>An int.</returns>
        public static int GetValidIntegerInput(string message)
        {
            int input = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write(message);
                isValidInput = int.TryParse(Console.ReadLine(), out input);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }

            return input;
        }

        /// <summary>
        /// Creates matrix out of array for better looking output.
        /// </summary>
        /// <param name="array">An array of integers to be processed.</param>
        /// <param name="size">the size of array.</param>
        /// <returns>The 2 dimensional array of int.</returns>
        public static int[,] CreateMatrixOutOfArray(int[] array, int size)
        {
            int n = (int)Math.Sqrt(size); // calculate n as the square root of size
            int m = (size + n - 1) / n; // calculate m using the formula (size + n - 1) / n
            int[,] matrix = new int[m, n];
            int index = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (index < array.Length)
                    {
                        matrix[i, j] = array[index];
                        index++;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                if (i == 0)
                {
                    Console.Write("[[");
                }
                else
                {
                    Console.Write(" [");
                }

                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j == n - 1)
                    {
                        Console.Write(".]");
                        if (i == m - 1 && j == n - 1)
                        {
                            Console.Write("]");
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }

                Console.WriteLine();
            }

            return matrix;
        }

        /// <summary>
        /// Counts the elements which are greater than midpoint values.
        /// </summary>
        /// <param name="array">An array of integers to be processed.</param>
        /// <param name="midpoint">Threshold.</param>
        /// <returns>An int.</returns>
        public static int CountElementsGreaterThanMidpoint(int[] array, int midpoint)
        {
            return array.Count(i => i > midpoint);
        }

        /// <summary>
        /// Creates the array which is greater than midpoint.
        /// </summary>
        /// <param name="array">An array of integers to be processed.</param>
        /// <param name="midpoint">Threshold.</param>
        /// <returns>An array of int.</returns>
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
            CreateMatrixOutOfArray(result, result.Length);
            return result;
        }

        /// <summary>
        /// Sorts the array in ascending order using bubble sort algorithm.
        /// </summary>
        /// <param name="arr">An array of integers to be processed.</param>
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