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

    public partial class ResQNickelZirconiumCommonWebHookDtosRelationshipWebHookDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosRelationshipWebHookDto class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosRelationshipWebHookDto() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosRelationshipWebHookDto class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosRelationshipWebHookDto(string hierarchyDescription = default(string), string contactNumber = default(string), ResQNickelZirconiumCommonWebHookDtosRepresentativeWebHookDto representative = default(ResQNickelZirconiumCommonWebHookDtosRepresentativeWebHookDto))
        {
            HierarchyDescription = hierarchyDescription;
            ContactNumber = contactNumber;
            Representative = representative;
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
        [JsonProperty(PropertyName = "Representative")]
        public ResQNickelZirconiumCommonWebHookDtosRepresentativeWebHookDto Representative { get; set; }

    }
}
