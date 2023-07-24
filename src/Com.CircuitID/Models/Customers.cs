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
    /// Customers
    /// </summary>
    [DataContract]
    public partial class Customers :  IEquatable<Customers>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            Active = active,

            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            Suspended = suspended,

            /// <summary>
            /// Enum Terminated for value: terminated
            /// </summary>
            Terminated = terminated,

            /// <summary>
            /// Enum Fraud for value: fraud
            /// </summary>
            Fraud = fraud

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines InternationalCalling
        /// </summary>
        public enum InternationalCallingEnum
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
        /// Gets or Sets InternationalCalling
        /// </summary>
        [DataMember(Name="internationalCalling", EmitDefaultValue=true)]
        public InternationalCallingEnum? InternationalCalling { get; set; }
        /// <summary>
        /// Defines CallDebug
        /// </summary>
        public enum CallDebugEnum
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
        /// Gets or Sets CallDebug
        /// </summary>
        [DataMember(Name="callDebug", EmitDefaultValue=true)]
        public CallDebugEnum? CallDebug { get; set; }
        /// <summary>
        /// Defines MediaBypass
        /// </summary>
        public enum MediaBypassEnum
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
        /// Gets or Sets MediaBypass
        /// </summary>
        [DataMember(Name="mediaBypass", EmitDefaultValue=true)]
        public MediaBypassEnum? MediaBypass { get; set; }
        /// <summary>
        /// Defines AccountLock
        /// </summary>
        public enum AccountLockEnum
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
        /// Gets or Sets AccountLock
        /// </summary>
        [DataMember(Name="accountLock", EmitDefaultValue=true)]
        public AccountLockEnum? AccountLock { get; set; }
        /// <summary>
        /// Defines CallRecording
        /// </summary>
        public enum CallRecordingEnum
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
        /// Gets or Sets CallRecording
        /// </summary>
        [DataMember(Name="callRecording", EmitDefaultValue=true)]
        public CallRecordingEnum? CallRecording { get; set; }
        /// <summary>
        /// Defines CnamLookUps
        /// </summary>
        public enum CnamLookUpsEnum
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
        /// Gets or Sets CnamLookUps
        /// </summary>
        [DataMember(Name="cnamLookUps", EmitDefaultValue=true)]
        public CnamLookUpsEnum? CnamLookUps { get; set; }
        /// <summary>
        /// Defines HoldMusic
        /// </summary>
        public enum HoldMusicEnum
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
        /// Gets or Sets HoldMusic
        /// </summary>
        [DataMember(Name="holdMusic", EmitDefaultValue=true)]
        public HoldMusicEnum? HoldMusic { get; set; }
        /// <summary>
        /// Defines TranscribeCalls
        /// </summary>
        public enum TranscribeCallsEnum
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
        /// Gets or Sets TranscribeCalls
        /// </summary>
        [DataMember(Name="transcribeCalls", EmitDefaultValue=true)]
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
            Credit = credit,

            /// <summary>
            /// Enum Paymentmethod for value: paymentmethod
            /// </summary>
            Paymentmethod = paymentmethod

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
        /// <param name="status">status.</param>
        /// <param name="websiteUrl">websiteUrl.</param>
        /// <param name="logo">logo.</param>
        /// <param name="credit">credit.</param>
        /// <param name="adminUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="billingUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="callRecordingUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="callForwardingCallLimit">callForwardingCallLimit.</param>
        /// <param name="supportUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="automaticRefillAmount">automaticRefillAmount.</param>
        /// <param name="lowBalanceAlertAmount">lowBalanceAlertAmount.</param>
        /// <param name="lowBalanceAlertAt">lowBalanceAlertAt.</param>
        /// <param name="lowBalanceAlertCount">lowBalanceAlertCount.</param>
        /// <param name="lastAutomaticRefillInvoice">ObjectId (unique 12 bytes ID).</param>
        /// <param name="internationalCalling">internationalCalling.</param>
        /// <param name="createdByIP">createdByIP.</param>
        /// <param name="callDebug">callDebug.</param>
        /// <param name="mediaBypass">mediaBypass.</param>
        /// <param name="accountLock">accountLock.</param>
        /// <param name="callRecording">callRecording.</param>
        /// <param name="cdrRetention">cdrRetention.</param>
        /// <param name="cnamLookUps">cnamLookUps.</param>
        /// <param name="holdMusic">holdMusic.</param>
        /// <param name="transcribeCalls">transcribeCalls.</param>
        /// <param name="maxOutboundCallRate">maxOutboundCallRate.</param>
        /// <param name="defaultBillMethod">defaultBillMethod (required).</param>
        public Customers(Object name = default(Object), StatusEnum? status = default(StatusEnum?), Object websiteUrl = default(Object), Object logo = default(Object), Object credit = default(Object), Object adminUserId = default(Object), Object billingUserId = default(Object), Object callRecordingUserId = default(Object), Object callForwardingCallLimit = default(Object), Object supportUserId = default(Object), Object automaticRefillAmount = default(Object), Object lowBalanceAlertAmount = default(Object), Object lowBalanceAlertAt = default(Object), Object lowBalanceAlertCount = default(Object), Object lastAutomaticRefillInvoice = default(Object), InternationalCallingEnum? internationalCalling = default(InternationalCallingEnum?), Object createdByIP = default(Object), CallDebugEnum? callDebug = default(CallDebugEnum?), MediaBypassEnum? mediaBypass = default(MediaBypassEnum?), AccountLockEnum? accountLock = default(AccountLockEnum?), CallRecordingEnum? callRecording = default(CallRecordingEnum?), Object cdrRetention = default(Object), CnamLookUpsEnum? cnamLookUps = default(CnamLookUpsEnum?), HoldMusicEnum? holdMusic = default(HoldMusicEnum?), TranscribeCallsEnum? transcribeCalls = default(TranscribeCallsEnum?), Object maxOutboundCallRate = default(Object), DefaultBillMethodEnum defaultBillMethod = default(DefaultBillMethodEnum))
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

            this.Name = name;
            this.Status = status;
            this.WebsiteUrl = websiteUrl;
            this.Logo = logo;
            this.Credit = credit;
            this.AdminUserId = adminUserId;
            this.BillingUserId = billingUserId;
            this.CallRecordingUserId = callRecordingUserId;
            this.CallForwardingCallLimit = callForwardingCallLimit;
            this.SupportUserId = supportUserId;
            this.AutomaticRefillAmount = automaticRefillAmount;
            this.LowBalanceAlertAmount = lowBalanceAlertAmount;
            this.LowBalanceAlertAt = lowBalanceAlertAt;
            this.LowBalanceAlertCount = lowBalanceAlertCount;
            this.LastAutomaticRefillInvoice = lastAutomaticRefillInvoice;
            this.InternationalCalling = internationalCalling;
            this.CreatedByIP = createdByIP;
            this.CallDebug = callDebug;
            this.MediaBypass = mediaBypass;
            this.AccountLock = accountLock;
            this.CallRecording = callRecording;
            this.CdrRetention = cdrRetention;
            this.CnamLookUps = cnamLookUps;
            this.HoldMusic = holdMusic;
            this.TranscribeCalls = transcribeCalls;
            this.MaxOutboundCallRate = maxOutboundCallRate;
            // to ensure "defaultBillMethod" is required (not null)
            if (defaultBillMethod == null)
            {
                throw new InvalidDataException("defaultBillMethod is a required property for Customers and cannot be null");
            }
            else
            {
                this.DefaultBillMethod = defaultBillMethod;
            }

            this.DefaultBillMethod = defaultBillMethod;
            this.Status = status;
            this.WebsiteUrl = websiteUrl;
            this.Logo = logo;
            this.Credit = credit;
            this.AdminUserId = adminUserId;
            this.BillingUserId = billingUserId;
            this.CallRecordingUserId = callRecordingUserId;
            this.CallForwardingCallLimit = callForwardingCallLimit;
            this.SupportUserId = supportUserId;
            this.AutomaticRefillAmount = automaticRefillAmount;
            this.LowBalanceAlertAmount = lowBalanceAlertAmount;
            this.LowBalanceAlertAt = lowBalanceAlertAt;
            this.LowBalanceAlertCount = lowBalanceAlertCount;
            this.LastAutomaticRefillInvoice = lastAutomaticRefillInvoice;
            this.InternationalCalling = internationalCalling;
            this.CreatedByIP = createdByIP;
            this.CallDebug = callDebug;
            this.MediaBypass = mediaBypass;
            this.AccountLock = accountLock;
            this.CallRecording = callRecording;
            this.CdrRetention = cdrRetention;
            this.CnamLookUps = cnamLookUps;
            this.HoldMusic = holdMusic;
            this.TranscribeCalls = transcribeCalls;
            this.MaxOutboundCallRate = maxOutboundCallRate;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Object Name { get; set; }


        /// <summary>
        /// Gets or Sets WebsiteUrl
        /// </summary>
        [DataMember(Name="websiteUrl", EmitDefaultValue=true)]
        public Object WebsiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name="logo", EmitDefaultValue=true)]
        public Object Logo { get; set; }

        /// <summary>
        /// Gets or Sets Credit
        /// </summary>
        [DataMember(Name="credit", EmitDefaultValue=true)]
        public Object Credit { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="adminUserId", EmitDefaultValue=true)]
        public Object AdminUserId { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="billingUserId", EmitDefaultValue=true)]
        public Object BillingUserId { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="callRecordingUserId", EmitDefaultValue=true)]
        public Object CallRecordingUserId { get; set; }

        /// <summary>
        /// Gets or Sets CallForwardingCallLimit
        /// </summary>
        [DataMember(Name="callForwardingCallLimit", EmitDefaultValue=true)]
        public Object CallForwardingCallLimit { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="supportUserId", EmitDefaultValue=true)]
        public Object SupportUserId { get; set; }

        /// <summary>
        /// Gets or Sets AutomaticRefillAmount
        /// </summary>
        [DataMember(Name="automaticRefillAmount", EmitDefaultValue=true)]
        public Object AutomaticRefillAmount { get; set; }

        /// <summary>
        /// Gets or Sets LowBalanceAlertAmount
        /// </summary>
        [DataMember(Name="lowBalanceAlertAmount", EmitDefaultValue=true)]
        public Object LowBalanceAlertAmount { get; set; }

        /// <summary>
        /// Gets or Sets LowBalanceAlertAt
        /// </summary>
        [DataMember(Name="lowBalanceAlertAt", EmitDefaultValue=true)]
        public Object LowBalanceAlertAt { get; set; }

        /// <summary>
        /// Gets or Sets LowBalanceAlertCount
        /// </summary>
        [DataMember(Name="lowBalanceAlertCount", EmitDefaultValue=true)]
        public Object LowBalanceAlertCount { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="lastAutomaticRefillInvoice", EmitDefaultValue=true)]
        public Object LastAutomaticRefillInvoice { get; set; }


        /// <summary>
        /// Gets or Sets CreatedByIP
        /// </summary>
        [DataMember(Name="createdByIP", EmitDefaultValue=true)]
        public Object CreatedByIP { get; set; }





        /// <summary>
        /// Gets or Sets CdrRetention
        /// </summary>
        [DataMember(Name="cdrRetention", EmitDefaultValue=true)]
        public Object CdrRetention { get; set; }




        /// <summary>
        /// Gets or Sets MaxOutboundCallRate
        /// </summary>
        [DataMember(Name="maxOutboundCallRate", EmitDefaultValue=true)]
        public Object MaxOutboundCallRate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Customers {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  AdminUserId: ").Append(AdminUserId).Append("\n");
            sb.Append("  BillingUserId: ").Append(BillingUserId).Append("\n");
            sb.Append("  CallRecordingUserId: ").Append(CallRecordingUserId).Append("\n");
            sb.Append("  CallForwardingCallLimit: ").Append(CallForwardingCallLimit).Append("\n");
            sb.Append("  SupportUserId: ").Append(SupportUserId).Append("\n");
            sb.Append("  AutomaticRefillAmount: ").Append(AutomaticRefillAmount).Append("\n");
            sb.Append("  LowBalanceAlertAmount: ").Append(LowBalanceAlertAmount).Append("\n");
            sb.Append("  LowBalanceAlertAt: ").Append(LowBalanceAlertAt).Append("\n");
            sb.Append("  LowBalanceAlertCount: ").Append(LowBalanceAlertCount).Append("\n");
            sb.Append("  LastAutomaticRefillInvoice: ").Append(LastAutomaticRefillInvoice).Append("\n");
            sb.Append("  InternationalCalling: ").Append(InternationalCalling).Append("\n");
            sb.Append("  CreatedByIP: ").Append(CreatedByIP).Append("\n");
            sb.Append("  CallDebug: ").Append(CallDebug).Append("\n");
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                    this.CallForwardingCallLimit == input.CallForwardingCallLimit ||
                    (this.CallForwardingCallLimit != null &&
                    this.CallForwardingCallLimit.Equals(input.CallForwardingCallLimit))
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
                    this.LowBalanceAlertAt == input.LowBalanceAlertAt ||
                    (this.LowBalanceAlertAt != null &&
                    this.LowBalanceAlertAt.Equals(input.LowBalanceAlertAt))
                ) && 
                (
                    this.LowBalanceAlertCount == input.LowBalanceAlertCount ||
                    (this.LowBalanceAlertCount != null &&
                    this.LowBalanceAlertCount.Equals(input.LowBalanceAlertCount))
                ) && 
                (
                    this.LastAutomaticRefillInvoice == input.LastAutomaticRefillInvoice ||
                    (this.LastAutomaticRefillInvoice != null &&
                    this.LastAutomaticRefillInvoice.Equals(input.LastAutomaticRefillInvoice))
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
                    this.CallDebug == input.CallDebug ||
                    (this.CallDebug != null &&
                    this.CallDebug.Equals(input.CallDebug))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
                if (this.CallForwardingCallLimit != null)
                    hashCode = hashCode * 59 + this.CallForwardingCallLimit.GetHashCode();
                if (this.SupportUserId != null)
                    hashCode = hashCode * 59 + this.SupportUserId.GetHashCode();
                if (this.AutomaticRefillAmount != null)
                    hashCode = hashCode * 59 + this.AutomaticRefillAmount.GetHashCode();
                if (this.LowBalanceAlertAmount != null)
                    hashCode = hashCode * 59 + this.LowBalanceAlertAmount.GetHashCode();
                if (this.LowBalanceAlertAt != null)
                    hashCode = hashCode * 59 + this.LowBalanceAlertAt.GetHashCode();
                if (this.LowBalanceAlertCount != null)
                    hashCode = hashCode * 59 + this.LowBalanceAlertCount.GetHashCode();
                if (this.LastAutomaticRefillInvoice != null)
                    hashCode = hashCode * 59 + this.LastAutomaticRefillInvoice.GetHashCode();
                if (this.InternationalCalling != null)
                    hashCode = hashCode * 59 + this.InternationalCalling.GetHashCode();
                if (this.CreatedByIP != null)
                    hashCode = hashCode * 59 + this.CreatedByIP.GetHashCode();
                if (this.CallDebug != null)
                    hashCode = hashCode * 59 + this.CallDebug.GetHashCode();
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
            // Name (Object) maxLength
            if(this.Name != null && this.Name.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 45.", new [] { "Name" });
            }


            // WebsiteUrl (Object) maxLength
            if(this.WebsiteUrl != null && this.WebsiteUrl.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebsiteUrl, length must be less than 255.", new [] { "WebsiteUrl" });
            }


            // Logo (Object) maxLength
            if(this.Logo != null && this.Logo.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Logo, length must be less than 255.", new [] { "Logo" });
            }


            // CreatedByIP (Object) maxLength
            if(this.CreatedByIP != null && this.CreatedByIP.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedByIP, length must be less than 45.", new [] { "CreatedByIP" });
            }

            // CreatedByIP (Object) minLength
            if(this.CreatedByIP != null && this.CreatedByIP.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedByIP, length must be greater than 8.", new [] { "CreatedByIP" });
            }

            yield break;
        }
    }

}
