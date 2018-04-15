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

    public partial class ResQYttriumWebApiModelsCreateLegalAssistServiceResultModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsCreateLegalAssistServiceResultModel class.
        /// </summary>
        public ResQYttriumWebApiModelsCreateLegalAssistServiceResultModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsCreateLegalAssistServiceResultModel class.
        /// </summary>
        public ResQYttriumWebApiModelsCreateLegalAssistServiceResultModel(Guid? serviceId = default(Guid?), bool? wasSuccessful = default(bool?), string errorMessage = default(string))
        {
            ServiceId = serviceId;
            WasSuccessful = wasSuccessful;
            ErrorMessage = errorMessage;
        }

        /// <summary>
        /// The id of the service that was created.
        /// </summary>
        [JsonProperty(PropertyName = "ServiceId")]
        public Guid? ServiceId { get; set; }

        /// <summary>
        /// True if the operation was successful, false otherwise with a
        /// message in &lt;see
        /// cref="P:ResQ.Yttrium.WebApi.Models.ResultModel.ErrorMessage"&gt;ErrorMessage&lt;/see&gt;.
        /// </summary>
        [JsonProperty(PropertyName = "WasSuccessful")]
        public bool? WasSuccessful { get; set; }

        /// <summary>
        /// A friendly message indicating what went wrong if there was an
        /// error processing the request.
        /// </summary>
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; set; }

    }
}
