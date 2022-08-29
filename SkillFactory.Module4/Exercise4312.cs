using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Exercise4312
    {
        //public void SortArray()
        //{
        //    var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        //    int temp;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for(int j = i + 1; j < arr.Length; j++)
        //        {
        //            if (arr[i] > arr[j])
        //            {
        //                temp = arr[i];
        //                arr[i] = arr[j];
        //                arr[j] = temp;
        //            }
        //        }
        //    }
        //    foreach (var item in arr)
        //    {
        //        Console.Write(item);
        //    }
        //}
        public void SummArray()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summ += arr[i];
            }
            Console.WriteLine(summ);
        }
    }
}
