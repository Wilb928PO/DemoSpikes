
namespace TeamMate.AutomationCluster.Core.Interfaces
{
    /// <summary>
    /// Represents an interface test that can be executed
    /// </summary>
    public interface ITest
    {
        string Name { get; }

        int Duration { get; set; }

        bool Parallelizable { get; }

        bool ReadableWritable { get; }

        short NumberFailed { get; set; }

        //List<TestCategory> Categories { get; set; }
    }
}
