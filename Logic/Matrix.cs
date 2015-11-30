using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    interface SortInterface 
    {
        void Sort(int[][] array);

    }
    public class Matrix
    {
        public static void Show(int[][] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write("{0} ", a[i][j]);
                Console.WriteLine();
            }

        }

        public static int SumStrin(int[] a)
        {
            int sum = 0;
            for (int j = 0; j < a.Length; j++)
            {
                sum = sum + a[j];
            }
            return sum;
        }

        public static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
        public static int SearchMax(int[] a)
        {
            int max = 0;
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] > max)
                { max = a[j]; }
            }
            return max;
        }

        public static int SearchMin(int[] a)
        {
            int min = a[0];
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] < min)
                { min = a[j]; }
            }
            return min;
        }


    }
    public class MatrxiWithStringSort : Matrix, SortInterface
    {
        public void Sort(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (SumStrin(array[j]) < SumStrin(array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            } 
        }
      
    }
    public class MatrixWithSortByMax : Matrix, SortInterface
    {
        public void Sort(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (SearchMax(array[j]) < SearchMax(array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            } 
        }
     }
    public class MatrixWithSortByMin : Matrix, SortInterface
    {
        public void Sort(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (SearchMin(array[j]) > SearchMin(array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }    
    }
}