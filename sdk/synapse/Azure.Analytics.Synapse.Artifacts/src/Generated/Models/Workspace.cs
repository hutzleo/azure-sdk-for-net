// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Workspace resource type. </summary>
    internal partial class Workspace : Resource, IReadOnlyDictionary<string, object>
    {
        /// <summary> Initializes a new instance of Workspace. </summary>
        internal Workspace()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Managed service identity of the workspace. </summary>
        public WorkspaceIdentity Identity { get; }
        /// <summary> Workspace provisioning state, example Succeeded. </summary>
        public string ProvisioningState { get; }
        /// <summary> Time the workspace was created in ISO8601 format. </summary>
        public DateTimeOffset? CreateTime { get; }
        /// <summary> Version of the workspace. </summary>
        public string Version { get; }
        /// <summary> Linked service reference. </summary>
        public LinkedServiceReference DefaultStorage { get; }
        /// <summary> Linked service reference. </summary>
        public LinkedServiceReference DefaultSqlServer { get; }
        internal IReadOnlyDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public IEnumerable<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public IEnumerable<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int IReadOnlyCollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
        }
    }
}
