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

    public partial class ResQYttriumWebApiModelsCreateTaxiServiceModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsCreateTaxiServiceModel class.
        /// </summary>
        public ResQYttriumWebApiModelsCreateTaxiServiceModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsCreateTaxiServiceModel class.
        /// </summary>
        public ResQYttriumWebApiModelsCreateTaxiServiceModel(Guid caseId, Guid caseServiceDefinitionId, Guid creatorId, ResQYttriumWebApiModelsLocationModel requestLocation, ResQYttriumWebApiModelsContactPersonModel requestContactPerson, bool isServiceProviderOnScene, ResQYttriumWebApiModelsLocationModel completedAtLocation = default(ResQYttriumWebApiModelsLocationModel), ResQYttriumWebApiModelsLocationModel destinationLocation = default(ResQYttriumWebApiModelsLocationModel), ResQYttriumWebApiModelsContactPersonModel destinationContactPerson = default(ResQYttriumWebApiModelsContactPersonModel), string serviceProviderFirstName = default(string), string serviceProviderSurname = default(string), string serviceProviderContactInformation = default(string), Guid? serviceProviderId = default(Guid?), ResQYttriumWebApiModelsPaymentSpecificationModel paymentSpecificationModel = default(ResQYttriumWebApiModelsPaymentSpecificationModel), ResQYttriumWebApiModelsScheduleModel scheduleModel = default(ResQYttriumWebApiModelsScheduleModel), Guid? callId = default(Guid?), string cllientOrderNumber = default(string), string instruction = default(string))
        {
            CompletedAtLocation = completedAtLocation;
            DestinationLocation = destinationLocation;
            DestinationContactPerson = destinationContactPerson;
            CaseId = caseId;
            CaseServiceDefinitionId = caseServiceDefinitionId;
            CreatorId = creatorId;
            RequestLocation = requestLocation;
            RequestContactPerson = requestContactPerson;
            IsServiceProviderOnScene = isServiceProviderOnScene;
            ServiceProviderFirstName = serviceProviderFirstName;
            ServiceProviderSurname = serviceProviderSurname;
            ServiceProviderContactInformation = serviceProviderContactInformation;
            ServiceProviderId = serviceProviderId;
            PaymentSpecificationModel = paymentSpecificationModel;
            ScheduleModel = scheduleModel;
            CallId = callId;
            CllientOrderNumber = cllientOrderNumber;
            Instruction = instruction;
        }

        /// <summary>
        /// The location the request should be completed at (i.e. destination
        /// location). For Tows this would be the drop-off location and for
        /// Taxis it will be the place the customer was droped-off.
        /// Compared to DestinationLocation, this is the destination where the
        /// service actually terminated.  E.g. where the vehicle was actually
        /// dropped off for a tow.
        /// </summary>
        [JsonProperty(PropertyName = "CompletedAtLocation")]
        public ResQYttriumWebApiModelsLocationModel CompletedAtLocation { get; set; }

        /// <summary>
        /// The intended destination of where the service should be completed.
        /// E.g. the drop off location for a tow, the destination location
        /// for a drive me home, etc.
        /// Prefer this property when specifying an intended destination.
        /// </summary>
        [JsonProperty(PropertyName = "DestinationLocation")]
        public ResQYttriumWebApiModelsLocationModel DestinationLocation { get; set; }

        /// <summary>
        /// Contact person at the destination location.
        /// </summary>
        [JsonProperty(PropertyName = "DestinationContactPerson")]
        public ResQYttriumWebApiModelsContactPersonModel DestinationContactPerson { get; set; }

        /// <summary>
        /// The id of the case to create the service on.
        /// </summary>
        [JsonProperty(PropertyName = "CaseId")]
        public Guid CaseId { get; set; }

        /// <summary>
        /// The case service definition id to use as a template for the
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "CaseServiceDefinitionId")]
        public Guid CaseServiceDefinitionId { get; set; }

        /// <summary>
        /// The creator of the case service.
        /// </summary>
        [JsonProperty(PropertyName = "CreatorId")]
        public Guid CreatorId { get; set; }

        /// <summary>
        /// The location at which the service must be performed.
        /// </summary>
        [JsonProperty(PropertyName = "RequestLocation")]
        public ResQYttriumWebApiModelsLocationModel RequestLocation { get; set; }

        /// <summary>
        /// Contact person at the location where the service is to be
        /// performed.
        /// </summary>
        [JsonProperty(PropertyName = "RequestContactPerson")]
        public ResQYttriumWebApiModelsContactPersonModel RequestContactPerson { get; set; }

        /// <summary>
        /// If there is a service provider on scene already.
        /// </summary>
        [JsonProperty(PropertyName = "IsServiceProviderOnScene")]
        public bool IsServiceProviderOnScene { get; set; }

        /// <summary>
        /// The name of the service provider on the scene.
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProviderFirstName")]
        public string ServiceProviderFirstName { get; set; }

        /// <summary>
        /// The surname of the service provider on the scene.
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProviderSurname")]
        public string ServiceProviderSurname { get; set; }

        /// <summary>
        /// The contact number for the service provider on the scene.
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProviderContactInformation")]
        public string ServiceProviderContactInformation { get; set; }

        /// <summary>
        /// The id of the service provider as used by Dreamtec.
        /// </summary>
        [JsonProperty(PropertyName = "ServiceProviderId")]
        public Guid? ServiceProviderId { get; set; }

        /// <summary>
        /// The payment specification options
        /// </summary>
        [JsonProperty(PropertyName = "PaymentSpecificationModel")]
        public ResQYttriumWebApiModelsPaymentSpecificationModel PaymentSpecificationModel { get; set; }

        /// <summary>
        /// The information on the scheduling of the job if it is scheduled.
        /// </summary>
        [JsonProperty(PropertyName = "ScheduleModel")]
        public ResQYttriumWebApiModelsScheduleModel ScheduleModel { get; set; }

        /// <summary>
        /// This is the id of the call. If a call fails then the same ID
        /// should be used to retry the call to ensure duplicates are not
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "CallId")]
        public Guid? CallId { get; set; }

        /// <summary>
        /// Order number from the client for the service to be rendered.
        /// </summary>
        [JsonProperty(PropertyName = "CllientOrderNumber")]
        public string CllientOrderNumber { get; set; }

        /// <summary>
        /// Additional instructions or comments.
        /// </summary>
        [JsonProperty(PropertyName = "Instruction")]
        public string Instruction { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (RequestLocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RequestLocation");
            }
            if (RequestContactPerson == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RequestContactPerson");
            }
        }
    }
}