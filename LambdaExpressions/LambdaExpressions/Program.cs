namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));

            // =>: is the Lambda operators
            // args => expressions
            // () => ...
            // x => ...
            // (x, y, ...) => ...
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5)); // equivalent

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10);
            Console.WriteLine(result);

            var books = new BookRepository().GetBooks();
            // Predicate<T> is a delegate that points to a method to returns <T> and returns a bool if a condition was satisfied
            // Predicates are used in collection.Find() instanced methods
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static public int Square(int number)
        {
            return number * number;
        }

        static public bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
