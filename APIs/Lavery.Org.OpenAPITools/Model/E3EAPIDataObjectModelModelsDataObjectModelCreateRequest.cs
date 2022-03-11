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
    /// Standard request to create a data object model.
    /// </summary>
    [DataContract]
    public partial class E3EAPIDataObjectModelModelsDataObjectModelCreateRequest :  IEquatable<E3EAPIDataObjectModelModelsDataObjectModelCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="E3EAPIDataObjectModelModelsDataObjectModelCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected E3EAPIDataObjectModelModelsDataObjectModelCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="E3EAPIDataObjectModelModelsDataObjectModelCreateRequest" /> class.
        /// </summary>
        /// <param name="name">Gets or sets a model name. (required).</param>
        /// <param name="itemId">Gets or sets the ID of a data object that is going to be used to create a model. (required).</param>
        /// <param name="isGlobal">Gets or sets a value indicating whether an user or a global model should be created..</param>
        public E3EAPIDataObjectModelModelsDataObjectModelCreateRequest(string name = default(string), Guid itemId = default(Guid), bool isGlobal = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for E3EAPIDataObjectModelModelsDataObjectModelCreateRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "itemId" is required (not null)
            if (itemId == null)
            {
                throw new InvalidDataException("itemId is a required property for E3EAPIDataObjectModelModelsDataObjectModelCreateRequest and cannot be null");
            }
            else
            {
                this.ItemId = itemId;
            }

            this.IsGlobal = isGlobal;
        }

        /// <summary>
        /// Gets or sets a model name.
        /// </summary>
        /// <value>Gets or sets a model name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ID of a data object that is going to be used to create a model.
        /// </summary>
        /// <value>Gets or sets the ID of a data object that is going to be used to create a model.</value>
        [DataMember(Name="itemId", EmitDefaultValue=true)]
        public Guid ItemId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an user or a global model should be created.
        /// </summary>
        /// <value>Gets or sets a value indicating whether an user or a global model should be created.</value>
        [DataMember(Name="isGlobal", EmitDefaultValue=false)]
        public bool IsGlobal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class E3EAPIDataObjectModelModelsDataObjectModelCreateRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
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
            return this.Equals(input as E3EAPIDataObjectModelModelsDataObjectModelCreateRequest);
        }

        /// <summary>
        /// Returns true if E3EAPIDataObjectModelModelsDataObjectModelCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of E3EAPIDataObjectModelModelsDataObjectModelCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(E3EAPIDataObjectModelModelsDataObjectModelCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
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
