using System;

namespace SkillFactory.Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise415 Example = new Exercise415();
            //Example.TimeOfYear();
            //Example.Condition();
            //Exercise4 Color = new Exercise4();
            //Color.YourFavoriteColour();
            //Exercise421 Test = new Exercise421();
            //Test.Cycling();
            //Exercise434 exercise434 = new Exercise434();
            //exercise434.StringArray();
            //exercise434.Reshuffle();
            //exercise434.Matrix();
            //Exercise4312 exercise4312 = new Exercise4312();
            //exercise4312.ReadArray();
            //exercise4312.PositiveNumberArray();
            //exercise4312.PositiveNumberMatrix();
            //exercise4312.SortMatrixArray();
            //exercise4312.SortArray();
            //exercise4312.SummArray();
            //Exercise43 exercise43 = new Exercise43();
            //exercise43.ArraysTesting();
            //Unit_4_4 unit_4_4 = new Unit_4_4();
            //unit_4_4.WriteInCortege();
            //unit_4_4.WriteFromInCortege();
            //unit_4_4.WritePetCortege();
            //Unit4PRACTICE practice = new Unit4PRACTICE();
            //practice.DoPractice();
            //Unit_5_1 unit_5_1 = new Unit_5_1();
            //unit5.ShowColor();
            //To Exercise 5.1.5
            //(string name, int age) anketa;
            //Console.WriteLine("Введите ваше имя: ");
            //anketa.name = Console.ReadLine();

            //Console.WriteLine("Введите ваш возраст: ");
            //anketa.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", anketa.Item1);
            //Console.WriteLine("Ваш возраст: {0}", anketa.Item2);

            //string[] favcolors = new string[3];
            //for (int i = 0; i < favcolors.Length; i++)
            //{
            //    favcolors[i] = unit_5_1.ShowColor(anketa.name, anketa.age);
            //}
            //foreach (var color in favcolors)
            //    Console.WriteLine(color);

            //To exercise 5.2.15
            Unit_5_2 unit_5_2 = new Unit_5_2();
            var array = unit_5_2.GetArrayFromConsole(10);
            unit_5_2.ShowArray(array, true);
        }
    }
}
