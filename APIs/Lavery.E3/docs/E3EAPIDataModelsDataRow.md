
# Org.OpenAPITools.Model.E3EAPIDataModelsDataRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Gets or sets the Id of the row. | [optional] 
**AccessType** | [**E3EAPIDataAccessType**](E3EAPIDataAccessType.md) | Gets or sets the access type of the row. When omitted, default value is Enabled (editable for data objects). | [optional] 
**Actions** | [**Dictionary&lt;string, E3EAPIDataModelsAction&gt;**](E3EAPIDataModelsAction.md) | Gets or sets the actions in this row that are not enabled (either disabled or hidden). | [optional] 
**Attributes** | [**Dictionary&lt;string, E3EAPIDataModelsAttribute&gt;**](E3EAPIDataModelsAttribute.md) | Gets or sets the attributes in this row. | [optional] 
**ChildObjects** | [**Dictionary&lt;string, E3EAPIDataModelsDataObject&gt;**](E3EAPIDataModelsDataObject.md) | Gets or sets the child objects for this row. | [optional] 
**Error** | [**E3EAPIDataDataError**](E3EAPIDataDataError.md) | Gets or sets the error in the row level. | [optional] 
**AttachmentCount** | **int** | Gets or sets the attachment count for the row. | [optional] 
**HasComment** | **bool** | Gets or sets a value indicating whether the row has a comment for collaboration. | [optional] 
**Index** | **int** | Gets or sets the index of the row. | [optional] [default to -1]
**IsConfidential** | **bool** | Gets or sets a value indicating whether the row is confidential. | [optional] 
**IsLocked** | **bool** | Gets or sets a value indicating whether the row is checked out by another process. | [optional] 
**LockedMessage** | **string** | Gets or sets the message indicating whether the row is locked. | [optional] 
**RowState** | [**E3EAPIDataModelsDataRowStates**](E3EAPIDataModelsDataRowStates.md) | Gets or sets the row state of the row. Applies to editable objects. When omitted, default value is Edit. | [optional] 
**SubclassId** | **string** | Gets or sets the subclass id of this row. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

