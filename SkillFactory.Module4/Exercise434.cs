using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Exercise434
    {
        //public void StringArray()
        //{
        //    Console.WriteLine("Введите свое имя");
        //    var name = Console.ReadLine();
        //    Console.WriteLine("Ваше имя по буквам: ");
        //    foreach(var ch in name)
        //    {
        //        Console.Write(ch + " ");
        //    }
        //    Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);
        //}

        public void Reshuffle()
        {
            Console.WriteLine("Введите свое имя");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам: ");
            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }
            Console.Write("\nВаше имя в обратном порядке: ");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }

        }
    }
}
