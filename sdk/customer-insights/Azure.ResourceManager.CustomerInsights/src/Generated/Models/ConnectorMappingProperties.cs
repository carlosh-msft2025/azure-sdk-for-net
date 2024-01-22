// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The connector mapping properties. </summary>
    public partial class ConnectorMappingProperties
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

        /// <summary> Initializes a new instance of <see cref="ConnectorMappingProperties"/>. </summary>
        /// <param name="errorManagement"> The error management setting for the mapping. </param>
        /// <param name="format"> The format of mapping property. </param>
        /// <param name="availability"> The availability of mapping property. </param>
        /// <param name="structure"> Ingestion mapping information at property level. </param>
        /// <param name="completeOperation"> The operation after import is done. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errorManagement"/>, <paramref name="format"/>, <paramref name="availability"/>, <paramref name="structure"/> or <paramref name="completeOperation"/> is null. </exception>
        public ConnectorMappingProperties(ConnectorMappingErrorManagement errorManagement, ConnectorMappingFormat format, ConnectorMappingAvailability availability, IEnumerable<ConnectorMappingStructure> structure, ConnectorMappingCompleteOperation completeOperation)
        {
            Argument.AssertNotNull(errorManagement, nameof(errorManagement));
            Argument.AssertNotNull(format, nameof(format));
            Argument.AssertNotNull(availability, nameof(availability));
            Argument.AssertNotNull(structure, nameof(structure));
            Argument.AssertNotNull(completeOperation, nameof(completeOperation));

            ErrorManagement = errorManagement;
            Format = format;
            Availability = availability;
            Structure = structure.ToList();
            CompleteOperation = completeOperation;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorMappingProperties"/>. </summary>
        /// <param name="folderPath"> The folder path for the mapping. </param>
        /// <param name="fileFilter"> The file filter for the mapping. </param>
        /// <param name="hasHeader"> If the file contains a header or not. </param>
        /// <param name="errorManagement"> The error management setting for the mapping. </param>
        /// <param name="format"> The format of mapping property. </param>
        /// <param name="availability"> The availability of mapping property. </param>
        /// <param name="structure"> Ingestion mapping information at property level. </param>
        /// <param name="completeOperation"> The operation after import is done. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectorMappingProperties(string folderPath, string fileFilter, bool? hasHeader, ConnectorMappingErrorManagement errorManagement, ConnectorMappingFormat format, ConnectorMappingAvailability availability, IList<ConnectorMappingStructure> structure, ConnectorMappingCompleteOperation completeOperation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FolderPath = folderPath;
            FileFilter = fileFilter;
            HasHeader = hasHeader;
            ErrorManagement = errorManagement;
            Format = format;
            Availability = availability;
            Structure = structure;
            CompleteOperation = completeOperation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorMappingProperties"/> for deserialization. </summary>
        internal ConnectorMappingProperties()
        {
        }

        /// <summary> The folder path for the mapping. </summary>
        public string FolderPath { get; set; }
        /// <summary> The file filter for the mapping. </summary>
        public string FileFilter { get; set; }
        /// <summary> If the file contains a header or not. </summary>
        public bool? HasHeader { get; set; }
        /// <summary> The error management setting for the mapping. </summary>
        public ConnectorMappingErrorManagement ErrorManagement { get; set; }
        /// <summary> The format of mapping property. </summary>
        public ConnectorMappingFormat Format { get; set; }
        /// <summary> The availability of mapping property. </summary>
        public ConnectorMappingAvailability Availability { get; set; }
        /// <summary> Ingestion mapping information at property level. </summary>
        public IList<ConnectorMappingStructure> Structure { get; }
        /// <summary> The operation after import is done. </summary>
        public ConnectorMappingCompleteOperation CompleteOperation { get; set; }
    }
}
