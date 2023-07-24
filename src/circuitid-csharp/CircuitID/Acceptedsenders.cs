/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!  # Clients  Discover the convenience of Circuit ID's readily available Client API libraries, enabling you to initiate seamless integration without delay. These pre-built libraries are designed for immediate use, empowering you to leverage the API's functionalities effortlessly. Get started with a Circuit ID&reg; Client library and streamline your development process today.  - <a href='https://github.com/circuitid/circuitid-node' target='_blank'>Node</a> - <a href='https://github.com/circuitid/circuitid-python' target='_blank'>Python</a> - <a href='https://github.com/circuitid/circuitid-java' target='_blank'>Java</a> - <a href='https://github.com/circuitid/circuitid-csharp' target='_blank'>C Sharp</a> - <a href='https://github.com/circuitid/circuitid-ruby' target='_blank'>Ruby</a> - <a href='https://github.com/circuitid/circuitid-go' target='_blank'>Go</a>
 *
 * The version of the OpenAPI document: 0.47.14
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
using OpenAPIDateConverter = circuitid-csharp.Client.OpenAPIDateConverter;

namespace circuitid-csharp.CircuitID
{
    /// <summary>
    /// Acceptedsenders
    /// </summary>
    [DataContract]
    public partial class Acceptedsenders :  IEquatable<Acceptedsenders>, IValidatableObject
    {
        /// <summary>
        /// Defines Ref
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefEnum
        {
            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            Users = users,

            /// <summary>
            /// Enum Domains for value: domains
            /// </summary>
            Domains = domains,

            /// <summary>
            /// Enum Contacts for value: contacts
            /// </summary>
            Contacts = contacts

        }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name="ref", EmitDefaultValue=true)]
        public RefEnum Ref { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Acceptedsenders" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Acceptedsenders() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Acceptedsenders" /> class.
        /// </summary>
        /// <param name="_object">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="service">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="serviceRef">serviceRef (required).</param>
        /// <param name="_ref">_ref (required).</param>
        public Acceptedsenders(Object _object = default(Object), Object service = default(Object), Object serviceRef = default(Object), RefEnum _ref = default(RefEnum))
        {
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new InvalidDataException("_object is a required property for Acceptedsenders and cannot be null");
            }
            else
            {
                this.Object = _object;
            }

            this.Object = _object;
            // to ensure "service" is required (not null)
            if (service == null)
            {
                throw new InvalidDataException("service is a required property for Acceptedsenders and cannot be null");
            }
            else
            {
                this.Service = service;
            }

            this.Service = service;
            // to ensure "serviceRef" is required (not null)
            if (serviceRef == null)
            {
                throw new InvalidDataException("serviceRef is a required property for Acceptedsenders and cannot be null");
            }
            else
            {
                this.ServiceRef = serviceRef;
            }

            this.ServiceRef = serviceRef;
            // to ensure "_ref" is required (not null)
            if (_ref == null)
            {
                throw new InvalidDataException("_ref is a required property for Acceptedsenders and cannot be null");
            }
            else
            {
                this.Ref = _ref;
            }

            this.Ref = _ref;
        }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="object", EmitDefaultValue=true)]
        public Object Object { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="service", EmitDefaultValue=true)]
        public Object Service { get; set; }

        /// <summary>
        /// Gets or Sets ServiceRef
        /// </summary>
        [DataMember(Name="serviceRef", EmitDefaultValue=true)]
        public Object ServiceRef { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Acceptedsenders {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  ServiceRef: ").Append(ServiceRef).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
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
            return this.Equals(input as Acceptedsenders);
        }

        /// <summary>
        /// Returns true if Acceptedsenders instances are equal
        /// </summary>
        /// <param name="input">Instance of Acceptedsenders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Acceptedsenders input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.ServiceRef == input.ServiceRef ||
                    (this.ServiceRef != null &&
                    this.ServiceRef.Equals(input.ServiceRef))
                ) && 
                (
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
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
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.ServiceRef != null)
                    hashCode = hashCode * 59 + this.ServiceRef.GetHashCode();
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
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
