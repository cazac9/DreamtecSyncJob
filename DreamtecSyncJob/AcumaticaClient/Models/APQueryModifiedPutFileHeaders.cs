﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DreamtecSyncJob.Acumatica.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Defines headers for PutFile operation.
    /// </summary>
    public partial class APQueryModifiedPutFileHeaders
    {
        /// <summary>
        /// Initializes a new instance of the APQueryModifiedPutFileHeaders
        /// class.
        /// </summary>
        public APQueryModifiedPutFileHeaders() { }

        /// <summary>
        /// Initializes a new instance of the APQueryModifiedPutFileHeaders
        /// class.
        /// </summary>
        public APQueryModifiedPutFileHeaders(string location = default(string))
        {
            Location = location;
        }

        /// <summary>
        /// A URL that can be used to retrieve the file from the system.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}