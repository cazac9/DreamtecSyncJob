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

    public partial class BooleanValue
    {
        /// <summary>
        /// Initializes a new instance of the BooleanValue class.
        /// </summary>
        public BooleanValue() { }

        /// <summary>
        /// Initializes a new instance of the BooleanValue class.
        /// </summary>
        public BooleanValue(bool? value = default(bool?))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public bool? Value { get; set; }

    }
}