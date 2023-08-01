
# Com.CircuitID.Models.GetUser200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** |  | 
**Password** | **string** |  | 
**SipPassword** | **string** |  | 
**TurnPassword** | **string** |  | [optional] 
**First** | **string** |  | 
**Last** | **string** |  | 
**MobilePhone** | **string** |  | [optional] 
**BusinessPhone** | **string** |  | [optional] 
**Extension** | **int** |  | [optional] 
**CustomCallerId** | **int** |  | [optional] 
**JobTitle** | **string** |  | [optional] 
**Department** | **string** |  | [optional] 
**Office** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**Avatar** | **string** |  | [optional] 
**Language** | **string** |  | [optional] [default to LanguageEnum.En]
**IsPrimary** | **int** |  | [optional] [default to IsPrimaryEnum.NUMBER_0]
**VmGreetingType** | **string** |  | [optional] [default to VmGreetingTypeEnum.Default]
**VmTimeout** | **int** |  | [optional] [default to 20]
**VmFile** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**VmPlaybackNumber** | **string** |  | [optional] 
**Pin** | **int** |  | [optional] [default to 1234]
**Number** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**Region** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**CallerIdNumber** | **string** |  | [optional] 
**AdminPermission** | **string** |  | [optional] 
**BillingPermission** | **string** |  | [optional] 
**PhonePermission** | **string** |  | [optional] 
**Timezone** | **string** |  | [default to TimezoneEnum.AmericaNewYork]
**VmTranscription** | **int** |  | [optional] [default to VmTranscriptionEnum.NUMBER_0]
**Communication** | **Object** |  | [optional] 
**Id** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**CreatedByUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**UpdatedByUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

