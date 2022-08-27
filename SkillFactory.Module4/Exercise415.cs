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
            Console.ReadKey();

            var inv = true;
            var result = !inv;
            Console.WriteLine(result);
        }
    }
}
