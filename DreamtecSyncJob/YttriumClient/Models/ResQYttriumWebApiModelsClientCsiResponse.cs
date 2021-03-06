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

    public partial class ResQYttriumWebApiModelsClientCsiResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsClientCsiResponse class.
        /// </summary>
        public ResQYttriumWebApiModelsClientCsiResponse() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsClientCsiResponse class.
        /// </summary>
        public ResQYttriumWebApiModelsClientCsiResponse(string caseReference = default(string), string source = default(string), string customerName = default(string), string customerPhoneNumber = default(string), DateTime? feedbackDate = default(DateTime?), int? rating = default(int?), string comment = default(string))
        {
            CaseReference = caseReference;
            Source = source;
            CustomerName = customerName;
            CustomerPhoneNumber = customerPhoneNumber;
            FeedbackDate = feedbackDate;
            Rating = rating;
            Comment = comment;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CaseReference")]
        public string CaseReference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomerPhoneNumber")]
        public string CustomerPhoneNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FeedbackDate")]
        public DateTime? FeedbackDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Rating")]
        public int? Rating { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Comment")]
        public string Comment { get; set; }

    }
}
