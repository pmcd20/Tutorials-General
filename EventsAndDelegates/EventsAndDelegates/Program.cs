using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EventsAndDelegates
{
    class Program
    {

        //taken from Mosh
        /// <summary>
        /// https://www.youtube.com/watch?v=jQgwEsJISy0
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();  //publisher
            var mailService = new MailService(); //suscriber
            var messageService = new MessageService(); //suscriber


            //reference -- pointer to method
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;


            videoEncoder.Encode(video);

        }
    }
}
