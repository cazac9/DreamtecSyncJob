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

    public partial class APQueryModified : Entity
    {
        /// <summary>
        /// Initializes a new instance of the APQueryModified class.
        /// </summary>
        public APQueryModified() { }

        /// <summary>
        /// Initializes a new instance of the APQueryModified class.
        /// </summary>
        public APQueryModified(Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), IDictionary<string, IDictionary<string, CustomField>> custom = default(IDictionary<string, IDictionary<string, CustomField>>), IList<FileLink> files = default(IList<FileLink>), StringValue documentType = default(StringValue), StringValue referenceNbrAPAdjustAdjdRefNbr = default(StringValue), StringValue adjgDocType = default(StringValue), StringValue referenceNbrAPAdjustAdjgRefNbr = default(StringValue), IntValue adjustmentNbr = default(IntValue), DateTimeValue aPAdjustCreatedDateTime = default(DateTimeValue), DecimalValue aPAdjustCuryAdjdAmt = default(DecimalValue), DateTimeValue aPAdjustLastModifiedDateTime = default(DateTimeValue), DecimalValue balance = default(DecimalValue), DecimalValue amount = default(DecimalValue), StringValue type = default(StringValue), StringValue referenceNbrAPRegisterRefNbr = default(StringValue), StringValue fromDate = default(StringValue), StringValue toDate = default(StringValue))
            : base(id, rowNumber, note, custom, files)
        {
            DocumentType = documentType;
            ReferenceNbrAPAdjustAdjdRefNbr = referenceNbrAPAdjustAdjdRefNbr;
            AdjgDocType = adjgDocType;
            ReferenceNbrAPAdjustAdjgRefNbr = referenceNbrAPAdjustAdjgRefNbr;
            AdjustmentNbr = adjustmentNbr;
            APAdjustCreatedDateTime = aPAdjustCreatedDateTime;
            APAdjustCuryAdjdAmt = aPAdjustCuryAdjdAmt;
            APAdjustLastModifiedDateTime = aPAdjustLastModifiedDateTime;
            Balance = balance;
            Amount = amount;
            Type = type;
            ReferenceNbrAPRegisterRefNbr = referenceNbrAPRegisterRefNbr;
            FromDate = fromDate;
            ToDate = toDate;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentType")]
        public StringValue DocumentType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceNbrAPAdjust_adjdRefNbr")]
        public StringValue ReferenceNbrAPAdjustAdjdRefNbr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdjgDocType")]
        public StringValue AdjgDocType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceNbrAPAdjust_adjgRefNbr")]
        public StringValue ReferenceNbrAPAdjustAdjgRefNbr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AdjustmentNbr")]
        public IntValue AdjustmentNbr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "APAdjust_createdDateTime")]
        public DateTimeValue APAdjustCreatedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "APAdjust_curyAdjdAmt")]
        public DecimalValue APAdjustCuryAdjdAmt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "APAdjust_lastModifiedDateTime")]
        public DateTimeValue APAdjustLastModifiedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Balance")]
        public DecimalValue Balance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public StringValue Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceNbrAPRegister_refNbr")]
        public StringValue ReferenceNbrAPRegisterRefNbr { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FromDate")]
        public StringValue FromDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ToDate")]
        public StringValue ToDate { get; set; }

    }
}
