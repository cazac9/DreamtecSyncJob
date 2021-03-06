﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DreamtecSyncJob.Yttrium
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// AccomodationService operations.
    /// </summary>
    public partial interface IAccomodationService
    {
        /// <summary>
        /// This service has been deprecated
        /// </summary>
        /// <param name='model'>
        /// CreateAccomodationAssistServiceModel
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ResQYttriumWebApiModelsCreateAccomodationAssistServiceResultModel>> CreateWithHttpMessagesAsync(ResQYttriumWebApiModelsCreateAccomodationAssistServiceModel model, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
