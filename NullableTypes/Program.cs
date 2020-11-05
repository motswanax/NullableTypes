using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;

            // shorthand for nullables
            DateTime? date = null;

            // preffered way!
            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);
        }
    }
}
