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

        // Exercise 4.3.14 
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

        //Exercise 4.3.15
        public void PositiveNumberArray()
        {
            int[] arrayOfNumbers = new int[] { 1, 3, -7, 8, -2 };
            int quantityPosNumb = 0;
            foreach (var item in arrayOfNumbers)
            {
                if (item > 0)
                {
                    quantityPosNumb++;
                }
            }
            Console.WriteLine("Количество положительных чисел равно " + quantityPosNumb);
        }
        //Exercise 4.3.16
        public void PositiveNumberMatrix()
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int quantityPosNumb = 0;

            Console.WriteLine("Вариант с for :");
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                    if (arr[i, k] > 0)
                        quantityPosNumb++;
            }
            Console.WriteLine("Количество положительных чисел - " + quantityPosNumb);

            Console.WriteLine("Вариант с foreach :");
            quantityPosNumb = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                    quantityPosNumb++;
            }
            Console.WriteLine("Количество положительных чисел - " + quantityPosNumb);
        }
        //Exercise 4.3.17
        public void SortMatrixArray()
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp;

            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                {
                    Console.Write(arr[i, k] + " ");
                }
            }

            Console.WriteLine();
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                {
                    for (int j = k + 1; j < arr.GetUpperBound(1) + 1; j++)
                    {
                        if (arr[i, k] > arr[i, j])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
                    }
                    Console.Write(arr[i, k] + " ");
                }
            }
        }
    }
}