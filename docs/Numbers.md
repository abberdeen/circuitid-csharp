
# Com.CircuitID.Models.Numbers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InUse** | **int** |  | [optional] [default to InUseEnum.NUMBER_1]
**Name** | **string** |  | 
**CountryCode** | **string** |  | 
**Amount** | **int** |  | [optional] 
**PerMinuteRate** | **int** |  | [optional] 
**Fax** | **int** |  | [optional] [default to FaxEnum.NUMBER_0]
**Voice** | **int** |  | [optional] [default to VoiceEnum.NUMBER_0]
**Status** | **int** |  | [optional] [default to StatusEnum.NUMBER_1]
**Sms** | **int** |  | [optional] [default to SmsEnum.NUMBER_0]
**Mms** | **int** |  | [optional] [default to MmsEnum.NUMBER_0]
**DirectoryListing** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**CallerName** | **string** |  | [optional] 
**E911** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**MessageCampaign** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**MessageClass** | **string** |  | [optional] 
**MessageType** | **string** |  | [optional] 
**E911Supported** | **int** |  | [optional] [default to E911SupportedEnum.NUMBER_0]
**CallerNameSupported** | **int** |  | [optional] [default to CallerNameSupportedEnum.NUMBER_0]
**DirectoryListingSupported** | **int** |  | [optional] [default to DirectoryListingSupportedEnum.NUMBER_0]
**MessagingSupported** | **int** |  | [optional] [default to MessagingSupportedEnum.NUMBER_0]
**DestinationType** | **string** |  | [default to DestinationTypeEnum.Park]
**Destination** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**Ref** | **string** |  | [optional] 
**CallForwardingDestination** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

