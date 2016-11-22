using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SortArray
{
    /// <summary>
    /// الگوریتم کوییک سورت 
    /// این الگوریتم یکی از الگوریتم های موجود برای سورت کردن میباشد
    /// بهترین زمان جستجو O(n log n)
    /// بدترین زمان جستجو O(n2)
    /// سوال؟ بهترین و بدترین زمان جستجو در الگوریتم کوییک سرت چه زمانی اتفاق میافتد؟
    /// </summary>
    public static class XSort
    {
        //#################################################

        static int Partition(int[] arr, int Lobj, int Robj)
        {
            int pivot = Lobj;
            int temp;
            while (Lobj < Robj)
            {
                while (arr[Lobj] <= arr[pivot])
                    Lobj++;

                while (arr[Robj] > arr[pivot])
                    Robj--;

                if (Lobj < Robj)
                {
                    temp = arr[Lobj];
                    arr[Lobj] = arr[Robj];
                    arr[Robj] = temp;
                }
            }
            if (arr[Robj] < arr[pivot])
            {
                temp = arr[pivot];
                arr[pivot] = arr[Robj];
                arr[Robj] = temp;
            } return Robj;
        }

        //#################################################

        public static void Quicksort(int[] arr, int Lobj, int Robj)
        {
            if (Lobj < Robj)
            {
                int pivot = Partition(arr, Lobj, Robj);
                Quicksort(arr, Lobj, pivot - 1);
                Quicksort(arr, pivot + 1, Robj);
            }
        }

        //#################################################




    }
}