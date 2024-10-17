// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class CosmosDBSqlRoleDefinitionData : IUtf8JsonSerializable, IJsonModel<CosmosDBSqlRoleDefinitionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBSqlRoleDefinitionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CosmosDBSqlRoleDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlRoleDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlRoleDefinitionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleName))
            {
                writer.WritePropertyName("roleName"u8);
                writer.WriteStringValue(RoleName);
            }
            if (Optional.IsDefined(RoleDefinitionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RoleDefinitionType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(AssignableScopes))
            {
                writer.WritePropertyName("assignableScopes"u8);
                writer.WriteStartArray();
                foreach (var item in AssignableScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Permissions))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStartArray();
                foreach (var item in Permissions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        CosmosDBSqlRoleDefinitionData IJsonModel<CosmosDBSqlRoleDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlRoleDefinitionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlRoleDefinitionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBSqlRoleDefinitionData(document.RootElement, options);
        }

        internal static CosmosDBSqlRoleDefinitionData DeserializeCosmosDBSqlRoleDefinitionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string roleName = default;
            CosmosDBSqlRoleDefinitionType? type0 = default;
            IList<string> assignableScopes = default;
            IList<CosmosDBSqlRolePermission> permissions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("roleName"u8))
                        {
                            roleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = property0.Value.GetString().ToCosmosDBSqlRoleDefinitionType();
                            continue;
                        }
                        if (property0.NameEquals("assignableScopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            assignableScopes = array;
                            continue;
                        }
                        if (property0.NameEquals("permissions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBSqlRolePermission> array = new List<CosmosDBSqlRolePermission>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBSqlRolePermission.DeserializeCosmosDBSqlRolePermission(item, options));
                            }
                            permissions = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CosmosDBSqlRoleDefinitionData(
                id,
                name,
                type,
                systemData,
                roleName,
                type0,
                assignableScopes ?? new ChangeTrackingList<string>(),
                permissions ?? new ChangeTrackingList<CosmosDBSqlRolePermission>(),
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RoleName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    roleName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RoleName))
                {
                    builder.Append("    roleName: ");
                    if (RoleName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RoleName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RoleName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RoleDefinitionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RoleDefinitionType))
                {
                    builder.Append("    type: ");
                    builder.AppendLine($"'{RoleDefinitionType.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AssignableScopes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    assignableScopes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AssignableScopes))
                {
                    if (AssignableScopes.Any())
                    {
                        builder.Append("    assignableScopes: ");
                        builder.AppendLine("[");
                        foreach (var item in AssignableScopes)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Permissions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    permissions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Permissions))
                {
                    if (Permissions.Any())
                    {
                        builder.Append("    permissions: ");
                        builder.AppendLine("[");
                        foreach (var item in Permissions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    permissions: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CosmosDBSqlRoleDefinitionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlRoleDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlRoleDefinitionData)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBSqlRoleDefinitionData IPersistableModel<CosmosDBSqlRoleDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlRoleDefinitionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBSqlRoleDefinitionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlRoleDefinitionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBSqlRoleDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
