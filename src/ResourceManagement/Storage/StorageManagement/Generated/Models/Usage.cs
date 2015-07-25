namespace Microsoft.Azure.Management.Storage.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes Storage Resource Usage.
    /// </summary>
    public partial class Usage
    {
        /// <summary>
        /// Gets the unit of measurement. Possible values for this property
        /// include: 'Count', 'Bytes', 'Seconds', 'Percent',
        /// 'CountsPerSecond', 'BytesPerSecond'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public UsageUnit? Unit { get; set; }

        /// <summary>
        /// Gets the current count of the allocated resources in the
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public int? CurrentValue { get; set; }

        /// <summary>
        /// Gets the maximum count of the resources that can be allocated in
        /// the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets the name of the type of usage.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public UsageName Name { get; set; }

    }
}
