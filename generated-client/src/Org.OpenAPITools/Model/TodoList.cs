/*
 * Todo-Listenverwaltung API
 *
 * API zur Verwaltung von Todo-Listen und deren Einträgen
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: asad.saleem@gmx.de
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TodoList
    /// </summary>
    [DataContract(Name = "Todo-List")]
    public partial class TodoList : IEquatable<TodoList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoList" /> class.
        /// </summary>
        /// <param name="id">ID der Todo-Liste.</param>
        /// <param name="name">Name der Todo-Liste.</param>
        public TodoList(Guid id = default(Guid), string name = default(string))
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// ID der Todo-Liste
        /// </summary>
        /// <value>ID der Todo-Liste</value>
        /// <example>d78d4f14-ddcb-416d-a2d2-31d640dd4ccc</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Name der Todo-Liste
        /// </summary>
        /// <value>Name der Todo-Liste</value>
        /// <example>Einkaufsliste</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TodoList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as TodoList);
        }

        /// <summary>
        /// Returns true if TodoList instances are equal
        /// </summary>
        /// <param name="input">Instance of TodoList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TodoList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
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
