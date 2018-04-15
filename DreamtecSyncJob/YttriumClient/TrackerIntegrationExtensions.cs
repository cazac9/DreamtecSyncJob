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
    /// Extension methods for TrackerIntegration.
    /// </summary>
    public static partial class TrackerIntegrationExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ResQYttriumWebApiModelsTrackerIntegrationTrackerRequestResultModel SubmitIncident(this ITrackerIntegration operations, ResQYttriumWebApiModelsTrackerIntegrationTrackerRequestModel model)
            {
                return Task.Factory.StartNew(s => ((ITrackerIntegration)s).SubmitIncidentAsync(model), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResQYttriumWebApiModelsTrackerIntegrationTrackerRequestResultModel> SubmitIncidentAsync(this ITrackerIntegration operations, ResQYttriumWebApiModelsTrackerIntegrationTrackerRequestModel model, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SubmitIncidentWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}