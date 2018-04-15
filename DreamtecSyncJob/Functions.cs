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

        [NoAutomaticTrigger]
        public void Trigger(TextWriter log)
        {
            _dataManager.SyncData();
        }
    }
}
