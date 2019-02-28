﻿using System;
namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
           Console.WriteLine("Message Service: Sending a textmessage... " + e.Video.Title);
        }
    }
}
