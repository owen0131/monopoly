using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestProj
{
    public static class Helpers
    {
        public static void RunCodeAsSTAWait(ThreadStart del)
        {
            var are = new AutoResetEvent(false);
            RunCodeAsSTA(are, del);
            are.WaitOne();
        }

        public static void RunCodeAsSTA( AutoResetEvent are, ThreadStart originalDel)
        {
            Thread t = new Thread(delegate ()
            {
                try
                {
                    originalDel.Invoke();
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Error {e.Message}");
                }
                are.Set();
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
