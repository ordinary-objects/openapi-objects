/*
 * Ordinary Objects Penpot API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Ordinary.Core.PenpotApi.Client.OpenAPIDateConverter;

namespace Ordinary.Core.PenpotApi.Model
{
    /// <summary>
    /// PushAuditEvents
    /// </summary>
    [DataContract(Name = "push_audit_events")]
    public partial class PushAuditEvents : IEquatable<PushAuditEvents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushAuditEvents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushAuditEvents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushAuditEvents" /> class.
        /// </summary>
        /// <param name="events">events (required).</param>
        public PushAuditEvents(List<Event> events = default(List<Event>))
        {
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new ArgumentNullException("events is a required property for PushAuditEvents and cannot be null");
            }
            this.Events = events;
        }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public List<Event> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PushAuditEvents {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PushAuditEvents);
        }

        /// <summary>
        /// Returns true if PushAuditEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of PushAuditEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushAuditEvents input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
