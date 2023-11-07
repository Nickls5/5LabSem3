using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab35
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, int> pair1 = new KeyValuePair<string, int>("Banana", 60);
            KeyValuePair<string, int> pair2 = new KeyValuePair<string, int>("Potato", 30);
            KeyValuePair<string, int> pair3 = new KeyValuePair<string, int>("Corn", 80);
            KeyValuePair<string, int> pair4 = new KeyValuePair<string, int>("Strawberry", 150);
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>(pair1, pair2, pair3);
            Console.WriteLine($"Corn: {myDictionary["Corn"]}");
            Console.WriteLine($"Size: {myDictionary.Size}");
            myDictionary.Add(pair4);
            Console.WriteLine($"New size: {myDictionary.Size}");
        }
    }

    class MyDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> dict;

        public MyDictionary(params KeyValuePair<TKey, TValue>[] args)
        {
            dict = Enumerable.ToList(args);
        }

        public void Add(KeyValuePair<TKey, TValue> arg)
        {
            dict.Add(arg);
        }

        public TValue this[TKey key]
        {
            get
            {
                foreach (var pair in dict)
                {
                    if (Equals(pair.Key, key)) return pair.Value;
                }

                KeyValuePair<TKey, TValue> temp = new KeyValuePair<TKey, TValue>();
                return temp.Value;
            }
        }

        public int Size => dict.Count;
    }

}



