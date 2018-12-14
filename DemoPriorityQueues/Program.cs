using Spikes.PriorityQueues.Implements;
using Spikes.PriorityQueues.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Threading;

namespace DemoStructure
{
    class Program
    {
        private static void LoadTest(QueueManager queueManager)
        {
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test1", PriorityQueue = PriorityQueue.Low });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test4", PriorityQueue = PriorityQueue.Medium });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test6", PriorityQueue = PriorityQueue.Medium });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test2", PriorityQueue = PriorityQueue.Low });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test3", PriorityQueue = PriorityQueue.Low });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test8", PriorityQueue = PriorityQueue.High });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test9", PriorityQueue = PriorityQueue.High });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test10", PriorityQueue = PriorityQueue.High });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test5", PriorityQueue = PriorityQueue.Medium });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test7", PriorityQueue = PriorityQueue.Medium });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test11", PriorityQueue = PriorityQueue.High });
            queueManager.pushRequest(new DefaultTestRequest() { Name = "Test12", PriorityQueue = PriorityQueue.High });
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nFirst Mode\n");
            DefaultComsumer consumer = new DefaultComsumer() { Name = "Localhost" };
            QueueManager queueManager = QueueManager.GetInstance();
            queueManager.ProcessQueues = new PQByPriority();
            LoadTest(queueManager);
            consumer.TestProcess(queueManager);

            Console.WriteLine("\nSecond Mode\n");

            ConcurrentDictionary<PriorityQueue, int> measure = new ConcurrentDictionary<PriorityQueue, int>();
            measure.TryAdd(PriorityQueue.Low, 1);
            measure.TryAdd(PriorityQueue.Medium, 2);
            measure.TryAdd(PriorityQueue.High, 3);
            queueManager.ProcessQueues = new PQByMeasure(measure);
            LoadTest(queueManager);
            consumer.TestProcess(queueManager);

            Console.WriteLine("\nThird Mode\n");

            DefaultComsumer consumer2 = new DefaultComsumer() { Name = "AutoTes2" };
            DefaultComsumer consumer3 = new DefaultComsumer() { Name = "Sharmar" };
            LoadTest(queueManager);
            Thread[] threads = new Thread[] {
                new Thread(() => consumer.TestProcess(queueManager)),
                new Thread(() => consumer2.TestProcess(queueManager)),
                new Thread(() => consumer3.TestProcess(queueManager)),
            };
            foreach (Thread client in threads) {
                client.Start();
            }

            Console.In.ReadLine();
        }
    }
}
