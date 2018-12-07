using Spike.WindowsService.Services;
using System.ServiceProcess;

namespace Spike.WindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServiceLaunchApp()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
