using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace XamarinDemo.iOS
{
    public class SourceOS : ISource
    {
        public string ChangeText()
        {
            return "Hello from Apple";
        }
    }
}