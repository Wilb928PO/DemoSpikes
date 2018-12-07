
namespace Spikes.PriorityQueues.Interfaces
{
    public enum PriorityQueue { Low, Medium, High };

    public interface IQueueManager
    {
        bool HasRequest();

        ITestRequest popRequest();
    }
}
