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
    /// MoveFiles
    /// </summary>
    [DataContract(Name = "move_files")]
    public partial class MoveFiles : IEquatable<MoveFiles>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFiles" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MoveFiles() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFiles" /> class.
        /// </summary>
        /// <param name="ids">Set of UUID (required).</param>
        /// <param name="projectId">UUID formatted string (required).</param>
        public MoveFiles(List<Guid> ids = default(List<Guid>), Guid projectId = default(Guid))
        {
            // to ensure "ids" is required (not null)
            if (ids == null)
            {
                throw new ArgumentNullException("ids is a required property for MoveFiles and cannot be null");
            }
            this.Ids = ids;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Set of UUID
        /// </summary>
        /// <value>Set of UUID</value>
        [DataMember(Name = "ids", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> Ids { get; set; }

        /// <summary>
        /// UUID formatted string
        /// </summary>
        /// <value>UUID formatted string</value>
        [DataMember(Name = "projectId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MoveFiles {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
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
            return this.Equals(input as MoveFiles);
        }

        /// <summary>
        /// Returns true if MoveFiles instances are equal
        /// </summary>
        /// <param name="input">Instance of MoveFiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoveFiles input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.Ids != null)
                {
                    hashCode = (hashCode * 59) + this.Ids.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
