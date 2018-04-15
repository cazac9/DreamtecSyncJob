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

    public partial class APQuery : Entity
    {
        /// <summary>
        /// Initializes a new instance of the APQuery class.
        /// </summary>
        public APQuery() { }

        /// <summary>
        /// Initializes a new instance of the APQuery class.
        /// </summary>
        public APQuery(Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), IDictionary<string, IDictionary<string, CustomField>> custom = default(IDictionary<string, IDictionary<string, CustomField>>), IList<FileLink> files = default(IList<FileLink>), StringValue documentType = default(StringValue), StringValue adjgDocType = default(StringValue), StringValue referenceNbrAPAdjustAdjgRefNbr = default(StringValue), IntValue adjustmentNbr = default(IntValue), DateTimeValue aPAdjustCreatedDateTime = default(DateTimeValue), DecimalValue aPAdjustCuryAdjdAmt = default(DecimalValue), DecimalValue balance = default(DecimalValue), DecimalValue amount = default(DecimalValue), StringValue type = default(StringValue), StringValue refNbr = default(StringValue))
            : base(id, rowNumber, note, custom, files)
        {
            DocumentType = documentType;
            AdjgDocType = adjgDocType;
            ReferenceNbrAPAdjustAdjgRefNbr = referenceNbrAPAdjustAdjgRefNbr;
            AdjustmentNbr = adjustmentNbr;
            APAdjustCreatedDateTime = aPAdjustCreatedDateTime;
            APAdjustCuryAdjdAmt = aPAdjustCuryAdjdAmt;
            Balance = balance;
            Amount = amount;
            Type = type;
            RefNbr = refNbr;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DocumentType")]
        public StringValue DocumentType { get; set; }

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
        [JsonProperty(PropertyName = "RefNbr")]
        public StringValue RefNbr { get; set; }

    }
}
