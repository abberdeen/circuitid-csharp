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
    /// Virtualextensions
    /// </summary>
    [DataContract]
    public partial class Virtualextensions :  IEquatable<Virtualextensions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Virtualextensions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Virtualextensions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Virtualextensions" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="extension">extension (required).</param>
        /// <param name="phoneinboundrule">ObjectId (unique 12 bytes ID).</param>
        public Virtualextensions(Object name = default(Object), Object extension = default(Object), Object phoneinboundrule = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Virtualextensions and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Name = name;
            // to ensure "extension" is required (not null)
            if (extension == null)
            {
                throw new InvalidDataException("extension is a required property for Virtualextensions and cannot be null");
            }
            else
            {
                this.Extension = extension;
            }

            this.Extension = extension;
            this.Phoneinboundrule = phoneinboundrule;
            this.Phoneinboundrule = phoneinboundrule;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Object Name { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=true)]
        public Object Extension { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="phoneinboundrule", EmitDefaultValue=true)]
        public Object Phoneinboundrule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Virtualextensions {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Phoneinboundrule: ").Append(Phoneinboundrule).Append("\n");
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
            return this.Equals(input as Virtualextensions);
        }

        /// <summary>
        /// Returns true if Virtualextensions instances are equal
        /// </summary>
        /// <param name="input">Instance of Virtualextensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Virtualextensions input)
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
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Phoneinboundrule == input.Phoneinboundrule ||
                    (this.Phoneinboundrule != null &&
                    this.Phoneinboundrule.Equals(input.Phoneinboundrule))
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
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.Phoneinboundrule != null)
                    hashCode = hashCode * 59 + this.Phoneinboundrule.GetHashCode();
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
            // Name (Object) maxLength
            if(this.Name != null && this.Name.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 45.", new [] { "Name" });
            }


            yield break;
        }
    }

}
