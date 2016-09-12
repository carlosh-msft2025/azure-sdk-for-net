// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL external datasource item.
    /// </summary>
    public partial class USqlExternalDataSource : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlExternalDataSource class.
        /// </summary>
        public USqlExternalDataSource() { }

        /// <summary>
        /// Initializes a new instance of the USqlExternalDataSource class.
        /// </summary>
        /// <param name="computeAccountName">the name of the Data Lake
        /// Analytics account.</param>
        /// <param name="version">the version of the catalog item.</param>
        /// <param name="databaseName">the name of the database.</param>
        /// <param name="name">the name of the external data source.</param>
        /// <param name="provider">the name of the provider for the external
        /// data source.</param>
        /// <param name="providerString">the name of the provider string for
        /// the external data source.</param>
        /// <param name="pushdownTypes">the list of types to push down from
        /// the external data source.</param>
        public USqlExternalDataSource(string computeAccountName = default(string), Guid? version = default(Guid?), string databaseName = default(string), string name = default(string), string provider = default(string), string providerString = default(string), IList<string> pushdownTypes = default(IList<string>))
            : base(computeAccountName, version)
        {
            DatabaseName = databaseName;
            Name = name;
            Provider = provider;
            ProviderString = providerString;
            PushdownTypes = pushdownTypes;
        }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the external data source.
        /// </summary>
        [JsonProperty(PropertyName = "externalDataSourceName")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the provider for the external data source.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the name of the provider string for the external data
        /// source.
        /// </summary>
        [JsonProperty(PropertyName = "providerString")]
        public string ProviderString { get; set; }

        /// <summary>
        /// Gets or sets the list of types to push down from the external data
        /// source.
        /// </summary>
        [JsonProperty(PropertyName = "pushdownTypes")]
        public IList<string> PushdownTypes { get; set; }

    }
}
