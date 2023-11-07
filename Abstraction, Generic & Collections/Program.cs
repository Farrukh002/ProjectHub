namespace HomeworkAbstractionGenericCollections
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
            Console.WriteLine("Adding to the list: ");
            MyList<int> list = new MyList<int>();
            list.Add(2);
            int firstItem = list[0];
            Console.WriteLine(firstItem);
            int[] array = { 7, 2, 6, 4, 5, 9 };
            Console.WriteLine("Adding to the list by using AddRange method: ");
            list.AddRange(array);
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Checking list with contain method: ");
            Console.WriteLine(list.Contains(8));

            Console.WriteLine("Outputing item based on first index: ");
            Console.WriteLine(list.IndexOf(6));

            Console.WriteLine("Outputing item based on last index: ");
            Console.WriteLine(list.IndexOf(2));
            Console.WriteLine("Outputing item based on first index: ");
            Console.WriteLine(list.LastIndexOf(2));

            Console.WriteLine("Removing an element from list by spefying item: ");
            list.Remove(6);
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing an element from list by spefying index of item: ");
            list.RemoveAt(4);
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Sorting the list: ");
            list.Sort();
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}