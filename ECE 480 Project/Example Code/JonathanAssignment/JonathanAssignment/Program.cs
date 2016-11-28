using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace JonathanAssignment
{
    class Program
    {   
         static Task[] task = new Task[10];
        static void Main(string[] args)
        {
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
           for(int i=0; i<10; i++)
           {
               waiting(i);
           }
           stopwatch.Stop();
           TimeSpan ts = stopwatch.Elapsed;
           var second = ts.Seconds;
           var milisecond = ts.Milliseconds;
           Console.WriteLine("Time of execution: " + second + "." + milisecond);
           Console.WriteLine("RUNNING IN PARALLEL"+"\n");
           Stopwatch stopwatch2 = new Stopwatch();
           stopwatch2.Start();
           for (int i = 0; i < 10; i++)
           {
               Callwait(i);
           }
           Task.WaitAll(task);
               
               stopwatch2.Stop();
               TimeSpan ts2 = stopwatch2.Elapsed;
               var second2 = ts2.Seconds;
               var milisecond2 = ts2.Milliseconds;
               Console.WriteLine("Time of execution: " + second2 + "." + milisecond2);
      
           Console.ReadKey();
         
        }


        private static void waiting(int id)
        {
            Console.WriteLine("Task {0} Starting...", id);
            for (int i = 0; i<1000000000; i++)
                ;
             Console.WriteLine("Task {0} has completed", id);
        }
       private static Task waitingAsync(int id)
        {
            task[id] = Task.Factory.StartNew(() => waiting(id));
           return task[id];
        }
        private static async void Callwait(int id)
       {
           await waitingAsync(id);
       }

    }
}
