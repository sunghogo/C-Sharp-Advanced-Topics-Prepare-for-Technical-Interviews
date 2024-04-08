namespace DynamicBinding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            obj.GetType();

            // With Original Reflection
            try
            {
                var methodInfo = obj.GetType().GetMethod("GetHashCode");
                methodInfo.Invoke(null, null);
            }
            catch (Exception)
            {
                Console.WriteLine("GetHashCode ambiguous expcetion");
            }

            object excelObject = "mosh";
            //excelObject.Optimize(); // Compilation error because .Optimize() method does not exist

            // With Reflection using dynamic keyword
            // .NET gets compiled code in IL, then CLR recompiles the IL into machine code using JIT compilation
            // Dynamic Language Runtime (DLR) sit on top of CLR, and gives dynamic language capabilities to C#
            dynamic excelObject2 = "mosh";
            try
            {
                excelObject2.Optimize();
            }
            catch (Exception)
            {
                Console.WriteLine("Optimize can't be found at runtime");
            }

            // Different dynamic types
            dynamic name = "Mosh";
            //name = 10;
            Console.WriteLine(name);
            try
            {
                name++;
            }
            catch (Exception)
            {
                Console.WriteLine("RuntimeBinderException");
            }

            // dynamic type with var
            dynamic a = 10;
            dynamic b = 20;
            var c = a + b; // dynamic [int]

            // dynamcic has implicit conversion from and to target ype
            int i = 5;
            dynamic d = i; // dynamic [int]
            long l = d; // implicit conversion of int to long carries over
        }
    }
}
