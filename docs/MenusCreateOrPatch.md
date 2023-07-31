
# Com.CircuitID.Models.MenusCreateOrPatch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**MaxExtensionLength** | **int** |  | [default to 4]
**SpeechRecognition** | **int** |  | [optional] [default to SpeechRecognitionEnum.NUMBER_0]
**Directory** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**GreetingType** | **string** |  | 
**GreetingTTS** | **string** |  | [optional] 
**MenuVoice** | **string** |  | [optional] 
**ExitSound** | **string** |  | [optional] [default to ExitSoundEnum.Default]
**TransferAnnouncement** | **string** |  | [optional] [default to TransferAnnouncementEnum.Default]
**MaxFailures** | **int** |  | [optional] [default to 3]
**MaxTimeouts** | **int** |  | [optional] [default to 3]
**Timeout** | **int** |  | [optional] [default to 10]
**TouchToneTerminators** | **int** |  | [optional] [default to TouchToneTerminatorsEnum.NUMBER_1]
**Timeschedule** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**DestinationType** | **string** |  | [optional] 
**Destination** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**Ref** | **string** |  | [optional] 
**CallForwardingDestination** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

