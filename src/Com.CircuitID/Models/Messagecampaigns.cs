/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.16
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
    /// Messagecampaigns
    /// </summary>
    [DataContract]
    public partial class Messagecampaigns :  IEquatable<Messagecampaigns>, IValidatableObject
    {
        /// <summary>
        /// Defines SubscriberOptin
        /// </summary>
        public enum SubscriberOptinEnum
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
        /// Gets or Sets SubscriberOptin
        /// </summary>
        [DataMember(Name="subscriberOptin", EmitDefaultValue=true)]
        public SubscriberOptinEnum? SubscriberOptin { get; set; }
        /// <summary>
        /// Defines SubscriberOptout
        /// </summary>
        public enum SubscriberOptoutEnum
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
        /// Gets or Sets SubscriberOptout
        /// </summary>
        [DataMember(Name="subscriberOptout", EmitDefaultValue=true)]
        public SubscriberOptoutEnum? SubscriberOptout { get; set; }
        /// <summary>
        /// Defines SubscriberHelp
        /// </summary>
        public enum SubscriberHelpEnum
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
        /// Gets or Sets SubscriberHelp
        /// </summary>
        [DataMember(Name="subscriberHelp", EmitDefaultValue=true)]
        public SubscriberHelpEnum? SubscriberHelp { get; set; }
        /// <summary>
        /// Defines NumberPool
        /// </summary>
        public enum NumberPoolEnum
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
        /// Gets or Sets NumberPool
        /// </summary>
        [DataMember(Name="numberPool", EmitDefaultValue=true)]
        public NumberPoolEnum? NumberPool { get; set; }
        /// <summary>
        /// Defines DirectLending
        /// </summary>
        public enum DirectLendingEnum
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
        /// Gets or Sets DirectLending
        /// </summary>
        [DataMember(Name="directLending", EmitDefaultValue=true)]
        public DirectLendingEnum? DirectLending { get; set; }
        /// <summary>
        /// Defines EmbeddedLink
        /// </summary>
        public enum EmbeddedLinkEnum
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
        /// Gets or Sets EmbeddedLink
        /// </summary>
        [DataMember(Name="embeddedLink", EmitDefaultValue=true)]
        public EmbeddedLinkEnum? EmbeddedLink { get; set; }
        /// <summary>
        /// Defines EmbeddedPhone
        /// </summary>
        public enum EmbeddedPhoneEnum
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
        /// Gets or Sets EmbeddedPhone
        /// </summary>
        [DataMember(Name="embeddedPhone", EmitDefaultValue=true)]
        public EmbeddedPhoneEnum? EmbeddedPhone { get; set; }
        /// <summary>
        /// Defines AffiliateMarketing
        /// </summary>
        public enum AffiliateMarketingEnum
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
        /// Gets or Sets AffiliateMarketing
        /// </summary>
        [DataMember(Name="affiliateMarketing", EmitDefaultValue=true)]
        public AffiliateMarketingEnum? AffiliateMarketing { get; set; }
        /// <summary>
        /// Defines AgeGated
        /// </summary>
        public enum AgeGatedEnum
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
        /// Gets or Sets AgeGated
        /// </summary>
        [DataMember(Name="ageGated", EmitDefaultValue=true)]
        public AgeGatedEnum? AgeGated { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Messagecampaigns" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Messagecampaigns() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Messagecampaigns" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="brandId">brandId (required).</param>
        /// <param name="order">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="subscriberOptin">subscriberOptin.</param>
        /// <param name="subscriberOptout">subscriberOptout.</param>
        /// <param name="subscriberHelp">subscriberHelp.</param>
        /// <param name="numberPool">numberPool.</param>
        /// <param name="directLending">directLending.</param>
        /// <param name="embeddedLink">embeddedLink.</param>
        /// <param name="embeddedPhone">embeddedPhone.</param>
        /// <param name="affiliateMarketing">affiliateMarketing.</param>
        /// <param name="ageGated">ageGated.</param>
        /// <param name="mnos">mnos.</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="useCase">useCase.</param>
        /// <param name="subUseCases">subUseCases.</param>
        /// <param name="sample1">sample1.</param>
        /// <param name="sample2">sample2.</param>
        /// <param name="sample3">sample3.</param>
        /// <param name="sample4">sample4.</param>
        /// <param name="sample5">sample5.</param>
        public Messagecampaigns(Object name = default(Object), Object campaignId = default(Object), Object brandId = default(Object), Object order = default(Object), SubscriberOptinEnum? subscriberOptin = default(SubscriberOptinEnum?), SubscriberOptoutEnum? subscriberOptout = default(SubscriberOptoutEnum?), SubscriberHelpEnum? subscriberHelp = default(SubscriberHelpEnum?), NumberPoolEnum? numberPool = default(NumberPoolEnum?), DirectLendingEnum? directLending = default(DirectLendingEnum?), EmbeddedLinkEnum? embeddedLink = default(EmbeddedLinkEnum?), EmbeddedPhoneEnum? embeddedPhone = default(EmbeddedPhoneEnum?), AffiliateMarketingEnum? affiliateMarketing = default(AffiliateMarketingEnum?), AgeGatedEnum? ageGated = default(AgeGatedEnum?), Object mnos = default(Object), Object referenceId = default(Object), Object useCase = default(Object), Object subUseCases = default(Object), Object sample1 = default(Object), Object sample2 = default(Object), Object sample3 = default(Object), Object sample4 = default(Object), Object sample5 = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Messagecampaigns and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Name = name;
            this.CampaignId = campaignId;
            // to ensure "brandId" is required (not null)
            if (brandId == null)
            {
                throw new InvalidDataException("brandId is a required property for Messagecampaigns and cannot be null");
            }
            else
            {
                this.BrandId = brandId;
            }

            this.BrandId = brandId;
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException("order is a required property for Messagecampaigns and cannot be null");
            }
            else
            {
                this.Order = order;
            }

            this.Order = order;
            this.SubscriberOptin = subscriberOptin;
            this.SubscriberOptout = subscriberOptout;
            this.SubscriberHelp = subscriberHelp;
            this.NumberPool = numberPool;
            this.DirectLending = directLending;
            this.EmbeddedLink = embeddedLink;
            this.EmbeddedPhone = embeddedPhone;
            this.AffiliateMarketing = affiliateMarketing;
            this.AgeGated = ageGated;
            this.Mnos = mnos;
            this.ReferenceId = referenceId;
            this.UseCase = useCase;
            this.SubUseCases = subUseCases;
            this.Sample1 = sample1;
            this.Sample2 = sample2;
            this.Sample3 = sample3;
            this.Sample4 = sample4;
            this.Sample5 = sample5;
            this.CampaignId = campaignId;
            this.SubscriberOptin = subscriberOptin;
            this.SubscriberOptout = subscriberOptout;
            this.SubscriberHelp = subscriberHelp;
            this.NumberPool = numberPool;
            this.DirectLending = directLending;
            this.EmbeddedLink = embeddedLink;
            this.EmbeddedPhone = embeddedPhone;
            this.AffiliateMarketing = affiliateMarketing;
            this.AgeGated = ageGated;
            this.Mnos = mnos;
            this.ReferenceId = referenceId;
            this.UseCase = useCase;
            this.SubUseCases = subUseCases;
            this.Sample1 = sample1;
            this.Sample2 = sample2;
            this.Sample3 = sample3;
            this.Sample4 = sample4;
            this.Sample5 = sample5;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Object Name { get; set; }

        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name="campaignId", EmitDefaultValue=true)]
        public Object CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets BrandId
        /// </summary>
        [DataMember(Name="brandId", EmitDefaultValue=true)]
        public Object BrandId { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="order", EmitDefaultValue=true)]
        public Object Order { get; set; }










        /// <summary>
        /// Gets or Sets Mnos
        /// </summary>
        [DataMember(Name="mnos", EmitDefaultValue=true)]
        public Object Mnos { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name="referenceId", EmitDefaultValue=true)]
        public Object ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets UseCase
        /// </summary>
        [DataMember(Name="useCase", EmitDefaultValue=true)]
        public Object UseCase { get; set; }

        /// <summary>
        /// Gets or Sets SubUseCases
        /// </summary>
        [DataMember(Name="subUseCases", EmitDefaultValue=true)]
        public Object SubUseCases { get; set; }

        /// <summary>
        /// Gets or Sets Sample1
        /// </summary>
        [DataMember(Name="sample1", EmitDefaultValue=true)]
        public Object Sample1 { get; set; }

        /// <summary>
        /// Gets or Sets Sample2
        /// </summary>
        [DataMember(Name="sample2", EmitDefaultValue=true)]
        public Object Sample2 { get; set; }

        /// <summary>
        /// Gets or Sets Sample3
        /// </summary>
        [DataMember(Name="sample3", EmitDefaultValue=true)]
        public Object Sample3 { get; set; }

        /// <summary>
        /// Gets or Sets Sample4
        /// </summary>
        [DataMember(Name="sample4", EmitDefaultValue=true)]
        public Object Sample4 { get; set; }

        /// <summary>
        /// Gets or Sets Sample5
        /// </summary>
        [DataMember(Name="sample5", EmitDefaultValue=true)]
        public Object Sample5 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Messagecampaigns {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  BrandId: ").Append(BrandId).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  SubscriberOptin: ").Append(SubscriberOptin).Append("\n");
            sb.Append("  SubscriberOptout: ").Append(SubscriberOptout).Append("\n");
            sb.Append("  SubscriberHelp: ").Append(SubscriberHelp).Append("\n");
            sb.Append("  NumberPool: ").Append(NumberPool).Append("\n");
            sb.Append("  DirectLending: ").Append(DirectLending).Append("\n");
            sb.Append("  EmbeddedLink: ").Append(EmbeddedLink).Append("\n");
            sb.Append("  EmbeddedPhone: ").Append(EmbeddedPhone).Append("\n");
            sb.Append("  AffiliateMarketing: ").Append(AffiliateMarketing).Append("\n");
            sb.Append("  AgeGated: ").Append(AgeGated).Append("\n");
            sb.Append("  Mnos: ").Append(Mnos).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  UseCase: ").Append(UseCase).Append("\n");
            sb.Append("  SubUseCases: ").Append(SubUseCases).Append("\n");
            sb.Append("  Sample1: ").Append(Sample1).Append("\n");
            sb.Append("  Sample2: ").Append(Sample2).Append("\n");
            sb.Append("  Sample3: ").Append(Sample3).Append("\n");
            sb.Append("  Sample4: ").Append(Sample4).Append("\n");
            sb.Append("  Sample5: ").Append(Sample5).Append("\n");
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
            return this.Equals(input as Messagecampaigns);
        }

        /// <summary>
        /// Returns true if Messagecampaigns instances are equal
        /// </summary>
        /// <param name="input">Instance of Messagecampaigns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Messagecampaigns input)
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
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.BrandId == input.BrandId ||
                    (this.BrandId != null &&
                    this.BrandId.Equals(input.BrandId))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.SubscriberOptin == input.SubscriberOptin ||
                    (this.SubscriberOptin != null &&
                    this.SubscriberOptin.Equals(input.SubscriberOptin))
                ) && 
                (
                    this.SubscriberOptout == input.SubscriberOptout ||
                    (this.SubscriberOptout != null &&
                    this.SubscriberOptout.Equals(input.SubscriberOptout))
                ) && 
                (
                    this.SubscriberHelp == input.SubscriberHelp ||
                    (this.SubscriberHelp != null &&
                    this.SubscriberHelp.Equals(input.SubscriberHelp))
                ) && 
                (
                    this.NumberPool == input.NumberPool ||
                    (this.NumberPool != null &&
                    this.NumberPool.Equals(input.NumberPool))
                ) && 
                (
                    this.DirectLending == input.DirectLending ||
                    (this.DirectLending != null &&
                    this.DirectLending.Equals(input.DirectLending))
                ) && 
                (
                    this.EmbeddedLink == input.EmbeddedLink ||
                    (this.EmbeddedLink != null &&
                    this.EmbeddedLink.Equals(input.EmbeddedLink))
                ) && 
                (
                    this.EmbeddedPhone == input.EmbeddedPhone ||
                    (this.EmbeddedPhone != null &&
                    this.EmbeddedPhone.Equals(input.EmbeddedPhone))
                ) && 
                (
                    this.AffiliateMarketing == input.AffiliateMarketing ||
                    (this.AffiliateMarketing != null &&
                    this.AffiliateMarketing.Equals(input.AffiliateMarketing))
                ) && 
                (
                    this.AgeGated == input.AgeGated ||
                    (this.AgeGated != null &&
                    this.AgeGated.Equals(input.AgeGated))
                ) && 
                (
                    this.Mnos == input.Mnos ||
                    (this.Mnos != null &&
                    this.Mnos.Equals(input.Mnos))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.UseCase == input.UseCase ||
                    (this.UseCase != null &&
                    this.UseCase.Equals(input.UseCase))
                ) && 
                (
                    this.SubUseCases == input.SubUseCases ||
                    (this.SubUseCases != null &&
                    this.SubUseCases.Equals(input.SubUseCases))
                ) && 
                (
                    this.Sample1 == input.Sample1 ||
                    (this.Sample1 != null &&
                    this.Sample1.Equals(input.Sample1))
                ) && 
                (
                    this.Sample2 == input.Sample2 ||
                    (this.Sample2 != null &&
                    this.Sample2.Equals(input.Sample2))
                ) && 
                (
                    this.Sample3 == input.Sample3 ||
                    (this.Sample3 != null &&
                    this.Sample3.Equals(input.Sample3))
                ) && 
                (
                    this.Sample4 == input.Sample4 ||
                    (this.Sample4 != null &&
                    this.Sample4.Equals(input.Sample4))
                ) && 
                (
                    this.Sample5 == input.Sample5 ||
                    (this.Sample5 != null &&
                    this.Sample5.Equals(input.Sample5))
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
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.BrandId != null)
                    hashCode = hashCode * 59 + this.BrandId.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.SubscriberOptin != null)
                    hashCode = hashCode * 59 + this.SubscriberOptin.GetHashCode();
                if (this.SubscriberOptout != null)
                    hashCode = hashCode * 59 + this.SubscriberOptout.GetHashCode();
                if (this.SubscriberHelp != null)
                    hashCode = hashCode * 59 + this.SubscriberHelp.GetHashCode();
                if (this.NumberPool != null)
                    hashCode = hashCode * 59 + this.NumberPool.GetHashCode();
                if (this.DirectLending != null)
                    hashCode = hashCode * 59 + this.DirectLending.GetHashCode();
                if (this.EmbeddedLink != null)
                    hashCode = hashCode * 59 + this.EmbeddedLink.GetHashCode();
                if (this.EmbeddedPhone != null)
                    hashCode = hashCode * 59 + this.EmbeddedPhone.GetHashCode();
                if (this.AffiliateMarketing != null)
                    hashCode = hashCode * 59 + this.AffiliateMarketing.GetHashCode();
                if (this.AgeGated != null)
                    hashCode = hashCode * 59 + this.AgeGated.GetHashCode();
                if (this.Mnos != null)
                    hashCode = hashCode * 59 + this.Mnos.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.UseCase != null)
                    hashCode = hashCode * 59 + this.UseCase.GetHashCode();
                if (this.SubUseCases != null)
                    hashCode = hashCode * 59 + this.SubUseCases.GetHashCode();
                if (this.Sample1 != null)
                    hashCode = hashCode * 59 + this.Sample1.GetHashCode();
                if (this.Sample2 != null)
                    hashCode = hashCode * 59 + this.Sample2.GetHashCode();
                if (this.Sample3 != null)
                    hashCode = hashCode * 59 + this.Sample3.GetHashCode();
                if (this.Sample4 != null)
                    hashCode = hashCode * 59 + this.Sample4.GetHashCode();
                if (this.Sample5 != null)
                    hashCode = hashCode * 59 + this.Sample5.GetHashCode();
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


            // CampaignId (Object) maxLength
            if(this.CampaignId != null && this.CampaignId.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CampaignId, length must be less than 45.", new [] { "CampaignId" });
            }


            // BrandId (Object) maxLength
            if(this.BrandId != null && this.BrandId.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BrandId, length must be less than 45.", new [] { "BrandId" });
            }


            // ReferenceId (Object) maxLength
            if(this.ReferenceId != null && this.ReferenceId.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceId, length must be less than 45.", new [] { "ReferenceId" });
            }


            // UseCase (Object) maxLength
            if(this.UseCase != null && this.UseCase.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UseCase, length must be less than 45.", new [] { "UseCase" });
            }


            // Sample1 (Object) maxLength
            if(this.Sample1 != null && this.Sample1.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sample1, length must be less than 255.", new [] { "Sample1" });
            }


            // Sample2 (Object) maxLength
            if(this.Sample2 != null && this.Sample2.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sample2, length must be less than 255.", new [] { "Sample2" });
            }


            // Sample3 (Object) maxLength
            if(this.Sample3 != null && this.Sample3.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sample3, length must be less than 255.", new [] { "Sample3" });
            }


            // Sample4 (Object) maxLength
            if(this.Sample4 != null && this.Sample4.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sample4, length must be less than 255.", new [] { "Sample4" });
            }


            // Sample5 (Object) maxLength
            if(this.Sample5 != null && this.Sample5.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sample5, length must be less than 255.", new [] { "Sample5" });
            }


            yield break;
        }
    }

}
