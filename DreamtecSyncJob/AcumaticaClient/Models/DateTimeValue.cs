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

    public partial class DateTimeValue
    {
        /// <summary>
        /// Initializes a new instance of the DateTimeValue class.
        /// </summary>
        public DateTimeValue() { }

        /// <summary>
        /// Initializes a new instance of the DateTimeValue class.
        /// </summary>
        public DateTimeValue(DateTime? value = default(DateTime?))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public DateTime? Value { get; set; }

    }
}
