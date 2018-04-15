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

    public partial class ResQNickelZirconiumCommonWebHookDtosServiceProviderRelationshipWebHookDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosServiceProviderRelationshipWebHookDto
        /// class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosServiceProviderRelationshipWebHookDto() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosServiceProviderRelationshipWebHookDto
        /// class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosServiceProviderRelationshipWebHookDto(string hierarchyDescription = default(string), string contactNumber = default(string), ResQNickelZirconiumCommonWebHookDtosServiceProviderAssignmentWebHookDto serviceProviderAssignment = default(ResQNickelZirconiumCommonWebHookDtosServiceProviderAssignmentWebHookDto))
        {
            HierarchyDescription = hierarchyDescription;
            ContactNumber = contactNumber;
            ServiceProviderAssignment = serviceProviderAssignment;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HierarchyDescription")]
        public string HierarchyDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactNumber")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProviderAssignment")]
        public ResQNickelZirconiumCommonWebHookDtosServiceProviderAssignmentWebHookDto ServiceProviderAssignment { get; set; }

    }
}
