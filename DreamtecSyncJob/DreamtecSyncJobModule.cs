using Autofac;
using DreamtecSyncJob.Acumatica;
using DreamtecSyncJob.Management;
using DreamtecSyncJob.Yttrium;
using Microsoft.Rest;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;

namespace DreamtecSyncJob
{
    public class DreamtecSyncJobModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataManager>().As<IDataManager>().SingleInstance();

            var acumaticaCookieContainer = new CookieContainer();
            var acumaticaHandler = new HttpClientHandler() { CookieContainer = acumaticaCookieContainer };


            RegisterService<IAcumaticaClient, AcumaticaClient>(builder,
                ConfigurationManager.AppSettings["AcumaticaUrl"],
                new AcumaticaLoginCredentials(
                    ConfigurationManager.AppSettings["AcumaticaLoginUrl"],
                    ConfigurationManager.AppSettings["AcumaticaUserName"],
                    ConfigurationManager.AppSettings["AcumaticaPassword"],
                    ConfigurationManager.AppSettings["AcumaticaCompany"],
                    acumaticaCookieContainer),
                acumaticaHandler);

            var yttriumHandler = new HttpClientHandler();
            RegisterService<IYttriumClient, YttriumClient>(builder, ConfigurationManager.AppSettings["YttriumClientUrl"], new YttriumLoginCredentials(
                    ConfigurationManager.AppSettings["YttriumLoginUrl"],
                    ConfigurationManager.AppSettings["YttriumUsername"],
                    ConfigurationManager.AppSettings["YttriumPassword"],
                    ConfigurationManager.AppSettings["YttriumClientId"]),
                    yttriumHandler);
        }

        private void RegisterService<I, T>(ContainerBuilder builder, string url, ServiceClientCredentials credentials, HttpClientHandler handler)
        {
            builder.Register(context =>
            {
                dynamic serviceClient = (T)Activator.CreateInstance(typeof(T), new Uri(url), credentials, handler);
                return serviceClient;
            }
            ).As<I>().SingleInstance();
        }
    }
}
