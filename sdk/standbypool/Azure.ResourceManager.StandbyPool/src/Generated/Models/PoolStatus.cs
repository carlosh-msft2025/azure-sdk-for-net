// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StandbyPool.Models
{
    /// <summary> Displays StandbyPool status. </summary>
    public partial class PoolStatus
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PoolStatus"/>. </summary>
        /// <param name="code"> Displays the healthy state of the StandbyPool. </param>
        internal PoolStatus(HealthStateCode code)
        {
            Code = code;
        }

        /// <summary> Initializes a new instance of <see cref="PoolStatus"/>. </summary>
        /// <param name="code"> Displays the healthy state of the StandbyPool. </param>
        /// <param name="message"> Displays the StandbyPool health state details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PoolStatus(HealthStateCode code, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PoolStatus"/> for deserialization. </summary>
        internal PoolStatus()
        {
        }

        /// <summary> Displays the healthy state of the StandbyPool. </summary>
        public HealthStateCode Code { get; }
        /// <summary> Displays the StandbyPool health state details. </summary>
        public string Message { get; }
    }
}
