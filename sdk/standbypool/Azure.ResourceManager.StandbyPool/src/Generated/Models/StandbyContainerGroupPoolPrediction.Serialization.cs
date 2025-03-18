// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StandbyPool.Models
{
    public partial class StandbyContainerGroupPoolPrediction : IUtf8JsonSerializable, IJsonModel<StandbyContainerGroupPoolPrediction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StandbyContainerGroupPoolPrediction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StandbyContainerGroupPoolPrediction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupPoolPrediction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandbyContainerGroupPoolPrediction)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("forecastValues"u8);
                writer.WriteObjectValue(ForecastValues, options);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("forecastStartTime"u8);
                writer.WriteStringValue(ForecastStartOn, "O");
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("forecastInfo"u8);
                writer.WriteStringValue(ForecastInfo);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        StandbyContainerGroupPoolPrediction IJsonModel<StandbyContainerGroupPoolPrediction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupPoolPrediction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StandbyContainerGroupPoolPrediction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStandbyContainerGroupPoolPrediction(document.RootElement, options);
        }

        internal static StandbyContainerGroupPoolPrediction DeserializeStandbyContainerGroupPoolPrediction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StandbyContainerGroupPoolForecastValues forecastValues = default;
            DateTimeOffset forecastStartTime = default;
            string forecastInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forecastValues"u8))
                {
                    forecastValues = StandbyContainerGroupPoolForecastValues.DeserializeStandbyContainerGroupPoolForecastValues(property.Value, options);
                    continue;
                }
                if (property.NameEquals("forecastStartTime"u8))
                {
                    forecastStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("forecastInfo"u8))
                {
                    forecastInfo = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StandbyContainerGroupPoolPrediction(forecastValues, forecastStartTime, forecastInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StandbyContainerGroupPoolPrediction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupPoolPrediction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StandbyContainerGroupPoolPrediction)} does not support writing '{options.Format}' format.");
            }
        }

        StandbyContainerGroupPoolPrediction IPersistableModel<StandbyContainerGroupPoolPrediction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StandbyContainerGroupPoolPrediction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStandbyContainerGroupPoolPrediction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StandbyContainerGroupPoolPrediction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StandbyContainerGroupPoolPrediction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
