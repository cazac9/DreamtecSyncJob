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

    public partial class ResQYttriumWebApiModelsTrackerIntegrationCustomer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsTrackerIntegrationCustomer class.
        /// </summary>
        public ResQYttriumWebApiModelsTrackerIntegrationCustomer() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsTrackerIntegrationCustomer class.
        /// </summary>
        public ResQYttriumWebApiModelsTrackerIntegrationCustomer(string iDNumber = default(string), string initials = default(string), string name = default(string), string surname = default(string), string contactNo1 = default(string), string contactNo2 = default(string), string emailAddress = default(string))
        {
            IDNumber = iDNumber;
            Initials = initials;
            Name = name;
            Surname = surname;
            ContactNo1 = contactNo1;
            ContactNo2 = contactNo2;
            EmailAddress = emailAddress;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IDNumber")]
        public string IDNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Initials")]
        public string Initials { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Surname")]
        public string Surname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactNo1")]
        public string ContactNo1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactNo2")]
        public string ContactNo2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

    }
}
