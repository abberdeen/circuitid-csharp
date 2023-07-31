
# Com.CircuitID.Models.PhoneinboundruleactionsCreateOrPatch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Phoneinboundrule** | **string** | ObjectId (unique 12 bytes ID) | 
**Timeschedule** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**Timeout** | **int** |  | [optional] 
**Status** | **int** |  | [optional] [default to StatusEnum.NUMBER_1]
**Priority** | **int** |  | [default to 1]
**DestinationType** | **string** |  | 
**Destination** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**CallForwardingDestination** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

