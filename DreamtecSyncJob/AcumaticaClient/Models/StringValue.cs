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

    public partial class StringValue
    {
        /// <summary>
        /// Initializes a new instance of the StringValue class.
        /// </summary>
        public StringValue() { }

        /// <summary>
        /// Initializes a new instance of the StringValue class.
        /// </summary>
        public StringValue(string value = default(string))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
