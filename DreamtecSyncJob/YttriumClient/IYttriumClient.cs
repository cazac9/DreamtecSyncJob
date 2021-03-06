﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DreamtecSyncJob.Yttrium
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// </summary>
    public partial interface IYttriumClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAccidentTowService.
        /// </summary>
        IAccidentTowService AccidentTowService { get; }

        /// <summary>
        /// Gets the IAccomodationService.
        /// </summary>
        IAccomodationService AccomodationService { get; }

        /// <summary>
        /// Gets the ICalAmp.
        /// </summary>
        ICalAmp CalAmp { get; }

        /// <summary>
        /// Gets the ICaseModel.
        /// </summary>
        ICaseModel CaseModel { get; }

        /// <summary>
        /// Gets the IClientCsi.
        /// </summary>
        IClientCsi ClientCsi { get; }

        /// <summary>
        /// Gets the IDriverAssistService.
        /// </summary>
        IDriverAssistService DriverAssistService { get; }

        /// <summary>
        /// Gets the IEmergencyAssistService.
        /// </summary>
        IEmergencyAssistService EmergencyAssistService { get; }

        /// <summary>
        /// Gets the IFinancial.
        /// </summary>
        IFinancial Financial { get; }

        /// <summary>
        /// Gets the IHomeAssistService.
        /// </summary>
        IHomeAssistService HomeAssistService { get; }

        /// <summary>
        /// Gets the ILegalAssistService.
        /// </summary>
        ILegalAssistService LegalAssistService { get; }

        /// <summary>
        /// Gets the IRecoveryService.
        /// </summary>
        IRecoveryService RecoveryService { get; }

        /// <summary>
        /// Gets the IReleaseRequestService.
        /// </summary>
        IReleaseRequestService ReleaseRequestService { get; }

        /// <summary>
        /// Gets the IRoadsideAssistService.
        /// </summary>
        IRoadsideAssistService RoadsideAssistService { get; }

        /// <summary>
        /// Gets the ISauIntegration.
        /// </summary>
        ISauIntegration SauIntegration { get; }

        /// <summary>
        /// Gets the IService.
        /// </summary>
        IService Service { get; }

        /// <summary>
        /// Gets the ISignIn.
        /// </summary>
        ISignIn SignIn { get; }

        /// <summary>
        /// Gets the ITaxiService.
        /// </summary>
        ITaxiService TaxiService { get; }

        /// <summary>
        /// Gets the ITrackerIntegration.
        /// </summary>
        ITrackerIntegration TrackerIntegration { get; }

        /// <summary>
        /// Gets the ITradeTowService.
        /// </summary>
        ITradeTowService TradeTowService { get; }

        /// <summary>
        /// Gets the IUpdate.
        /// </summary>
        IUpdate Update { get; }

        /// <summary>
        /// Gets the IVehicleLocksmithingCaseService.
        /// </summary>
        IVehicleLocksmithingCaseService VehicleLocksmithingCaseService { get; }

        /// <summary>
        /// Gets the IZirconiumWebHooks.
        /// </summary>
        IZirconiumWebHooks ZirconiumWebHooks { get; }

    }
}
