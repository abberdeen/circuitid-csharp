
# Com.CircuitID.Models.GetCustomer200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Status** | **string** |  | [optional] [default to StatusEnum.Active]
**WebsiteUrl** | **string** |  | [optional] 
**Logo** | **string** |  | [optional] 
**Credit** | **int** |  | [optional] [default to 0]
**AdminUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**BillingUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**CallRecordingUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**CallForwardingCallLimit** | **int** |  | [optional] [default to 10]
**SupportUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**AutomaticRefillAmount** | **int** |  | [optional] [default to 0]
**LowBalanceAlertAmount** | **int** |  | [optional] [default to 0]
**LowBalanceAlertAt** | **DateTime** |  | [optional] 
**LowBalanceAlertCount** | **int** |  | [optional] [default to 0]
**LastAutomaticRefillInvoice** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**InternationalCalling** | **int** |  | [optional] [default to InternationalCallingEnum.NUMBER_0]
**CreatedByIP** | **string** |  | [optional] 
**CallDebug** | **int** |  | [optional] [default to CallDebugEnum.NUMBER_0]
**MediaBypass** | **int** |  | [optional] [default to MediaBypassEnum.NUMBER_0]
**AccountLock** | **int** |  | [optional] [default to AccountLockEnum.NUMBER_1]
**CallRecording** | **int** |  | [optional] [default to CallRecordingEnum.NUMBER_0]
**CdrRetention** | **int** |  | [optional] [default to 12]
**CnamLookUps** | **int** |  | [optional] [default to CnamLookUpsEnum.NUMBER_0]
**HoldMusic** | **int** |  | [optional] [default to HoldMusicEnum.NUMBER_0]
**TranscribeCalls** | **int** |  | [optional] 
**MaxOutboundCallRate** | **int** |  | [optional] [default to 1]
**DefaultBillMethod** | **string** |  | [default to DefaultBillMethodEnum.Credit]
**CreatedByUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**UpdatedByUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

