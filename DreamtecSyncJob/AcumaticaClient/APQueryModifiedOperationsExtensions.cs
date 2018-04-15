﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DreamtecSyncJob.Acumatica
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for APQueryModifiedOperations.
    /// </summary>
    public static partial class APQueryModifiedOperationsExtensions
    {
            /// <summary>
            /// Retrieves the schema of custom fields of the entity from the system.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object GetAdHocSchema(this IAPQueryModifiedOperations operations)
            {
                return Task.Factory.StartNew(s => ((IAPQueryModifiedOperations)s).GetAdHocSchemaAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the schema of custom fields of the entity from the system.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAdHocSchemaAsync(this IAPQueryModifiedOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAdHocSchemaWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a record by the values of its key fields from the system.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ids'>
            /// The values of the key fields of the record.
            /// </param>
            /// <param name='select'>
            /// The fields of the entity to be returned from the system.
            /// </param>
            /// <param name='filter'>
            /// The conditions that determine which records should be selected from the
            /// system.
            /// </param>
            /// <param name='expand'>
            /// The linked and detail entities that should be expanded.
            /// </param>
            /// <param name='custom'>
            /// The fields that are not defined in the contract of the endpoint to be
            /// returned from the system.
            /// </param>
            public static object GetByKeys(this IAPQueryModifiedOperations operations, IList<string> ids, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string))
            {
                return Task.Factory.StartNew(s => ((IAPQueryModifiedOperations)s).GetByKeysAsync(ids, select, filter, expand, custom), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a record by the values of its key fields from the system.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ids'>
            /// The values of the key fields of the record.
            /// </param>
            /// <param name='select'>
            /// The fields of the entity to be returned from the system.
            /// </param>
            /// <param name='filter'>
            /// The conditions that determine which records should be selected from the
            /// system.
            /// </param>
            /// <param name='expand'>
            /// The linked and detail entities that should be expanded.
            /// </param>
            /// <param name='custom'>
            /// The fields that are not defined in the contract of the endpoint to be
            /// returned from the system.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetByKeysAsync(this IAPQueryModifiedOperations operations, IList<string> ids, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeysWithHttpMessagesAsync(ids, select, filter, expand, custom, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the record by the values of its key fields.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ids'>
            /// The values of the key fields of the record.
            /// </param>
            public static object DeleteByKeys(this IAPQueryModifiedOperations operations, IList<string> ids)
            {
                return Task.Factory.StartNew(s => ((IAPQueryModifiedOperations)s).DeleteByKeysAsync(ids), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the record by the values of its key fields.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ids'>
            /// The values of the key fields of the record.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteByKeysAsync(this IAPQueryModifiedOperations operations, IList<string> ids, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByKeysWithHttpMessagesAsync(ids, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a record by the value of the session entity ID from the system.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The session ID of the record.
            /// </param>
            /// <param name='select'>
            /// The fields of the entity to be returned from the system.
            /// </param>
            /// <param name='filter'>
            /// The conditions that determine which records should be selected from the
            /// system.
            /// </param>
            /// <param name='expand'>
            /// The linked and detail entities that should be expanded.
            /// </param>
            /// <param name='custom'>
            /// The fields that are not defined in the contract of the endpoint to be
            /// returned from the system.
            /// </param>
            public static object GetById(this IAPQueryModifiedOperations operations, Guid id, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string))
            {
                return Task.Factory.StartNew(s => ((IAPQueryModifiedOperations)s).GetByIdAsync(id, select, filter, expand, custom), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a record by the value of the session entity ID from the system.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The session ID of the record.
            /// </param>
            /// <param name='select'>
            /// The fields of the entity to be returned from the system.
            /// </param>
            /// <param name='filter'>
            /// The conditions that determine which records should be selected from the
            /// system.
            /// </param>
            /// <param name='expand'>
            /// The linked and detail entities that should be expanded.
            /// </param>
            /// <param name='custom'>
            /// The fields that are not defined in the contract of the endpoint to be
            /// returned from the system.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetByIdAsync(this IAPQueryModifiedOperations operations, Guid id, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, select, filter, expand, custom, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the record by its session identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The session ID of the record.
            /// </param>
            public static object DeleteById(this IAPQueryModifiedOperations operations, Guid id)
            {
                return Task.Factory.StartNew(s => ((IAPQueryModifiedOperations)s).DeleteByIdAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the record by its session identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The session ID of the record.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteByIdAsync(this IAPQueryModifiedOperations operations, Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteByIdWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Attaches a file to a record.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ids'>
            /// The values of the key fields of the record.
            /// </param>
            /// <param name='filename'>
            /// The name of the file that you are going to attach with the extension.
            /// </param>
            public static object PutFile(this IAPQueryModifiedOperations operations, IList<string> ids, string filename)
            {
                return Task.Factory.StartNew(s => ((IAPQueryModifiedOperations)s).PutFileAsync(ids, filename), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Attaches a file to a record.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ids'>
            /// The values of the key fields of the record.
            /// </param>
            /// <param name='filename'>
            /// The name of the file that you are going to attach with the extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PutFileAsync(this IAPQueryModifiedOperations operations, IList<string> ids, string filename, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutFileWithHttpMessagesAsync(ids, filename, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves records that satisfy the specified conditions from the system.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='select'>
            /// The fields of the entity to be returned from the system.
            /// </param>
            /// <param name='filter'>
            /// The conditions that determine which records should be selected from the
            /// system.
            /// </param>
            /// <param name='expand'>
            /// The linked and detail entities that should be expanded.
            /// </param>
            /// <param name='custom'>
            /// The fields that are not defined in the contract of the endpoint to be
            /// returned from the system.
            /// </param>
            /// <param name='skip'>
            /// The number of records to be skipped from the list of returned records.
            /// </param>
            /// <param name='top'>
            /// The number of records to be returned from the system.
            /// </param>
            public static object GetList(this IAPQueryModifiedOperations operations, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string), int? skip = default(int?), int? top = default(int?))
            {
                return Task.Factory.StartNew(s => ((IAPQueryModifiedOperations)s).GetListAsync(select, filter, expand, custom, skip, top), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves records that satisfy the specified conditions from the system.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='select'>
            /// The fields of the entity to be returned from the system.
            /// </param>
            /// <param name='filter'>
            /// The conditions that determine which records should be selected from the
            /// system.
            /// </param>
            /// <param name='expand'>
            /// The linked and detail entities that should be expanded.
            /// </param>
            /// <param name='custom'>
            /// The fields that are not defined in the contract of the endpoint to be
            /// returned from the system.
            /// </param>
            /// <param name='skip'>
            /// The number of records to be skipped from the list of returned records.
            /// </param>
            /// <param name='top'>
            /// The number of records to be returned from the system.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetListAsync(this IAPQueryModifiedOperations operations, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string), int? skip = default(int?), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetListWithHttpMessagesAsync(select, filter, expand, custom, skip, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a record or updates an existing record.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='entity'>
            /// The record to be passed to the system.
            /// </param>
            /// <param name='select'>
            /// The fields of the entity to be returned from the system.
            /// </param>
            /// <param name='filter'>
            /// The conditions that determine which records should be selected from the
            /// system.
            /// </param>
            /// <param name='expand'>
            /// The linked and detail entities that should be expanded.
            /// </param>
            /// <param name='custom'>
            /// The fields that are not defined in the contract of the endpoint to be
            /// returned from the system.
            /// </param>
            public static object PutEntity(this IAPQueryModifiedOperations operations, APQueryModified entity, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string))
            {
                return Task.Factory.StartNew(s => ((IAPQueryModifiedOperations)s).PutEntityAsync(entity, select, filter, expand, custom), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a record or updates an existing record.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='entity'>
            /// The record to be passed to the system.
            /// </param>
            /// <param name='select'>
            /// The fields of the entity to be returned from the system.
            /// </param>
            /// <param name='filter'>
            /// The conditions that determine which records should be selected from the
            /// system.
            /// </param>
            /// <param name='expand'>
            /// The linked and detail entities that should be expanded.
            /// </param>
            /// <param name='custom'>
            /// The fields that are not defined in the contract of the endpoint to be
            /// returned from the system.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> PutEntityAsync(this IAPQueryModifiedOperations operations, APQueryModified entity, string select = default(string), string filter = default(string), string expand = default(string), string custom = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutEntityWithHttpMessagesAsync(entity, select, filter, expand, custom, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
