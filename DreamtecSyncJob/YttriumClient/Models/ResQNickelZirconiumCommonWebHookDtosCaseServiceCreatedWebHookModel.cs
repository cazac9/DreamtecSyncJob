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

    public partial class ResQNickelZirconiumCommonWebHookDtosCaseServiceCreatedWebHookModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosCaseServiceCreatedWebHookModel
        /// class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosCaseServiceCreatedWebHookModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosCaseServiceCreatedWebHookModel
        /// class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosCaseServiceCreatedWebHookModel(Guid? id = default(Guid?), Guid? caseId = default(Guid?), DateTime? dateCreated = default(DateTime?), DateTime? dateOfService = default(DateTime?), string reference = default(string), ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto caseServiceDefinition = default(ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto), ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto nextRequiredAction = default(ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto), string state = default(string), string brokerageState = default(string), ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto incidentLocation = default(ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto), ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto directedDestination = default(ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto), ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto customerDirectedDestination = default(ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto), ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto actualDestination = default(ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto), ResQNickelZirconiumCommonWebHookDtosRelationshipWebHookDto serviceProviderLiaison = default(ResQNickelZirconiumCommonWebHookDtosRelationshipWebHookDto), ResQNickelZirconiumCommonWebHookDtosServiceProviderRelationshipWebHookDto serviceProvider = default(ResQNickelZirconiumCommonWebHookDtosServiceProviderRelationshipWebHookDto), Guid? operationId = default(Guid?), DateTime? dateOfOperationTrigger = default(DateTime?))
        {
            Id = id;
            CaseId = caseId;
            DateCreated = dateCreated;
            DateOfService = dateOfService;
            Reference = reference;
            CaseServiceDefinition = caseServiceDefinition;
            NextRequiredAction = nextRequiredAction;
            State = state;
            BrokerageState = brokerageState;
            IncidentLocation = incidentLocation;
            DirectedDestination = directedDestination;
            CustomerDirectedDestination = customerDirectedDestination;
            ActualDestination = actualDestination;
            ServiceProviderLiaison = serviceProviderLiaison;
            ServiceProvider = serviceProvider;
            OperationId = operationId;
            DateOfOperationTrigger = dateOfOperationTrigger;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseId")]
        public Guid? CaseId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateCreated")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateOfService")]
        public DateTime? DateOfService { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseServiceDefinition")]
        public ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto CaseServiceDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NextRequiredAction")]
        public ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto NextRequiredAction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BrokerageState")]
        public string BrokerageState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IncidentLocation")]
        public ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto IncidentLocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DirectedDestination")]
        public ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto DirectedDestination { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomerDirectedDestination")]
        public ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto CustomerDirectedDestination { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActualDestination")]
        public ResQNickelZirconiumCommonWebHookDtosLocationWebHookDto ActualDestination { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProviderLiaison")]
        public ResQNickelZirconiumCommonWebHookDtosRelationshipWebHookDto ServiceProviderLiaison { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProvider")]
        public ResQNickelZirconiumCommonWebHookDtosServiceProviderRelationshipWebHookDto ServiceProvider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OperationId")]
        public Guid? OperationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateOfOperationTrigger")]
        public DateTime? DateOfOperationTrigger { get; set; }

    }
}
