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

    public partial class ResQNickelZirconiumCommonWebHookDtosVehicleWebHookDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosVehicleWebHookDto class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosVehicleWebHookDto() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQNickelZirconiumCommonWebHookDtosVehicleWebHookDto class.
        /// </summary>
        public ResQNickelZirconiumCommonWebHookDtosVehicleWebHookDto(string licensePlateNumber = default(string), string make = default(string), string description = default(string), string vin = default(string), string colour = default(string))
        {
            LicensePlateNumber = licensePlateNumber;
            Make = make;
            Description = description;
            Vin = vin;
            Colour = colour;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LicensePlateNumber")]
        public string LicensePlateNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Make")]
        public string Make { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Vin")]
        public string Vin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Colour")]
        public string Colour { get; set; }

    }
}
