# Org.OpenAPITools.Api.CostApi

All URIs are relative to *http://ldbm3ewapi1/TE_3E_SAMPLE/web*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CostCreatePendingCostCard**](CostApi.md#costcreatependingcostcard) | **POST** /api/v1/cost/pending | Creates a new PendingCostCard.
[**CostCreatePostedCostCard**](CostApi.md#costcreatepostedcostcard) | **POST** /api/v1/cost/posted | Creates a new CostCard.
[**CostGetNewPendingCostCard**](CostApi.md#costgetnewpendingcostcard) | **GET** /api/v1/cost/pending/template | Gets a new PendingCostCard with default values.
[**CostGetNewPostedCostCard**](CostApi.md#costgetnewpostedcostcard) | **GET** /api/v1/cost/posted/template | Gets a new CostCard with default values.
[**CostGetPendingCostCardSchema**](CostApi.md#costgetpendingcostcardschema) | **GET** /api/v1/cost/pending/schema | Gets the schema for PendingCostCard.
[**CostGetPendingCostCards**](CostApi.md#costgetpendingcostcards) | **GET** /api/v1/cost/pending | Gets PendingCostCards and returns a CostCardGetResponse.
[**CostGetPostedCostCardSchema**](CostApi.md#costgetpostedcostcardschema) | **GET** /api/v1/cost/posted/schema | Gets the schema for CostCard.
[**CostGetPostedCostCards**](CostApi.md#costgetpostedcostcards) | **GET** /api/v1/cost/posted | Gets CostCards and returns a CostCardGetResponse.
[**CostModelFromPendingCostCards**](CostApi.md#costmodelfrompendingcostcards) | **GET** /api/v1/cost/pending/modelfrom | Gets cloned PendingCostCards and returns a CostCardGetResponse.
[**CostModelFromPostedCostCards**](CostApi.md#costmodelfrompostedcostcards) | **GET** /api/v1/cost/posted/modelfrom | Gets cloned CostCards and returns a CostCardGetResponse.
[**CostUpdatePendingCostCard**](CostApi.md#costupdatependingcostcard) | **PATCH** /api/v1/cost/pending | Updates a PendingCostCard.
[**CostUpdatePostedCostCard**](CostApi.md#costupdatepostedcostcard) | **PATCH** /api/v1/cost/posted | Updates a CostCard.
[**CostValidatePendingCostCards**](CostApi.md#costvalidatependingcostcards) | **POST** /api/v1/cost/pending/validate | Validates one or more existing PendingCostCards.
[**CostValidatePostedCostCards**](CostApi.md#costvalidatepostedcostcards) | **POST** /api/v1/cost/posted/validate | Validates one or more existing CostCards.



## CostCreatePendingCostCard

> E3EAPICostModelsCostCardCreateResponse CostCreatePendingCostCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPICostModelsCostCardCreateRequest e3EAPICostModelsCostCardCreateRequest = null)

Creates a new PendingCostCard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostCreatePendingCostCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPICostModelsCostCardCreateRequest = new E3EAPICostModelsCostCardCreateRequest(); // E3EAPICostModelsCostCardCreateRequest | The request details. (optional) 

            try
            {
                // Creates a new PendingCostCard.
                E3EAPICostModelsCostCardCreateResponse result = apiInstance.CostCreatePendingCostCard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPICostModelsCostCardCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostCreatePendingCostCard: " + e.Message );
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
 **e3EAPICostModelsCostCardCreateRequest** | [**E3EAPICostModelsCostCardCreateRequest**](E3EAPICostModelsCostCardCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPICostModelsCostCardCreateResponse**](E3EAPICostModelsCostCardCreateResponse.md)

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
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostCreatePostedCostCard

> E3EAPICostModelsCostCardCreateResponse CostCreatePostedCostCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPICostModelsCostCardCreateRequest e3EAPICostModelsCostCardCreateRequest = null)

Creates a new CostCard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostCreatePostedCostCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPICostModelsCostCardCreateRequest = new E3EAPICostModelsCostCardCreateRequest(); // E3EAPICostModelsCostCardCreateRequest | The request details. (optional) 

            try
            {
                // Creates a new CostCard.
                E3EAPICostModelsCostCardCreateResponse result = apiInstance.CostCreatePostedCostCard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPICostModelsCostCardCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostCreatePostedCostCard: " + e.Message );
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
 **e3EAPICostModelsCostCardCreateRequest** | [**E3EAPICostModelsCostCardCreateRequest**](E3EAPICostModelsCostCardCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPICostModelsCostCardCreateResponse**](E3EAPICostModelsCostCardCreateResponse.md)

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
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostGetNewPendingCostCard

> E3EAPICostModelsCostCardTemplateResponse CostGetNewPendingCostCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets a new PendingCostCard with default values.

This method does not launch a process or add any data in 3E.  It is intended to be used with CreateCostCard.  e.g. call this method, then set whichever attributes need to be changed and then call CreateCostCard with the modified data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostGetNewPendingCostCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets a new PendingCostCard with default values.
                E3EAPICostModelsCostCardTemplateResponse result = apiInstance.CostGetNewPendingCostCard(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostGetNewPendingCostCard: " + e.Message );
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

[**E3EAPICostModelsCostCardTemplateResponse**](E3EAPICostModelsCostCardTemplateResponse.md)

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
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostGetNewPostedCostCard

> E3EAPICostModelsCostCardTemplateResponse CostGetNewPostedCostCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets a new CostCard with default values.

This method does not launch a process or add any data in 3E.  It is intended to be used with CreateCostCard.  e.g. call this method, then set whichever attributes need to be changed and then call CreateCostCard with the modified data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostGetNewPostedCostCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets a new CostCard with default values.
                E3EAPICostModelsCostCardTemplateResponse result = apiInstance.CostGetNewPostedCostCard(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostGetNewPostedCostCard: " + e.Message );
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

[**E3EAPICostModelsCostCardTemplateResponse**](E3EAPICostModelsCostCardTemplateResponse.md)

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
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostGetPendingCostCardSchema

> E3EAPICostModelsCostCardGetSchemaResponse CostGetPendingCostCardSchema (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets the schema for PendingCostCard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostGetPendingCostCardSchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets the schema for PendingCostCard.
                E3EAPICostModelsCostCardGetSchemaResponse result = apiInstance.CostGetPendingCostCardSchema(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostGetPendingCostCardSchema: " + e.Message );
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

[**E3EAPICostModelsCostCardGetSchemaResponse**](E3EAPICostModelsCostCardGetSchemaResponse.md)

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
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostGetPendingCostCards

> E3EAPICostModelsCostCardGetResponse CostGetPendingCostCards (DateTime? startDate = null, DateTime? endDate = null, List<Guid> costcardID = null, int? costPeindIndex = null, string costType = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, int? matterIndex = null, string matterNumber = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets PendingCostCards and returns a CostCardGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostGetPendingCostCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the StartDate (WorkDate). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the EndDate (WorkDate). (optional) 
            var costcardID = new List<Guid>(); // List<Guid> | Gets or sets the CostcardIDs. (optional) 
            var costPeindIndex = 56;  // int? | Gets or sets the CostPeindIndex. (optional) 
            var costType = costType_example;  // string | Gets or sets the CostType. (optional) 
            var timekeeperIndex = 56;  // int? |  (optional) 
            var timekeeperNumber = timekeeperNumber_example;  // string |  (optional) 
            var timekeeperID = new Guid?(); // Guid? |  (optional) 
            var matterIndex = 56;  // int? | Gets or sets MatterIndex. (optional) 
            var matterNumber = matterNumber_example;  // string | Gets or sets MatterNumber. (optional) 
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
                // Gets PendingCostCards and returns a CostCardGetResponse.
                E3EAPICostModelsCostCardGetResponse result = apiInstance.CostGetPendingCostCards(startDate, endDate, costcardID, costPeindIndex, costType, timekeeperIndex, timekeeperNumber, timekeeperID, matterIndex, matterNumber, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostGetPendingCostCards: " + e.Message );
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
 **startDate** | **DateTime?**| Gets or sets the StartDate (WorkDate). | [optional] 
 **endDate** | **DateTime?**| Gets or sets the EndDate (WorkDate). | [optional] 
 **costcardID** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the CostcardIDs. | [optional] 
 **costPeindIndex** | **int?**| Gets or sets the CostPeindIndex. | [optional] 
 **costType** | **string**| Gets or sets the CostType. | [optional] 
 **timekeeperIndex** | **int?**|  | [optional] 
 **timekeeperNumber** | **string**|  | [optional] 
 **timekeeperID** | [**Guid?**](Guid?.md)|  | [optional] 
 **matterIndex** | **int?**| Gets or sets MatterIndex. | [optional] 
 **matterNumber** | **string**| Gets or sets MatterNumber. | [optional] 
 **advancedFilterAttributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterFilterXOQL** | **string**|  | [optional] 
 **advancedFilterFilterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **advancedFilterFilterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **advancedFilterFilterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPICostModelsCostCardGetResponse**](E3EAPICostModelsCostCardGetResponse.md)

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
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostGetPostedCostCardSchema

> E3EAPICostModelsCostCardGetSchemaResponse CostGetPostedCostCardSchema (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets the schema for CostCard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostGetPostedCostCardSchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets the schema for CostCard.
                E3EAPICostModelsCostCardGetSchemaResponse result = apiInstance.CostGetPostedCostCardSchema(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostGetPostedCostCardSchema: " + e.Message );
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

[**E3EAPICostModelsCostCardGetSchemaResponse**](E3EAPICostModelsCostCardGetSchemaResponse.md)

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
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostGetPostedCostCards

> E3EAPICostModelsCostCardGetResponse CostGetPostedCostCards (DateTime? startDate = null, DateTime? endDate = null, List<Guid> costcardID = null, int? costIndex = null, string costType = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, int? matterIndex = null, string matterNumber = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets CostCards and returns a CostCardGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostGetPostedCostCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the StartDate (WorkDate). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the EndDate (WorkDate). (optional) 
            var costcardID = new List<Guid>(); // List<Guid> | Gets or sets the CostcardIDs. (optional) 
            var costIndex = 56;  // int? | Gets or sets the CostIndex. (optional) 
            var costType = costType_example;  // string | Gets or sets the CostType. (optional) 
            var timekeeperIndex = 56;  // int? |  (optional) 
            var timekeeperNumber = timekeeperNumber_example;  // string |  (optional) 
            var timekeeperID = new Guid?(); // Guid? |  (optional) 
            var matterIndex = 56;  // int? | Gets or sets MatterIndex. (optional) 
            var matterNumber = matterNumber_example;  // string | Gets or sets MatterNumber. (optional) 
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
                // Gets CostCards and returns a CostCardGetResponse.
                E3EAPICostModelsCostCardGetResponse result = apiInstance.CostGetPostedCostCards(startDate, endDate, costcardID, costIndex, costType, timekeeperIndex, timekeeperNumber, timekeeperID, matterIndex, matterNumber, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostGetPostedCostCards: " + e.Message );
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
 **startDate** | **DateTime?**| Gets or sets the StartDate (WorkDate). | [optional] 
 **endDate** | **DateTime?**| Gets or sets the EndDate (WorkDate). | [optional] 
 **costcardID** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the CostcardIDs. | [optional] 
 **costIndex** | **int?**| Gets or sets the CostIndex. | [optional] 
 **costType** | **string**| Gets or sets the CostType. | [optional] 
 **timekeeperIndex** | **int?**|  | [optional] 
 **timekeeperNumber** | **string**|  | [optional] 
 **timekeeperID** | [**Guid?**](Guid?.md)|  | [optional] 
 **matterIndex** | **int?**| Gets or sets MatterIndex. | [optional] 
 **matterNumber** | **string**| Gets or sets MatterNumber. | [optional] 
 **advancedFilterAttributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterFilterXOQL** | **string**|  | [optional] 
 **advancedFilterFilterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **advancedFilterFilterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **advancedFilterFilterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPICostModelsCostCardGetResponse**](E3EAPICostModelsCostCardGetResponse.md)

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
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostModelFromPendingCostCards

> E3EAPICostModelsCostCardGetResponse CostModelFromPendingCostCards (List<string> itemId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets cloned PendingCostCards and returns a CostCardGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostModelFromPendingCostCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var itemId = new List<string>(); // List<string> |  (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets cloned PendingCostCards and returns a CostCardGetResponse.
                E3EAPICostModelsCostCardGetResponse result = apiInstance.CostModelFromPendingCostCards(itemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostModelFromPendingCostCards: " + e.Message );
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

[**E3EAPICostModelsCostCardGetResponse**](E3EAPICostModelsCostCardGetResponse.md)

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
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostModelFromPostedCostCards

> E3EAPICostModelsCostCardGetResponse CostModelFromPostedCostCards (List<string> itemId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets cloned CostCards and returns a CostCardGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostModelFromPostedCostCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var itemId = new List<string>(); // List<string> |  (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets cloned CostCards and returns a CostCardGetResponse.
                E3EAPICostModelsCostCardGetResponse result = apiInstance.CostModelFromPostedCostCards(itemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostModelFromPostedCostCards: " + e.Message );
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

[**E3EAPICostModelsCostCardGetResponse**](E3EAPICostModelsCostCardGetResponse.md)

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
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostUpdatePendingCostCard

> E3EAPICostModelsCostCardUpdateResponse CostUpdatePendingCostCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPICostModelsCostCardUpdateRequest e3EAPICostModelsCostCardUpdateRequest = null)

Updates a PendingCostCard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostUpdatePendingCostCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPICostModelsCostCardUpdateRequest = new E3EAPICostModelsCostCardUpdateRequest(); // E3EAPICostModelsCostCardUpdateRequest | The request details. (optional) 

            try
            {
                // Updates a PendingCostCard.
                E3EAPICostModelsCostCardUpdateResponse result = apiInstance.CostUpdatePendingCostCard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPICostModelsCostCardUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostUpdatePendingCostCard: " + e.Message );
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
 **e3EAPICostModelsCostCardUpdateRequest** | [**E3EAPICostModelsCostCardUpdateRequest**](E3EAPICostModelsCostCardUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPICostModelsCostCardUpdateResponse**](E3EAPICostModelsCostCardUpdateResponse.md)

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
| **404** | NotFound - The CostCard to be updated does not exist. |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostUpdatePostedCostCard

> E3EAPICostModelsCostCardUpdateResponse CostUpdatePostedCostCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPICostModelsCostCardUpdateRequest e3EAPICostModelsCostCardUpdateRequest = null)

Updates a CostCard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostUpdatePostedCostCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPICostModelsCostCardUpdateRequest = new E3EAPICostModelsCostCardUpdateRequest(); // E3EAPICostModelsCostCardUpdateRequest | The request details. (optional) 

            try
            {
                // Updates a CostCard.
                E3EAPICostModelsCostCardUpdateResponse result = apiInstance.CostUpdatePostedCostCard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPICostModelsCostCardUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostUpdatePostedCostCard: " + e.Message );
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
 **e3EAPICostModelsCostCardUpdateRequest** | [**E3EAPICostModelsCostCardUpdateRequest**](E3EAPICostModelsCostCardUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPICostModelsCostCardUpdateResponse**](E3EAPICostModelsCostCardUpdateResponse.md)

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
| **404** | NotFound - The CostCard to be updated does not exist. |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostValidatePendingCostCards

> E3EAPICostModelsCostCardValidateResponse CostValidatePendingCostCards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPICostModelsCostCardValidateRequest e3EAPICostModelsCostCardValidateRequest = null)

Validates one or more existing PendingCostCards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostValidatePendingCostCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPICostModelsCostCardValidateRequest = new E3EAPICostModelsCostCardValidateRequest(); // E3EAPICostModelsCostCardValidateRequest | The PendingCostCard.CostIndex values of the CostCards to be validated. (optional) 

            try
            {
                // Validates one or more existing PendingCostCards.
                E3EAPICostModelsCostCardValidateResponse result = apiInstance.CostValidatePendingCostCards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPICostModelsCostCardValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostValidatePendingCostCards: " + e.Message );
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
 **e3EAPICostModelsCostCardValidateRequest** | [**E3EAPICostModelsCostCardValidateRequest**](E3EAPICostModelsCostCardValidateRequest.md)| The PendingCostCard.CostIndex values of the CostCards to be validated. | [optional] 

### Return type

[**E3EAPICostModelsCostCardValidateResponse**](E3EAPICostModelsCostCardValidateResponse.md)

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
| **404** | NotFound - The CostCard to be validated does not exist. |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CostValidatePostedCostCards

> E3EAPICostModelsCostCardValidateResponse CostValidatePostedCostCards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPICostModelsCostCardValidateRequest e3EAPICostModelsCostCardValidateRequest = null)

Validates one or more existing CostCards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CostValidatePostedCostCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new CostApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPICostModelsCostCardValidateRequest = new E3EAPICostModelsCostCardValidateRequest(); // E3EAPICostModelsCostCardValidateRequest | The CostCard.CostIndex values of the CostCards to be validated. (optional) 

            try
            {
                // Validates one or more existing CostCards.
                E3EAPICostModelsCostCardValidateResponse result = apiInstance.CostValidatePostedCostCards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPICostModelsCostCardValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CostApi.CostValidatePostedCostCards: " + e.Message );
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
 **e3EAPICostModelsCostCardValidateRequest** | [**E3EAPICostModelsCostCardValidateRequest**](E3EAPICostModelsCostCardValidateRequest.md)| The CostCard.CostIndex values of the CostCards to be validated. | [optional] 

### Return type

[**E3EAPICostModelsCostCardValidateResponse**](E3EAPICostModelsCostCardValidateResponse.md)

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
| **404** | NotFound - The CostCard to be validated does not exist. |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

