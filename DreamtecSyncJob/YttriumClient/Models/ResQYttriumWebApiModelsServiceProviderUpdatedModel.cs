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

    public partial class ResQYttriumWebApiModelsServiceProviderUpdatedModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsServiceProviderUpdatedModel class.
        /// </summary>
        public ResQYttriumWebApiModelsServiceProviderUpdatedModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsServiceProviderUpdatedModel class.
        /// </summary>
        public ResQYttriumWebApiModelsServiceProviderUpdatedModel(Guid? serviceProviderId = default(Guid?), string serviceProviderCompanyName = default(string), string serviceProviderContactNumber = default(string), DateTime? assignedDate = default(DateTime?), DateTime? arrivedDate = default(DateTime?), DateTime? completedDate = default(DateTime?), double? estimatedKmToScene = default(double?))
        {
            ServiceProviderId = serviceProviderId;
            ServiceProviderCompanyName = serviceProviderCompanyName;
            ServiceProviderContactNumber = serviceProviderContactNumber;
            AssignedDate = assignedDate;
            ArrivedDate = arrivedDate;
            CompletedDate = completedDate;
            EstimatedKmToScene = estimatedKmToScene;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProviderId")]
        public Guid? ServiceProviderId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProviderCompanyName")]
        public string ServiceProviderCompanyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProviderContactNumber")]
        public string ServiceProviderContactNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssignedDate")]
        public DateTime? AssignedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ArrivedDate")]
        public DateTime? ArrivedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompletedDate")]
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EstimatedKmToScene")]
        public double? EstimatedKmToScene { get; set; }

    }
}
