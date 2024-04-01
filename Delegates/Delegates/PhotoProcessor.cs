namespace Delegates
{
    public class PhotoProcessor
    {
        // delegate keyword to instantiate delegate to reference/point to functions
        // Useful for making frameworks and extensible code
        // Use delegates over interfaces when the caller does not need to access other properties or methods on the object implementing the method
        //public delegate void PhotoFilterHandler(Photo photo);

        // Generic System Delegates: System.Action<> (returns void) & System.Func<> (returns a value)
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            // Can call delegate once to call all its referenced methods
            filterHandler(photo);

            photo.Save();
        }
    }
}
