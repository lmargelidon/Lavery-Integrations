
# Org.OpenAPITools.Model.E3EAPIDataObjectModelsDataObjectLiteCollection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Gets or sets the Id of the data object. | [optional] 
**ObjectId** | **string** | Gets or sets the Id of the object. | [optional] 
**ActualRowCount** | **int** | Gets or sets the actual row count. | [optional] [default to 0]
**RowCount** | **int** | Gets the row count. | [optional] [readonly] 
**Error** | [**E3EAPIDataDataError**](E3EAPIDataDataError.md) | Gets or sets the error in the collection level. | [optional] 
**Errors** | [**List&lt;E3EAPIDataModelsErrorInfo&gt;**](E3EAPIDataModelsErrorInfo.md) | Gets or sets list of errors. Contains all errors, even for not loaded rows. | [optional] 
**Rows** | [**List&lt;E3EAPIDataObjectModelsDataObjectLite&gt;**](E3EAPIDataObjectModelsDataObjectLite.md) | Gets the collection of DataObjectLite. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

