/* 
 * Statistics Service
 *
 * Statistics Service
 *
 * OpenAPI spec version: 9.0.000.00.387
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Genesys.Internal.Statistics.Client.SwaggerDateConverter;

namespace Genesys.Internal.Statistics.Model
{
    /// <summary>
    /// PeekedStatistics
    /// </summary>
    [DataContract]
    public partial class PeekedStatistics :  IEquatable<PeekedStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeekedStatistics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PeekedStatistics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeekedStatistics" /> class.
        /// </summary>
        /// <param name="Statistics">Statistics (required).</param>
        public PeekedStatistics(List<PeekedStatisticValue> Statistics = default(List<PeekedStatisticValue>))
        {
            // to ensure "Statistics" is required (not null)
            if (Statistics == null)
            {
                throw new InvalidDataException("Statistics is a required property for PeekedStatistics and cannot be null");
            }
            else
            {
                this.Statistics = Statistics;
            }
        }
        
        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public List<PeekedStatisticValue> Statistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeekedStatistics {\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PeekedStatistics);
        }

        /// <summary>
        /// Returns true if PeekedStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of PeekedStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeekedStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Statistics == input.Statistics ||
                    this.Statistics != null &&
                    this.Statistics.SequenceEqual(input.Statistics)
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
                if (this.Statistics != null)
                    hashCode = hashCode * 59 + this.Statistics.GetHashCode();
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
