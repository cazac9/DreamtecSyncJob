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

    public partial class ResQYttriumWebApiModelsUpdateCaseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsUpdateCaseModel class.
        /// </summary>
        public ResQYttriumWebApiModelsUpdateCaseModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsUpdateCaseModel class.
        /// </summary>
        public ResQYttriumWebApiModelsUpdateCaseModel(Guid? caseId = default(Guid?), Guid? updatorNodeId = default(Guid?), ResQYttriumWebApiModelsCustomerModel customer = default(ResQYttriumWebApiModelsCustomerModel), ResQYttriumWebApiModelsVehicleModel vehicle = default(ResQYttriumWebApiModelsVehicleModel), ResQYttriumWebApiModelsAccountModel account = default(ResQYttriumWebApiModelsAccountModel))
        {
            CaseId = caseId;
            UpdatorNodeId = updatorNodeId;
            Customer = customer;
            Vehicle = vehicle;
            Account = account;
        }

        /// <summary>
        /// The id of the case that should be updated.
        /// </summary>
        [JsonProperty(PropertyName = "CaseId")]
        public Guid? CaseId { get; set; }

        /// <summary>
        /// The id of the capacity a person is acting in relative to a node.
        /// </summary>
        [JsonProperty(PropertyName = "UpdatorNodeId")]
        public Guid? UpdatorNodeId { get; set; }

        /// <summary>
        /// The customer information.
        /// </summary>
        [JsonProperty(PropertyName = "Customer")]
        public ResQYttriumWebApiModelsCustomerModel Customer { get; set; }

        /// <summary>
        /// The vehicle the case is on (if any).
        /// </summary>
        [JsonProperty(PropertyName = "Vehicle")]
        public ResQYttriumWebApiModelsVehicleModel Vehicle { get; set; }

        /// <summary>
        /// The account information for the case.
        /// </summary>
        [JsonProperty(PropertyName = "Account")]
        public ResQYttriumWebApiModelsAccountModel Account { get; set; }

    }
}
