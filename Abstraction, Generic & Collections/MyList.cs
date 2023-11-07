namespace HomeworkAbstractionGenericCollections
{
    using System.Collections;

    /// <summary>
    /// A generic list implementation that stores elements of type T.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the list.</typeparam>
    internal class MyList<T> : IEnumerable<T>
    {
        private T[] items;
        private int count;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyList{T}"/> class.
        /// </summary>
        /// <param name="capacity">Stores the capacity of list which at the begining is set to 10.</param>
        public MyList(int capacity = 10)
        {
            items = new T[capacity];
        }

        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <returns>The element at the specified index.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the index is out of range.</exception>
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                return items[index];
            }

            set
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                items[index] = value;
            }
        }

        /// <summary>
        /// Adds an item to the end of the list.
        /// </summary>
        /// <param name="item">The item to add to the list.</param>
        public void Add(T item)
        {
            if (count == items.Length)
            {
                T[] newArray = new T[items.Length * 2];
                Array.Copy(items, newArray, count);
                items = newArray;
            }

            items[count++] = item;
        }

        /// <summary>
        /// Adds the elements of the specified collection to the end of the list>.
        /// </summary>
        /// <param name="collection">The collection whose elements should be added to the end of the list>.
        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        /// <summary>
        /// Checks whether specific item exists or not in the list.
        /// </summary>
        /// <param name="item">The item to be checked.</param>
        /// <returns>True if element exists otherwise false.</returns>
        public bool Contains(T item)
        {
            foreach (var it in items)
            {
                if (it.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }


        /// <summary>
        /// Searches for the specified element and returns the index of the first occurrence within the entire list.
        /// </summary>
        /// <param name="item">The item to be checked.</param>
        /// <returns>The zero-based index of the first occurrence of the item within the entire list, if found; otherwise, -1.</returns>
        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Searches for the specified element and returns the index of the last occurrence within the entire list.
        /// </summary>
        /// <param name="item">The item to be checked.</param>
        /// <returns>The zero-based index of the last occurrence of the item within the entire list, if found; otherwise, -1.</returns>
        public int LastIndexOf(T item)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Removes an element from list by specifying an element.
        /// </summary>
        /// <param name="item">The item to be checked.</param>
        /// <returns>True if element is succefuly deleted or false if element was not found.</returns>
        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return false;
            }

            RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Removes an element from list by specifying the index of an element.
        /// </summary>
        /// <param name="index">The index of item to be checked.</param>
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            count--;
        }

        /// <summary>
        /// Removes an element from list by specifying the index of an element.
        /// </summary>
        public void Sort()
        {
            Array.Sort(items, 0, count);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator for the collection.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
