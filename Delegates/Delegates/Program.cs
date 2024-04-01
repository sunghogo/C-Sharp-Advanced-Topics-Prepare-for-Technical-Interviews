namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // Load filters instanced methods into delegate filterHandler
            // System.MulticastDelegate vs System.Delegate classes: MulticastDelegate can have multiple pointers to different functions
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;

            filterHandler += RemoveRedEyeFilter;

            processor.Process(@"photo.jpg", filterHandler);
        }

        static public void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Removing red eye");
        }
    }
}
