/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.20
 * Contact: support@circuitid.com
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
using OpenAPIDateConverter = Com.CircuitID.Client.OpenAPIDateConverter;

namespace Com.CircuitID.Models
{
    /// <summary>
    /// Ratecenters
    /// </summary>
    [DataContract]
    public partial class Ratecenters :  IEquatable<Ratecenters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ratecenters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Ratecenters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ratecenters" /> class.
        /// </summary>
        /// <param name="npa">npa (required).</param>
        /// <param name="nxx">nxx (required).</param>
        /// <param name="lata">lata (required).</param>
        /// <param name="locState">locState (required).</param>
        /// <param name="rcAbbre">rcAbbre (required).</param>
        public Ratecenters(string npa = default(string), string nxx = default(string), string lata = default(string), string locState = default(string), string rcAbbre = default(string))
        {
            // to ensure "npa" is required (not null)
            if (npa == null)
            {
                throw new InvalidDataException("npa is a required property for Ratecenters and cannot be null");
            }
            else
            {
                this.Npa = npa;
            }

            // to ensure "nxx" is required (not null)
            if (nxx == null)
            {
                throw new InvalidDataException("nxx is a required property for Ratecenters and cannot be null");
            }
            else
            {
                this.Nxx = nxx;
            }

            // to ensure "lata" is required (not null)
            if (lata == null)
            {
                throw new InvalidDataException("lata is a required property for Ratecenters and cannot be null");
            }
            else
            {
                this.Lata = lata;
            }

            // to ensure "locState" is required (not null)
            if (locState == null)
            {
                throw new InvalidDataException("locState is a required property for Ratecenters and cannot be null");
            }
            else
            {
                this.LocState = locState;
            }

            // to ensure "rcAbbre" is required (not null)
            if (rcAbbre == null)
            {
                throw new InvalidDataException("rcAbbre is a required property for Ratecenters and cannot be null");
            }
            else
            {
                this.RcAbbre = rcAbbre;
            }

        }

        /// <summary>
        /// Gets or Sets Npa
        /// </summary>
        [DataMember(Name="npa", EmitDefaultValue=true)]
        public string Npa { get; set; }

        /// <summary>
        /// Gets or Sets Nxx
        /// </summary>
        [DataMember(Name="nxx", EmitDefaultValue=true)]
        public string Nxx { get; set; }

        /// <summary>
        /// Gets or Sets Lata
        /// </summary>
        [DataMember(Name="lata", EmitDefaultValue=true)]
        public string Lata { get; set; }

        /// <summary>
        /// Gets or Sets LocState
        /// </summary>
        [DataMember(Name="locState", EmitDefaultValue=true)]
        public string LocState { get; set; }

        /// <summary>
        /// Gets or Sets RcAbbre
        /// </summary>
        [DataMember(Name="rcAbbre", EmitDefaultValue=true)]
        public string RcAbbre { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ratecenters {\n");
            sb.Append("  Npa: ").Append(Npa).Append("\n");
            sb.Append("  Nxx: ").Append(Nxx).Append("\n");
            sb.Append("  Lata: ").Append(Lata).Append("\n");
            sb.Append("  LocState: ").Append(LocState).Append("\n");
            sb.Append("  RcAbbre: ").Append(RcAbbre).Append("\n");
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
            return this.Equals(input as Ratecenters);
        }

        /// <summary>
        /// Returns true if Ratecenters instances are equal
        /// </summary>
        /// <param name="input">Instance of Ratecenters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ratecenters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Npa == input.Npa ||
                    (this.Npa != null &&
                    this.Npa.Equals(input.Npa))
                ) && 
                (
                    this.Nxx == input.Nxx ||
                    (this.Nxx != null &&
                    this.Nxx.Equals(input.Nxx))
                ) && 
                (
                    this.Lata == input.Lata ||
                    (this.Lata != null &&
                    this.Lata.Equals(input.Lata))
                ) && 
                (
                    this.LocState == input.LocState ||
                    (this.LocState != null &&
                    this.LocState.Equals(input.LocState))
                ) && 
                (
                    this.RcAbbre == input.RcAbbre ||
                    (this.RcAbbre != null &&
                    this.RcAbbre.Equals(input.RcAbbre))
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
                if (this.Npa != null)
                    hashCode = hashCode * 59 + this.Npa.GetHashCode();
                if (this.Nxx != null)
                    hashCode = hashCode * 59 + this.Nxx.GetHashCode();
                if (this.Lata != null)
                    hashCode = hashCode * 59 + this.Lata.GetHashCode();
                if (this.LocState != null)
                    hashCode = hashCode * 59 + this.LocState.GetHashCode();
                if (this.RcAbbre != null)
                    hashCode = hashCode * 59 + this.RcAbbre.GetHashCode();
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
            // Npa (string) maxLength
            if(this.Npa != null && this.Npa.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Npa, length must be less than 3.", new [] { "Npa" });
            }

            // Npa (string) minLength
            if(this.Npa != null && this.Npa.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Npa, length must be greater than 3.", new [] { "Npa" });
            }

            // Nxx (string) maxLength
            if(this.Nxx != null && this.Nxx.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nxx, length must be less than 3.", new [] { "Nxx" });
            }

            // Nxx (string) minLength
            if(this.Nxx != null && this.Nxx.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nxx, length must be greater than 3.", new [] { "Nxx" });
            }

            // Lata (string) maxLength
            if(this.Lata != null && this.Lata.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Lata, length must be less than 3.", new [] { "Lata" });
            }

            // Lata (string) minLength
            if(this.Lata != null && this.Lata.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Lata, length must be greater than 3.", new [] { "Lata" });
            }

            // LocState (string) maxLength
            if(this.LocState != null && this.LocState.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocState, length must be less than 2.", new [] { "LocState" });
            }

            // LocState (string) minLength
            if(this.LocState != null && this.LocState.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocState, length must be greater than 2.", new [] { "LocState" });
            }

            // RcAbbre (string) maxLength
            if(this.RcAbbre != null && this.RcAbbre.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RcAbbre, length must be less than 45.", new [] { "RcAbbre" });
            }


            yield break;
        }
    }

}
