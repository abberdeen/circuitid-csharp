
# Com.CircuitID.Models.Faxes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attachments** | **List&lt;string&gt;** |  | [optional] 
**CallerDestinations** | **List&lt;string&gt;** |  | 
**CallerIdNumber** | **string** |  | 
**CallerDestination** | **string** |  | 
**Pages** | **int** |  | [optional] [default to 0]
**StatusCode** | **int** |  | [optional] 
**TransferedPages** | **int** |  | [optional] [default to 0]
**Status** | **string** |  | [default to StatusEnum.Processing]
**Error** | **string** |  | [optional] 
**Type** | **string** |  | 
**Order** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**File** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**Contact** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**Number** | **string** | ObjectId (unique 12 bytes ID) | 
**FaxAccount** | **string** | ObjectId (unique 12 bytes ID) | 
**Retries** | **int** |  | [optional] [default to 0]
**Invoice** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**SenderEmail** | **string** |  | [optional] 
**SenderName** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

