using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Module4
{
    class Exercise415
    {
        public void TimeOfYear()
        {
            int currentDayInYear = 293;
            bool isLeapYear = false;

            bool isWinter =
                !isLeapYear & (currentDayInYear >= 335 | currentDayInYear <= 59)
                |
                isLeapYear & (currentDayInYear >= 336 | currentDayInYear <= 60);

            Console.WriteLine("Текущее время года - зима: {0}", isWinter);

            var inv = true;
            var result = !inv;
            Console.WriteLine(result);

            Console.ReadKey();

        }
        public void Condition()
        {
            int A = 2;
            int B = 1;
            double X = 6.3;
            double Y = 4.5;
            var C = (A < B) | (X > Y);
            Console.WriteLine(C);
        }
    }
}
