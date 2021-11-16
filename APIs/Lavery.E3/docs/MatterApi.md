# Org.OpenAPITools.Api.MatterApi

All URIs are relative to *http://ldbm3ewapi1/TE_3E_SAMPLE/web*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MatterCreateMatter**](MatterApi.md#mattercreatematter) | **POST** /api/v1/matter | Creates a new Matter.
[**MatterCreateMatterNickname**](MatterApi.md#mattercreatematternickname) | **POST** /api/v1/matter/nickname | Creates a new Matter Nickname.
[**MatterCreateTempMatter**](MatterApi.md#mattercreatetempmatter) | **POST** /api/v1/matter/temp | Creates a new Temp Matter.
[**MatterDeleteMatterNickname**](MatterApi.md#matterdeletematternickname) | **DELETE** /api/v1/matter/nickname | Deletes one or more existing matter nicknames.
[**MatterDeleteTempMatter**](MatterApi.md#matterdeletetempmatter) | **DELETE** /api/v1/matter/temp | Deletes the specified Temp Matters.
[**MatterGetMatterNicknames**](MatterApi.md#mattergetmatternicknames) | **GET** /api/v1/matter/nickname | Gets Matter Nicknames and returns a MatterNicknameGetResponse.
[**MatterGetMatterSchema**](MatterApi.md#mattergetmatterschema) | **GET** /api/v1/matter/schema | Gets the schema for Matter.
[**MatterGetMatters**](MatterApi.md#mattergetmatters) | **GET** /api/v1/matter | Gets Matters and returns a MatterGetResponse.
[**MatterGetNewMatter**](MatterApi.md#mattergetnewmatter) | **GET** /api/v1/matter/template | Gets a new Matter with default values.
[**MatterGetTempMatterNameList**](MatterApi.md#mattergettempmatternamelist) | **GET** /api/v1/matter/temp/name | Gets high level Temp Matter name list and returns a TempMatterGetResponse.
[**MatterGetTempMatters**](MatterApi.md#mattergettempmatters) | **GET** /api/v1/matter/temp | Gets Temp Matters and returns a TempMatterGetResponse.
[**MatterModelFromMatters**](MatterApi.md#mattermodelfrommatters) | **GET** /api/v1/matter/modelfrom | Gets cloned Matters and returns a MatterGetResponse.
[**MatterReplaceTempMatter**](MatterApi.md#matterreplacetempmatter) | **POST** /api/v1/matter/temp/replace | Replaces a Temp Matter with an actual matter.
[**MatterUpdateMatter**](MatterApi.md#matterupdatematter) | **PATCH** /api/v1/matter | Updates a Matter.
[**MatterUpdateMatterNickname**](MatterApi.md#matterupdatematternickname) | **PATCH** /api/v1/matter/nickname | Updates a Matter Nickname.
[**MatterValidateMatters**](MatterApi.md#mattervalidatematters) | **POST** /api/v1/matter/validate | Validates one or more existing Matters.



## MatterCreateMatter

> E3EAPIMatterModelsMatterCreateResponse MatterCreateMatter (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIMatterModelsMatterCreateRequest e3EAPIMatterModelsMatterCreateRequest = null)

Creates a new Matter.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterCreateMatterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIMatterModelsMatterCreateRequest = new E3EAPIMatterModelsMatterCreateRequest(); // E3EAPIMatterModelsMatterCreateRequest | The request details. (optional) 

            try
            {
                // Creates a new Matter.
                E3EAPIMatterModelsMatterCreateResponse result = apiInstance.MatterCreateMatter(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIMatterModelsMatterCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterCreateMatter: " + e.Message );
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
 **e3EAPIMatterModelsMatterCreateRequest** | [**E3EAPIMatterModelsMatterCreateRequest**](E3EAPIMatterModelsMatterCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIMatterModelsMatterCreateResponse**](E3EAPIMatterModelsMatterCreateResponse.md)

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


## MatterCreateMatterNickname

> E3EAPIMatterNicknameModelsMatterNicknameCreateResponse MatterCreateMatterNickname (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIMatterNicknameModelsMatterNicknameCreateRequest e3EAPIMatterNicknameModelsMatterNicknameCreateRequest = null)

Creates a new Matter Nickname.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterCreateMatterNicknameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIMatterNicknameModelsMatterNicknameCreateRequest = new E3EAPIMatterNicknameModelsMatterNicknameCreateRequest(); // E3EAPIMatterNicknameModelsMatterNicknameCreateRequest | The request details. (optional) 

            try
            {
                // Creates a new Matter Nickname.
                E3EAPIMatterNicknameModelsMatterNicknameCreateResponse result = apiInstance.MatterCreateMatterNickname(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIMatterNicknameModelsMatterNicknameCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterCreateMatterNickname: " + e.Message );
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
 **e3EAPIMatterNicknameModelsMatterNicknameCreateRequest** | [**E3EAPIMatterNicknameModelsMatterNicknameCreateRequest**](E3EAPIMatterNicknameModelsMatterNicknameCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIMatterNicknameModelsMatterNicknameCreateResponse**](E3EAPIMatterNicknameModelsMatterNicknameCreateResponse.md)

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


## MatterCreateTempMatter

> E3EAPITempMatterModelsTempMatterCreateResponse MatterCreateTempMatter (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITempMatterModelsTempMatterCreateRequest e3EAPITempMatterModelsTempMatterCreateRequest = null)

Creates a new Temp Matter.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterCreateTempMatterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITempMatterModelsTempMatterCreateRequest = new E3EAPITempMatterModelsTempMatterCreateRequest(); // E3EAPITempMatterModelsTempMatterCreateRequest | The request details. (optional) 

            try
            {
                // Creates a new Temp Matter.
                E3EAPITempMatterModelsTempMatterCreateResponse result = apiInstance.MatterCreateTempMatter(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITempMatterModelsTempMatterCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterCreateTempMatter: " + e.Message );
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
 **e3EAPITempMatterModelsTempMatterCreateRequest** | [**E3EAPITempMatterModelsTempMatterCreateRequest**](E3EAPITempMatterModelsTempMatterCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITempMatterModelsTempMatterCreateResponse**](E3EAPITempMatterModelsTempMatterCreateResponse.md)

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


## MatterDeleteMatterNickname

> E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse MatterDeleteMatterNickname (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIMatterNicknameModelsMatterNicknameDeleteRequest e3EAPIMatterNicknameModelsMatterNicknameDeleteRequest = null)

Deletes one or more existing matter nicknames.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterDeleteMatterNicknameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIMatterNicknameModelsMatterNicknameDeleteRequest = new E3EAPIMatterNicknameModelsMatterNicknameDeleteRequest(); // E3EAPIMatterNicknameModelsMatterNicknameDeleteRequest | The MatterNickname.MatterNicknameID values of the matter nicknames to be deleted. (optional) 

            try
            {
                // Deletes one or more existing matter nicknames.
                E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse result = apiInstance.MatterDeleteMatterNickname(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIMatterNicknameModelsMatterNicknameDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterDeleteMatterNickname: " + e.Message );
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
 **e3EAPIMatterNicknameModelsMatterNicknameDeleteRequest** | [**E3EAPIMatterNicknameModelsMatterNicknameDeleteRequest**](E3EAPIMatterNicknameModelsMatterNicknameDeleteRequest.md)| The MatterNickname.MatterNicknameID values of the matter nicknames to be deleted. | [optional] 

### Return type

[**E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse**](E3EAPIMatterNicknameModelsMatterNicknameDeleteResponse.md)

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


## MatterDeleteTempMatter

> E3EAPITempMatterModelsTempMatterDeleteResponse MatterDeleteTempMatter (List<string> itemId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Deletes the specified Temp Matters.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterDeleteTempMatterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var itemId = new List<string>(); // List<string> |  (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Deletes the specified Temp Matters.
                E3EAPITempMatterModelsTempMatterDeleteResponse result = apiInstance.MatterDeleteTempMatter(itemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterDeleteTempMatter: " + e.Message );
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

[**E3EAPITempMatterModelsTempMatterDeleteResponse**](E3EAPITempMatterModelsTempMatterDeleteResponse.md)

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


## MatterGetMatterNicknames

> E3EAPIMatterModelsMatterNicknameGetResponse MatterGetMatterNicknames (List<Guid> matterNicknameId = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets Matter Nicknames and returns a MatterNicknameGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterGetMatterNicknamesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var matterNicknameId = new List<Guid>(); // List<Guid> | Gets or sets the MatterNicknameIds. (optional) 
            var timekeeperIndex = 56;  // int? |  (optional) 
            var timekeeperNumber = timekeeperNumber_example;  // string |  (optional) 
            var timekeeperID = new Guid?(); // Guid? |  (optional) 
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
                // Gets Matter Nicknames and returns a MatterNicknameGetResponse.
                E3EAPIMatterModelsMatterNicknameGetResponse result = apiInstance.MatterGetMatterNicknames(matterNicknameId, timekeeperIndex, timekeeperNumber, timekeeperID, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterGetMatterNicknames: " + e.Message );
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
 **matterNicknameId** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the MatterNicknameIds. | [optional] 
 **timekeeperIndex** | **int?**|  | [optional] 
 **timekeeperNumber** | **string**|  | [optional] 
 **timekeeperID** | [**Guid?**](Guid?.md)|  | [optional] 
 **advancedFilterAttributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterFilterXOQL** | **string**|  | [optional] 
 **advancedFilterFilterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **advancedFilterFilterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **advancedFilterFilterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIMatterModelsMatterNicknameGetResponse**](E3EAPIMatterModelsMatterNicknameGetResponse.md)

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


## MatterGetMatterSchema

> E3EAPIMatterModelsMatterGetSchemaResponse MatterGetMatterSchema (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

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
    public class MatterGetMatterSchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets the schema for Matter.
                E3EAPIMatterModelsMatterGetSchemaResponse result = apiInstance.MatterGetMatterSchema(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterGetMatterSchema: " + e.Message );
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

[**E3EAPIMatterModelsMatterGetSchemaResponse**](E3EAPIMatterModelsMatterGetSchemaResponse.md)

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


## MatterGetMatters

> E3EAPIMatterModelsMatterGetResponse MatterGetMatters (List<Guid> matterId = null, int? mattIndex = null, string number = null, List<string> advancedFilterChildObjectsToInclude = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets Matters and returns a MatterGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterGetMattersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var matterId = new List<Guid>(); // List<Guid> | Gets or sets the MatterIds. (optional) 
            var mattIndex = 56;  // int? | Gets or sets the MattIndex. (optional) 
            var number = number_example;  // string | Gets or sets the Number (Matter Alias). (optional) 
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
                // Gets Matters and returns a MatterGetResponse.
                E3EAPIMatterModelsMatterGetResponse result = apiInstance.MatterGetMatters(matterId, mattIndex, number, advancedFilterChildObjectsToInclude, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterGetMatters: " + e.Message );
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
 **matterId** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the MatterIds. | [optional] 
 **mattIndex** | **int?**| Gets or sets the MattIndex. | [optional] 
 **number** | **string**| Gets or sets the Number (Matter Alias). | [optional] 
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

[**E3EAPIMatterModelsMatterGetResponse**](E3EAPIMatterModelsMatterGetResponse.md)

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


## MatterGetNewMatter

> E3EAPIMatterModelsMatterTemplateResponse MatterGetNewMatter (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets a new Matter with default values.

This method does not launch a process or add any data in 3E.  It is intended to be used with CreateMatter.  e.g. call this method, then set whichever attributes need to be changed and then call CreateMatter with the modified data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterGetNewMatterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets a new Matter with default values.
                E3EAPIMatterModelsMatterTemplateResponse result = apiInstance.MatterGetNewMatter(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterGetNewMatter: " + e.Message );
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

[**E3EAPIMatterModelsMatterTemplateResponse**](E3EAPIMatterModelsMatterTemplateResponse.md)

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


## MatterGetTempMatterNameList

> E3EAPIMatterModelsTempMatterGetResponse MatterGetTempMatterNameList (List<Guid> tempMatterID = null, string tempMatterName = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets high level Temp Matter name list and returns a TempMatterGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterGetTempMatterNameListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var tempMatterID = new List<Guid>(); // List<Guid> | Gets or sets the TempMatterIDs. (optional) 
            var tempMatterName = tempMatterName_example;  // string | Gets or sets the TempMatterName. (optional) 
            var timekeeperIndex = 56;  // int? |  (optional) 
            var timekeeperNumber = timekeeperNumber_example;  // string |  (optional) 
            var timekeeperID = new Guid?(); // Guid? |  (optional) 
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
                // Gets high level Temp Matter name list and returns a TempMatterGetResponse.
                E3EAPIMatterModelsTempMatterGetResponse result = apiInstance.MatterGetTempMatterNameList(tempMatterID, tempMatterName, timekeeperIndex, timekeeperNumber, timekeeperID, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterGetTempMatterNameList: " + e.Message );
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
 **tempMatterID** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the TempMatterIDs. | [optional] 
 **tempMatterName** | **string**| Gets or sets the TempMatterName. | [optional] 
 **timekeeperIndex** | **int?**|  | [optional] 
 **timekeeperNumber** | **string**|  | [optional] 
 **timekeeperID** | [**Guid?**](Guid?.md)|  | [optional] 
 **advancedFilterAttributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterFilterXOQL** | **string**|  | [optional] 
 **advancedFilterFilterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **advancedFilterFilterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **advancedFilterFilterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIMatterModelsTempMatterGetResponse**](E3EAPIMatterModelsTempMatterGetResponse.md)

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


## MatterGetTempMatters

> E3EAPIMatterModelsTempMatterGetResponse MatterGetTempMatters (List<Guid> tempMatterID = null, string tempMatterName = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets Temp Matters and returns a TempMatterGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterGetTempMattersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var tempMatterID = new List<Guid>(); // List<Guid> | Gets or sets the TempMatterIDs. (optional) 
            var tempMatterName = tempMatterName_example;  // string | Gets or sets the TempMatterName. (optional) 
            var timekeeperIndex = 56;  // int? |  (optional) 
            var timekeeperNumber = timekeeperNumber_example;  // string |  (optional) 
            var timekeeperID = new Guid?(); // Guid? |  (optional) 
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
                // Gets Temp Matters and returns a TempMatterGetResponse.
                E3EAPIMatterModelsTempMatterGetResponse result = apiInstance.MatterGetTempMatters(tempMatterID, tempMatterName, timekeeperIndex, timekeeperNumber, timekeeperID, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterGetTempMatters: " + e.Message );
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
 **tempMatterID** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the TempMatterIDs. | [optional] 
 **tempMatterName** | **string**| Gets or sets the TempMatterName. | [optional] 
 **timekeeperIndex** | **int?**|  | [optional] 
 **timekeeperNumber** | **string**|  | [optional] 
 **timekeeperID** | [**Guid?**](Guid?.md)|  | [optional] 
 **advancedFilterAttributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **advancedFilterFilterXOQL** | **string**|  | [optional] 
 **advancedFilterFilterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **advancedFilterFilterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **advancedFilterFilterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIMatterModelsTempMatterGetResponse**](E3EAPIMatterModelsTempMatterGetResponse.md)

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


## MatterModelFromMatters

> E3EAPIMatterModelsMatterGetResponse MatterModelFromMatters (List<string> itemId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets cloned Matters and returns a MatterGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterModelFromMattersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var itemId = new List<string>(); // List<string> |  (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets cloned Matters and returns a MatterGetResponse.
                E3EAPIMatterModelsMatterGetResponse result = apiInstance.MatterModelFromMatters(itemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterModelFromMatters: " + e.Message );
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

[**E3EAPIMatterModelsMatterGetResponse**](E3EAPIMatterModelsMatterGetResponse.md)

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


## MatterReplaceTempMatter

> E3EAPITempMatterModelsTempMatterReplaceResponse MatterReplaceTempMatter (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITempMatterModelsTempMatterReplaceRequest e3EAPITempMatterModelsTempMatterReplaceRequest = null)

Replaces a Temp Matter with an actual matter.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterReplaceTempMatterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITempMatterModelsTempMatterReplaceRequest = new E3EAPITempMatterModelsTempMatterReplaceRequest(); // E3EAPITempMatterModelsTempMatterReplaceRequest | The request details. (optional) 

            try
            {
                // Replaces a Temp Matter with an actual matter.
                E3EAPITempMatterModelsTempMatterReplaceResponse result = apiInstance.MatterReplaceTempMatter(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITempMatterModelsTempMatterReplaceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterReplaceTempMatter: " + e.Message );
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
 **e3EAPITempMatterModelsTempMatterReplaceRequest** | [**E3EAPITempMatterModelsTempMatterReplaceRequest**](E3EAPITempMatterModelsTempMatterReplaceRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITempMatterModelsTempMatterReplaceResponse**](E3EAPITempMatterModelsTempMatterReplaceResponse.md)

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


## MatterUpdateMatter

> E3EAPIMatterModelsMatterUpdateResponse MatterUpdateMatter (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIMatterModelsMatterUpdateRequest e3EAPIMatterModelsMatterUpdateRequest = null)

Updates a Matter.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterUpdateMatterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIMatterModelsMatterUpdateRequest = new E3EAPIMatterModelsMatterUpdateRequest(); // E3EAPIMatterModelsMatterUpdateRequest | The request details. (optional) 

            try
            {
                // Updates a Matter.
                E3EAPIMatterModelsMatterUpdateResponse result = apiInstance.MatterUpdateMatter(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIMatterModelsMatterUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterUpdateMatter: " + e.Message );
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
 **e3EAPIMatterModelsMatterUpdateRequest** | [**E3EAPIMatterModelsMatterUpdateRequest**](E3EAPIMatterModelsMatterUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIMatterModelsMatterUpdateResponse**](E3EAPIMatterModelsMatterUpdateResponse.md)

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


## MatterUpdateMatterNickname

> E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse MatterUpdateMatterNickname (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIMatterNicknameModelsMatterNicknameUpdateRequest e3EAPIMatterNicknameModelsMatterNicknameUpdateRequest = null)

Updates a Matter Nickname.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterUpdateMatterNicknameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIMatterNicknameModelsMatterNicknameUpdateRequest = new E3EAPIMatterNicknameModelsMatterNicknameUpdateRequest(); // E3EAPIMatterNicknameModelsMatterNicknameUpdateRequest | The request details. (optional) 

            try
            {
                // Updates a Matter Nickname.
                E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse result = apiInstance.MatterUpdateMatterNickname(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIMatterNicknameModelsMatterNicknameUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterUpdateMatterNickname: " + e.Message );
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
 **e3EAPIMatterNicknameModelsMatterNicknameUpdateRequest** | [**E3EAPIMatterNicknameModelsMatterNicknameUpdateRequest**](E3EAPIMatterNicknameModelsMatterNicknameUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse**](E3EAPIMatterNicknameModelsMatterNicknameUpdateResponse.md)

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


## MatterValidateMatters

> E3EAPIMatterModelsMatterValidateResponse MatterValidateMatters (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIMatterModelsMatterValidateRequest e3EAPIMatterModelsMatterValidateRequest = null)

Validates one or more existing Matters.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MatterValidateMattersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new MatterApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIMatterModelsMatterValidateRequest = new E3EAPIMatterModelsMatterValidateRequest(); // E3EAPIMatterModelsMatterValidateRequest | The Matter.MattIndex values of the Matters to be validated. (optional) 

            try
            {
                // Validates one or more existing Matters.
                E3EAPIMatterModelsMatterValidateResponse result = apiInstance.MatterValidateMatters(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIMatterModelsMatterValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MatterApi.MatterValidateMatters: " + e.Message );
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
 **e3EAPIMatterModelsMatterValidateRequest** | [**E3EAPIMatterModelsMatterValidateRequest**](E3EAPIMatterModelsMatterValidateRequest.md)| The Matter.MattIndex values of the Matters to be validated. | [optional] 

### Return type

[**E3EAPIMatterModelsMatterValidateResponse**](E3EAPIMatterModelsMatterValidateResponse.md)

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

