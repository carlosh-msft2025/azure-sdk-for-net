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
    /// A Class representing a StandbyVirtualMachine along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="StandbyVirtualMachineResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetStandbyVirtualMachineResource method.
    /// Otherwise you can get one from its parent resource <see cref="StandbyVirtualMachinePoolResource"/> using the GetStandbyVirtualMachine method.
    /// </summary>
    public partial class StandbyVirtualMachineResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StandbyVirtualMachineResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="standbyVirtualMachinePoolName"> The standbyVirtualMachinePoolName. </param>
        /// <param name="standbyVirtualMachineName"> The standbyVirtualMachineName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string standbyVirtualMachinePoolName, string standbyVirtualMachineName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/standbyVirtualMachines/{standbyVirtualMachineName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _standbyVirtualMachineClientDiagnostics;
        private readonly StandbyVirtualMachinesRestOperations _standbyVirtualMachineRestClient;
        private readonly StandbyVirtualMachineData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StandbyPool/standbyVirtualMachinePools/standbyVirtualMachines";

        /// <summary> Initializes a new instance of the <see cref="StandbyVirtualMachineResource"/> class for mocking. </summary>
        protected StandbyVirtualMachineResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StandbyVirtualMachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StandbyVirtualMachineResource(ArmClient client, StandbyVirtualMachineData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StandbyVirtualMachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StandbyVirtualMachineResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _standbyVirtualMachineClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StandbyPool", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string standbyVirtualMachineApiVersion);
            _standbyVirtualMachineRestClient = new StandbyVirtualMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, standbyVirtualMachineApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StandbyVirtualMachineData Data
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
        /// Get a StandbyVirtualMachineResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/standbyVirtualMachines/{standbyVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StandbyVirtualMachineResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _standbyVirtualMachineClientDiagnostics.CreateScope("StandbyVirtualMachineResource.Get");
            scope.Start();
            try
            {
                var response = await _standbyVirtualMachineRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a StandbyVirtualMachineResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}/standbyVirtualMachines/{standbyVirtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachines_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachineResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StandbyVirtualMachineResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _standbyVirtualMachineClientDiagnostics.CreateScope("StandbyVirtualMachineResource.Get");
            scope.Start();
            try
            {
                var response = _standbyVirtualMachineRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
