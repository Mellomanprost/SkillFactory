using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Unit_5_3
    {
        public void GetName(out string name, out string oldname)
        {
            oldname = "Евгения";
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            
        }

        public void ChangeAge(int age = 31)
        {

        }

        public void SortArray(int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);

        }

        public int[] SortArrayDesc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;

        }

        public int[] SortArrayAsc(int[] array)
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

        public int[] GetArrayFromConsole(ref int num)
        {
            var array = new int[num];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        public void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if (IsSort == true)
            {
                temp = SortArrayAsc(array);
                temp = SortArrayDesc(array);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }



    }
}
