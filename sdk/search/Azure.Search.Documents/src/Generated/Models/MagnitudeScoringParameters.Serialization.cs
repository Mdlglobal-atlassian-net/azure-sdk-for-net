// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class MagnitudeScoringParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("boostingRangeStart");
            writer.WriteNumberValue(BoostingRangeStart);
            writer.WritePropertyName("boostingRangeEnd");
            writer.WriteNumberValue(BoostingRangeEnd);
            if (ShouldBoostBeyondRangeByConstant != null)
            {
                writer.WritePropertyName("constantBoostBeyondRange");
                writer.WriteBooleanValue(ShouldBoostBeyondRangeByConstant.Value);
            }
            writer.WriteEndObject();
        }

        internal static MagnitudeScoringParameters DeserializeMagnitudeScoringParameters(JsonElement element)
        {
            double boostingRangeStart = default;
            double boostingRangeEnd = default;
            bool? constantBoostBeyondRange = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("boostingRangeStart"))
                {
                    boostingRangeStart = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("boostingRangeEnd"))
                {
                    boostingRangeEnd = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("constantBoostBeyondRange"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    constantBoostBeyondRange = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MagnitudeScoringParameters(boostingRangeStart, boostingRangeEnd, constantBoostBeyondRange);
        }
    }
}
