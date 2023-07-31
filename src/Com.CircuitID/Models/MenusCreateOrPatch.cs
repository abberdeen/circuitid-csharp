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
    /// MenusCreateOrPatch
    /// </summary>
    [DataContract]
    public partial class MenusCreateOrPatch :  IEquatable<MenusCreateOrPatch>, IValidatableObject
    {
        /// <summary>
        /// Defines SpeechRecognition
        /// </summary>
        public enum SpeechRecognitionEnum
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
        /// Gets or Sets SpeechRecognition
        /// </summary>
        [DataMember(Name="speechRecognition", EmitDefaultValue=false)]
        public SpeechRecognitionEnum? SpeechRecognition { get; set; }
        /// <summary>
        /// Defines GreetingType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GreetingTypeEnum
        {
            /// <summary>
            /// Enum Tts for value: tts
            /// </summary>
            [EnumMember(Value = "tts")]
            Tts = 1,

            /// <summary>
            /// Enum Mp3 for value: mp3
            /// </summary>
            [EnumMember(Value = "mp3")]
            Mp3 = 2

        }

        /// <summary>
        /// Gets or Sets GreetingType
        /// </summary>
        [DataMember(Name="greetingType", EmitDefaultValue=true)]
        public GreetingTypeEnum GreetingType { get; set; }
        /// <summary>
        /// Defines ExitSound
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExitSoundEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,

            /// <summary>
            /// Enum Mp3 for value: mp3
            /// </summary>
            [EnumMember(Value = "mp3")]
            Mp3 = 2

        }

        /// <summary>
        /// Gets or Sets ExitSound
        /// </summary>
        [DataMember(Name="exitSound", EmitDefaultValue=false)]
        public ExitSoundEnum? ExitSound { get; set; }
        /// <summary>
        /// Defines TransferAnnouncement
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransferAnnouncementEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,

            /// <summary>
            /// Enum Mp3 for value: mp3
            /// </summary>
            [EnumMember(Value = "mp3")]
            Mp3 = 2,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 3

        }

        /// <summary>
        /// Gets or Sets TransferAnnouncement
        /// </summary>
        [DataMember(Name="transferAnnouncement", EmitDefaultValue=false)]
        public TransferAnnouncementEnum? TransferAnnouncement { get; set; }
        /// <summary>
        /// Defines TouchToneTerminators
        /// </summary>
        public enum TouchToneTerminatorsEnum
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
        /// Gets or Sets TouchToneTerminators
        /// </summary>
        [DataMember(Name="touchToneTerminators", EmitDefaultValue=false)]
        public TouchToneTerminatorsEnum? TouchToneTerminators { get; set; }
        /// <summary>
        /// Defines DestinationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DestinationTypeEnum
        {
            /// <summary>
            /// Enum Announcements for value: announcements
            /// </summary>
            [EnumMember(Value = "announcements")]
            Announcements = 1,

            /// <summary>
            /// Enum Directories for value: directories
            /// </summary>
            [EnumMember(Value = "directories")]
            Directories = 2,

            /// <summary>
            /// Enum Park for value: park
            /// </summary>
            [EnumMember(Value = "park")]
            Park = 3,

            /// <summary>
            /// Enum Numbers for value: numbers
            /// </summary>
            [EnumMember(Value = "numbers")]
            Numbers = 4,

            /// <summary>
            /// Enum Menus for value: menus
            /// </summary>
            [EnumMember(Value = "menus")]
            Menus = 5,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 6,

            /// <summary>
            /// Enum Servers for value: servers
            /// </summary>
            [EnumMember(Value = "servers")]
            Servers = 7,

            /// <summary>
            /// Enum Inboundrules for value: inboundrules
            /// </summary>
            [EnumMember(Value = "inboundrules")]
            Inboundrules = 8,

            /// <summary>
            /// Enum Callqueues for value: callqueues
            /// </summary>
            [EnumMember(Value = "callqueues")]
            Callqueues = 9,

            /// <summary>
            /// Enum Faxaccounts for value: faxaccounts
            /// </summary>
            [EnumMember(Value = "faxaccounts")]
            Faxaccounts = 10,

            /// <summary>
            /// Enum Callforwarding for value: callforwarding
            /// </summary>
            [EnumMember(Value = "callforwarding")]
            Callforwarding = 11,

            /// <summary>
            /// Enum Hangup for value: hangup
            /// </summary>
            [EnumMember(Value = "hangup")]
            Hangup = 12,

            /// <summary>
            /// Enum Phoneinboundrules for value: phoneinboundrules
            /// </summary>
            [EnumMember(Value = "phoneinboundrules")]
            Phoneinboundrules = 13,

            /// <summary>
            /// Enum Voicemailaccounts for value: voicemailaccounts
            /// </summary>
            [EnumMember(Value = "voicemailaccounts")]
            Voicemailaccounts = 14

        }

        /// <summary>
        /// Gets or Sets DestinationType
        /// </summary>
        [DataMember(Name="destinationType", EmitDefaultValue=false)]
        public DestinationTypeEnum? DestinationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MenusCreateOrPatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MenusCreateOrPatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MenusCreateOrPatch" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="maxExtensionLength">maxExtensionLength (required) (default to 4).</param>
        /// <param name="speechRecognition">speechRecognition (default to SpeechRecognitionEnum.NUMBER_0).</param>
        /// <param name="directory">ObjectId (unique 12 bytes ID).</param>
        /// <param name="greetingType">greetingType (required).</param>
        /// <param name="greetingTTS">greetingTTS.</param>
        /// <param name="menuVoice">menuVoice.</param>
        /// <param name="exitSound">exitSound (default to ExitSoundEnum.Default).</param>
        /// <param name="transferAnnouncement">transferAnnouncement (default to TransferAnnouncementEnum.Default).</param>
        /// <param name="maxFailures">maxFailures (default to 3).</param>
        /// <param name="maxTimeouts">maxTimeouts (default to 3).</param>
        /// <param name="timeout">timeout (default to 10).</param>
        /// <param name="touchToneTerminators">touchToneTerminators (default to TouchToneTerminatorsEnum.NUMBER_1).</param>
        /// <param name="timeschedule">ObjectId (unique 12 bytes ID).</param>
        /// <param name="destinationType">destinationType.</param>
        /// <param name="destination">ObjectId (unique 12 bytes ID).</param>
        /// <param name="_ref">_ref.</param>
        /// <param name="callForwardingDestination">callForwardingDestination.</param>
        public MenusCreateOrPatch(string name = default(string), int maxExtensionLength = 4, SpeechRecognitionEnum? speechRecognition = SpeechRecognitionEnum.NUMBER_0, string directory = default(string), GreetingTypeEnum greetingType = default(GreetingTypeEnum), string greetingTTS = default(string), string menuVoice = default(string), ExitSoundEnum? exitSound = ExitSoundEnum.Default, TransferAnnouncementEnum? transferAnnouncement = TransferAnnouncementEnum.Default, int maxFailures = 3, int maxTimeouts = 3, int timeout = 10, TouchToneTerminatorsEnum? touchToneTerminators = TouchToneTerminatorsEnum.NUMBER_1, string timeschedule = default(string), DestinationTypeEnum? destinationType = default(DestinationTypeEnum?), string destination = default(string), string _ref = default(string), string callForwardingDestination = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for MenusCreateOrPatch and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "maxExtensionLength" is required (not null)
            if (maxExtensionLength == null)
            {
                throw new InvalidDataException("maxExtensionLength is a required property for MenusCreateOrPatch and cannot be null");
            }
            else
            {
                this.MaxExtensionLength = maxExtensionLength;
            }

            // to ensure "greetingType" is required (not null)
            if (greetingType == null)
            {
                throw new InvalidDataException("greetingType is a required property for MenusCreateOrPatch and cannot be null");
            }
            else
            {
                this.GreetingType = greetingType;
            }

            // use default value if no "speechRecognition" provided
            if (speechRecognition == null)
            {
                this.SpeechRecognition = SpeechRecognitionEnum.NUMBER_0;
            }
            else
            {
                this.SpeechRecognition = speechRecognition;
            }
            this.Directory = directory;
            this.GreetingTTS = greetingTTS;
            this.MenuVoice = menuVoice;
            // use default value if no "exitSound" provided
            if (exitSound == null)
            {
                this.ExitSound = ExitSoundEnum.Default;
            }
            else
            {
                this.ExitSound = exitSound;
            }
            // use default value if no "transferAnnouncement" provided
            if (transferAnnouncement == null)
            {
                this.TransferAnnouncement = TransferAnnouncementEnum.Default;
            }
            else
            {
                this.TransferAnnouncement = transferAnnouncement;
            }
            // use default value if no "maxFailures" provided
            if (maxFailures == null)
            {
                this.MaxFailures = 3;
            }
            else
            {
                this.MaxFailures = maxFailures;
            }
            // use default value if no "maxTimeouts" provided
            if (maxTimeouts == null)
            {
                this.MaxTimeouts = 3;
            }
            else
            {
                this.MaxTimeouts = maxTimeouts;
            }
            // use default value if no "timeout" provided
            if (timeout == null)
            {
                this.Timeout = 10;
            }
            else
            {
                this.Timeout = timeout;
            }
            // use default value if no "touchToneTerminators" provided
            if (touchToneTerminators == null)
            {
                this.TouchToneTerminators = TouchToneTerminatorsEnum.NUMBER_1;
            }
            else
            {
                this.TouchToneTerminators = touchToneTerminators;
            }
            this.Timeschedule = timeschedule;
            this.DestinationType = destinationType;
            this.Destination = destination;
            this.Ref = _ref;
            this.CallForwardingDestination = callForwardingDestination;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MaxExtensionLength
        /// </summary>
        [DataMember(Name="maxExtensionLength", EmitDefaultValue=true)]
        public int MaxExtensionLength { get; set; }


        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="directory", EmitDefaultValue=false)]
        public string Directory { get; set; }


        /// <summary>
        /// Gets or Sets GreetingTTS
        /// </summary>
        [DataMember(Name="greetingTTS", EmitDefaultValue=false)]
        public string GreetingTTS { get; set; }

        /// <summary>
        /// Gets or Sets MenuVoice
        /// </summary>
        [DataMember(Name="menuVoice", EmitDefaultValue=false)]
        public string MenuVoice { get; set; }



        /// <summary>
        /// Gets or Sets MaxFailures
        /// </summary>
        [DataMember(Name="maxFailures", EmitDefaultValue=false)]
        public int MaxFailures { get; set; }

        /// <summary>
        /// Gets or Sets MaxTimeouts
        /// </summary>
        [DataMember(Name="maxTimeouts", EmitDefaultValue=false)]
        public int MaxTimeouts { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int Timeout { get; set; }


        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="timeschedule", EmitDefaultValue=false)]
        public string Timeschedule { get; set; }


        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public string Ref { get; set; }

        /// <summary>
        /// Gets or Sets CallForwardingDestination
        /// </summary>
        [DataMember(Name="callForwardingDestination", EmitDefaultValue=false)]
        public string CallForwardingDestination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MenusCreateOrPatch {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MaxExtensionLength: ").Append(MaxExtensionLength).Append("\n");
            sb.Append("  SpeechRecognition: ").Append(SpeechRecognition).Append("\n");
            sb.Append("  Directory: ").Append(Directory).Append("\n");
            sb.Append("  GreetingType: ").Append(GreetingType).Append("\n");
            sb.Append("  GreetingTTS: ").Append(GreetingTTS).Append("\n");
            sb.Append("  MenuVoice: ").Append(MenuVoice).Append("\n");
            sb.Append("  ExitSound: ").Append(ExitSound).Append("\n");
            sb.Append("  TransferAnnouncement: ").Append(TransferAnnouncement).Append("\n");
            sb.Append("  MaxFailures: ").Append(MaxFailures).Append("\n");
            sb.Append("  MaxTimeouts: ").Append(MaxTimeouts).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  TouchToneTerminators: ").Append(TouchToneTerminators).Append("\n");
            sb.Append("  Timeschedule: ").Append(Timeschedule).Append("\n");
            sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  CallForwardingDestination: ").Append(CallForwardingDestination).Append("\n");
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
            return this.Equals(input as MenusCreateOrPatch);
        }

        /// <summary>
        /// Returns true if MenusCreateOrPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of MenusCreateOrPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenusCreateOrPatch input)
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
                    this.MaxExtensionLength == input.MaxExtensionLength ||
                    (this.MaxExtensionLength != null &&
                    this.MaxExtensionLength.Equals(input.MaxExtensionLength))
                ) && 
                (
                    this.SpeechRecognition == input.SpeechRecognition ||
                    (this.SpeechRecognition != null &&
                    this.SpeechRecognition.Equals(input.SpeechRecognition))
                ) && 
                (
                    this.Directory == input.Directory ||
                    (this.Directory != null &&
                    this.Directory.Equals(input.Directory))
                ) && 
                (
                    this.GreetingType == input.GreetingType ||
                    (this.GreetingType != null &&
                    this.GreetingType.Equals(input.GreetingType))
                ) && 
                (
                    this.GreetingTTS == input.GreetingTTS ||
                    (this.GreetingTTS != null &&
                    this.GreetingTTS.Equals(input.GreetingTTS))
                ) && 
                (
                    this.MenuVoice == input.MenuVoice ||
                    (this.MenuVoice != null &&
                    this.MenuVoice.Equals(input.MenuVoice))
                ) && 
                (
                    this.ExitSound == input.ExitSound ||
                    (this.ExitSound != null &&
                    this.ExitSound.Equals(input.ExitSound))
                ) && 
                (
                    this.TransferAnnouncement == input.TransferAnnouncement ||
                    (this.TransferAnnouncement != null &&
                    this.TransferAnnouncement.Equals(input.TransferAnnouncement))
                ) && 
                (
                    this.MaxFailures == input.MaxFailures ||
                    (this.MaxFailures != null &&
                    this.MaxFailures.Equals(input.MaxFailures))
                ) && 
                (
                    this.MaxTimeouts == input.MaxTimeouts ||
                    (this.MaxTimeouts != null &&
                    this.MaxTimeouts.Equals(input.MaxTimeouts))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.TouchToneTerminators == input.TouchToneTerminators ||
                    (this.TouchToneTerminators != null &&
                    this.TouchToneTerminators.Equals(input.TouchToneTerminators))
                ) && 
                (
                    this.Timeschedule == input.Timeschedule ||
                    (this.Timeschedule != null &&
                    this.Timeschedule.Equals(input.Timeschedule))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
                ) && 
                (
                    this.CallForwardingDestination == input.CallForwardingDestination ||
                    (this.CallForwardingDestination != null &&
                    this.CallForwardingDestination.Equals(input.CallForwardingDestination))
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
                if (this.MaxExtensionLength != null)
                    hashCode = hashCode * 59 + this.MaxExtensionLength.GetHashCode();
                if (this.SpeechRecognition != null)
                    hashCode = hashCode * 59 + this.SpeechRecognition.GetHashCode();
                if (this.Directory != null)
                    hashCode = hashCode * 59 + this.Directory.GetHashCode();
                if (this.GreetingType != null)
                    hashCode = hashCode * 59 + this.GreetingType.GetHashCode();
                if (this.GreetingTTS != null)
                    hashCode = hashCode * 59 + this.GreetingTTS.GetHashCode();
                if (this.MenuVoice != null)
                    hashCode = hashCode * 59 + this.MenuVoice.GetHashCode();
                if (this.ExitSound != null)
                    hashCode = hashCode * 59 + this.ExitSound.GetHashCode();
                if (this.TransferAnnouncement != null)
                    hashCode = hashCode * 59 + this.TransferAnnouncement.GetHashCode();
                if (this.MaxFailures != null)
                    hashCode = hashCode * 59 + this.MaxFailures.GetHashCode();
                if (this.MaxTimeouts != null)
                    hashCode = hashCode * 59 + this.MaxTimeouts.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.TouchToneTerminators != null)
                    hashCode = hashCode * 59 + this.TouchToneTerminators.GetHashCode();
                if (this.Timeschedule != null)
                    hashCode = hashCode * 59 + this.Timeschedule.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.CallForwardingDestination != null)
                    hashCode = hashCode * 59 + this.CallForwardingDestination.GetHashCode();
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


            // Ref (string) maxLength
            if(this.Ref != null && this.Ref.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ref, length must be less than 100.", new [] { "Ref" });
            }

            // Ref (string) minLength
            if(this.Ref != null && this.Ref.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ref, length must be greater than 5.", new [] { "Ref" });
            }

            // CallForwardingDestination (string) maxLength
            if(this.CallForwardingDestination != null && this.CallForwardingDestination.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallForwardingDestination, length must be less than 45.", new [] { "CallForwardingDestination" });
            }

            // CallForwardingDestination (string) minLength
            if(this.CallForwardingDestination != null && this.CallForwardingDestination.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallForwardingDestination, length must be greater than 10.", new [] { "CallForwardingDestination" });
            }

            yield break;
        }
    }

}
