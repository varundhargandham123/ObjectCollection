using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace CollectionClasses
{
   
    internal class ObjectModelCollections
    {
        public void collection()
        {
            Collection<int> collection = new Collection<int>();
            collection.Add(1);
            collection.Insert(0, 1);
            collection.RemoveAt(1);

            foreach (var i in collection)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        ///  class for a  read-only collection.
        /// </summary>
        public void readOnlyCollection()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            ReadOnlyCollection<int> readOnly = new ReadOnlyCollection<int>(list);

            foreach (var i in readOnly)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        ///class for a  readOnlyDictionary .
        /// </summary>
        public void readOnlyDictionary()
        {
            Dictionary<int, int> list = new Dictionary<int, int>();
            list.Add(1, 100);
            list.Add(2, 101);
            list.Add(3, 102);
            ReadOnlyDictionary<int, int> readOnly = new ReadOnlyDictionary<int, int>(list);

            foreach (var i in readOnly)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        ///  a read-only ObservableCollection<T>.
        /// </summary>
        public void readOnlyObservable()
        {
            ObservableCollection<int> list = new ObservableCollection<int> { 1, 2, 3 };

            ReadOnlyObservableCollection<int> readOnly = new ReadOnlyObservableCollection<int>(list);
            foreach (var i in readOnly)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class Collections
    {
        private static void Main(string[] args)
        {
          
            ObjectModelCollections objectModel = new ObjectModelCollections();
            Console.WriteLine("Collection");
            objectModel.collection();
            Console.WriteLine("ReadOnlyCollection");
            objectModel.readOnlyCollection();
            Console.WriteLine("ReadOnlyDictionary");
            objectModel.readOnlyDictionary();
            Console.WriteLine("ObservableCollection");
            objectModel.readOnlyObservable();
        }
    }
}