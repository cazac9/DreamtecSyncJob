﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DreamtecSyncJob.Acumatica
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// APQueryOperations operations.
    /// </summary>
    public partial interface IAPQueryOperations
    {
        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the
        /// system.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetAdHocSchemaWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves a record by the values of its key fields from the system.
        /// </summary>
        /// <param name='ids'>
        /// The values of the key fields of the record.
        /// </param>
        /// <param name='select'>
        /// The fields of the entity to be returned from the system.
        /// </param>
        /// <param name='filter'>
        /// The conditions that determine which records should be selected
        /// from the system.
        /// </param>
        /// <param name='expand'>
        /// The linked and detail entities that should be expanded.
        /// </param>
        /// <param name='custom'>
        /// The fields that are not defined in the contract of the endpoint to
        /// be returned from the system.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetByKeysWithHttpMessagesAsync(IList<string> ids, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the record by the values of its key fields.
        /// </summary>
        /// <param name='ids'>
        /// The values of the key fields of the record.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteByKeysWithHttpMessagesAsync(IList<string> ids, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves a record by the value of the session entity ID from the
        /// system.
        /// </summary>
        /// <param name='id'>
        /// The session ID of the record.
        /// </param>
        /// <param name='select'>
        /// The fields of the entity to be returned from the system.
        /// </param>
        /// <param name='filter'>
        /// The conditions that determine which records should be selected
        /// from the system.
        /// </param>
        /// <param name='expand'>
        /// The linked and detail entities that should be expanded.
        /// </param>
        /// <param name='custom'>
        /// The fields that are not defined in the contract of the endpoint to
        /// be returned from the system.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetByIdWithHttpMessagesAsync(Guid id, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the record by its session identifier.
        /// </summary>
        /// <param name='id'>
        /// The session ID of the record.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteByIdWithHttpMessagesAsync(Guid id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Attaches a file to a record.
        /// </summary>
        /// <param name='ids'>
        /// The values of the key fields of the record.
        /// </param>
        /// <param name='filename'>
        /// The name of the file that you are going to attach with the
        /// extension.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object,APQueryPutFileHeaders>> PutFileWithHttpMessagesAsync(IList<string> ids, string filename, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves records that satisfy the specified conditions from the
        /// system.
        /// </summary>
        /// <param name='select'>
        /// The fields of the entity to be returned from the system.
        /// </param>
        /// <param name='filter'>
        /// The conditions that determine which records should be selected
        /// from the system.
        /// </param>
        /// <param name='expand'>
        /// The linked and detail entities that should be expanded.
        /// </param>
        /// <param name='custom'>
        /// The fields that are not defined in the contract of the endpoint to
        /// be returned from the system.
        /// </param>
        /// <param name='skip'>
        /// The number of records to be skipped from the list of returned
        /// records.
        /// </param>
        /// <param name='top'>
        /// The number of records to be returned from the system.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetListWithHttpMessagesAsync(string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string), int? skip = default(int?), int? top = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a record or updates an existing record.
        /// </summary>
        /// <param name='entity'>
        /// The record to be passed to the system.
        /// </param>
        /// <param name='select'>
        /// The fields of the entity to be returned from the system.
        /// </param>
        /// <param name='filter'>
        /// The conditions that determine which records should be selected
        /// from the system.
        /// </param>
        /// <param name='expand'>
        /// The linked and detail entities that should be expanded.
        /// </param>
        /// <param name='custom'>
        /// The fields that are not defined in the contract of the endpoint to
        /// be returned from the system.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PutEntityWithHttpMessagesAsync(APQuery entity, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
