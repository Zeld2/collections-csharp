using System;
using static System.Console;

namespace collections.src
{
    public class ArrayOperations
    {

        public void BubbleSort(int[] array)
        {
            int temp = 0;

            for (var i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void PrintArray(int[] array)
        {
            WriteLine(string.Join(", ", array));
        }

        public void Sort(int[] array)
        {
            Array.Sort(array);
        }

        public void Copy(int[] array, int[] arrayDestiny)
        {
            Array.Copy(array, arrayDestiny, array.Length);
        }

        public bool Exists(int[] array, int valor)
        {
            return Array.Exists(array, element => element == valor);
        }

        public bool AllBigger(int[] array, int valor)
        {
            return Array.TrueForAll(array, element => element > valor);
        }

        public int FindValue(int [] array, int valor)
        {
            return Array.FindIndex(array, element => element == valor);
        }

        public void Resize(ref int[] array, int valor)
        {
            Array.Resize(ref array, valor);
        }

        public string[] ArrayToString(int[] array)
        {
            return Array.ConvertAll(array, element => element.ToString());
        }
    }
}