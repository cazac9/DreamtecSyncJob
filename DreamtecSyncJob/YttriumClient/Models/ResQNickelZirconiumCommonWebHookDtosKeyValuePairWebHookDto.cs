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

    public partial class ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosKeyValuePairWebHookDto(string key = default(string), string value = default(string))
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}
