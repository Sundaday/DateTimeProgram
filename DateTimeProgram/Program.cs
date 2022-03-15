using System;
using System.Globalization;

namespace DateTimeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            DateTime tomorrow = date.AddDays(1).AddHours(2).AddMinutes(10);

            CultureInfo langueFr = CultureInfo.GetCultureInfo("de-AT");

            Console.WriteLine(tomorrow);
            //Console.WriteLine(date.ToString("dddd dd MMMM yyyy HH:mm:ss:ffff", langueFr));

            var diff = tomorrow - date;
            Console.WriteLine(diff.TotalSeconds);
        }
    }
}
