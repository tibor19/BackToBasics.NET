using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting2
{

    // [x   Flags]
    enum Weekdays 
    {
        NoDay = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
        Weekend = Saturday + Sunday

    }

    class Program
    {
        static void Main(string[] args)
        {
            Weekdays day = Weekdays.Saturday | Weekdays.Monday;

            Console.WriteLine(day);
        }
    }
}
