// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.StandbyPool.Models;

namespace Azure.ResourceManager.StandbyPool
{
    internal partial class StandbyContainerGroupPoolRuntimeViewsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of StandbyContainerGroupPoolRuntimeViewsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> Service host. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public StandbyContainerGroupPoolRuntimeViewsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2025-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName, string runtimeView)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StandbyPool/standbyContainerGroupPools/", false);
            uri.AppendPath(standbyContainerGroupPoolName, true);
            uri.AppendPath("/runtimeViews/", false);
            uri.AppendPath(runtimeView, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName, string runtimeView)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StandbyPool/standbyContainerGroupPools/", false);
            uri.AppendPath(standbyContainerGroupPoolName, true);
            uri.AppendPath("/runtimeViews/", false);
            uri.AppendPath(runtimeView, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a StandbyContainerGroupPoolRuntimeViewResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="standbyContainerGroupPoolName"/> or <paramref name="runtimeView"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="standbyContainerGroupPoolName"/> or <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<StandbyContainerGroupPoolRuntimeViewData>> GetAsync(string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName, string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, standbyContainerGroupPoolName, runtimeView);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyContainerGroupPoolRuntimeViewData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = StandbyContainerGroupPoolRuntimeViewData.DeserializeStandbyContainerGroupPoolRuntimeViewData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((StandbyContainerGroupPoolRuntimeViewData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a StandbyContainerGroupPoolRuntimeViewResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="runtimeView"> The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="standbyContainerGroupPoolName"/> or <paramref name="runtimeView"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="standbyContainerGroupPoolName"/> or <paramref name="runtimeView"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<StandbyContainerGroupPoolRuntimeViewData> Get(string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName, string runtimeView, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));
            Argument.AssertNotNullOrEmpty(runtimeView, nameof(runtimeView));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, standbyContainerGroupPoolName, runtimeView);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyContainerGroupPoolRuntimeViewData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = StandbyContainerGroupPoolRuntimeViewData.DeserializeStandbyContainerGroupPoolRuntimeViewData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((StandbyContainerGroupPoolRuntimeViewData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByStandbyPoolRequestUri(string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StandbyPool/standbyContainerGroupPools/", false);
            uri.AppendPath(standbyContainerGroupPoolName, true);
            uri.AppendPath("/runtimeViews", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByStandbyPoolRequest(string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StandbyPool/standbyContainerGroupPools/", false);
            uri.AppendPath(standbyContainerGroupPoolName, true);
            uri.AppendPath("/runtimeViews", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List StandbyContainerGroupPoolRuntimeViewResource resources by StandbyContainerGroupPoolResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<StandbyContainerGroupPoolRuntimeViewResourceListResult>> ListByStandbyPoolAsync(string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var message = CreateListByStandbyPoolRequest(subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyContainerGroupPoolRuntimeViewResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = StandbyContainerGroupPoolRuntimeViewResourceListResult.DeserializeStandbyContainerGroupPoolRuntimeViewResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List StandbyContainerGroupPoolRuntimeViewResource resources by StandbyContainerGroupPoolResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<StandbyContainerGroupPoolRuntimeViewResourceListResult> ListByStandbyPool(string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var message = CreateListByStandbyPoolRequest(subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyContainerGroupPoolRuntimeViewResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = StandbyContainerGroupPoolRuntimeViewResourceListResult.DeserializeStandbyContainerGroupPoolRuntimeViewResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByStandbyPoolNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByStandbyPoolNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List StandbyContainerGroupPoolRuntimeViewResource resources by StandbyContainerGroupPoolResource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<StandbyContainerGroupPoolRuntimeViewResourceListResult>> ListByStandbyPoolNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var message = CreateListByStandbyPoolNextPageRequest(nextLink, subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyContainerGroupPoolRuntimeViewResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = StandbyContainerGroupPoolRuntimeViewResourceListResult.DeserializeStandbyContainerGroupPoolRuntimeViewResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List StandbyContainerGroupPoolRuntimeViewResource resources by StandbyContainerGroupPoolResource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<StandbyContainerGroupPoolRuntimeViewResourceListResult> ListByStandbyPoolNextPage(string nextLink, string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var message = CreateListByStandbyPoolNextPageRequest(nextLink, subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyContainerGroupPoolRuntimeViewResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = StandbyContainerGroupPoolRuntimeViewResourceListResult.DeserializeStandbyContainerGroupPoolRuntimeViewResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
