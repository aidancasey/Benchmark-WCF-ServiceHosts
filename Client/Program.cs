using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Client
{
    class Program
    {

        private static int _numerOfThreadsNotYetCompleted = 500;
        private static readonly ManualResetEvent _doneEvent = new ManualResetEvent(false);

        private static void Main(string[] args)
        {

            DateTime startTime = DateTime.Now;
           // RunMultiThreaded();
            
            RunSingleThreaded();

            DateTime endTime = DateTime.Now;
            TimeSpan span = endTime.Subtract(startTime);
             Console.WriteLine("time taken  " + span.TotalMilliseconds.ToString());
            Console.WriteLine("All done.");
            Console.ReadLine();
        }

        private static void RunMultiThreaded()
        {
            for (int threadNumber = 0; threadNumber < 500; threadNumber++)
                ThreadPool.QueueUserWorkItem(new WaitCallback(RunTask),
                    (object)threadNumber);

            _doneEvent.WaitOne();
        }


        private static void RunSingleThreaded()
        {
            for (int i = 0; i < 500; i++)
            {
                DataMigrationClient client = default(DataMigrationClient);
                try
                {
                client = new DataMigrationClient();
                string result = client.MigrateSingleClient("client" + i);
                Console.WriteLine("response is ... " + result);
                client.Close();
                }
                catch (Exception)
                {
                    if(client !=null)
                    client.Abort();
                    throw;
                }
                
            }
        }

        private static void RunTask(object task)
        {
            try
            {
                Console.WriteLine("Thread number: {0}", (int)task);
                int id = (int)task;
                DataMigrationClient client = default(DataMigrationClient);
                try
                {
                    client = new DataMigrationClient();
                    string result = client.MigrateSingleClient("client" + id);
                    Console.WriteLine("result is ... " + result);
                    client.Close();
                }
                catch (Exception)
                {
                    if (client != null)
                        client.Abort();
                    throw;
                }

            }
            finally
            {
                if (Interlocked.Decrement(ref _numerOfThreadsNotYetCompleted) == 0)
                    _doneEvent.Set();
            }
        }

    }
}
