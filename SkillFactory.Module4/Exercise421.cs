using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Exercise421
    {
        public void Cycling()
        {
            //Console.WriteLine("Цикл for");
            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("Iteration {0}", i);
            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;


            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Your color is something else!");
            //            break;
            //    }

            //}

            Console.WriteLine("Цикл while");
            int k = 0;

            while (k < 1)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                Console.WriteLine(k);

                var text = Console.ReadLine();

                //if (text == "stop")
                //{
                //    Console.WriteLine("Цикл остановлен");
                //    break;
                //}
                switch (text)
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
                        //Console.BackgroundColor = ConsoleColor.Yellow;
                        //Console.ForegroundColor = ConsoleColor.Red;

                        //Console.WriteLine("Your color is something else!");
                        //break;
                        continue;
                }

                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }

                k++;
            }

            //Console.WriteLine("Цикл do while");
            //int t = 0;
            //do
            //{
            //    Console.WriteLine(t);
            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;


            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Your color is something else!");
            //            break;
            //    }
            //    t++;
            //}
            //while (t < 0);

        }
    }
}
