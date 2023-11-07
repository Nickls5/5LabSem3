using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab35
{
    internal class Program2
    {
        /* static void Main(string[] args)
         {
             MyList<int> list = new MyList<int>(12, 233, 56, 139);
             Console.WriteLine($"First element in list{list[1]}");
             Console.WriteLine($"List size: {list.Size}");
             list.Add( 14 );
             Console.WriteLine("Elements of list: ");
             for (var i = 0; i < list.Size; i++)
             {
                 Console.Write($" {list[i]} ");
             }
             Console.WriteLine();
         }*/
    }


    class MyList<T>
    {
        private T[] arr;

        public MyList(params T[] arr2)
        {
            arr = new T[arr2.Length];
            for (var i = 0; i < arr2.Length; ++i)
            {
                arr[i] = arr2[i];
            }
        }

        public void Add(T ar)
        {
            var tArr = new T[arr.Length + 1];
            arr.CopyTo(tArr, 0);
            tArr[arr.Length] = ar;
            arr = tArr;
        }

        public T this[int index] => arr[index];
        public int Size => arr.Length;
    }



}

