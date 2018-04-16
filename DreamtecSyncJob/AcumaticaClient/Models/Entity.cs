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

    public partial class Entity
    {
        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        public Entity() { }

        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        public Entity(Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), IDictionary<string, IDictionary<string, CustomField>> custom = default(IDictionary<string, IDictionary<string, CustomField>>), IList<FileLink> files = default(IList<FileLink>))
        {
            Id = id;
            RowNumber = rowNumber;
            Note = note;
            Custom = custom;
            Files = files;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rowNumber")]
        public long? RowNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "custom")]
        public IDictionary<string, IDictionary<string, CustomField>> Custom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<FileLink> Files { get; set; }

    }
}
