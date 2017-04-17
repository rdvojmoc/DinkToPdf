using DinkToPdf.Contracts;
using System;
using System.Threading;
using System.Collections.Concurrent;
using System.Reflection;
using System.Threading.Tasks;

namespace DinkToPdf
{
    public class SynchronizedConverter : BasicConverter
    {
        Thread conversionThread;

        BlockingCollection<Task> conversions = new BlockingCollection<Task>();

        bool kill = false;

        private readonly object startLock = new object();

        public SynchronizedConverter(ITools tools) : base(tools)
        {

        }

        public override byte[] Convert(IDocument document)
        {
            return Invoke(() => base.Convert(document));
        }

        public TResult Invoke<TResult>(Func<TResult> @delegate)
        {
            StartThread();

            Task<TResult> task = new Task<TResult>(@delegate);

            lock (task)
            {
                //add task to blocking collection
                conversions.Add(task);

                //wait for task to be processed by conversion thread 
                Monitor.Wait(task);
            }

            //throw exception that happened during conversion
            if (task.Exception != null)
            {
                throw task.Exception;
            }

            return task.Result;
        }

        private void StartThread()
        {
            lock (startLock)
            {
                if (conversionThread == null)
                {
                    conversionThread = new Thread(Run)
                    {
                        IsBackground = true,
                        Name = "wkhtmltopdf worker thread"
                    };

                    kill = false;

                    conversionThread.Start();
                }
            }
        }
        
        private void StopThread()
        {
            lock (startLock)
            {
                if (conversionThread != null)
                {
                    kill = true;

                    while (conversionThread.ThreadState == ThreadState.Stopped)
                    { }

                    conversionThread = null;
                }
            }
        }

        private void Run()
        {
            while (!kill)
            {
                //get next conversion taks from blocking collection
                Task task = conversions.Take();

                lock (task)
                {
                    //run taks on thread that called RunSynchronously method
                    task.RunSynchronously();

                    //notify caller thread that task is completed
                    Monitor.Pulse(task);
                }
            }
        }
    }
}
