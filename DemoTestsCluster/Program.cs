using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TeamMate.AutomationCluster.Core;
using TeamMate.AutomationCluster.Core.Interfaces;

namespace TeamMate.AutomationCluster
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new TestManager(1, true).Queue;
            queue.Push(new DefaultTest("Test1", 100, true, false, 1));
            queue.Push(new DefaultTest("Test2", 200, true, true, 0));
            queue.Push(new DefaultTest("Test3", 300, true, true, 0));
            queue.Push(new DefaultTest("Test4", 400, true, true, 0));
            queue.Push(new DefaultTest("Test5", 300, true, true, 0));
            queue.Push(new DefaultTest("Test6", 400, false, true, 0));
            queue.Push(new DefaultTest("Test7", 500, false, true, 0));
            queue.Push(new DefaultTest("Test8", 550, false, true, 0));
            queue.Push(new DefaultTest("Test9", 50, false, true, 1));
            queue.Push(new DefaultTest("Test10", 1000, false, true, 0));
            queue.Push(new DefaultTest("Test11", 1100, false, true, 0));
            queue.Push(new DefaultTest("Test12", 300, true, true, 0));
            queue.Push(new DefaultTest("Test13", 400, true, true, 0));
            queue.Push(new DefaultTest("Test14", 600, true, true, 0));
            queue.Push(new DefaultTest("Test15", 700, true, true, 0));
            queue.Push(new DefaultTest("Test16", 800, true, true, 0));
            queue.Push(new DefaultTest("Test17", 1200, true, true, 1));
            queue.Push(new DefaultTest("Test18", 1300, false, true, 0));
            queue.Push(new DefaultTest("Test19", 30, false, true, 0));
            queue.Push(new DefaultTest("Test20", 20, false, true, 0));
            queue.Push(new DefaultTest("Test21", 10, false, true, 0));
            queue.Push(new DefaultTest("Test22", 10, false, false, 1));

            int count = queue.Count();
            while (queue.HasValues())
            {
                Console.Write(count--);
                Console.Write(".- ");
                Console.WriteLine(queue.Pop().ToStringFormat());
            }

            Console.In.ReadLine();
        }
    }
}
