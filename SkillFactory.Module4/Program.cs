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
            Unit5 unit5 = new Unit5();
            //unit5.ShowColor();
            string[] favcolours = new string[3];
            for(int i = 0; i < favcolours.Length; i++)
            {
                favcolours[i] = unit5.ShowColor();
            }
            foreach (var color in favcolours)
                Console.WriteLine(color);
        }
    }
}
