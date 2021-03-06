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

    public partial class FileLink
    {
        /// <summary>
        /// Initializes a new instance of the FileLink class.
        /// </summary>
        public FileLink() { }

        /// <summary>
        /// Initializes a new instance of the FileLink class.
        /// </summary>
        public FileLink(Guid? id = default(Guid?), string filename = default(string), string href = default(string))
        {
            Id = id;
            Filename = filename;
            Href = href;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

    }
}
