
# Org.OpenAPITools.Model.E3EAPIQuerySJQLSJPredicate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attribute** | **string** | Gets or Sets the attribute Id. Can be \&quot;.\&quot; notated. For attributes from the joined archetypes, it should start with the ArchetypeId. Root archetype id can be omitted. e.g. MattDate.Client1.Number. | [optional] 
**Operator** | [**E3EAPIQuerySJQLSJConditionalOperator**](E3EAPIQuerySJQLSJConditionalOperator.md) | Gets or Sets the conditional operator. | [optional] 
**OperatorUnit** | [**E3EAPIQuerySJQLSJConditionalOperatorUnit**](E3EAPIQuerySJQLSJConditionalOperatorUnit.md) | Gets or Sets the conditional operator unit. | [optional] 
**Value** | **List&lt;string&gt;** | Gets or Sets the value. | [optional] 
**Select** | [**E3EAPIQuerySJQLSJSelect**](E3EAPIQuerySJQLSJSelect.md) | Gets or sets the Select statement to be used instead of the Value. May be more comoonly used with IsIn and IsNotIn operators. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

