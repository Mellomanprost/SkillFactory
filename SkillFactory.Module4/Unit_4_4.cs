using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Unit_4_4
    {
        //Exercise 4.4.2
        public void WriteInCortege()
        {
            (string name, int age) anketa;
            Console.WriteLine("Введите ваше имя: ");
            anketa.name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.Item1);
            Console.WriteLine("Ваш возраст: {0}", anketa.Item2);
        }

        //Exercise 4.4.3
        public void WriteFromInCortege()
        {
            var (name, age) = ("Pavel", 31);
            Console.WriteLine("My name: " + name);
            Console.WriteLine("My age: " + age);

            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

        }

        //Exercise 4.4.5
        public void WritePetCortege()
        {
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.WriteLine("Enter pet name: ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;
            //if (Pet.NameCount < 1 || Pet.NameCount > 16)
            //{
            //    Console.WriteLine("The number of characters exceeds the allowed value!");
            //}
            Console.WriteLine("Enter pet type: ");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Enter pet age: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());

        }
    }
}
