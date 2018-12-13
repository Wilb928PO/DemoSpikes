using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TeamMate.ClusterTestManager.Core;
using TeamMate.ClusterTestManager.Core.Interfaces;

namespace TeamMate.ClusterTestManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new TestManager().TestsQueueWrapper;
            queue.Push(new TMTest("Test1", 100, true, false, 1));//x
            queue.Push(new TMTest("Test2", 200, true, true, 0));//x
            queue.Push(new TMTest("Test3", 300, true, true, 0));//x
            queue.Push(new TMTest("Test4", 400, true, true, 0));//x
            queue.Push(new TMTest("Test5", 300, true, true, 0));
            queue.Push(new TMTest("Test6", 400, false, true, 0));//x
            queue.Push(new TMTest("Test7", 500, false, true, 0));//x
            queue.Push(new TMTest("Test8", 550, false, true, 0));//x
            queue.Push(new TMTest("Test9", 50, false, true, 1));//x
            queue.Push(new TMTest("Test10", 1000, false, true, 0));//x
            queue.Push(new TMTest("Test11", 1100, false, true, 0));//x
            queue.Push(new TMTest("Test12", 300, true, true, 0));
            queue.Push(new TMTest("Test13", 400, true, true, 0));
            queue.Push(new TMTest("Test14", 600, true, true, 0));//x
            queue.Push(new TMTest("Test15", 700, true, true, 0));//x
            queue.Push(new TMTest("Test16", 800, true, true, 0));//x
            queue.Push(new TMTest("Test17", 1200, true, true, 1));//x
            queue.Push(new TMTest("Test18", 1300, false, true, 0));//x
            queue.Push(new TMTest("Test19", 30, false, true, 0));//x
            queue.Push(new TMTest("Test20", 20, false, true, 0));//x
            queue.Push(new TMTest("Test21", 10, false, true, 0));//x
            queue.Push(new TMTest("Test22", 10, false, false, 1));//x

            int count = queue.Count();
            while (queue.HasTest())
            {                
                Console.Write(count--);
                Console.Write(".- ");
                Console.WriteLine(queue.Pop().ToStringFormat());
            }

            Console.In.ReadLine();
        }
    }
}
