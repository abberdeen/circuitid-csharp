
# Com.CircuitID.Models.Numberports

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Type** | **string** |  | 
**TypeOfService** | **string** |  | 
**AuthorizedPerson** | **string** |  | 
**DesiredDueDate** | **DateTime** |  | 
**AccountNumber** | **string** |  | 
**AccountPhoneNumber** | **string** |  | 
**Office** | **string** | ObjectId (unique 12 bytes ID) | 
**E911** | **int** |  | [optional] [default to E911Enum.NUMBER_0]
**Invoice** | **string** | ObjectId (unique 12 bytes ID) | 
**Status** | **string** |  | [default to StatusEnum.Processing]
**DestinationType** | **string** |  | 
**Destination** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**Ref** | **string** |  | [optional] 
**CallForwardingDestination** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

