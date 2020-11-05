using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;

            // shorthand for nullables
            DateTime? date = new DateTime(2020, 3, 4);
            DateTime date1 = date.GetValueOrDefault();
            DateTime? date2 = date1;

            Console.WriteLine(date1);

        }
    }
}
