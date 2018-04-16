using System.IO;
using DreamtecSyncJob.Management;
using Microsoft.Azure.WebJobs;

namespace DreamtecSyncJob
{
    public class Functions
    {
        private readonly IDataManager _dataManager;

        public Functions(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public void Trigger([TimerTrigger("00:01:00", RunOnStartup = true, UseMonitor = true)] TimerInfo timer, TextWriter log)
        {
            _dataManager.SyncData();
        }
    }
}
