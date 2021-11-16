# Org.OpenAPITools.Api.ClientApi

All URIs are relative to *http://ldbm3ewapi1/TE_3E_SAMPLE/web*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClientCreateClient**](ClientApi.md#clientcreateclient) | **POST** /api/v1/client | Creates a new Client.
[**ClientGetClientSchema**](ClientApi.md#clientgetclientschema) | **GET** /api/v1/client/schema | Gets the schema for Client.
[**ClientGetClients**](ClientApi.md#clientgetclients) | **GET** /api/v1/client | Gets Clients and returns a ClientGetResponse.
[**ClientGetNewClient**](ClientApi.md#clientgetnewclient) | **GET** /api/v1/client/template | Gets a new Client with default values.
[**ClientModelFromClients**](ClientApi.md#clientmodelfromclients) | **GET** /api/v1/client/modelfrom | Gets cloned Clients and returns a ClientGetResponse.
[**ClientUpdateClient**](ClientApi.md#clientupdateclient) | **PATCH** /api/v1/client | Updates a Client.
[**ClientValidateClients**](ClientApi.md#clientvalidateclients) | **POST** /api/v1/client/validate | Validates one or more existing Clients.



## ClientCreateClient

> E3EAPIClientModelsClientCreateResponse ClientCreateClient (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIClientModelsClientCreateRequest e3EAPIClientModelsClientCreateRequest = null)

Creates a new Client.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientCreateClientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new ClientApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIClientModelsClientCreateRequest = new E3EAPIClientModelsClientCreateRequest(); // E3EAPIClientModelsClientCreateRequest | The request details. (optional) 

            try
            {
                // Creates a new Client.
                E3EAPIClientModelsClientCreateResponse result = apiInstance.ClientCreateClient(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIClientModelsClientCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientApi.ClientCreateClient: " + e.Message );
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
 **e3EAPIClientModelsClientCreateRequest** | [**E3EAPIClientModelsClientCreateRequest**](E3EAPIClientModelsClientCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIClientModelsClientCreateResponse**](E3EAPIClientModelsClientCreateResponse.md)

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


## ClientGetClientSchema

> E3EAPIClientModelsClientGetSchemaResponse ClientGetClientSchema (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets the schema for Client.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientGetClientSchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new ClientApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets the schema for Client.
                E3EAPIClientModelsClientGetSchemaResponse result = apiInstance.ClientGetClientSchema(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientApi.ClientGetClientSchema: " + e.Message );
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

[**E3EAPIClientModelsClientGetSchemaResponse**](E3EAPIClientModelsClientGetSchemaResponse.md)

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


## ClientGetClients

> E3EAPIClientModelsClientGetResponse ClientGetClients (List<Guid> clientId = null, int? clientIndex = null, string number = null, List<string> advancedFilterChildObjectsToInclude = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets Clients and returns a ClientGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientGetClientsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new ClientApi(Configuration.Default);
            var clientId = new List<Guid>(); // List<Guid> | Gets or sets the ClientIds. (optional) 
            var clientIndex = 56;  // int? | Gets or sets the ClientIndex. (optional) 
            var number = number_example;  // string | Gets or sets the Number (Client Alias). (optional) 
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
                // Gets Clients and returns a ClientGetResponse.
                E3EAPIClientModelsClientGetResponse result = apiInstance.ClientGetClients(clientId, clientIndex, number, advancedFilterChildObjectsToInclude, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientApi.ClientGetClients: " + e.Message );
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
 **clientId** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the ClientIds. | [optional] 
 **clientIndex** | **int?**| Gets or sets the ClientIndex. | [optional] 
 **number** | **string**| Gets or sets the Number (Client Alias). | [optional] 
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

[**E3EAPIClientModelsClientGetResponse**](E3EAPIClientModelsClientGetResponse.md)

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
| **403** | Forbidden - The authenticated user or application is not allowed to perform the operation. |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error - An unhandled error occurred, check server logs for the exact error. |  -  |
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ClientGetNewClient

> E3EAPIClientModelsClientTemplateResponse ClientGetNewClient (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets a new Client with default values.

This method does not launch a process or add any data in 3E.  It is intended to be used with CreateClient.  e.g. call this method, then set whichever attributes need to be changed and then call CreateClient with the modified data.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientGetNewClientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new ClientApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets a new Client with default values.
                E3EAPIClientModelsClientTemplateResponse result = apiInstance.ClientGetNewClient(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientApi.ClientGetNewClient: " + e.Message );
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

[**E3EAPIClientModelsClientTemplateResponse**](E3EAPIClientModelsClientTemplateResponse.md)

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


## ClientModelFromClients

> E3EAPIClientModelsClientGetResponse ClientModelFromClients (List<string> itemId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets cloned Clients and returns a ClientGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientModelFromClientsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new ClientApi(Configuration.Default);
            var itemId = new List<string>(); // List<string> |  (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets cloned Clients and returns a ClientGetResponse.
                E3EAPIClientModelsClientGetResponse result = apiInstance.ClientModelFromClients(itemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientApi.ClientModelFromClients: " + e.Message );
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

[**E3EAPIClientModelsClientGetResponse**](E3EAPIClientModelsClientGetResponse.md)

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


## ClientUpdateClient

> E3EAPIClientModelsClientUpdateResponse ClientUpdateClient (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIClientModelsClientUpdateRequest e3EAPIClientModelsClientUpdateRequest = null)

Updates a Client.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientUpdateClientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new ClientApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIClientModelsClientUpdateRequest = new E3EAPIClientModelsClientUpdateRequest(); // E3EAPIClientModelsClientUpdateRequest | The request details. (optional) 

            try
            {
                // Updates a Client.
                E3EAPIClientModelsClientUpdateResponse result = apiInstance.ClientUpdateClient(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIClientModelsClientUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientApi.ClientUpdateClient: " + e.Message );
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
 **e3EAPIClientModelsClientUpdateRequest** | [**E3EAPIClientModelsClientUpdateRequest**](E3EAPIClientModelsClientUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIClientModelsClientUpdateResponse**](E3EAPIClientModelsClientUpdateResponse.md)

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
| **404** | NotFound - The Client to be updated does not exist. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ClientValidateClients

> E3EAPIClientModelsClientValidateResponse ClientValidateClients (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIClientModelsClientValidateRequest e3EAPIClientModelsClientValidateRequest = null)

Validates one or more existing Clients.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ClientValidateClientsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new ClientApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIClientModelsClientValidateRequest = new E3EAPIClientModelsClientValidateRequest(); // E3EAPIClientModelsClientValidateRequest | The Client.ClientIndex values of the Clients to be validated. (optional) 

            try
            {
                // Validates one or more existing Clients.
                E3EAPIClientModelsClientValidateResponse result = apiInstance.ClientValidateClients(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIClientModelsClientValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientApi.ClientValidateClients: " + e.Message );
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
 **e3EAPIClientModelsClientValidateRequest** | [**E3EAPIClientModelsClientValidateRequest**](E3EAPIClientModelsClientValidateRequest.md)| The Client.ClientIndex values of the Clients to be validated. | [optional] 

### Return type

[**E3EAPIClientModelsClientValidateResponse**](E3EAPIClientModelsClientValidateResponse.md)

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
| **404** | NotFound - The Client to be validated does not exist. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

