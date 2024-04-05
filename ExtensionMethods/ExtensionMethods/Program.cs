// String Extension methods located here
using System;

// Instance methods have priority over extension methods
// If you have source code of original class, change it there. Otherwise derive a child class, and change it there. Finally using extension methods to create methods.
namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            var max = numbers.Max();

            Console.WriteLine(max);
        }
    }
}
