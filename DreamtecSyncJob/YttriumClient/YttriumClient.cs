﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DreamtecSyncJob.Yttrium
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Models;

    public partial class YttriumClient : ServiceClient<YttriumClient>, IYttriumClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }        

        /// <summary>
        /// Subscription credentials which uniquely identify client subscription.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets the IAccidentTowService.
        /// </summary>
        public virtual IAccidentTowService AccidentTowService { get; private set; }

        /// <summary>
        /// Gets the IAccomodationService.
        /// </summary>
        public virtual IAccomodationService AccomodationService { get; private set; }

        /// <summary>
        /// Gets the ICalAmp.
        /// </summary>
        public virtual ICalAmp CalAmp { get; private set; }

        /// <summary>
        /// Gets the ICaseModel.
        /// </summary>
        public virtual ICaseModel CaseModel { get; private set; }

        /// <summary>
        /// Gets the IClientCsi.
        /// </summary>
        public virtual IClientCsi ClientCsi { get; private set; }

        /// <summary>
        /// Gets the IDriverAssistService.
        /// </summary>
        public virtual IDriverAssistService DriverAssistService { get; private set; }

        /// <summary>
        /// Gets the IEmergencyAssistService.
        /// </summary>
        public virtual IEmergencyAssistService EmergencyAssistService { get; private set; }

        /// <summary>
        /// Gets the IFinancial.
        /// </summary>
        public virtual IFinancial Financial { get; private set; }

        /// <summary>
        /// Gets the IHomeAssistService.
        /// </summary>
        public virtual IHomeAssistService HomeAssistService { get; private set; }

        /// <summary>
        /// Gets the ILegalAssistService.
        /// </summary>
        public virtual ILegalAssistService LegalAssistService { get; private set; }

        /// <summary>
        /// Gets the IRecoveryService.
        /// </summary>
        public virtual IRecoveryService RecoveryService { get; private set; }

        /// <summary>
        /// Gets the IReleaseRequestService.
        /// </summary>
        public virtual IReleaseRequestService ReleaseRequestService { get; private set; }

        /// <summary>
        /// Gets the IRoadsideAssistService.
        /// </summary>
        public virtual IRoadsideAssistService RoadsideAssistService { get; private set; }

        /// <summary>
        /// Gets the ISauIntegration.
        /// </summary>
        public virtual ISauIntegration SauIntegration { get; private set; }

        /// <summary>
        /// Gets the IService.
        /// </summary>
        public virtual IService Service { get; private set; }

        /// <summary>
        /// Gets the ISignIn.
        /// </summary>
        public virtual ISignIn SignIn { get; private set; }

        /// <summary>
        /// Gets the ITaxiService.
        /// </summary>
        public virtual ITaxiService TaxiService { get; private set; }

        /// <summary>
        /// Gets the ITrackerIntegration.
        /// </summary>
        public virtual ITrackerIntegration TrackerIntegration { get; private set; }

        /// <summary>
        /// Gets the ITradeTowService.
        /// </summary>
        public virtual ITradeTowService TradeTowService { get; private set; }

        /// <summary>
        /// Gets the IUpdate.
        /// </summary>
        public virtual IUpdate Update { get; private set; }

        /// <summary>
        /// Gets the IVehicleLocksmithingCaseService.
        /// </summary>
        public virtual IVehicleLocksmithingCaseService VehicleLocksmithingCaseService { get; private set; }

        /// <summary>
        /// Gets the IZirconiumWebHooks.
        /// </summary>
        public virtual IZirconiumWebHooks ZirconiumWebHooks { get; private set; }

        /// <summary>
        /// Initializes a new instance of the YttriumClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected YttriumClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the YttriumClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected YttriumClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the YttriumClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected YttriumClient(Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the YttriumClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected YttriumClient(Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the YttriumClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public YttriumClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the YttriumClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public YttriumClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the YttriumClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public YttriumClient(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the YttriumClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public YttriumClient(Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary> 
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            this.AccidentTowService = new AccidentTowService(this);
            this.AccomodationService = new AccomodationService(this);
            this.CalAmp = new CalAmp(this);
            this.CaseModel = new CaseModel(this);
            this.ClientCsi = new ClientCsi(this);
            this.DriverAssistService = new DriverAssistService(this);
            this.EmergencyAssistService = new EmergencyAssistService(this);
            this.Financial = new Financial(this);
            this.HomeAssistService = new HomeAssistService(this);
            this.LegalAssistService = new LegalAssistService(this);
            this.RecoveryService = new RecoveryService(this);
            this.ReleaseRequestService = new ReleaseRequestService(this);
            this.RoadsideAssistService = new RoadsideAssistService(this);
            this.SauIntegration = new SauIntegration(this);
            this.Service = new Service(this);
            this.SignIn = new SignIn(this);
            this.TaxiService = new TaxiService(this);
            this.TrackerIntegration = new TrackerIntegration(this);
            this.TradeTowService = new TradeTowService(this);
            this.Update = new Update(this);
            this.VehicleLocksmithingCaseService = new VehicleLocksmithingCaseService(this);
            this.ZirconiumWebHooks = new ZirconiumWebHooks(this);
            this.BaseUri = new Uri("https://yttriumstaging.dreamtec.co.za");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }    
    }
}
