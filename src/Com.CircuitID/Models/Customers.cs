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
    /// Customers
    /// </summary>
    [DataContract]
    public partial class Customers :  IEquatable<Customers>, IValidatableObject
    {
        /// <summary>
        /// Defines InternationalCalling
        /// </summary>
        public enum InternationalCallingEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0

        }

        /// <summary>
        /// Gets or Sets InternationalCalling
        /// </summary>
        [DataMember(Name="internationalCalling", EmitDefaultValue=false)]
        public InternationalCallingEnum? InternationalCalling { get; set; }
        /// <summary>
        /// Defines MediaBypass
        /// </summary>
        public enum MediaBypassEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0

        }

        /// <summary>
        /// Gets or Sets MediaBypass
        /// </summary>
        [DataMember(Name="mediaBypass", EmitDefaultValue=false)]
        public MediaBypassEnum? MediaBypass { get; set; }
        /// <summary>
        /// Defines AccountLock
        /// </summary>
        public enum AccountLockEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0

        }

        /// <summary>
        /// Gets or Sets AccountLock
        /// </summary>
        [DataMember(Name="accountLock", EmitDefaultValue=false)]
        public AccountLockEnum? AccountLock { get; set; }
        /// <summary>
        /// Defines CallRecording
        /// </summary>
        public enum CallRecordingEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0

        }

        /// <summary>
        /// Gets or Sets CallRecording
        /// </summary>
        [DataMember(Name="callRecording", EmitDefaultValue=false)]
        public CallRecordingEnum? CallRecording { get; set; }
        /// <summary>
        /// Defines CnamLookUps
        /// </summary>
        public enum CnamLookUpsEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0

        }

        /// <summary>
        /// Gets or Sets CnamLookUps
        /// </summary>
        [DataMember(Name="cnamLookUps", EmitDefaultValue=false)]
        public CnamLookUpsEnum? CnamLookUps { get; set; }
        /// <summary>
        /// Defines HoldMusic
        /// </summary>
        public enum HoldMusicEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0

        }

        /// <summary>
        /// Gets or Sets HoldMusic
        /// </summary>
        [DataMember(Name="holdMusic", EmitDefaultValue=false)]
        public HoldMusicEnum? HoldMusic { get; set; }
        /// <summary>
        /// Defines TranscribeCalls
        /// </summary>
        public enum TranscribeCallsEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0

        }

        /// <summary>
        /// Gets or Sets TranscribeCalls
        /// </summary>
        [DataMember(Name="transcribeCalls", EmitDefaultValue=false)]
        public TranscribeCallsEnum? TranscribeCalls { get; set; }
        /// <summary>
        /// Defines DefaultBillMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DefaultBillMethodEnum
        {
            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 1,

            /// <summary>
            /// Enum Paymentmethod for value: paymentmethod
            /// </summary>
            [EnumMember(Value = "paymentmethod")]
            Paymentmethod = 2

        }

        /// <summary>
        /// Gets or Sets DefaultBillMethod
        /// </summary>
        [DataMember(Name="defaultBillMethod", EmitDefaultValue=true)]
        public DefaultBillMethodEnum DefaultBillMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Customers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Customers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Customers" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="websiteUrl">websiteUrl.</param>
        /// <param name="logo">logo.</param>
        /// <param name="credit">credit (default to 0).</param>
        /// <param name="adminUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="billingUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="callRecordingUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="supportUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="automaticRefillAmount">automaticRefillAmount (default to 0).</param>
        /// <param name="lowBalanceAlertAmount">lowBalanceAlertAmount (default to 0).</param>
        /// <param name="internationalCalling">internationalCalling (default to InternationalCallingEnum.NUMBER_0).</param>
        /// <param name="createdByIP">createdByIP.</param>
        /// <param name="mediaBypass">mediaBypass (default to MediaBypassEnum.NUMBER_0).</param>
        /// <param name="accountLock">accountLock (default to AccountLockEnum.NUMBER_1).</param>
        /// <param name="callRecording">callRecording (default to CallRecordingEnum.NUMBER_0).</param>
        /// <param name="cdrRetention">cdrRetention (default to 12).</param>
        /// <param name="cnamLookUps">cnamLookUps (default to CnamLookUpsEnum.NUMBER_0).</param>
        /// <param name="holdMusic">holdMusic (default to HoldMusicEnum.NUMBER_0).</param>
        /// <param name="transcribeCalls">transcribeCalls.</param>
        /// <param name="maxOutboundCallRate">maxOutboundCallRate (default to 1).</param>
        /// <param name="defaultBillMethod">defaultBillMethod (required) (default to DefaultBillMethodEnum.Credit).</param>
        public Customers(string name = default(string), string websiteUrl = default(string), string logo = default(string), int credit = 0, string adminUserId = default(string), string billingUserId = default(string), string callRecordingUserId = default(string), string supportUserId = default(string), int automaticRefillAmount = 0, int lowBalanceAlertAmount = 0, InternationalCallingEnum? internationalCalling = InternationalCallingEnum.NUMBER_0, string createdByIP = default(string), MediaBypassEnum? mediaBypass = MediaBypassEnum.NUMBER_0, AccountLockEnum? accountLock = AccountLockEnum.NUMBER_1, CallRecordingEnum? callRecording = CallRecordingEnum.NUMBER_0, int cdrRetention = 12, CnamLookUpsEnum? cnamLookUps = CnamLookUpsEnum.NUMBER_0, HoldMusicEnum? holdMusic = HoldMusicEnum.NUMBER_0, TranscribeCallsEnum? transcribeCalls = default(TranscribeCallsEnum?), int maxOutboundCallRate = 1, DefaultBillMethodEnum defaultBillMethod = DefaultBillMethodEnum.Credit)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Customers and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "defaultBillMethod" is required (not null)
            if (defaultBillMethod == null)
            {
                throw new InvalidDataException("defaultBillMethod is a required property for Customers and cannot be null");
            }
            else
            {
                this.DefaultBillMethod = defaultBillMethod;
            }

            this.WebsiteUrl = websiteUrl;
            this.Logo = logo;
            // use default value if no "credit" provided
            if (credit == null)
            {
                this.Credit = 0;
            }
            else
            {
                this.Credit = credit;
            }
            this.AdminUserId = adminUserId;
            this.BillingUserId = billingUserId;
            this.CallRecordingUserId = callRecordingUserId;
            this.SupportUserId = supportUserId;
            // use default value if no "automaticRefillAmount" provided
            if (automaticRefillAmount == null)
            {
                this.AutomaticRefillAmount = 0;
            }
            else
            {
                this.AutomaticRefillAmount = automaticRefillAmount;
            }
            // use default value if no "lowBalanceAlertAmount" provided
            if (lowBalanceAlertAmount == null)
            {
                this.LowBalanceAlertAmount = 0;
            }
            else
            {
                this.LowBalanceAlertAmount = lowBalanceAlertAmount;
            }
            // use default value if no "internationalCalling" provided
            if (internationalCalling == null)
            {
                this.InternationalCalling = InternationalCallingEnum.NUMBER_0;
            }
            else
            {
                this.InternationalCalling = internationalCalling;
            }
            this.CreatedByIP = createdByIP;
            // use default value if no "mediaBypass" provided
            if (mediaBypass == null)
            {
                this.MediaBypass = MediaBypassEnum.NUMBER_0;
            }
            else
            {
                this.MediaBypass = mediaBypass;
            }
            // use default value if no "accountLock" provided
            if (accountLock == null)
            {
                this.AccountLock = AccountLockEnum.NUMBER_1;
            }
            else
            {
                this.AccountLock = accountLock;
            }
            // use default value if no "callRecording" provided
            if (callRecording == null)
            {
                this.CallRecording = CallRecordingEnum.NUMBER_0;
            }
            else
            {
                this.CallRecording = callRecording;
            }
            // use default value if no "cdrRetention" provided
            if (cdrRetention == null)
            {
                this.CdrRetention = 12;
            }
            else
            {
                this.CdrRetention = cdrRetention;
            }
            // use default value if no "cnamLookUps" provided
            if (cnamLookUps == null)
            {
                this.CnamLookUps = CnamLookUpsEnum.NUMBER_0;
            }
            else
            {
                this.CnamLookUps = cnamLookUps;
            }
            // use default value if no "holdMusic" provided
            if (holdMusic == null)
            {
                this.HoldMusic = HoldMusicEnum.NUMBER_0;
            }
            else
            {
                this.HoldMusic = holdMusic;
            }
            this.TranscribeCalls = transcribeCalls;
            // use default value if no "maxOutboundCallRate" provided
            if (maxOutboundCallRate == null)
            {
                this.MaxOutboundCallRate = 1;
            }
            else
            {
                this.MaxOutboundCallRate = maxOutboundCallRate;
            }
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets WebsiteUrl
        /// </summary>
        [DataMember(Name="websiteUrl", EmitDefaultValue=false)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// Gets or Sets Credit
        /// </summary>
        [DataMember(Name="credit", EmitDefaultValue=false)]
        public int Credit { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="adminUserId", EmitDefaultValue=false)]
        public string AdminUserId { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="billingUserId", EmitDefaultValue=false)]
        public string BillingUserId { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="callRecordingUserId", EmitDefaultValue=false)]
        public string CallRecordingUserId { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="supportUserId", EmitDefaultValue=false)]
        public string SupportUserId { get; set; }

        /// <summary>
        /// Gets or Sets AutomaticRefillAmount
        /// </summary>
        [DataMember(Name="automaticRefillAmount", EmitDefaultValue=false)]
        public int AutomaticRefillAmount { get; set; }

        /// <summary>
        /// Gets or Sets LowBalanceAlertAmount
        /// </summary>
        [DataMember(Name="lowBalanceAlertAmount", EmitDefaultValue=false)]
        public int LowBalanceAlertAmount { get; set; }


        /// <summary>
        /// Gets or Sets CreatedByIP
        /// </summary>
        [DataMember(Name="createdByIP", EmitDefaultValue=false)]
        public string CreatedByIP { get; set; }




        /// <summary>
        /// Gets or Sets CdrRetention
        /// </summary>
        [DataMember(Name="cdrRetention", EmitDefaultValue=false)]
        public int CdrRetention { get; set; }




        /// <summary>
        /// Gets or Sets MaxOutboundCallRate
        /// </summary>
        [DataMember(Name="maxOutboundCallRate", EmitDefaultValue=false)]
        public int MaxOutboundCallRate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Customers {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  AdminUserId: ").Append(AdminUserId).Append("\n");
            sb.Append("  BillingUserId: ").Append(BillingUserId).Append("\n");
            sb.Append("  CallRecordingUserId: ").Append(CallRecordingUserId).Append("\n");
            sb.Append("  SupportUserId: ").Append(SupportUserId).Append("\n");
            sb.Append("  AutomaticRefillAmount: ").Append(AutomaticRefillAmount).Append("\n");
            sb.Append("  LowBalanceAlertAmount: ").Append(LowBalanceAlertAmount).Append("\n");
            sb.Append("  InternationalCalling: ").Append(InternationalCalling).Append("\n");
            sb.Append("  CreatedByIP: ").Append(CreatedByIP).Append("\n");
            sb.Append("  MediaBypass: ").Append(MediaBypass).Append("\n");
            sb.Append("  AccountLock: ").Append(AccountLock).Append("\n");
            sb.Append("  CallRecording: ").Append(CallRecording).Append("\n");
            sb.Append("  CdrRetention: ").Append(CdrRetention).Append("\n");
            sb.Append("  CnamLookUps: ").Append(CnamLookUps).Append("\n");
            sb.Append("  HoldMusic: ").Append(HoldMusic).Append("\n");
            sb.Append("  TranscribeCalls: ").Append(TranscribeCalls).Append("\n");
            sb.Append("  MaxOutboundCallRate: ").Append(MaxOutboundCallRate).Append("\n");
            sb.Append("  DefaultBillMethod: ").Append(DefaultBillMethod).Append("\n");
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
            return this.Equals(input as Customers);
        }

        /// <summary>
        /// Returns true if Customers instances are equal
        /// </summary>
        /// <param name="input">Instance of Customers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Customers input)
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
                    this.WebsiteUrl == input.WebsiteUrl ||
                    (this.WebsiteUrl != null &&
                    this.WebsiteUrl.Equals(input.WebsiteUrl))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.Credit == input.Credit ||
                    (this.Credit != null &&
                    this.Credit.Equals(input.Credit))
                ) && 
                (
                    this.AdminUserId == input.AdminUserId ||
                    (this.AdminUserId != null &&
                    this.AdminUserId.Equals(input.AdminUserId))
                ) && 
                (
                    this.BillingUserId == input.BillingUserId ||
                    (this.BillingUserId != null &&
                    this.BillingUserId.Equals(input.BillingUserId))
                ) && 
                (
                    this.CallRecordingUserId == input.CallRecordingUserId ||
                    (this.CallRecordingUserId != null &&
                    this.CallRecordingUserId.Equals(input.CallRecordingUserId))
                ) && 
                (
                    this.SupportUserId == input.SupportUserId ||
                    (this.SupportUserId != null &&
                    this.SupportUserId.Equals(input.SupportUserId))
                ) && 
                (
                    this.AutomaticRefillAmount == input.AutomaticRefillAmount ||
                    (this.AutomaticRefillAmount != null &&
                    this.AutomaticRefillAmount.Equals(input.AutomaticRefillAmount))
                ) && 
                (
                    this.LowBalanceAlertAmount == input.LowBalanceAlertAmount ||
                    (this.LowBalanceAlertAmount != null &&
                    this.LowBalanceAlertAmount.Equals(input.LowBalanceAlertAmount))
                ) && 
                (
                    this.InternationalCalling == input.InternationalCalling ||
                    (this.InternationalCalling != null &&
                    this.InternationalCalling.Equals(input.InternationalCalling))
                ) && 
                (
                    this.CreatedByIP == input.CreatedByIP ||
                    (this.CreatedByIP != null &&
                    this.CreatedByIP.Equals(input.CreatedByIP))
                ) && 
                (
                    this.MediaBypass == input.MediaBypass ||
                    (this.MediaBypass != null &&
                    this.MediaBypass.Equals(input.MediaBypass))
                ) && 
                (
                    this.AccountLock == input.AccountLock ||
                    (this.AccountLock != null &&
                    this.AccountLock.Equals(input.AccountLock))
                ) && 
                (
                    this.CallRecording == input.CallRecording ||
                    (this.CallRecording != null &&
                    this.CallRecording.Equals(input.CallRecording))
                ) && 
                (
                    this.CdrRetention == input.CdrRetention ||
                    (this.CdrRetention != null &&
                    this.CdrRetention.Equals(input.CdrRetention))
                ) && 
                (
                    this.CnamLookUps == input.CnamLookUps ||
                    (this.CnamLookUps != null &&
                    this.CnamLookUps.Equals(input.CnamLookUps))
                ) && 
                (
                    this.HoldMusic == input.HoldMusic ||
                    (this.HoldMusic != null &&
                    this.HoldMusic.Equals(input.HoldMusic))
                ) && 
                (
                    this.TranscribeCalls == input.TranscribeCalls ||
                    (this.TranscribeCalls != null &&
                    this.TranscribeCalls.Equals(input.TranscribeCalls))
                ) && 
                (
                    this.MaxOutboundCallRate == input.MaxOutboundCallRate ||
                    (this.MaxOutboundCallRate != null &&
                    this.MaxOutboundCallRate.Equals(input.MaxOutboundCallRate))
                ) && 
                (
                    this.DefaultBillMethod == input.DefaultBillMethod ||
                    (this.DefaultBillMethod != null &&
                    this.DefaultBillMethod.Equals(input.DefaultBillMethod))
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
                if (this.WebsiteUrl != null)
                    hashCode = hashCode * 59 + this.WebsiteUrl.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.Credit != null)
                    hashCode = hashCode * 59 + this.Credit.GetHashCode();
                if (this.AdminUserId != null)
                    hashCode = hashCode * 59 + this.AdminUserId.GetHashCode();
                if (this.BillingUserId != null)
                    hashCode = hashCode * 59 + this.BillingUserId.GetHashCode();
                if (this.CallRecordingUserId != null)
                    hashCode = hashCode * 59 + this.CallRecordingUserId.GetHashCode();
                if (this.SupportUserId != null)
                    hashCode = hashCode * 59 + this.SupportUserId.GetHashCode();
                if (this.AutomaticRefillAmount != null)
                    hashCode = hashCode * 59 + this.AutomaticRefillAmount.GetHashCode();
                if (this.LowBalanceAlertAmount != null)
                    hashCode = hashCode * 59 + this.LowBalanceAlertAmount.GetHashCode();
                if (this.InternationalCalling != null)
                    hashCode = hashCode * 59 + this.InternationalCalling.GetHashCode();
                if (this.CreatedByIP != null)
                    hashCode = hashCode * 59 + this.CreatedByIP.GetHashCode();
                if (this.MediaBypass != null)
                    hashCode = hashCode * 59 + this.MediaBypass.GetHashCode();
                if (this.AccountLock != null)
                    hashCode = hashCode * 59 + this.AccountLock.GetHashCode();
                if (this.CallRecording != null)
                    hashCode = hashCode * 59 + this.CallRecording.GetHashCode();
                if (this.CdrRetention != null)
                    hashCode = hashCode * 59 + this.CdrRetention.GetHashCode();
                if (this.CnamLookUps != null)
                    hashCode = hashCode * 59 + this.CnamLookUps.GetHashCode();
                if (this.HoldMusic != null)
                    hashCode = hashCode * 59 + this.HoldMusic.GetHashCode();
                if (this.TranscribeCalls != null)
                    hashCode = hashCode * 59 + this.TranscribeCalls.GetHashCode();
                if (this.MaxOutboundCallRate != null)
                    hashCode = hashCode * 59 + this.MaxOutboundCallRate.GetHashCode();
                if (this.DefaultBillMethod != null)
                    hashCode = hashCode * 59 + this.DefaultBillMethod.GetHashCode();
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


            // WebsiteUrl (string) maxLength
            if(this.WebsiteUrl != null && this.WebsiteUrl.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebsiteUrl, length must be less than 255.", new [] { "WebsiteUrl" });
            }


            // Logo (string) maxLength
            if(this.Logo != null && this.Logo.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Logo, length must be less than 255.", new [] { "Logo" });
            }


            // CreatedByIP (string) maxLength
            if(this.CreatedByIP != null && this.CreatedByIP.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedByIP, length must be less than 45.", new [] { "CreatedByIP" });
            }

            // CreatedByIP (string) minLength
            if(this.CreatedByIP != null && this.CreatedByIP.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedByIP, length must be greater than 8.", new [] { "CreatedByIP" });
            }

            yield break;
        }
    }

}
