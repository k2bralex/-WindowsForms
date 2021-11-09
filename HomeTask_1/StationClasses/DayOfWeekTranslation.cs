using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_1
{
    class DayOfWeekTranslation
    {
        public static string Translation(DateTime datetime)
        {
            List<string> translationsList = new List<string>()
            {
                "Воскресение",
                "Понедельник",
                "Вторник",
                "Среда",
                "Четверг",
                "Пятница",
                "Суббота",
            };
            DayOfWeek dayindex = datetime.DayOfWeek;
            return $"{translationsList[(int)dayindex]}";
        }


    }
}
