using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Exercise4312
    {
        public void SortArray()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
        }
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

        public void ReadArray()
        {
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };
            Console.Write("Ваш массив: ");
            foreach (var item in array)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item[i] + " ");
                }

                // или
                //foreach (var num in item)
                //{
                //    Console.Write(num + " ");
                //}
            }
        }

    }
}
