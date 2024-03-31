namespace Generics
{
    // Creating reusable classes like this has performance disadvantages due to boxing and casting
    //public class List
    //{
    //    public void Add(int numebr)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public int this[int index]
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}

    //public class BookList
    //{
    //    public void Add(BookList book)
    //    {
    //        throw new NotImplementedException();

    //    }

    //    public BookList this[int index]
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}

    //public class ObjectList
    //{
    //    public void Add(object value)
    //    {
    //        throw new NotImplementedException();

    //    }

    //    public object this[int index]
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
