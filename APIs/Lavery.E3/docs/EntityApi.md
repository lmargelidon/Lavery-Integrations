# Org.OpenAPITools.Api.EntityApi

All URIs are relative to *http://ldbm3ewapi1/TE_3E_SAMPLE/web*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EntityCloneEntity**](EntityApi.md#entitycloneentity) | **POST** /api/v1/entity/clone | Clones one or more Entities.
[**EntityCreateOrganization**](EntityApi.md#entitycreateorganization) | **POST** /api/v1/entity/organization | Creates a new Entity Organization.
[**EntityCreatePerson**](EntityApi.md#entitycreateperson) | **POST** /api/v1/entity/person | Creates a new Entity Person.
[**EntityDeleteEntity**](EntityApi.md#entitydeleteentity) | **DELETE** /api/v1/entity | Deletes one or more existing Entity.
[**EntityGetAllEntities**](EntityApi.md#entitygetallentities) | **GET** /api/v1/entity/all | Gets Entities and returns a EntityGetResponse.
[**EntityGetNewOrganization**](EntityApi.md#entitygetneworganization) | **GET** /api/v1/entity/organization/template | Gets a new EntityOrg with default values.
[**EntityGetNewPerson**](EntityApi.md#entitygetnewperson) | **GET** /api/v1/entity/person/template | Gets a new EntityPerson with default values.
[**EntityGetOrganizationSchema**](EntityApi.md#entitygetorganizationschema) | **GET** /api/v1/entity/organization/schema | Gets the schema for Matter.
[**EntityGetOrganizations**](EntityApi.md#entitygetorganizations) | **GET** /api/v1/entity/organization | Gets EntityOrganizations and returns a EntityGetResponse.
[**EntityGetPersonSchema**](EntityApi.md#entitygetpersonschema) | **GET** /api/v1/entity/person/schema | Gets the schema for EntityPerson.
[**EntityGetPersons**](EntityApi.md#entitygetpersons) | **GET** /api/v1/entity/person | Gets EntityPersons and returns a EntityGetResponse.
[**EntityModelFromEntities**](EntityApi.md#entitymodelfromentities) | **GET** /api/v1/entity/modelfrom | Gets cloned Entities and returns a EntityGetResponse.
[**EntityUpdateEntity**](EntityApi.md#entityupdateentity) | **PATCH** /api/v1/entity | Updates an Entity.



## EntityCloneEntity

> E3EAPIEntityModelsEntityCloneResponse EntityCloneEntity (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIEntityModelsEntityCloneRequest e3EAPIEntityModelsEntityCloneRequest = null)

Clones one or more Entities.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityCloneEntityExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIEntityModelsEntityCloneRequest = new E3EAPIEntityModelsEntityCloneRequest(); // E3EAPIEntityModelsEntityCloneRequest | The request details. (optional) 

            try
            {
                // Clones one or more Entities.
                E3EAPIEntityModelsEntityCloneResponse result = apiInstance.EntityCloneEntity(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIEntityModelsEntityCloneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityCloneEntity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]
 **e3EAPIEntityModelsEntityCloneRequest** | [**E3EAPIEntityModelsEntityCloneRequest**](E3EAPIEntityModelsEntityCloneRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIEntityModelsEntityCloneResponse**](E3EAPIEntityModelsEntityCloneResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityCreateOrganization

> E3EAPIEntityModelsEntityCreateResponse EntityCreateOrganization (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIEntityModelsEntityCreateRequest e3EAPIEntityModelsEntityCreateRequest = null)

Creates a new Entity Organization.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityCreateOrganizationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIEntityModelsEntityCreateRequest = new E3EAPIEntityModelsEntityCreateRequest(); // E3EAPIEntityModelsEntityCreateRequest | The request details. (optional) 

            try
            {
                // Creates a new Entity Organization.
                E3EAPIEntityModelsEntityCreateResponse result = apiInstance.EntityCreateOrganization(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIEntityModelsEntityCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityCreateOrganization: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]
 **e3EAPIEntityModelsEntityCreateRequest** | [**E3EAPIEntityModelsEntityCreateRequest**](E3EAPIEntityModelsEntityCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIEntityModelsEntityCreateResponse**](E3EAPIEntityModelsEntityCreateResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityCreatePerson

> E3EAPIEntityModelsEntityCreateResponse EntityCreatePerson (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIEntityModelsEntityCreateRequest e3EAPIEntityModelsEntityCreateRequest = null)

Creates a new Entity Person.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityCreatePersonExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIEntityModelsEntityCreateRequest = new E3EAPIEntityModelsEntityCreateRequest(); // E3EAPIEntityModelsEntityCreateRequest | The request details. (optional) 

            try
            {
                // Creates a new Entity Person.
                E3EAPIEntityModelsEntityCreateResponse result = apiInstance.EntityCreatePerson(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIEntityModelsEntityCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityCreatePerson: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]
 **e3EAPIEntityModelsEntityCreateRequest** | [**E3EAPIEntityModelsEntityCreateRequest**](E3EAPIEntityModelsEntityCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIEntityModelsEntityCreateResponse**](E3EAPIEntityModelsEntityCreateResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityDeleteEntity

> E3EAPIEntityModelsEntityDeleteResponse EntityDeleteEntity (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIEntityModelsEntityDeleteRequest e3EAPIEntityModelsEntityDeleteRequest = null)

Deletes one or more existing Entity.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityDeleteEntityExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIEntityModelsEntityDeleteRequest = new E3EAPIEntityModelsEntityDeleteRequest(); // E3EAPIEntityModelsEntityDeleteRequest | The request details. (optional) 

            try
            {
                // Deletes one or more existing Entity.
                E3EAPIEntityModelsEntityDeleteResponse result = apiInstance.EntityDeleteEntity(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIEntityModelsEntityDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityDeleteEntity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]
 **e3EAPIEntityModelsEntityDeleteRequest** | [**E3EAPIEntityModelsEntityDeleteRequest**](E3EAPIEntityModelsEntityDeleteRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIEntityModelsEntityDeleteResponse**](E3EAPIEntityModelsEntityDeleteResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityGetAllEntities

> E3EAPIEntityModelsEntityGetRequest EntityGetAllEntities (List<Guid> entityId = null, int? entityIndex = null, string displayName = null, List<string> advancedFilterChildObjectsToInclude = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets Entities and returns a EntityGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityGetAllEntitiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var entityId = new List<Guid>(); // List<Guid> | Gets or sets the EntityIds. (optional) 
            var entityIndex = 56;  // int? | Gets or sets the EntityIndex. (optional) 
            var displayName = displayName_example;  // string | Gets or sets the DisplayName (Entity Alias). (optional) 
            var advancedFilterChildObjectsToInclude = new List<string>(); // List<string> |  (optional) 
            var advancedFilterAttributesToInclude = new List<string>(); // List<string> |  (optional) 
            var advancedFilterFilterXOQL = advancedFilterFilterXOQL_example;  // string |  (optional) 
            var advancedFilterFilterPredicates = new List<E3EAPIQuerySJQLSJPredicate>(); // List<E3EAPIQuerySJQLSJPredicate> | Gets or Sets predicates. (optional) 
            var advancedFilterFilterOperator = ;  // E3EAPIQuerySJQLSJLogicalOperator? | Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. (optional) 
            var advancedFilterFilterGroups = new List<E3EAPIQuerySJQLSJPredicateGroup>(); // List<E3EAPIQuerySJQLSJPredicateGroup> | Gets or Sets group of predicates based on a logical operator. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets Entities and returns a EntityGetResponse.
                E3EAPIEntityModelsEntityGetRequest result = apiInstance.EntityGetAllEntities(entityId, entityIndex, displayName, advancedFilterChildObjectsToInclude, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityGetAllEntities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityId** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the EntityIds. | [optional] 
 **entityIndex** | **int?**| Gets or sets the EntityIndex. | [optional] 
 **displayName** | **string**| Gets or sets the DisplayName (Entity Alias). | [optional] 
 **advancedFilterChildObjectsToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterAttributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterFilterXOQL** | **string**|  | [optional] 
 **advancedFilterFilterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **advancedFilterFilterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **advancedFilterFilterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIEntityModelsEntityGetRequest**](E3EAPIEntityModelsEntityGetRequest.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityGetNewOrganization

> E3EAPIEntityModelsEntityTemplateResponse EntityGetNewOrganization (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets a new EntityOrg with default values.

This method does not launch a process or add any data in 3E.  It is intended to be used with CreateMatter.  e.g. call this method, then set whichever attributes need to be changed and then call CreateEntityOrg with the modified data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityGetNewOrganizationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets a new EntityOrg with default values.
                E3EAPIEntityModelsEntityTemplateResponse result = apiInstance.EntityGetNewOrganization(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityGetNewOrganization: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIEntityModelsEntityTemplateResponse**](E3EAPIEntityModelsEntityTemplateResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityGetNewPerson

> E3EAPIEntityModelsEntityTemplateResponse EntityGetNewPerson (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets a new EntityPerson with default values.

This method does not launch a process or add any data in 3E.  It is intended to be used with CreateMatter.  e.g. call this method, then set whichever attributes need to be changed and then call CreateEntityPerson with the modified data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityGetNewPersonExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets a new EntityPerson with default values.
                E3EAPIEntityModelsEntityTemplateResponse result = apiInstance.EntityGetNewPerson(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityGetNewPerson: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIEntityModelsEntityTemplateResponse**](E3EAPIEntityModelsEntityTemplateResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityGetOrganizationSchema

> E3EAPIEntityModelsEntityGetSchemaResponse EntityGetOrganizationSchema (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets the schema for Matter.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityGetOrganizationSchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets the schema for Matter.
                E3EAPIEntityModelsEntityGetSchemaResponse result = apiInstance.EntityGetOrganizationSchema(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityGetOrganizationSchema: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIEntityModelsEntityGetSchemaResponse**](E3EAPIEntityModelsEntityGetSchemaResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityGetOrganizations

> E3EAPIEntityModelsEntityGetRequest EntityGetOrganizations (List<Guid> entityId = null, int? entityIndex = null, string displayName = null, List<string> advancedFilterChildObjectsToInclude = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets EntityOrganizations and returns a EntityGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityGetOrganizationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var entityId = new List<Guid>(); // List<Guid> | Gets or sets the EntityIds. (optional) 
            var entityIndex = 56;  // int? | Gets or sets the EntityIndex. (optional) 
            var displayName = displayName_example;  // string | Gets or sets the DisplayName (Entity Alias). (optional) 
            var advancedFilterChildObjectsToInclude = new List<string>(); // List<string> |  (optional) 
            var advancedFilterAttributesToInclude = new List<string>(); // List<string> |  (optional) 
            var advancedFilterFilterXOQL = advancedFilterFilterXOQL_example;  // string |  (optional) 
            var advancedFilterFilterPredicates = new List<E3EAPIQuerySJQLSJPredicate>(); // List<E3EAPIQuerySJQLSJPredicate> | Gets or Sets predicates. (optional) 
            var advancedFilterFilterOperator = ;  // E3EAPIQuerySJQLSJLogicalOperator? | Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. (optional) 
            var advancedFilterFilterGroups = new List<E3EAPIQuerySJQLSJPredicateGroup>(); // List<E3EAPIQuerySJQLSJPredicateGroup> | Gets or Sets group of predicates based on a logical operator. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets EntityOrganizations and returns a EntityGetResponse.
                E3EAPIEntityModelsEntityGetRequest result = apiInstance.EntityGetOrganizations(entityId, entityIndex, displayName, advancedFilterChildObjectsToInclude, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityGetOrganizations: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityId** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the EntityIds. | [optional] 
 **entityIndex** | **int?**| Gets or sets the EntityIndex. | [optional] 
 **displayName** | **string**| Gets or sets the DisplayName (Entity Alias). | [optional] 
 **advancedFilterChildObjectsToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterAttributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterFilterXOQL** | **string**|  | [optional] 
 **advancedFilterFilterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **advancedFilterFilterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **advancedFilterFilterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIEntityModelsEntityGetRequest**](E3EAPIEntityModelsEntityGetRequest.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityGetPersonSchema

> E3EAPIEntityModelsEntityGetSchemaResponse EntityGetPersonSchema (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets the schema for EntityPerson.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityGetPersonSchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets the schema for EntityPerson.
                E3EAPIEntityModelsEntityGetSchemaResponse result = apiInstance.EntityGetPersonSchema(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityGetPersonSchema: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIEntityModelsEntityGetSchemaResponse**](E3EAPIEntityModelsEntityGetSchemaResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityGetPersons

> E3EAPIEntityModelsEntityGetRequest EntityGetPersons (List<Guid> entityId = null, int? entityIndex = null, string displayName = null, List<string> advancedFilterChildObjectsToInclude = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets EntityPersons and returns a EntityGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityGetPersonsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var entityId = new List<Guid>(); // List<Guid> | Gets or sets the EntityIds. (optional) 
            var entityIndex = 56;  // int? | Gets or sets the EntityIndex. (optional) 
            var displayName = displayName_example;  // string | Gets or sets the DisplayName (Entity Alias). (optional) 
            var advancedFilterChildObjectsToInclude = new List<string>(); // List<string> |  (optional) 
            var advancedFilterAttributesToInclude = new List<string>(); // List<string> |  (optional) 
            var advancedFilterFilterXOQL = advancedFilterFilterXOQL_example;  // string |  (optional) 
            var advancedFilterFilterPredicates = new List<E3EAPIQuerySJQLSJPredicate>(); // List<E3EAPIQuerySJQLSJPredicate> | Gets or Sets predicates. (optional) 
            var advancedFilterFilterOperator = ;  // E3EAPIQuerySJQLSJLogicalOperator? | Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. (optional) 
            var advancedFilterFilterGroups = new List<E3EAPIQuerySJQLSJPredicateGroup>(); // List<E3EAPIQuerySJQLSJPredicateGroup> | Gets or Sets group of predicates based on a logical operator. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets EntityPersons and returns a EntityGetResponse.
                E3EAPIEntityModelsEntityGetRequest result = apiInstance.EntityGetPersons(entityId, entityIndex, displayName, advancedFilterChildObjectsToInclude, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityGetPersons: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityId** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the EntityIds. | [optional] 
 **entityIndex** | **int?**| Gets or sets the EntityIndex. | [optional] 
 **displayName** | **string**| Gets or sets the DisplayName (Entity Alias). | [optional] 
 **advancedFilterChildObjectsToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterAttributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterFilterXOQL** | **string**|  | [optional] 
 **advancedFilterFilterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **advancedFilterFilterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **advancedFilterFilterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIEntityModelsEntityGetRequest**](E3EAPIEntityModelsEntityGetRequest.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityModelFromEntities

> E3EAPIEntityModelsEntityGetResponse EntityModelFromEntities (List<string> itemId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets cloned Entities and returns a EntityGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityModelFromEntitiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var itemId = new List<string>(); // List<string> |  (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets cloned Entities and returns a EntityGetResponse.
                E3EAPIEntityModelsEntityGetResponse result = apiInstance.EntityModelFromEntities(itemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityModelFromEntities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIEntityModelsEntityGetResponse**](E3EAPIEntityModelsEntityGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EntityUpdateEntity

> E3EAPIEntityModelsEntityUpdateResponse EntityUpdateEntity (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIEntityModelsEntityUpdateRequest e3EAPIEntityModelsEntityUpdateRequest = null)

Updates an Entity.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EntityUpdateEntityExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new EntityApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIEntityModelsEntityUpdateRequest = new E3EAPIEntityModelsEntityUpdateRequest(); // E3EAPIEntityModelsEntityUpdateRequest | The request details. (optional) 

            try
            {
                // Updates an Entity.
                E3EAPIEntityModelsEntityUpdateResponse result = apiInstance.EntityUpdateEntity(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIEntityModelsEntityUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EntityApi.EntityUpdateEntity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]
 **e3EAPIEntityModelsEntityUpdateRequest** | [**E3EAPIEntityModelsEntityUpdateRequest**](E3EAPIEntityModelsEntityUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIEntityModelsEntityUpdateResponse**](E3EAPIEntityModelsEntityUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized - Has not been authorized by Windows or Azure Active directory. |  -  |
| **403** | Forbidden - The authenticated user or application is not allowed perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **207** | Success |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

