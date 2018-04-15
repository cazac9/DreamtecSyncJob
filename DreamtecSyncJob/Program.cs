using Autofac;
using Crown.CC.PatronProfile.WebJob;
using Microsoft.Azure.WebJobs;

namespace DreamtecSyncJob
{
    // To learn more about Microsoft Azure WebJobs SDK, please see https://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Functions>().InstancePerDependency();
            builder.RegisterModule<DreamtecSyncJobModule>();
            var container = builder.Build();

            JobHostConfiguration config = new JobHostConfiguration()
            {
                JobActivator = new AutofacJobActivator(container)
            };

            var host = new JobHost(config);
            // The following code ensures that the WebJob will be running continuously
            host.Call(typeof(Functions).GetMethod("Trigger"));
        }
    }
}
