/*
 * 3E API
 *
 * The 3E Public API provides a powerful and convenient Web Services API for interacting with the 3E platform. The 3E API endpoints are a common integration point to allow programmatic interaction with the 3E business logic and data.
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Standard request to update a data object model.
    /// </summary>
    [DataContract]
    public partial class E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest :  IEquatable<E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest" /> class.
        /// </summary>
        /// <param name="modelId">Gets or sets the ID of a model that is going to be updated. (required).</param>
        /// <param name="name">Gets or sets a model name..</param>
        /// <param name="isGlobal">Gets or sets a value indicating whether an user or a global model should be updated..</param>
        public E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest(Guid modelId = default(Guid), string name = default(string), bool? isGlobal = default(bool?))
        {
            // to ensure "modelId" is required (not null)
            if (modelId == null)
            {
                throw new InvalidDataException("modelId is a required property for E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest and cannot be null");
            }
            else
            {
                this.ModelId = modelId;
            }

            this.Name = name;
            this.IsGlobal = isGlobal;
            this.Name = name;
            this.IsGlobal = isGlobal;
        }

        /// <summary>
        /// Gets or sets the ID of a model that is going to be updated.
        /// </summary>
        /// <value>Gets or sets the ID of a model that is going to be updated.</value>
        [DataMember(Name="modelId", EmitDefaultValue=true)]
        public Guid ModelId { get; set; }

        /// <summary>
        /// Gets or sets a model name.
        /// </summary>
        /// <value>Gets or sets a model name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an user or a global model should be updated.
        /// </summary>
        /// <value>Gets or sets a value indicating whether an user or a global model should be updated.</value>
        [DataMember(Name="isGlobal", EmitDefaultValue=true)]
        public bool? IsGlobal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest {\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsGlobal: ").Append(IsGlobal).Append("\n");
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
            return this.Equals(input as E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest);
        }

        /// <summary>
        /// Returns true if E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsGlobal == input.IsGlobal ||
                    (this.IsGlobal != null &&
                    this.IsGlobal.Equals(input.IsGlobal))
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
                if (this.ModelId != null)
                    hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsGlobal != null)
                    hashCode = hashCode * 59 + this.IsGlobal.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
