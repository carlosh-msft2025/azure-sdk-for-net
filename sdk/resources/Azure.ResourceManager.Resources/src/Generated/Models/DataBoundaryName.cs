// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The DataBoundaryName. </summary>
    public readonly partial struct DataBoundaryName : IEquatable<DataBoundaryName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoundaryName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoundaryName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static DataBoundaryName Default { get; } = new DataBoundaryName(DefaultValue);
        /// <summary> Determines if two <see cref="DataBoundaryName"/> values are the same. </summary>
        public static bool operator ==(DataBoundaryName left, DataBoundaryName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoundaryName"/> values are not the same. </summary>
        public static bool operator !=(DataBoundaryName left, DataBoundaryName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataBoundaryName"/>. </summary>
        public static implicit operator DataBoundaryName(string value) => new DataBoundaryName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoundaryName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoundaryName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
