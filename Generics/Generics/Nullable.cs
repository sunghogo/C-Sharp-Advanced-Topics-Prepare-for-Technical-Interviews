namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
            
        }

        public Nullable(T value)
        {
            // Boxing
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }
        public T GetValueOrDefault()
        {
            if (HasValue)
                // Unboxing/casting
                return (T)_value;

            // default keyword return default of T
            return default(T);
        }
    }
}
