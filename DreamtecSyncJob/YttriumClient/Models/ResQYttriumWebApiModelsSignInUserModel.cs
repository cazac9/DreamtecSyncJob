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

    public partial class ResQYttriumWebApiModelsSignInUserModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsSignInUserModel class.
        /// </summary>
        public ResQYttriumWebApiModelsSignInUserModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsSignInUserModel class.
        /// </summary>
        public ResQYttriumWebApiModelsSignInUserModel(Guid userId, Guid clientId)
        {
            UserId = userId;
            ClientId = clientId;
        }

        /// <summary>
        /// The user id provided to aquire access to a specific application
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public Guid UserId { get; set; }

        /// <summary>
        /// The id of the client that is requesting the log-in.
        /// </summary>
        [JsonProperty(PropertyName = "ClientId")]
        public Guid ClientId { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
