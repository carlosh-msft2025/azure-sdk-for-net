// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningEnvironmentVersionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWorkspaceEnvironmentVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/EnvironmentVersion/get.json
            // this example is just showing the usage of "EnvironmentVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningEnvironmentVersionResource created on azure
            // for more information of creating MachineLearningEnvironmentVersionResource, please refer to the document of MachineLearningEnvironmentVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningEnvironmentVersionResourceId = MachineLearningEnvironmentVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningEnvironmentVersionResource machineLearningEnvironmentVersion = client.GetMachineLearningEnvironmentVersionResource(machineLearningEnvironmentVersionResourceId);

            // invoke the operation
            MachineLearningEnvironmentVersionResource result = await machineLearningEnvironmentVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteWorkspaceEnvironmentVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/EnvironmentVersion/delete.json
            // this example is just showing the usage of "EnvironmentVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningEnvironmentVersionResource created on azure
            // for more information of creating MachineLearningEnvironmentVersionResource, please refer to the document of MachineLearningEnvironmentVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningEnvironmentVersionResourceId = MachineLearningEnvironmentVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningEnvironmentVersionResource machineLearningEnvironmentVersion = client.GetMachineLearningEnvironmentVersionResource(machineLearningEnvironmentVersionResourceId);

            // invoke the operation
            await machineLearningEnvironmentVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateWorkspaceEnvironmentVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/EnvironmentVersion/createOrUpdate.json
            // this example is just showing the usage of "EnvironmentVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningEnvironmentVersionResource created on azure
            // for more information of creating MachineLearningEnvironmentVersionResource, please refer to the document of MachineLearningEnvironmentVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningEnvironmentVersionResourceId = MachineLearningEnvironmentVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningEnvironmentVersionResource machineLearningEnvironmentVersion = client.GetMachineLearningEnvironmentVersionResource(machineLearningEnvironmentVersionResourceId);

            // invoke the operation
            MachineLearningEnvironmentVersionData data = new MachineLearningEnvironmentVersionData(new MachineLearningEnvironmentVersionProperties
            {
                Image = "docker.io/tensorflow/serving:latest",
                CondaFile = "string",
                Build = new MachineLearningBuildContext(new Uri("https://storage-account.blob.core.windows.net/azureml/DockerBuildContext/95ddede6b9b8c4e90472db3acd0a8d28/"))
                {
                    DockerfilePath = "prod/Dockerfile",
                },
                InferenceConfig = new MachineLearningInferenceContainerProperties
                {
                    LivenessRoute = new MachineLearningInferenceContainerRoute("string", 1),
                    ReadinessRoute = new MachineLearningInferenceContainerRoute("string", 1),
                    ScoringRoute = new MachineLearningInferenceContainerRoute("string", 1),
                },
                IsAnonymous = false,
                Description = "string",
                Tags =
{
["string"] = "string"
},
                Properties =
{
["string"] = "string"
},
            });
            ArmOperation<MachineLearningEnvironmentVersionResource> lro = await machineLearningEnvironmentVersion.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningEnvironmentVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningEnvironmentVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Publish_PublishWorkspaceEnvironmentVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Workspace/EnvironmentVersion/publish.json
            // this example is just showing the usage of "EnvironmentVersions_Publish" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningEnvironmentVersionResource created on azure
            // for more information of creating MachineLearningEnvironmentVersionResource, please refer to the document of MachineLearningEnvironmentVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningEnvironmentVersionResourceId = MachineLearningEnvironmentVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningEnvironmentVersionResource machineLearningEnvironmentVersion = client.GetMachineLearningEnvironmentVersionResource(machineLearningEnvironmentVersionResourceId);

            // invoke the operation
            DestinationAssetContent content = new DestinationAssetContent
            {
                RegistryName = "string",
                DestinationName = "string",
                DestinationVersion = "string",
            };
            await machineLearningEnvironmentVersion.PublishAsync(WaitUntil.Completed, content);

            Console.WriteLine("Succeeded");
        }
    }
}
