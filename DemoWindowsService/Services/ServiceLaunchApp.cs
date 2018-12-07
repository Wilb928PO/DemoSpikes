using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Threading;
using System.Linq;
using Spike.WindowsService.Helpers;

namespace Spike.WindowsService.Services
{
    public partial class ServiceLaunchApp : ServiceBase
    {
        private System.Timers.Timer timer;
        private bool timerWorking = false;
        private int iterationNumber = 0;

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(timer)).BeginInit();
            timer.Interval = timer.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["TimerInterval"]);
            timer.Enabled = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            ((System.ComponentModel.ISupportInitialize)(timer)).EndInit();
        }

        public ServiceLaunchApp()
        {
            InitializeComponent();
            InitializeTimer();
        }

        protected override void OnStart(string[] args)
        {
            timer.Start();
            EventLog.WriteEntry($"SystemPath : {System.AppDomain.CurrentDomain.BaseDirectory}");
        }

        protected override void OnStop()
        {
            timer.Stop();
        }

        private void RunTest()
        {
            // the name of the application to launch;
            // to launch an application using the full command path simply escape
            // the path with quotes, for example to launch firefox.exe:
            //      String applicationName = "\"C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe\"";
            //String applicationName = "cmd.exe";
            String applicationName = ConfigurationManager.AppSettings["TestRun"];
            Thread.Sleep(Convert.ToInt32(ConfigurationManager.AppSettings["DebugSleep"]));
            // launch the application
            ApplicationLoader.PROCESS_INFORMATION procInfo = new ApplicationLoader.PROCESS_INFORMATION();
            ApplicationLoader.StartProcess(applicationName, out procInfo);
            Process process = Process.GetProcesses().LastOrDefault(x => x.Id == procInfo.dwProcessId);
            if (process != null && process.Id > 0)
            {
                EventLog.WriteEntry($"The Process[{process.Id}] found!!!", EventLogEntryType.Information);
                process.WaitForExit();
                EventLog.WriteEntry($"The Process finalized!!!", EventLogEntryType.Information);
            }
            else EventLog.WriteEntry($"The Process not found!!!", EventLogEntryType.Warning);
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (timerWorking) return;
            timerWorking = true;
            try
            {
                EventLog.WriteEntry($"The timer[{iterationNumber}] is running!!!", EventLogEntryType.Information);
                RunTest();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry($"The timer[{iterationNumber}] >> {ex.Message}", EventLogEntryType.Error);
            }
            iterationNumber++;
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["ManyRun"])) timerWorking = false;
        }
    }
}
