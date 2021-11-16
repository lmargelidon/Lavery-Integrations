
# Org.OpenAPITools.Model.E3EAPIDataModelsDataObject

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Actions** | [**Dictionary&lt;string, E3EAPIDataModelsAction&gt;**](E3EAPIDataModelsAction.md) | Gets or sets the collection level actions for this object. | [optional] 
**ActualRowCount** | **int** | Gets or sets the actual row count. | [optional] [default to 0]
**DataLoadState** | [**E3EAPIDataModelsDataLoadState**](E3EAPIDataModelsDataLoadState.md) | Gets or sets the data load state. | [optional] 
**Error** | [**E3EAPIDataDataError**](E3EAPIDataDataError.md) | Gets or sets the error in the collection level. | [optional] 
**GroupCount** | **int** | Gets or sets the number of groups in the first level. | [optional] 
**Groups** | [**Dictionary&lt;string, E3EAPIDataModelsGroup&gt;**](E3EAPIDataModelsGroup.md) | Gets or sets the groups in the data object. | [optional] 
**Header** | [**E3EAPIDataModelsGroup**](E3EAPIDataModelsGroup.md) | Gets or sets the header data. | [optional] 
**Id** | **string** | Gets or sets the Id of the data object. | [optional] 
**ObjectId** | **string** | Gets or sets the Id of the object. | [optional] 
**RowCount** | **int** | Gets or sets the row count. | [optional] 
**Rows** | [**Dictionary&lt;string, E3EAPIDataModelsDataRow&gt;**](E3EAPIDataModelsDataRow.md) | Gets or sets the rows in this data object. | [optional] 
**Totals** | **Dictionary&lt;string, string&gt;** | Gets or sets the totals in this collection. | [optional] 
**Errors** | [**List&lt;E3EAPIDataModelsErrorInfo&gt;**](E3EAPIDataModelsErrorInfo.md) | Gets or sets list of errors. Contains all errors, even for not loaded rows. | [optional] 
**EditedGroup** | [**E3EAPIDataModelsGroup**](E3EAPIDataModelsGroup.md) | Gets or sets editedGroup. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

