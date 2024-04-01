namespace Delegates
{
    public class Photo
    {
        public void Save() { }

        static public Photo Load(string path)
        {
            return new Photo();
        }
    }
}
