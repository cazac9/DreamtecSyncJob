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

    public partial class ResQYttriumWebApiModelsAccountModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsAccountModel class.
        /// </summary>
        public ResQYttriumWebApiModelsAccountModel() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ResQYttriumWebApiModelsAccountModel class.
        /// </summary>
        public ResQYttriumWebApiModelsAccountModel(string companyName = default(string), string firstName = default(string), string surname = default(string), string iDNumber = default(string), int? identificationType = default(int?), DateTime? dateOfBirth = default(DateTime?), string contactNumber = default(string), Guid? clientId = default(Guid?), string policyNumber = default(string))
        {
            CompanyName = companyName;
            FirstName = firstName;
            Surname = surname;
            IDNumber = iDNumber;
            IdentificationType = identificationType;
            DateOfBirth = dateOfBirth;
            ContactNumber = contactNumber;
            ClientId = clientId;
            PolicyNumber = policyNumber;
        }

        /// <summary>
        /// The name of the company responsible for the account.
        /// </summary>
        [JsonProperty(PropertyName = "CompanyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// The first name of the person of the account.
        /// </summary>
        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The surname of the person of the account.
        /// </summary>
        [JsonProperty(PropertyName = "Surname")]
        public string Surname { get; set; }

        /// <summary>
        /// The ID number of the person of the account.
        /// </summary>
        [JsonProperty(PropertyName = "IDNumber")]
        public string IDNumber { get; set; }

        /// <summary>
        /// The means of identification.
        /// ID Document = 0,
        /// Driver's License = 1,
        /// Passport = 2
        /// </summary>
        [JsonProperty(PropertyName = "IdentificationType")]
        public int? IdentificationType { get; set; }

        /// <summary>
        /// The date of birth of the person.
        /// </summary>
        [JsonProperty(PropertyName = "DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The contact number for the person responsible for the account.
        /// </summary>
        [JsonProperty(PropertyName = "ContactNumber")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// The id of the insurer the person is with.
        /// </summary>
        [JsonProperty(PropertyName = "ClientId")]
        public Guid? ClientId { get; set; }

        /// <summary>
        /// Policy number with the insurer.
        /// </summary>
        [JsonProperty(PropertyName = "PolicyNumber")]
        public string PolicyNumber { get; set; }

    }
}
