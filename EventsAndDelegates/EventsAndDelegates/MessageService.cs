namespace EventsAndDelegates
{
    // Event Subscriber
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MessageService: Sending a text message for {e.Video.Title}...");
        }
    }
}
