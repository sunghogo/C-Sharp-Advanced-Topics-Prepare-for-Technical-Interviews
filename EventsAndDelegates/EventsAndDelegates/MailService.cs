namespace EventsAndDelegates
{
    // Event Subscriber
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService: Sending an email for {e.Video.Title}...");
        }
    }
}
