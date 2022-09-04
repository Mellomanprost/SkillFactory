using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Unit_5_2
    {
        // Exercise 5.2.8 + Exercise 5.2.14
        public int[] GetArrayFromConsole(int num = 5)
        {
            var array = new int[num];

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
            return array;
        }

        // Exercise 5.2.17

        public void ShowArray(int[] array, bool IsSort = false) 
        {
            var temp = array;
            if (IsSort == true)
            {
                temp = SortArray(array);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }




    }
}
