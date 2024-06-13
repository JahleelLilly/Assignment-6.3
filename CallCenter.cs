using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._3
{
    internal class CallCenter
    {
        private int counter = 0;
        public Queue<IncomingCall> CallQueue { get; } = new Queue<IncomingCall>();

        public IncomingCall Call(int Id)
        {
            var call = new IncomingCall { CallId = Id };
            CallQueue.Enqueue(call);
            Console.WriteLine($"Call {call.CallId} has been assigned to the queue.");
            return call;
        }

        public void Answer()
        {
            if (CallQueue.Count > 0)
            {
                CallQueue.Dequeue();
                counter--;
                Console.WriteLine("The call has been removed from the queue.");
                DisplayCallCount();
            }
            else
            {
                Console.WriteLine("No callers in the queue.");
            }
        }

        public void DisplayCallCount()
        {
            Console.WriteLine($"Number of calls in the queue: {CallQueue.Count}");
        }
    }

    internal class IncomingCall
    {
        public int CallId { get; set; }
    }

    class Program
    {
        static void Main()
        {
            CallCenter callCenter = new CallCenter();

            // Example usage:
            callCenter.Call(1);
            callCenter.Answer();
        }
    }
}
