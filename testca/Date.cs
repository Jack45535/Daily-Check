using System;
using System.Collections.Generic;

namespace calender_app
{
    class Date
    {
        public void GetDate()
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
        }
    }
}