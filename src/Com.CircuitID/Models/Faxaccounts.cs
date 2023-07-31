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
    /// Faxaccounts
    /// </summary>
    [DataContract]
    public partial class Faxaccounts :  IEquatable<Faxaccounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Faxaccounts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Faxaccounts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Faxaccounts" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="order">ObjectId (unique 12 bytes ID).</param>
        /// <param name="inboundNotification">ObjectId (unique 12 bytes ID).</param>
        /// <param name="outboundNotification">ObjectId (unique 12 bytes ID).</param>
        /// <param name="number">ObjectId (unique 12 bytes ID).</param>
        public Faxaccounts(string name = default(string), string order = default(string), string inboundNotification = default(string), string outboundNotification = default(string), string number = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Faxaccounts and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Order = order;
            this.InboundNotification = inboundNotification;
            this.OutboundNotification = outboundNotification;
            this.Number = number;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="inboundNotification", EmitDefaultValue=false)]
        public string InboundNotification { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="outboundNotification", EmitDefaultValue=false)]
        public string OutboundNotification { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Faxaccounts {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  InboundNotification: ").Append(InboundNotification).Append("\n");
            sb.Append("  OutboundNotification: ").Append(OutboundNotification).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as Faxaccounts);
        }

        /// <summary>
        /// Returns true if Faxaccounts instances are equal
        /// </summary>
        /// <param name="input">Instance of Faxaccounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Faxaccounts input)
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
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.InboundNotification == input.InboundNotification ||
                    (this.InboundNotification != null &&
                    this.InboundNotification.Equals(input.InboundNotification))
                ) && 
                (
                    this.OutboundNotification == input.OutboundNotification ||
                    (this.OutboundNotification != null &&
                    this.OutboundNotification.Equals(input.OutboundNotification))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.InboundNotification != null)
                    hashCode = hashCode * 59 + this.InboundNotification.GetHashCode();
                if (this.OutboundNotification != null)
                    hashCode = hashCode * 59 + this.OutboundNotification.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 45.", new [] { "Name" });
            }


            yield break;
        }
    }

}
