using System;

namespace ProgrammerDay
{
    public class ProgrammerDayGetDay 
    {
        public string getDate(int year) {
            DateTime DateTime = new DateTime(year, 1, 1);
            var programmerDay = DateTime.AddDays(255);
            string date = programmerDay.Day.ToString() +"."+ programmerDay.Month.ToString() +"."+ programmerDay.Day.ToString();
            Console.WriteLine(date);
            return date;
        }
    }
}