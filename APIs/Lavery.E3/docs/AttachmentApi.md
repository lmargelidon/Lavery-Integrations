# Org.OpenAPITools.Api.AttachmentApi

All URIs are relative to *http://ldbm3ewapi1/TE_3E_SAMPLE/web*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachmentDownloadDMSAttachment**](AttachmentApi.md#attachmentdownloaddmsattachment) | **GET** /api/v1/attachment/dms | Downloads a DMS attachment.
[**AttachmentDownloadFileAttachment**](AttachmentApi.md#attachmentdownloadfileattachment) | **GET** /api/v1/attachment/file | Downloads a File attachment.
[**AttachmentDownloadICAttachment**](AttachmentApi.md#attachmentdownloadicattachment) | **GET** /api/v1/attachment/ic | Downloads an IC attachment.
[**AttachmentGetAttachments**](AttachmentApi.md#attachmentgetattachments) | **GET** /api/v1/attachment | Gets Attachments and returns a AttachmentGetResponse.
[**AttachmentGetDMSParameters**](AttachmentApi.md#attachmentgetdmsparameters) | **GET** /api/v1/attachment/dms/parameters | Collects DMS parameters and returns DMSParametersGetResponse.
[**AttachmentUploadDMSAttachment**](AttachmentApi.md#attachmentuploaddmsattachment) | **POST** /api/v1/attachment/dms | Uploads DMS Attachment.
[**AttachmentUploadFileAttachment**](AttachmentApi.md#attachmentuploadfileattachment) | **POST** /api/v1/attachment/file | Uploads File Attachment.
[**AttachmentUploadICAttachment**](AttachmentApi.md#attachmentuploadicattachment) | **POST** /api/v1/attachment/ic | Uploads IC Attachment.



## AttachmentDownloadDMSAttachment

> E3EAPIAttachmentModelsAttachmentDownloadRequest AttachmentDownloadDMSAttachment (Guid attachmentId, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Downloads a DMS attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttachmentDownloadDMSAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new AttachmentApi(Configuration.Default);
            var attachmentId = new Guid(); // Guid | Gets or sets the attachment Id.
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Downloads a DMS attachment.
                E3EAPIAttachmentModelsAttachmentDownloadRequest result = apiInstance.AttachmentDownloadDMSAttachment(attachmentId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentDownloadDMSAttachment: " + e.Message );
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
 **attachmentId** | [**Guid**](Guid.md)| Gets or sets the attachment Id. | 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIAttachmentModelsAttachmentDownloadRequest**](E3EAPIAttachmentModelsAttachmentDownloadRequest.md)

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


## AttachmentDownloadFileAttachment

> E3EAPIAttachmentModelsAttachmentDownloadRequest AttachmentDownloadFileAttachment (Guid attachmentId, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Downloads a File attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttachmentDownloadFileAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new AttachmentApi(Configuration.Default);
            var attachmentId = new Guid(); // Guid | Gets or sets the attachment Id.
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Downloads a File attachment.
                E3EAPIAttachmentModelsAttachmentDownloadRequest result = apiInstance.AttachmentDownloadFileAttachment(attachmentId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentDownloadFileAttachment: " + e.Message );
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
 **attachmentId** | [**Guid**](Guid.md)| Gets or sets the attachment Id. | 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIAttachmentModelsAttachmentDownloadRequest**](E3EAPIAttachmentModelsAttachmentDownloadRequest.md)

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


## AttachmentDownloadICAttachment

> E3EAPIAttachmentModelsICAttachmentDownloadRequest AttachmentDownloadICAttachment (string syncId, string archetype, Guid parentItemId, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Downloads an IC attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttachmentDownloadICAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new AttachmentApi(Configuration.Default);
            var syncId = syncId_example;  // string | Gets or sets IC SyncId.
            var archetype = archetype_example;  // string | Gets or sets an archetype.
            var parentItemId = new Guid(); // Guid | Gets or sets the Id of a parent data object.
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Downloads an IC attachment.
                E3EAPIAttachmentModelsICAttachmentDownloadRequest result = apiInstance.AttachmentDownloadICAttachment(syncId, archetype, parentItemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentDownloadICAttachment: " + e.Message );
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
 **syncId** | **string**| Gets or sets IC SyncId. | 
 **archetype** | **string**| Gets or sets an archetype. | 
 **parentItemId** | [**Guid**](Guid.md)| Gets or sets the Id of a parent data object. | 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIAttachmentModelsICAttachmentDownloadRequest**](E3EAPIAttachmentModelsICAttachmentDownloadRequest.md)

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


## AttachmentGetAttachments

> E3EAPIAttachmentModelsAttachmentGetResponse AttachmentGetAttachments (List<string> parentItemIds, string archetype = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets Attachments and returns a AttachmentGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttachmentGetAttachmentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new AttachmentApi(Configuration.Default);
            var parentItemIds = new List<string>(); // List<string> | Gets or sets Ids of parent data objects.
            var archetype = archetype_example;  // string | Gets or sets an archetype. Required for IC. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets Attachments and returns a AttachmentGetResponse.
                E3EAPIAttachmentModelsAttachmentGetResponse result = apiInstance.AttachmentGetAttachments(parentItemIds, archetype, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentGetAttachments: " + e.Message );
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
 **parentItemIds** | [**List&lt;string&gt;**](string.md)| Gets or sets Ids of parent data objects. | 
 **archetype** | **string**| Gets or sets an archetype. Required for IC. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIAttachmentModelsAttachmentGetResponse**](E3EAPIAttachmentModelsAttachmentGetResponse.md)

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


## AttachmentGetDMSParameters

> E3EAPIAttachmentModelsDMSParametersGetResponse AttachmentGetDMSParameters (string archetype = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Collects DMS parameters and returns DMSParametersGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttachmentGetDMSParametersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new AttachmentApi(Configuration.Default);
            var archetype = archetype_example;  // string | Gets or sets the data object archetype. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Collects DMS parameters and returns DMSParametersGetResponse.
                E3EAPIAttachmentModelsDMSParametersGetResponse result = apiInstance.AttachmentGetDMSParameters(archetype, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentGetDMSParameters: " + e.Message );
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
 **archetype** | **string**| Gets or sets the data object archetype. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIAttachmentModelsDMSParametersGetResponse**](E3EAPIAttachmentModelsDMSParametersGetResponse.md)

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


## AttachmentUploadDMSAttachment

> E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadDMSAttachment (string library, string documentClass, string documentType, string dMSFolder, Guid parentItemId, string archetype, Guid? syncMapID = null, string subFolder = null, string description = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Uploads DMS Attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttachmentUploadDMSAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new AttachmentApi(Configuration.Default);
            var library = library_example;  // string | Gets or sets DMS library.
            var documentClass = documentClass_example;  // string | Gets or sets DMS document class.
            var documentType = documentType_example;  // string | Gets or sets DMS document type.
            var dMSFolder = dMSFolder_example;  // string | Gets or sets a folder.
            var parentItemId = new Guid(); // Guid | Gets or sets a parent item id.
            var archetype = archetype_example;  // string | Gets or sets an archetype.
            var syncMapID = new Guid?(); // Guid? | Gets or sets DMS SyncMapID. (optional) 
            var subFolder = subFolder_example;  // string | Gets or sets a subfolder. (optional) 
            var description = description_example;  // string | Gets or sets a description. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Uploads DMS Attachment.
                E3EAPIAttachmentModelsAttachmentCreateResponse result = apiInstance.AttachmentUploadDMSAttachment(library, documentClass, documentType, dMSFolder, parentItemId, archetype, syncMapID, subFolder, description, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentUploadDMSAttachment: " + e.Message );
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
 **library** | **string**| Gets or sets DMS library. | 
 **documentClass** | **string**| Gets or sets DMS document class. | 
 **documentType** | **string**| Gets or sets DMS document type. | 
 **dMSFolder** | **string**| Gets or sets a folder. | 
 **parentItemId** | [**Guid**](Guid.md)| Gets or sets a parent item id. | 
 **archetype** | **string**| Gets or sets an archetype. | 
 **syncMapID** | [**Guid?**](Guid?.md)| Gets or sets DMS SyncMapID. | [optional] 
 **subFolder** | **string**| Gets or sets a subfolder. | [optional] 
 **description** | **string**| Gets or sets a description. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIAttachmentModelsAttachmentCreateResponse**](E3EAPIAttachmentModelsAttachmentCreateResponse.md)

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


## AttachmentUploadFileAttachment

> E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadFileAttachment (Guid parentItemId, string archetype, string subFolder = null, string description = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Uploads File Attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttachmentUploadFileAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new AttachmentApi(Configuration.Default);
            var parentItemId = new Guid(); // Guid | Gets or sets a parent item id.
            var archetype = archetype_example;  // string | Gets or sets an archetype.
            var subFolder = subFolder_example;  // string | Gets or sets a subfolder. (optional) 
            var description = description_example;  // string | Gets or sets a description. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Uploads File Attachment.
                E3EAPIAttachmentModelsAttachmentCreateResponse result = apiInstance.AttachmentUploadFileAttachment(parentItemId, archetype, subFolder, description, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentUploadFileAttachment: " + e.Message );
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
 **parentItemId** | [**Guid**](Guid.md)| Gets or sets a parent item id. | 
 **archetype** | **string**| Gets or sets an archetype. | 
 **subFolder** | **string**| Gets or sets a subfolder. | [optional] 
 **description** | **string**| Gets or sets a description. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIAttachmentModelsAttachmentCreateResponse**](E3EAPIAttachmentModelsAttachmentCreateResponse.md)

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


## AttachmentUploadICAttachment

> E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadICAttachment (string process, Guid parentItemId, string archetype = null, string subFolder = null, string description = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Uploads IC Attachment.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttachmentUploadICAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new AttachmentApi(Configuration.Default);
            var process = process_example;  // string | Gets or sets a process.
            var parentItemId = new Guid(); // Guid | Gets or sets a parent item id.
            var archetype = archetype_example;  // string | Gets or sets an archetype. Ignored for IC. (optional) 
            var subFolder = subFolder_example;  // string | Gets or sets a subfolder. (optional) 
            var description = description_example;  // string | Gets or sets a description. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Uploads IC Attachment.
                E3EAPIAttachmentModelsAttachmentCreateResponse result = apiInstance.AttachmentUploadICAttachment(process, parentItemId, archetype, subFolder, description, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AttachmentApi.AttachmentUploadICAttachment: " + e.Message );
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
 **process** | **string**| Gets or sets a process. | 
 **parentItemId** | [**Guid**](Guid.md)| Gets or sets a parent item id. | 
 **archetype** | **string**| Gets or sets an archetype. Ignored for IC. | [optional] 
 **subFolder** | **string**| Gets or sets a subfolder. | [optional] 
 **description** | **string**| Gets or sets a description. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIAttachmentModelsAttachmentCreateResponse**](E3EAPIAttachmentModelsAttachmentCreateResponse.md)

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

