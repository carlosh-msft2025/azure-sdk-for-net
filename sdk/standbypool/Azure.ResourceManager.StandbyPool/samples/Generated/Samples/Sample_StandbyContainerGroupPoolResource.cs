// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.StandbyPool.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.StandbyPool.Samples
{
    public partial class Sample_StandbyContainerGroupPoolResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_StandbyContainerGroupPoolsGet()
        {
            // Generated from example definition: 2025-03-01/StandbyContainerGroupPools_Get.json
            // this example is just showing the usage of "StandbyContainerGroupPoolResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyContainerGroupPoolResource created on azure
            // for more information of creating StandbyContainerGroupPoolResource, please refer to the document of StandbyContainerGroupPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyContainerGroupPoolName = "pool";
            ResourceIdentifier standbyContainerGroupPoolResourceId = StandbyContainerGroupPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource standbyContainerGroupPool = client.GetStandbyContainerGroupPoolResource(standbyContainerGroupPoolResourceId);

            // invoke the operation
            StandbyContainerGroupPoolResource result = await standbyContainerGroupPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyContainerGroupPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_StandbyContainerGroupPoolsDelete()
        {
            // Generated from example definition: 2025-03-01/StandbyContainerGroupPools_Delete.json
            // this example is just showing the usage of "StandbyContainerGroupPoolResource_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyContainerGroupPoolResource created on azure
            // for more information of creating StandbyContainerGroupPoolResource, please refer to the document of StandbyContainerGroupPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyContainerGroupPoolName = "pool";
            ResourceIdentifier standbyContainerGroupPoolResourceId = StandbyContainerGroupPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource standbyContainerGroupPool = client.GetStandbyContainerGroupPoolResource(standbyContainerGroupPoolResourceId);

            // invoke the operation
            await standbyContainerGroupPool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_StandbyContainerGroupPoolsUpdate()
        {
            // Generated from example definition: 2025-03-01/StandbyContainerGroupPools_Update.json
            // this example is just showing the usage of "StandbyContainerGroupPoolResource_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyContainerGroupPoolResource created on azure
            // for more information of creating StandbyContainerGroupPoolResource, please refer to the document of StandbyContainerGroupPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyContainerGroupPoolName = "pool";
            ResourceIdentifier standbyContainerGroupPoolResourceId = StandbyContainerGroupPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource standbyContainerGroupPool = client.GetStandbyContainerGroupPoolResource(standbyContainerGroupPoolResourceId);

            // invoke the operation
            StandbyContainerGroupPoolPatch patch = new StandbyContainerGroupPoolPatch
            {
                Tags = { },
                Properties = new StandbyContainerGroupPoolUpdateProperties
                {
                    ElasticityProfile = new StandbyContainerGroupPoolElasticityProfile(1743L)
                    {
                        RefillPolicy = StandbyRefillPolicy.Always,
                    },
                    ContainerGroupProperties = new StandbyContainerGroupProperties(new StandbyContainerGroupProfile(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000009/resourceGroups/rgstandbypool/providers/Microsoft.ContainerInstance/containerGroupProfiles/cgProfile"))
                    {
                        Revision = 2L,
                    })
                    {
                        SubnetIds = {new WritableSubResource
{
Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000009/resourceGroups/rgstandbypool/providers/Microsoft.Network/virtualNetworks/cgSubnet/subnets/cgSubnet"),
}},
                    },
                    Zones = { "1", "2", "3" },
                },
            };
            StandbyContainerGroupPoolResource result = await standbyContainerGroupPool.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyContainerGroupPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
