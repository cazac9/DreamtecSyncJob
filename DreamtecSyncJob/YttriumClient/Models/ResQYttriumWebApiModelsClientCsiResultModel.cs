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

    public partial class ResQYttriumWebApiModelsClientCsiResultModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsClientCsiResultModel class.
        /// </summary>
        public ResQYttriumWebApiModelsClientCsiResultModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsClientCsiResultModel class.
        /// </summary>
        public ResQYttriumWebApiModelsClientCsiResultModel(bool? callSucceeded = default(bool?), string message = default(string))
        {
            CallSucceeded = callSucceeded;
            Message = message;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CallSucceeded")]
        public bool? CallSucceeded { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

    }
}