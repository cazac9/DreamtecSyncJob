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

    public partial class ResQYttriumWebApiModelsCreateCaseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsCreateCaseModel class.
        /// </summary>
        public ResQYttriumWebApiModelsCreateCaseModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsCreateCaseModel class.
        /// </summary>
        public ResQYttriumWebApiModelsCreateCaseModel(Guid operationsNodeId, Guid creatorNodeId, Guid? clientNodeId = default(Guid?), ResQYttriumWebApiModelsCustomerModel customer = default(ResQYttriumWebApiModelsCustomerModel), ResQYttriumWebApiModelsVehicleModel vehicle = default(ResQYttriumWebApiModelsVehicleModel), ResQYttriumWebApiModelsAccountModel account = default(ResQYttriumWebApiModelsAccountModel), string externalClaimReference = default(string), string externalCaseId = default(string), DateTime? dateOfIncident = default(DateTime?), bool? reuseExistingCaseIfFound = default(bool?))
        {
            OperationsNodeId = operationsNodeId;
            ClientNodeId = clientNodeId;
            CreatorNodeId = creatorNodeId;
            Customer = customer;
            Vehicle = vehicle;
            Account = account;
            ExternalClaimReference = externalClaimReference;
            ExternalCaseId = externalCaseId;
            DateOfIncident = dateOfIncident;
            ReuseExistingCaseIfFound = reuseExistingCaseIfFound;
        }

        /// <summary>
        /// The id of the operations center that is creating the case.
        /// </summary>
        [JsonProperty(PropertyName = "OperationsNodeId")]
        public Guid OperationsNodeId { get; set; }

        /// <summary>
        /// The id of the insurer the person is with.
        /// </summary>
        [JsonProperty(PropertyName = "ClientNodeId")]
        public Guid? ClientNodeId { get; set; }

        /// <summary>
        /// The id of the capacity a person is acting in relative to a node.
        /// </summary>
        [JsonProperty(PropertyName = "CreatorNodeId")]
        public Guid CreatorNodeId { get; set; }

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

        /// <summary>
        /// The claim reference the external party is using. Either this or
        /// ExternalCaseId is required.
        /// If populated the values should be unique for each new case.
        /// </summary>
        [JsonProperty(PropertyName = "ExternalClaimReference")]
        public string ExternalClaimReference { get; set; }

        /// <summary>
        /// The id the external party is using for the case. Either this or
        /// ExternalClaimNumber is required.
        /// If populated the values should be unique for each new case.
        /// </summary>
        [JsonProperty(PropertyName = "ExternalCaseId")]
        public string ExternalCaseId { get; set; }

        /// <summary>
        /// Date incident occurred, e.g. Date of Loss
        /// </summary>
        [JsonProperty(PropertyName = "DateOfIncident")]
        public DateTime? DateOfIncident { get; set; }

        /// <summary>
        /// Should attempt to use existing case, based on external reference
        /// and external case id.
        /// Will default to true
        /// </summary>
        [JsonProperty(PropertyName = "ReuseExistingCaseIfFound")]
        public bool? ReuseExistingCaseIfFound { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
