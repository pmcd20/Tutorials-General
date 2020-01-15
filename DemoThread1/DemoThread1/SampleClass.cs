using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoThread1
{
    public delegate void MyMessage(string msg);

    class SampleClass : IDisposable
    {

        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        public void Dispose()
        {
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        public SampleClass()
        {
           
        }

        public void DoWork(MyMessage myMessage)
        {
            myMessage("DoWork Method");

            new Thread(() =>
            {
                try
                {
                    Thread.Sleep(5000);
                    System.Diagnostics.Debug.Print("hello");
                    //txtDemo.Text += "" 
                    myMessage("Finishing up with Thread");

                    throw new Exception("Wow i am an exception");
                }
                catch (Exception ex)
                {
                    myMessage(ex.ToString());
                }

            }).Start();

            myMessage("Last Line of DoWorkMethod");
        }

 


        public void Method2(MyMessage myMessage)
        {
            myMessage("Method2 Method");

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
    }
}
