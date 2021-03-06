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

    public partial class ResQYttriumWebApiModelsTrackerIntegrationInsurer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsTrackerIntegrationInsurer class.
        /// </summary>
        public ResQYttriumWebApiModelsTrackerIntegrationInsurer() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsTrackerIntegrationInsurer class.
        /// </summary>
        public ResQYttriumWebApiModelsTrackerIntegrationInsurer(string insurerName = default(string), string policyNumber = default(string), string memberNo = default(string), string vehicleRiskID = default(string))
        {
            InsurerName = insurerName;
            PolicyNumber = policyNumber;
            MemberNo = memberNo;
            VehicleRiskID = vehicleRiskID;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InsurerName")]
        public string InsurerName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PolicyNumber")]
        public string PolicyNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MemberNo")]
        public string MemberNo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VehicleRiskID")]
        public string VehicleRiskID { get; set; }

    }
}
