
# Com.CircuitID.Models.CallqueuesCreateOrPatch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Strategy** | **string** |  | 
**AnnouncePosition** | **int** |  | [optional] 
**Moh** | **string** |  | [default to "deafult"]
**CallerResumeTimeout** | **int** |  | [default to 3600]
**MaxWaitTime** | **int** |  | [default to 300]
**MaxWaitTimeNoAgent** | **int** |  | [default to 300]
**MaxNoAnswer** | **int** |  | [default to 1000000]
**NoAnswerDelayTimeout** | **int** |  | [optional] [default to 60]
**RejectTimeout** | **int** |  | [optional] [default to 60]
**BusyTimeout** | **int** |  | [optional] [default to 60]
**WrapUpTimeout** | **int** |  | [optional] [default to 10]
**TimeBasedScore** | **string** |  | [default to TimeBasedScoreEnum.Queue]
**TierRulesApply** | **bool** |  | [default to false]
**TierRuleNoAgentNoWait** | **bool** |  | [default to true]
**TierRuleWaitSecond** | **int** |  | [optional] [default to 300]
**TierRuleWaitMultiplyLevel** | **bool** |  | [default to true]
**AbandonedResumeAllowed** | **bool** |  | [default to true]
**DiscardAbandonedAfter** | **int** |  | [optional] [default to 14400]
**MaxWaitTimeNoAgentTimeReached** | **int** |  | [default to 5]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

