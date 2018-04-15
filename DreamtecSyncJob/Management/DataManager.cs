using DreamtecSyncJob.Acumatica;
using DreamtecSyncJob.Yttrium;
using System;

namespace DreamtecSyncJob.Management
{
    public class DataManager : IDataManager
    {
        private readonly IAcumaticaClient _acumaticaClient;
        private readonly IYttriumClient _yttriumClient;

        public DataManager(IAcumaticaClient acumaticaClient, IYttriumClient yttriumClient)
        {
            _acumaticaClient = acumaticaClient;
            _yttriumClient = yttriumClient;
        }

        public void SyncData()
        {
            var resp = _yttriumClient.Financial.UpdateFinancialDocumentExport(new Yttrium.Models.ResQYttriumWebApiModelsUpdateFinancialDocumentExportModel());
        }
    }
}
