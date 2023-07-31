
# Com.CircuitID.Models.Servers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Host** | **string** |  | 
**Port** | **int** |  | [default to 5060]
**CallerId** | **string** |  | [optional] 
**Type** | **string** |  | 
**InboundSipTrunkingOrder** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**OutboundSipTrunkingOrder** | **string** | ObjectId (unique 12 bytes ID) | [optional] 
**NoInstantRingBack** | **int** |  | [optional] 
**BypassMedia** | **int** |  | [optional] [default to BypassMediaEnum.NUMBER_0]
**DisableRTPAutoAdjust** | **int** |  | [optional] [default to DisableRTPAutoAdjustEnum.NUMBER_0]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

