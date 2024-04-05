// Have to be in the SAME namespace, or call using namespace  to call extension methods
// Can also put the extension namespace where the original class is located
//namespace ExtensionMethods
namespace System
{
    // String is a sealed class and cannot be inherited from
    //public class RichString : String{}

    // Naming convention: Prefix with the class you are extending, and postfix with Extensions
    // use this keyword as first argument to specify the actual instance of the class you are trying to extend
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException(
                    "numberOfWords should be greater than or equal to 0"
                );
            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
            {
                return str;
            }

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
