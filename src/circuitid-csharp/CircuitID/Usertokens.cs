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
    /// Usertokens
    /// </summary>
    [DataContract]
    public partial class Usertokens :  IEquatable<Usertokens>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            _1 = 1,

            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            _0 = 0

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Usertokens" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Usertokens() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Usertokens" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="user">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="token">token (required).</param>
        /// <param name="expiresInYears">expiresInYears (required).</param>
        /// <param name="status">status.</param>
        public Usertokens(Object name = default(Object), Object user = default(Object), Object token = default(Object), Object expiresInYears = default(Object), StatusEnum? status = default(StatusEnum?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Usertokens and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Name = name;
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for Usertokens and cannot be null");
            }
            else
            {
                this.User = user;
            }

            this.User = user;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new InvalidDataException("token is a required property for Usertokens and cannot be null");
            }
            else
            {
                this.Token = token;
            }

            this.Token = token;
            // to ensure "expiresInYears" is required (not null)
            if (expiresInYears == null)
            {
                throw new InvalidDataException("expiresInYears is a required property for Usertokens and cannot be null");
            }
            else
            {
                this.ExpiresInYears = expiresInYears;
            }

            this.ExpiresInYears = expiresInYears;
            this.Status = status;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Object Name { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public Object User { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=true)]
        public Object Token { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresInYears
        /// </summary>
        [DataMember(Name="expiresInYears", EmitDefaultValue=true)]
        public Object ExpiresInYears { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Usertokens {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  ExpiresInYears: ").Append(ExpiresInYears).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Usertokens);
        }

        /// <summary>
        /// Returns true if Usertokens instances are equal
        /// </summary>
        /// <param name="input">Instance of Usertokens to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Usertokens input)
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
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.ExpiresInYears == input.ExpiresInYears ||
                    (this.ExpiresInYears != null &&
                    this.ExpiresInYears.Equals(input.ExpiresInYears))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.ExpiresInYears != null)
                    hashCode = hashCode * 59 + this.ExpiresInYears.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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


            // Token (Object) maxLength
            if(this.Token != null && this.Token.Length > 2048)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Token, length must be less than 2048.", new [] { "Token" });
            }


            yield break;
        }
    }

}
