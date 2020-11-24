using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 3, 5, 4, 8, 9, 6, 7 };
            int i, j, temp;
            // bubble Sort

            Console.WriteLine("Original array:");
            foreach (var a in arr)
                Console.Write(a + " ");
            for (i = 0; i < arr.Length - 1; i++)
                for (j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            Console.WriteLine("New array after BubbleSorting:");
            foreach (var a in arr)
                Console.Write(a + " ");

            //insertion Sort
            int holePosition;
            for (i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                holePosition = i;
                while (holePosition > 0 && arr[holePosition - 1] > temp)
                {
                    arr[holePosition] = arr[holePosition - 1];
                    holePosition--;
                }
                if (holePosition != i)
                    arr[holePosition] = temp;
            }

            // selection Sort
            int minPosition;
            for (i = 0; i < arr.Length - 1; i++)
            {
                minPosition = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minPosition] > arr[j])
                        minPosition = j;
                }
                if (minPosition != i)
                {
                    temp = arr[minPosition];
                    arr[minPosition] = arr[i];
                    arr[i] = temp;
                }
            }

            Console.WriteLine("New array after InsertionSorting:");
            foreach (var a in arr)
                Console.Write(a + " ");
            Console.ReadKey();
        }
    }
}
