
# Com.CircuitID.Models.GetPhoneOutboundRuleAction200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Group** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**Phoneoutboundrule** | **string** | ObjectId (unique 12 bytes ID) | 
**Status** | **int** |  | [optional] [default to StatusEnum.NUMBER_1]
**Priority** | **int** |  | [default to 1]
**StartingChars** | **string** |  | [optional] 
**Contains** | **string** |  | [optional] 
**LengthType** | **string** |  | [optional] 
**Length** | **int** |  | [optional] 
**AppendChars** | **string** |  | [optional] 
**PrependChars** | **string** |  | [optional] 
**RangeStart** | **int** |  | [optional] 
**RangeEnd** | **int** |  | [optional] 
**RemoveStartingChars** | **int** |  | [optional] 
**RemoveEndingChars** | **int** |  | [optional] 
**Route** | **string** |  | [default to RouteEnum.Default]
**RoutingType** | **string** |  | [optional] 
**CreatedByUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**UpdatedByUserId** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

