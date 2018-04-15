﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DreamtecSyncJob.Yttrium
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for AccomodationService.
    /// </summary>
    public static partial class AccomodationServiceExtensions
    {
            /// <summary>
            /// This service has been deprecated
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// CreateAccomodationAssistServiceModel
            /// </param>
            public static ResQYttriumWebApiModelsCreateAccomodationAssistServiceResultModel Create(this IAccomodationService operations, ResQYttriumWebApiModelsCreateAccomodationAssistServiceModel model)
            {
                return Task.Factory.StartNew(s => ((IAccomodationService)s).CreateAsync(model), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// This service has been deprecated
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// CreateAccomodationAssistServiceModel
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResQYttriumWebApiModelsCreateAccomodationAssistServiceResultModel> CreateAsync(this IAccomodationService operations, ResQYttriumWebApiModelsCreateAccomodationAssistServiceModel model, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
