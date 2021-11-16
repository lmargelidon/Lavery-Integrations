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
    /// Contains parameters to make a request to create a new Timekeeper.
    /// </summary>
    [DataContract]
    public partial class E3EAPITimekeeperModelsTimekeeperCreateRequest :  IEquatable<E3EAPITimekeeperModelsTimekeeperCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="E3EAPITimekeeperModelsTimekeeperCreateRequest" /> class.
        /// </summary>
        /// <param name="dataCollection">Gets or sets the DataCollection..</param>
        public E3EAPITimekeeperModelsTimekeeperCreateRequest(E3EAPIDataObjectModelsDataObjectLiteCollection dataCollection = default(E3EAPIDataObjectModelsDataObjectLiteCollection))
        {
            this.DataCollection = dataCollection;
            this.DataCollection = dataCollection;
        }

        /// <summary>
        /// Gets or sets the DataCollection.
        /// </summary>
        /// <value>Gets or sets the DataCollection.</value>
        [DataMember(Name="dataCollection", EmitDefaultValue=true)]
        public E3EAPIDataObjectModelsDataObjectLiteCollection DataCollection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class E3EAPITimekeeperModelsTimekeeperCreateRequest {\n");
            sb.Append("  DataCollection: ").Append(DataCollection).Append("\n");
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
            return this.Equals(input as E3EAPITimekeeperModelsTimekeeperCreateRequest);
        }

        /// <summary>
        /// Returns true if E3EAPITimekeeperModelsTimekeeperCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of E3EAPITimekeeperModelsTimekeeperCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(E3EAPITimekeeperModelsTimekeeperCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataCollection == input.DataCollection ||
                    (this.DataCollection != null &&
                    this.DataCollection.Equals(input.DataCollection))
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
                if (this.DataCollection != null)
                    hashCode = hashCode * 59 + this.DataCollection.GetHashCode();
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
