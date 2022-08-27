using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Exercise4
    {
        public void YourFavoriteColour()
        {
			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

			var color = Console.ReadLine();

			switch (color)
			{
				case "red":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is red!");
					break;

				case "green":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is green!");
					break;

				case "cyan":
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is cyan!");
					break;


				default:
					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.ForegroundColor = ConsoleColor.Red;

					Console.WriteLine("Your color is something else!");
					break;
			}
		}
    }
}
