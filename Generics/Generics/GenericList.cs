namespace Generics
{
    // Creating reusable classes like this has performance disadvantages due to boxing and casting
    public class List
    {
        public void Add(int numebr)
        {
            throw new NotImplementedException();
        }
        public int this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    public class BookList
    {
        public void Add(BookList book)
        {
            throw new NotImplementedException();

        }

        public BookList this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    public class ObjectList
    {
        public void Add(object value)
        {
            throw new NotImplementedException();

        }

        public object this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    // Generics at runtime are the specified Template/Type so there is no casting or boxing
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // Prefix your Generics parameters with 'T'
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value) { }
    }
}
