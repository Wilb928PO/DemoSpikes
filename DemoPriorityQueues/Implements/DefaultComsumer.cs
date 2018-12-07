using Spikes.PriorityQueues.Interfaces;
using System;

namespace Spikes.PriorityQueues.Implements
{
    public class DefaultComsumer : IComsumer
    {
        public string Name { get; set; }

        public void TestProcess(IQueueManager queueManager)
        {           
            
            while (queueManager.HasRequest())
            {
                Console.WriteLine($"Host : {Name} =>>> {queueManager.popRequest().ToString()}");                
            }
        }
    }
}
