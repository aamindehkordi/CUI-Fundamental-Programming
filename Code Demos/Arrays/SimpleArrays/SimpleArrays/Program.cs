using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] monthsDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


            string[] monthNames;
            monthNames = new string[12];
            monthNames[0] = "January";
            monthNames[1] = "February";
            monthNames[2] = "March";
            monthNames[3] = "April";
            monthNames[4] = "May";
            monthNames[5] = "June";
            monthNames[6] = "July";
            monthNames[7] = "August";
            monthNames[8] = "September";
            monthNames[9] = "October";
            monthNames[10] = "November";
            monthNames[11] = "December";


            string[] decemberCalendar = new string[monthsDays[12]]; // December is counted as month #11
            decemberCalendar[5] = "St. Nikolaus Tag";
            decemberCalendar[9] = "CSC Final - Section 1";
            decemberCalendar[11] = "CSC Final - Section 2";
            decemberCalendar[23] = "Christmas Eve";
            decemberCalendar[24] = "Christmas";


            Console.WriteLine($"Month #{11} is called {monthNames[11]} and has {monthsDays[11]} days in it, the most famous is {decemberCalendar[24]}");
        }
    }
}
