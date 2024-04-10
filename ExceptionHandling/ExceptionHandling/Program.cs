namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                //var calculator = new Calculator();
                //var result = calculator.Divide(5, 0); // Crashes

                //streamReader = new StreamReader(@"C:\temp\file.txt");
                //var content = streamReader.ReadToEnd();
                //throw new Exception("Oops");

                // using statement will automatically .Dispose() so does need finally statement
                //using (var streamReader2 = new StreamReader(@"C:\temp\file.txt"))
                //{
                //    var content2 = streamReader.ReadToEnd();
                //}

                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sorry, can't divide by 0.");
            }
            catch (ArithmeticException ex) { }
            catch (Exception ex)
            {
                //Console.WriteLine("Sorry, and unexpected error occured.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Unmanaged resources not managed by CLR and garbage collector: file handles. database connections, graphic handles, etc...
                // IDiposable Interface w/ .Dispose() method
                if (streamReader != null)
                {
                    streamReader.Dispose();
                }
            }
        }
    }
}
