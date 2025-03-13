// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.StandbyPool
{
    /// <summary>
    /// A Class representing a StandbyContainerGroupPoolRuntimeView along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="StandbyContainerGroupPoolRuntimeViewResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetStandbyContainerGroupPoolRuntimeViewResource method.
    /// Otherwise you can get one from its parent resource <see cref="StandbyContainerGroupPoolResource"/> using the GetStandbyContainerGroupPoolRuntimeView method.
    /// </summary>
    public partial class StandbyContainerGroupPoolRuntimeViewResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="standbyContainerGroupPoolName"> The standbyContainerGroupPoolName. </param>
        /// <param name="runtimeView"> The runtimeView. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string standbyContainerGroupPoolName, string runtimeView)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews/{runtimeView}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _standbyContainerGroupPoolRuntimeViewClientDiagnostics;
        private readonly StandbyContainerGroupPoolRuntimeViewsRestOperations _standbyContainerGroupPoolRuntimeViewRestClient;
        private readonly StandbyContainerGroupPoolRuntimeViewData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StandbyPool/standbyContainerGroupPools/runtimeViews";

        /// <summary> Initializes a new instance of the <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> class for mocking. </summary>
        protected StandbyContainerGroupPoolRuntimeViewResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StandbyContainerGroupPoolRuntimeViewResource(ArmClient client, StandbyContainerGroupPoolRuntimeViewData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StandbyContainerGroupPoolRuntimeViewResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _standbyContainerGroupPoolRuntimeViewClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StandbyPool", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string standbyContainerGroupPoolRuntimeViewApiVersion);
            _standbyContainerGroupPoolRuntimeViewRestClient = new StandbyContainerGroupPoolRuntimeViewsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, standbyContainerGroupPoolRuntimeViewApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StandbyContainerGroupPoolRuntimeViewData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a StandbyContainerGroupPoolRuntimeViewResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViews_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StandbyContainerGroupPoolRuntimeViewResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _standbyContainerGroupPoolRuntimeViewClientDiagnostics.CreateScope("StandbyContainerGroupPoolRuntimeViewResource.Get");
            scope.Start();
            try
            {
                var response = await _standbyContainerGroupPoolRuntimeViewRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a StandbyContainerGroupPoolRuntimeViewResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}/runtimeViews/{runtimeView}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolRuntimeViews_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolRuntimeViewResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StandbyContainerGroupPoolRuntimeViewResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _standbyContainerGroupPoolRuntimeViewClientDiagnostics.CreateScope("StandbyContainerGroupPoolRuntimeViewResource.Get");
            scope.Start();
            try
            {
                var response = _standbyContainerGroupPoolRuntimeViewRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolRuntimeViewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
