using LINQ;

// LINQ = Language Integrated Query, allows you to query objects, (databases) entites, XML, data sets
// LINQ extension methods used often to query SQL databases using Entity framework
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Without LINQ or using .FindAll()
            //var cheapBooks = new List<Book>();

            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            // LINQ Query Operators
            var cheaperBooks = from b in books where b.Price < 10 orderby b.Title select b.Title;

            // LINQ Extension Methods
            // .Where() to filter
            // .OrderBy to sort
            // .Select() to property and generate a new list with that property
            // Can chain LINQ methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var book in cheapBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }

            // .Single() to find single object
            // Creashes if it cannot find, so use .SingleOrDefault()
            var singleBook = books.Single(b => b.Title == "ASP.NET MVC");
            var nullBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");

            Console.WriteLine(singleBook.Title);
            Console.WriteLine(nullBook == null);

            // .First() to find first object fulfilling condition
            // .Last() to find last object fulfilling condition
            // Similarly, .FirstOrDefault() or .LastOrDefault()
            var firstBook = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(firstBook?.Title + " " + firstBook?.Price);

            var lastBook = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(lastBook?.Title + " " + lastBook?.Price);

            // .Skip() and .Take() used for paging data / slicing
            var pagedBooks = books.Skip(2).Take(3);

            foreach (var book in pagedBooks)
            {
                Console.WriteLine(book.Title);
            }

            // .Count() to get number of objs
            var count = books.Count();
            Console.WriteLine(count);

            // .Max() and .Min() to get highest/lowest property value
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);

            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);

            // .Sum() to aggregate property value
            // .Average() to average property value
            var totalPrice = books.Sum(b => b.Price);
            var averagePrice = books.Average(b => b.Price);

            Console.WriteLine(totalPrice);
            Console.WriteLine(averagePrice);
        }
    }
}
