using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyThreads
{
    class MyThreadClass
    {
        public void thread1()
        {
            for (int LoopCount = 0; LoopCount <= 5; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + " = " + LoopCount);
                Thread.Sleep(TimeSpan.FromSeconds(1.5));
            }
        }

        public void thread2()
        {
            for (int LoopCount = 0; LoopCount <= 5; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of the thread: " + thread.Name + " = " + LoopCount);
                Thread.Sleep(TimeSpan.FromSeconds(1.5));
            }
        }
    }
}
