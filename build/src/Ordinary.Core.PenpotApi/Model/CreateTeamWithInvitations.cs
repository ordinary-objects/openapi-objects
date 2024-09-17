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
    /// CreateTeamWithInvitations
    /// </summary>
    [DataContract(Name = "create_team_with_invitations")]
    public partial class CreateTeamWithInvitations : IEquatable<CreateTeamWithInvitations>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamWithInvitations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTeamWithInvitations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamWithInvitations" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="features">Set of Strings.</param>
        /// <param name="id">UUID formatted string.</param>
        /// <param name="emails">Set of Strings (required).</param>
        /// <param name="role">One of the Set (required).</param>
        public CreateTeamWithInvitations(string name = default(string), List<string> features = default(List<string>), Guid id = default(Guid), List<string> emails = default(List<string>), string role = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateTeamWithInvitations and cannot be null");
            }
            this.Name = name;
            // to ensure "emails" is required (not null)
            if (emails == null)
            {
                throw new ArgumentNullException("emails is a required property for CreateTeamWithInvitations and cannot be null");
            }
            this.Emails = emails;
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new ArgumentNullException("role is a required property for CreateTeamWithInvitations and cannot be null");
            }
            this.Role = role;
            this.Features = features;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Set of Strings
        /// </summary>
        /// <value>Set of Strings</value>
        [DataMember(Name = "features", EmitDefaultValue = false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// UUID formatted string
        /// </summary>
        /// <value>UUID formatted string</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Set of Strings
        /// </summary>
        /// <value>Set of Strings</value>
        [DataMember(Name = "emails", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// One of the Set
        /// </summary>
        /// <value>One of the Set</value>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTeamWithInvitations {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as CreateTeamWithInvitations);
        }

        /// <summary>
        /// Returns true if CreateTeamWithInvitations instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTeamWithInvitations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTeamWithInvitations input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Features != null)
                {
                    hashCode = (hashCode * 59) + this.Features.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Emails != null)
                {
                    hashCode = (hashCode * 59) + this.Emails.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
