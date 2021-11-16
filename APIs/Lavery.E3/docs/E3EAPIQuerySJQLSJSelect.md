
# Org.OpenAPITools.Model.E3EAPIQuerySJQLSJSelect

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Archetype** | **string** | Gets or Sets the archetype id for the query | [optional] 
**ArchetypeType** | [**E3EAPIAppObjectType**](E3EAPIAppObjectType.md) | Gets or sets the Archetype Type. It can be Archetype, MetricArchetype or MetricArchetype Group | [optional] 
**Top** | **int?** | Gets or Sets the maximum number of rows to return | [optional] 
**Attributes** | **List&lt;string&gt;** | Gets or Sets the attributes for the select values. Can be \&quot;.\&quot; notated. For attributes from the joined archetypes, it should start with the ArchetypeId. Root archetype id can be omitted. e.g. MattDate.Client1.Number. | [optional] 
**Where** | [**E3EAPIQuerySJQLSJPredicateGroup**](E3EAPIQuerySJQLSJPredicateGroup.md) | Gets or Sets Filter on the select query | [optional] 
**Joins** | [**List&lt;E3EAPIQuerySJQLSJJoin&gt;**](E3EAPIQuerySJQLSJJoin.md) | Gets or Sets the Joins for the select statement | [optional] 
**SortBy** | [**List&lt;E3EAPIQuerySortAttribute&gt;**](E3EAPIQuerySortAttribute.md) | Gets or Sets the sort attributes for the select query. Can be \&quot;.\&quot; notated. For attributes from the joined archetypes, it should start with the ArchetypeId. Root archetype id can be omitted. e.g. MattDate.Client1.Number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

