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
    /// FixObjChange
    /// </summary>
    [DataContract(Name = "FixObjChange")]
    public partial class FixObjChange : IEquatable<FixObjChange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixObjChange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixObjChange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixObjChange" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">UUID formatted string (required).</param>
        /// <param name="fix">fix.</param>
        /// <param name="pageId">UUID formatted string.</param>
        /// <param name="componentId">UUID formatted string.</param>
        public FixObjChange(Object type = default(Object), Guid id = default(Guid), string fix = default(string), Guid pageId = default(Guid), Guid componentId = default(Guid))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for FixObjChange and cannot be null");
            }
            this.Type = type;
            this.Id = id;
            this.Fix = fix;
            this.PageId = pageId;
            this.ComponentId = componentId;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public Object Type { get; set; }

        /// <summary>
        /// UUID formatted string
        /// </summary>
        /// <value>UUID formatted string</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Fix
        /// </summary>
        [DataMember(Name = "fix", EmitDefaultValue = false)]
        public string Fix { get; set; }

        /// <summary>
        /// UUID formatted string
        /// </summary>
        /// <value>UUID formatted string</value>
        [DataMember(Name = "pageId", EmitDefaultValue = false)]
        public Guid PageId { get; set; }

        /// <summary>
        /// UUID formatted string
        /// </summary>
        /// <value>UUID formatted string</value>
        [DataMember(Name = "componentId", EmitDefaultValue = false)]
        public Guid ComponentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FixObjChange {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Fix: ").Append(Fix).Append("\n");
            sb.Append("  PageId: ").Append(PageId).Append("\n");
            sb.Append("  ComponentId: ").Append(ComponentId).Append("\n");
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
            return this.Equals(input as FixObjChange);
        }

        /// <summary>
        /// Returns true if FixObjChange instances are equal
        /// </summary>
        /// <param name="input">Instance of FixObjChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixObjChange input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Fix == input.Fix ||
                    (this.Fix != null &&
                    this.Fix.Equals(input.Fix))
                ) && 
                (
                    this.PageId == input.PageId ||
                    (this.PageId != null &&
                    this.PageId.Equals(input.PageId))
                ) && 
                (
                    this.ComponentId == input.ComponentId ||
                    (this.ComponentId != null &&
                    this.ComponentId.Equals(input.ComponentId))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Fix != null)
                {
                    hashCode = (hashCode * 59) + this.Fix.GetHashCode();
                }
                if (this.PageId != null)
                {
                    hashCode = (hashCode * 59) + this.PageId.GetHashCode();
                }
                if (this.ComponentId != null)
                {
                    hashCode = (hashCode * 59) + this.ComponentId.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
