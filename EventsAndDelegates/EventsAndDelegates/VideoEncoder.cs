namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    // Event publisher
    public class VideoEncoder
    {
        // 1. Define a delegate (event handler
        // Naming convertion: Event + EventHandler
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2. Define an event based on that delegate
        // event word to specify event based on delegate
        // This event is a list of pointer to methods, need to add the event methods at object instantiation
        //public event VideoEncodedEventHandler VideoEncoded;

        // Built-In event handler classes so we don't need to declare our own delegates: EventHandler & EventHandler<TEventArgs>
        //public event EventHandler VideoEncoded
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding {video.Title}...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // 3. Raise the event
        // Convention states the raising event method should be protected and virtual
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded is not null)
            {
                //VideoEncoded(this, EventArgs.Empty);
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
