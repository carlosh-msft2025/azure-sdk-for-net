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
    internal partial class StandbyVirtualMachinesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of StandbyVirtualMachinesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> Service host. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public StandbyVirtualMachinesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2025-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName, string standbyVirtualMachineName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/", false);
            uri.AppendPath(standbyVirtualMachinePoolName, true);
            uri.AppendPath("/standbyVirtualMachines/", false);
            uri.AppendPath(standbyVirtualMachineName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName, string standbyVirtualMachineName)
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
            uri.AppendPath("/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/", false);
            uri.AppendPath(standbyVirtualMachinePoolName, true);
            uri.AppendPath("/standbyVirtualMachines/", false);
            uri.AppendPath(standbyVirtualMachineName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a StandbyVirtualMachineResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="standbyVirtualMachineName"> Name of the standby virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="standbyVirtualMachinePoolName"/> or <paramref name="standbyVirtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="standbyVirtualMachinePoolName"/> or <paramref name="standbyVirtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<StandbyVirtualMachineData>> GetAsync(string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName, string standbyVirtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyVirtualMachinePoolName, nameof(standbyVirtualMachinePoolName));
            Argument.AssertNotNullOrEmpty(standbyVirtualMachineName, nameof(standbyVirtualMachineName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName, standbyVirtualMachineName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyVirtualMachineData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = StandbyVirtualMachineData.DeserializeStandbyVirtualMachineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((StandbyVirtualMachineData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a StandbyVirtualMachineResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="standbyVirtualMachineName"> Name of the standby virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="standbyVirtualMachinePoolName"/> or <paramref name="standbyVirtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="standbyVirtualMachinePoolName"/> or <paramref name="standbyVirtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<StandbyVirtualMachineData> Get(string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName, string standbyVirtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyVirtualMachinePoolName, nameof(standbyVirtualMachinePoolName));
            Argument.AssertNotNullOrEmpty(standbyVirtualMachineName, nameof(standbyVirtualMachineName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName, standbyVirtualMachineName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyVirtualMachineData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = StandbyVirtualMachineData.DeserializeStandbyVirtualMachineData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((StandbyVirtualMachineData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByStandbyVirtualMachinePoolResourceRequestUri(string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/", false);
            uri.AppendPath(standbyVirtualMachinePoolName, true);
            uri.AppendPath("/standbyVirtualMachines", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByStandbyVirtualMachinePoolResourceRequest(string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName)
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
            uri.AppendPath("/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/", false);
            uri.AppendPath(standbyVirtualMachinePoolName, true);
            uri.AppendPath("/standbyVirtualMachines", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List StandbyVirtualMachineResource resources by StandbyVirtualMachinePoolResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyVirtualMachinePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyVirtualMachinePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<StandbyVirtualMachineResourceListResult>> ListByStandbyVirtualMachinePoolResourceAsync(string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyVirtualMachinePoolName, nameof(standbyVirtualMachinePoolName));

            using var message = CreateListByStandbyVirtualMachinePoolResourceRequest(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyVirtualMachineResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = StandbyVirtualMachineResourceListResult.DeserializeStandbyVirtualMachineResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List StandbyVirtualMachineResource resources by StandbyVirtualMachinePoolResource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyVirtualMachinePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyVirtualMachinePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<StandbyVirtualMachineResourceListResult> ListByStandbyVirtualMachinePoolResource(string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyVirtualMachinePoolName, nameof(standbyVirtualMachinePoolName));

            using var message = CreateListByStandbyVirtualMachinePoolResourceRequest(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyVirtualMachineResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = StandbyVirtualMachineResourceListResult.DeserializeStandbyVirtualMachineResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByStandbyVirtualMachinePoolResourceNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByStandbyVirtualMachinePoolResourceNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName)
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

        /// <summary> List StandbyVirtualMachineResource resources by StandbyVirtualMachinePoolResource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyVirtualMachinePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyVirtualMachinePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<StandbyVirtualMachineResourceListResult>> ListByStandbyVirtualMachinePoolResourceNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyVirtualMachinePoolName, nameof(standbyVirtualMachinePoolName));

            using var message = CreateListByStandbyVirtualMachinePoolResourceNextPageRequest(nextLink, subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyVirtualMachineResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = StandbyVirtualMachineResourceListResult.DeserializeStandbyVirtualMachineResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List StandbyVirtualMachineResource resources by StandbyVirtualMachinePoolResource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyVirtualMachinePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="standbyVirtualMachinePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<StandbyVirtualMachineResourceListResult> ListByStandbyVirtualMachinePoolResourceNextPage(string nextLink, string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(standbyVirtualMachinePoolName, nameof(standbyVirtualMachinePoolName));

            using var message = CreateListByStandbyVirtualMachinePoolResourceNextPageRequest(nextLink, subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StandbyVirtualMachineResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = StandbyVirtualMachineResourceListResult.DeserializeStandbyVirtualMachineResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
