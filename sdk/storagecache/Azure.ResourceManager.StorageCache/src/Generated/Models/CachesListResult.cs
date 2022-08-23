// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageCache;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Result of the request to list Caches. It contains a list of Caches and a URL link to get the next set of results. </summary>
    internal partial class CachesListResult
    {
        /// <summary> Initializes a new instance of CachesListResult. </summary>
        internal CachesListResult()
        {
            Value = new ChangeTrackingList<CacheData>();
        }

        /// <summary> Initializes a new instance of CachesListResult. </summary>
        /// <param name="nextLink"> URL to get the next set of Cache list results, if there are any. </param>
        /// <param name="value"> List of Caches. </param>
        internal CachesListResult(string nextLink, IReadOnlyList<CacheData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> URL to get the next set of Cache list results, if there are any. </summary>
        public string NextLink { get; }
        /// <summary> List of Caches. </summary>
        public IReadOnlyList<CacheData> Value { get; }
    }
}
