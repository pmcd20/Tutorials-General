using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        public VideoEncoder()
        {
        }

        //1-define a delegate

        //////public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //2 - Define an Event based on that delegate

        //////public event VideoEncodedEventHandler VideoEncoded;

        //this below Statement is equivilant to the delegate and event above.

        public event EventHandler<VideoEventArgs> VideoEncoded;        



        //raise the event//

       protected virtual void OnVideoEncoded(Video video)
        {
            //notify subsactibers
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }

        internal void Encode(Video video)
        {
            Console.WriteLine("Encoding video....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
            Console.Read();

        }
    }
}