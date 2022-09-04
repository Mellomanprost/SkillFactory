using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Unit_5_2
    {
        // Exercise 5.2.8
        public int[] GetArrayFromConsole()
        {
            var array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }


        public int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


            return array;
        }


    }
}
