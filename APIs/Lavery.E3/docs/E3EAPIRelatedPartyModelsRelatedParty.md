
# Org.OpenAPITools.Model.E3EAPIRelatedPartyModelsRelatedParty

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Gets or sets unique id associated with the object. | [optional] 
**AccessType** | [**E3EAPIDataAccessType**](E3EAPIDataAccessType.md) | Gets or sets the access type of the row. When omitted, default value is Enabled (editable for data objects). | [optional] 
**DataState** | [**E3EAPIDataObjectModelsDataObjectLiteState**](E3EAPIDataObjectModelsDataObjectLiteState.md) | Gets or sets the data object state. | [optional] 
**Attributes** | [**Dictionary&lt;string, E3EAPIDataModelsAttribute&gt;**](E3EAPIDataModelsAttribute.md) | Gets or sets the attributes. | [optional] 
**ChildObjects** | [**List&lt;E3EAPIDataObjectModelsDataObjectLiteCollection&gt;**](E3EAPIDataObjectModelsDataObjectLiteCollection.md) | Gets or sets the child objects for this data object. This is a collection of collections. | [optional] 
**Error** | [**E3EAPIDataDataError**](E3EAPIDataDataError.md) | Gets or sets the error in the row level. | [optional] 
**Index** | **int** | Gets or sets the index of the row. | [optional] [default to -1]
**IsLocked** | **bool** | Gets or sets a value indicating whether the row is checked out by another process. | [optional] 
**LockedMessage** | **string** | Gets or sets the message indicating whether the row is locked. | [optional] 
**SubclassId** | **string** | Gets or sets the subclass id of this row. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

