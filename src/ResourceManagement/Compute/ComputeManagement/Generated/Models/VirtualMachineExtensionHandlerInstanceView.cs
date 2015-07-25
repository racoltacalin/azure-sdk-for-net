namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The instance view of a virtual machine extension handler.
    /// </summary>
    public partial class VirtualMachineExtensionHandlerInstanceView
    {
        /// <summary>
        /// Gets or sets full type of the extension handler which includes
        /// both publisher and type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the type version of the extension handler.
        /// </summary>
        [JsonProperty(PropertyName = "typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets the extension handler status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public InstanceViewStatus Status { get; set; }

    }
}
