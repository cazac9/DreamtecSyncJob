﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DreamtecSyncJob.Yttrium.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class ResQYttriumWebApiModelsFinaliseServiceModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsFinaliseServiceModel class.
        /// </summary>
        public ResQYttriumWebApiModelsFinaliseServiceModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsFinaliseServiceModel class.
        /// </summary>
        public ResQYttriumWebApiModelsFinaliseServiceModel(Guid? serviceId = default(Guid?), double? kilometers = default(double?), ResQYttriumWebApiModelsServiceProviderUpdatedModel serviceProvider = default(ResQYttriumWebApiModelsServiceProviderUpdatedModel))
        {
            ServiceId = serviceId;
            Kilometers = kilometers;
            ServiceProvider = serviceProvider;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceId")]
        public Guid? ServiceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Kilometers")]
        public double? Kilometers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProvider")]
        public ResQYttriumWebApiModelsServiceProviderUpdatedModel ServiceProvider { get; set; }

    }
}