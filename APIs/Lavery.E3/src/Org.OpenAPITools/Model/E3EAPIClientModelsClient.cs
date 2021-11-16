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
    /// Represents a client object.
    /// </summary>
    [DataContract]
    public partial class E3EAPIClientModelsClient :  IEquatable<E3EAPIClientModelsClient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="E3EAPIClientModelsClient" /> class.
        /// </summary>
        /// <param name="id">Gets or sets unique id associated with the object..</param>
        /// <param name="accessType">Gets or sets the access type of the row. When omitted, default value is Enabled (editable for data objects)..</param>
        /// <param name="dataState">Gets or sets the data object state..</param>
        /// <param name="attributes">Gets or sets the attributes..</param>
        /// <param name="childObjects">Gets or sets the child objects for this data object. This is a collection of collections..</param>
        /// <param name="error">Gets or sets the error in the row level..</param>
        /// <param name="index">Gets or sets the index of the row. (default to -1).</param>
        /// <param name="isLocked">Gets or sets a value indicating whether the row is checked out by another process..</param>
        /// <param name="lockedMessage">Gets or sets the message indicating whether the row is locked..</param>
        /// <param name="subclassId">Gets or sets the subclass id of this row..</param>
        public E3EAPIClientModelsClient(string id = default(string), E3EAPIDataAccessType accessType = default(E3EAPIDataAccessType), E3EAPIDataObjectModelsDataObjectLiteState dataState = default(E3EAPIDataObjectModelsDataObjectLiteState), Dictionary<string, E3EAPIDataModelsAttribute> attributes = default(Dictionary<string, E3EAPIDataModelsAttribute>), List<E3EAPIDataObjectModelsDataObjectLiteCollection> childObjects = default(List<E3EAPIDataObjectModelsDataObjectLiteCollection>), E3EAPIDataDataError error = default(E3EAPIDataDataError), int index = -1, bool isLocked = default(bool), string lockedMessage = default(string), string subclassId = default(string))
        {
            this.Id = id;
            this.Attributes = attributes;
            this.ChildObjects = childObjects;
            this.Error = error;
            this.LockedMessage = lockedMessage;
            this.SubclassId = subclassId;
            this.Id = id;
            this.AccessType = accessType;
            this.DataState = dataState;
            this.Attributes = attributes;
            this.ChildObjects = childObjects;
            this.Error = error;
            // use default value if no "index" provided
            if (index == null)
            {
                this.Index = -1;
            }
            else
            {
                this.Index = index;
            }
            this.IsLocked = isLocked;
            this.LockedMessage = lockedMessage;
            this.SubclassId = subclassId;
        }

        /// <summary>
        /// Gets or sets unique id associated with the object.
        /// </summary>
        /// <value>Gets or sets unique id associated with the object.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the access type of the row. When omitted, default value is Enabled (editable for data objects).
        /// </summary>
        /// <value>Gets or sets the access type of the row. When omitted, default value is Enabled (editable for data objects).</value>
        [DataMember(Name="accessType", EmitDefaultValue=false)]
        public E3EAPIDataAccessType AccessType { get; set; }

        /// <summary>
        /// Gets or sets the data object state.
        /// </summary>
        /// <value>Gets or sets the data object state.</value>
        [DataMember(Name="dataState", EmitDefaultValue=false)]
        public E3EAPIDataObjectModelsDataObjectLiteState DataState { get; set; }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>Gets or sets the attributes.</value>
        [DataMember(Name="attributes", EmitDefaultValue=true)]
        public Dictionary<string, E3EAPIDataModelsAttribute> Attributes { get; set; }

        /// <summary>
        /// Gets or sets the child objects for this data object. This is a collection of collections.
        /// </summary>
        /// <value>Gets or sets the child objects for this data object. This is a collection of collections.</value>
        [DataMember(Name="childObjects", EmitDefaultValue=true)]
        public List<E3EAPIDataObjectModelsDataObjectLiteCollection> ChildObjects { get; set; }

        /// <summary>
        /// Gets or sets the error in the row level.
        /// </summary>
        /// <value>Gets or sets the error in the row level.</value>
        [DataMember(Name="error", EmitDefaultValue=true)]
        public E3EAPIDataDataError Error { get; set; }

        /// <summary>
        /// Gets or sets the index of the row.
        /// </summary>
        /// <value>Gets or sets the index of the row.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the row is checked out by another process.
        /// </summary>
        /// <value>Gets or sets a value indicating whether the row is checked out by another process.</value>
        [DataMember(Name="isLocked", EmitDefaultValue=false)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Gets or sets the message indicating whether the row is locked.
        /// </summary>
        /// <value>Gets or sets the message indicating whether the row is locked.</value>
        [DataMember(Name="lockedMessage", EmitDefaultValue=true)]
        public string LockedMessage { get; set; }

        /// <summary>
        /// Gets or sets the subclass id of this row.
        /// </summary>
        /// <value>Gets or sets the subclass id of this row.</value>
        [DataMember(Name="subclassId", EmitDefaultValue=true)]
        public string SubclassId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class E3EAPIClientModelsClient {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  DataState: ").Append(DataState).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ChildObjects: ").Append(ChildObjects).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  LockedMessage: ").Append(LockedMessage).Append("\n");
            sb.Append("  SubclassId: ").Append(SubclassId).Append("\n");
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
            return this.Equals(input as E3EAPIClientModelsClient);
        }

        /// <summary>
        /// Returns true if E3EAPIClientModelsClient instances are equal
        /// </summary>
        /// <param name="input">Instance of E3EAPIClientModelsClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(E3EAPIClientModelsClient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AccessType == input.AccessType ||
                    (this.AccessType != null &&
                    this.AccessType.Equals(input.AccessType))
                ) && 
                (
                    this.DataState == input.DataState ||
                    (this.DataState != null &&
                    this.DataState.Equals(input.DataState))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.ChildObjects == input.ChildObjects ||
                    this.ChildObjects != null &&
                    input.ChildObjects != null &&
                    this.ChildObjects.SequenceEqual(input.ChildObjects)
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.IsLocked == input.IsLocked ||
                    (this.IsLocked != null &&
                    this.IsLocked.Equals(input.IsLocked))
                ) && 
                (
                    this.LockedMessage == input.LockedMessage ||
                    (this.LockedMessage != null &&
                    this.LockedMessage.Equals(input.LockedMessage))
                ) && 
                (
                    this.SubclassId == input.SubclassId ||
                    (this.SubclassId != null &&
                    this.SubclassId.Equals(input.SubclassId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AccessType != null)
                    hashCode = hashCode * 59 + this.AccessType.GetHashCode();
                if (this.DataState != null)
                    hashCode = hashCode * 59 + this.DataState.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.ChildObjects != null)
                    hashCode = hashCode * 59 + this.ChildObjects.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.IsLocked != null)
                    hashCode = hashCode * 59 + this.IsLocked.GetHashCode();
                if (this.LockedMessage != null)
                    hashCode = hashCode * 59 + this.LockedMessage.GetHashCode();
                if (this.SubclassId != null)
                    hashCode = hashCode * 59 + this.SubclassId.GetHashCode();
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
