using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Unit4PRACTICE
    {
        public void DoPractice()
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] FavColors) User;

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                string checkFlag = Console.ReadLine();
                if (checkFlag == "Да")
                    User.HasPet = true;
                else
                    User.HasPet = false;

                Console.WriteLine("Введите возраст пользователя");
                User.Age = Convert.ToDouble(Console.ReadLine());

                User.FavColors = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < 3; i++)
                {
                    User.FavColors[i] = Console.ReadLine();
                }

            }
        }

    }
}
