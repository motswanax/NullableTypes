using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date1;

            /*if (date != null)
                date1 = date.GetValueOrDefault();
            else
                date1 = DateTime.Today;*/

            // Null coalescing
            DateTime date2 = date ?? DateTime.Today;

            Console.WriteLine(date2);
        }
    }
}
