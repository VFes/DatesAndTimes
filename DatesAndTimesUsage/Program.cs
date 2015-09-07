using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimesUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now; ///creates a date type with the information att the moment of the compilation
            Console.WriteLine(myValue.ToString());

            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine("Han transcurrido " + myValue.DayOfYear + " días");
            Console.WriteLine("Han transcurrido {0} días", myValue.DayOfYear);
            Console.WriteLine("agregando 1 día a la fecha actual: " + myValue.AddDays(1).ToLongDateString());
            Console.WriteLine("quitando 1 día a la fecha actual: " + myValue.AddDays(-1).ToLongDateString());
            Console.WriteLine("Mostrando el mes " + myValue.Month);

            DateTime myBirthday = new DateTime(1991, 06, 01);
            Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday2 = DateTime.Parse("01/06/1991");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday2);
            Console.WriteLine("He vivido {0} días.", myAge.TotalDays);



            Console.ReadLine();
        }
    }
}
