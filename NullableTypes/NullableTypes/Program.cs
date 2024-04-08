namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> date = null;
            DateTime? date = null;

            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            // Accessing .Value on nullable objects that are null will crash the program due to .HasValue shortcircuiting to throw an exception.
            // Use GetValueOrDefault() to access value on nullable types, or instance?.property on non-nullable types
            //Console.WriteLine(date.Value);


            DateTime? date2 = new DateTime(2014, 1, 1);
            DateTime date3 = date2.GetValueOrDefault(); // Copying from nullable types should use GetValueOrDefault()
            Console.WriteLine(date3);

            // Type Coercion from non-nullable to nullable is simple
            DateTime? date4 = date2;
            Console.WriteLine(date4.GetValueOrDefault());

            // Conditional null expression assignment
            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;

            date2 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            // Null coalescing operator to basically to do conditional operator with null
            date2 = date ?? DateTime.Today;

            Console.WriteLine(date2);
        }
    }
}
