// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies the clip time as an absolute time position in the media file.
    /// The absolute time can point to a different position depending on
    /// whether the media file starts from a timestamp of zero or not.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.AbsoluteClipTime")]
    public partial class AbsoluteClipTime : ClipTime
    {
        /// <summary>
        /// Initializes a new instance of the AbsoluteClipTime class.
        /// </summary>
        public AbsoluteClipTime()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteClipTime class.
        /// </summary>
        /// <param name="time">The time position on the timeline of the input
        /// media. It is usually specified as an ISO8601 period. e.g PT30S for
        /// 30 seconds.</param>
        public AbsoluteClipTime(System.TimeSpan time)
        {
            Time = time;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the time position on the timeline of the input media.
        /// It is usually specified as an ISO8601 period. e.g PT30S for 30
        /// seconds.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.TimeSpan Time { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
