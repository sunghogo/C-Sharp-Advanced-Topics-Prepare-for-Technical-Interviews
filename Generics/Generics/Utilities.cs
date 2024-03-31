namespace Generics
{
    // Can put constraints at the class level
    // Other types of constraints:
    // where T : IComparable
    // where T : Product (T or any of its children/subclasses is a Product class)
    // where T : struct (T is a value type)
    // where T : class (T is a reference type)
    // where T : new() (T is an object with a default constructor)
    public class Utilities<T> where T: IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        // where keyword to apply constraints
        // Can have generic methods in a non generic class
        //public T Max<T>(T a, T b) where T :IComparable
        public T Max(T a, T b)
        {
            // Compiler does not know the type so cannot compare
            //return a > b ? a : b;
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
