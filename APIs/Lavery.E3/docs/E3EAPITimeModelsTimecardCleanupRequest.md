
# Org.OpenAPITools.Model.E3EAPITimeModelsTimecardCleanupRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeepTimecardsWithNarrative** | **bool?** | Gets or sets a value indicating whether timecards with Narrative populated (in addition to Work Hours) should be kept during cleanup.  If not supplied, then the behaviour will depend on Billing system option &#39;time_entry_cleanup&#39;. | [optional] 
**StartDate** | **DateTime?** | Gets or sets the StartDate (WorkDate). | [optional] 
**EndDate** | **DateTime?** | Gets or sets the EndDate (WorkDate). | [optional] 
**TimekeeperIndex** | **int** |  | [optional] 
**TimekeeperNumber** | **string** |  | [optional] 
**TimekeeperID** | **Guid** |  | [optional] 
**ItemIds** | **List&lt;Guid&gt;** |  | [optional] 
**AttributesToInclude** | **List&lt;string&gt;** |  | [optional] 
**FilterXOQL** | **string** |  | [optional] 
**Filter** | [**E3EAPIQuerySJQLSJPredicateGroup**](E3EAPIQuerySJQLSJPredicateGroup.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

