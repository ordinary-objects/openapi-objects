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
    /// CommandCreateFileThumbnailPostDefaultResponse
    /// </summary>
    [DataContract(Name = "_command_create_file_thumbnail_post_default_response")]
    public partial class CommandCreateFileThumbnailPostDefaultResponse : IEquatable<CommandCreateFileThumbnailPostDefaultResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandCreateFileThumbnailPostDefaultResponse" /> class.
        /// </summary>
        /// <param name="uri">uri.</param>
        public CommandCreateFileThumbnailPostDefaultResponse(string uri = default(string))
        {
            this.Uri = uri;
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommandCreateFileThumbnailPostDefaultResponse {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(input as CommandCreateFileThumbnailPostDefaultResponse);
        }

        /// <summary>
        /// Returns true if CommandCreateFileThumbnailPostDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CommandCreateFileThumbnailPostDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommandCreateFileThumbnailPostDefaultResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
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
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
