# Org.OpenAPITools.Api.TimeApi

All URIs are relative to *http://ldbm3ewapi1/TE_3E_SAMPLE/web*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimeAddPendingTimecard**](TimeApi.md#timeaddpendingtimecard) | **POST** /api/v1/time/pending/add | Add a new pending timecard with default values.
[**TimeApplyTimeCaptureModel**](TimeApi.md#timeapplytimecapturemodel) | **PUT** /api/v1/time/model/timecapture | Applies a TimeCapture model.
[**TimeCleanupPendingTimecards**](TimeApi.md#timecleanuppendingtimecards) | **DELETE** /api/v1/time/pending/cleanup | Cleans up pending timecards, so that only timecards with works hours or timecards with work hours or narrative remain.
[**TimeClearTimecapturePostExceptions**](TimeApi.md#timecleartimecapturepostexceptions) | **POST** /api/v1/time/timecapture/clearPostExceptions | Cleaars timecapture post exceptions.
[**TimeClonePendingTimecards**](TimeApi.md#timeclonependingtimecards) | **POST** /api/v1/time/pending/clone | Clones one or more existing pending timecards.
[**TimeClonePostedTimecards**](TimeApi.md#timeclonepostedtimecards) | **POST** /api/v1/time/posted/clone | Clones one or more existing posted timecards.
[**TimeClonePostedTimecardsAsPendingTimecards**](TimeApi.md#timeclonepostedtimecardsaspendingtimecards) | **POST** /api/v1/time/posted/cloneaspending | Clones one or more existing posted timecards and creates one or more pending timecards from them.
[**TimeCloneTimecaptureCard**](TimeApi.md#timeclonetimecapturecard) | **POST** /api/v1/time/timecapture/clone | Clones one or more existing timecapture records.
[**TimeCreatePendingTimecard**](TimeApi.md#timecreatependingtimecard) | **POST** /api/v1/time/pending | Creates a pending timecard.
[**TimeCreatePostedTimecard**](TimeApi.md#timecreatepostedtimecard) | **POST** /api/v1/time/posted | Creates a posted timecard.
[**TimeCreateTimeCaptureCard**](TimeApi.md#timecreatetimecapturecard) | **POST** /api/v1/time/timecapture | Creates a new timecapture record.
[**TimeCreateTimeCaptureModel**](TimeApi.md#timecreatetimecapturemodel) | **POST** /api/v1/time/model/timecapture | Creates a TimeCapture model.
[**TimeCreateTimecaptureCardFromPosted**](TimeApi.md#timecreatetimecapturecardfromposted) | **POST** /api/v1/time/timecapture/clonefromposted | Clones one or more existing posted timecards and creates one or more timecapture records from them.
[**TimeDeletePendingTimecards**](TimeApi.md#timedeletependingtimecards) | **DELETE** /api/v1/time/pending | Deletes one or more existing pending timecards.
[**TimeDeleteTimeCaptureModel**](TimeApi.md#timedeletetimecapturemodel) | **DELETE** /api/v1/time/model/timecapture | Deletes a TimeCapture model.
[**TimeGetActiveTimers**](TimeApi.md#timegetactivetimers) | **GET** /api/v1/time/timer/activetimers | Gets active timers for a given timekeeper and returns a ActiveTimersResponse.
[**TimeGetCalendarReport**](TimeApi.md#timegetcalendarreport) | **GET** /api/v1/time/report | Gets calendar data report for a given timekeeper and period.
[**TimeGetNewPendingTimecard**](TimeApi.md#timegetnewpendingtimecard) | **GET** /api/v1/time/pending/template | Gets a new pending timecard with default values.
[**TimeGetNewPostedTimecard**](TimeApi.md#timegetnewpostedtimecard) | **GET** /api/v1/time/posted/template | Gets a new posted timecard with default values.
[**TimeGetNewTimeCaptureCard**](TimeApi.md#timegetnewtimecapturecard) | **GET** /api/v1/time/timecapture/template | Gets a new timecapture timecard with default values.
[**TimeGetPendingTimecardSchema**](TimeApi.md#timegetpendingtimecardschema) | **GET** /api/v1/time/pending/schema | Gets the schema for pending timecards.
[**TimeGetPendingTimecards**](TimeApi.md#timegetpendingtimecards) | **GET** /api/v1/time/pending | Gets pending timecards for a given timekeeper and returns a TimecardGetResponse.
[**TimeGetPostedTimecardSchema**](TimeApi.md#timegetpostedtimecardschema) | **GET** /api/v1/time/posted/schema | Gets the schema for posted timecards.
[**TimeGetPostedTimecards**](TimeApi.md#timegetpostedtimecards) | **GET** /api/v1/time/posted | Gets posted timecards for a given timekeeper and returns a TimecardGetResponse.
[**TimeGetTimeCaptureAllCards**](TimeApi.md#timegettimecaptureallcards) | **GET** /api/v1/time/timecapture/all | Gets timecapture records (both posted and pending) for a given timekeeper and returns a TimecardGetAllResponse.
[**TimeGetTimeCaptureModels**](TimeApi.md#timegettimecapturemodels) | **GET** /api/v1/time/model/timecapture | Gets TimeCapture models.
[**TimeGetTimeCapturePendingCards**](TimeApi.md#timegettimecapturependingcards) | **GET** /api/v1/time/timecapture | Gets timecapture pending records for a given timekeeper and returns a TimecardGetResponse.
[**TimeGetTimecards**](TimeApi.md#timegettimecards) | **GET** /api/v1/time/all | Gets timecards (both posted and pending) for a given timekeeper and returns a TimecardGetAllResponse.
[**TimeGetTimecardsGroupedByDay**](TimeApi.md#timegettimecardsgroupedbyday) | **GET** /api/v1/time/weeklyview | Gets pending and posted timecards grouped for display in weekly view.
[**TimeModelFromPendingTimecards**](TimeApi.md#timemodelfrompendingtimecards) | **GET** /api/v1/time/pending/modelfrom | Gets cloned pending timecards and returns a TimecardGetResponse.
[**TimeModelFromPostedTimecards**](TimeApi.md#timemodelfrompostedtimecards) | **GET** /api/v1/time/posted/modelfrom | Gets cloned timecards and returns a TimecardGetResponse.
[**TimePostPendingTimecards**](TimeApi.md#timepostpendingtimecards) | **POST** /api/v1/time/pending/post | Posts one or more existing pending timecards.
[**TimeQueryTimeCaptureAllCards**](TimeApi.md#timequerytimecaptureallcards) | **POST** /api/v1/time/timecapture/query/all | Queries timecapture records (both posted and pending) filtered out according to request body conditions.
[**TimeQueryTimeCapturePendingCards**](TimeApi.md#timequerytimecapturependingcards) | **POST** /api/v1/time/timecapture/query | Queries timecapture records (pending only) filtered out according to request body conditions.
[**TimeSpellcheckPendingTimecards**](TimeApi.md#timespellcheckpendingtimecards) | **GET** /api/v1/time/pending/spellcheck | Spellchecks one or more existing pending timecards.
[**TimeStartStopTimer**](TimeApi.md#timestartstoptimer) | **POST** /api/v1/time/timer/startstop | Starts/stops a timer for a given pending timecard.
[**TimeUpdatePendingTimecard**](TimeApi.md#timeupdatependingtimecard) | **PATCH** /api/v1/time/pending | Updates a pending timecard.
[**TimeUpdatePostedTimecard**](TimeApi.md#timeupdatepostedtimecard) | **PATCH** /api/v1/time/posted | Updates a posted timecard.
[**TimeUpdateTimeCaptureCard**](TimeApi.md#timeupdatetimecapturecard) | **PATCH** /api/v1/time/timecapture | Updates an existing timecapture record.
[**TimeUpdateTimeCaptureModel**](TimeApi.md#timeupdatetimecapturemodel) | **PATCH** /api/v1/time/model/timecapture | Updates a TimeCapture model.
[**TimeValidatePendingTimecards**](TimeApi.md#timevalidatependingtimecards) | **POST** /api/v1/time/pending/validate | Validates one or more existing pending timecards.
[**TimeValidatePostedTimecards**](TimeApi.md#timevalidatepostedtimecards) | **POST** /api/v1/time/posted/validate | Validates one or more existing timecards.
[**TimeValidateTimecaptureCard**](TimeApi.md#timevalidatetimecapturecard) | **POST** /api/v1/time/timecapture/validate | Validates one or more existing timecapture records.



## TimeAddPendingTimecard

> E3EAPITimeModelsTimecardAddResponse TimeAddPendingTimecard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Add a new pending timecard with default values.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeAddPendingTimecardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Add a new pending timecard with default values.
                E3EAPITimeModelsTimecardAddResponse result = apiInstance.TimeAddPendingTimecard(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeAddPendingTimecard: " + e.Message );
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

[**E3EAPITimeModelsTimecardAddResponse**](E3EAPITimeModelsTimecardAddResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TimeApplyTimeCaptureModel

> E3EAPIDataObjectModelModelsDataObjectModelApplyResponse TimeApplyTimeCaptureModel (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecaptureModelApplyRequest e3EAPITimeModelsTimecaptureModelApplyRequest = null)

Applies a TimeCapture model.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeApplyTimeCaptureModelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecaptureModelApplyRequest = new E3EAPITimeModelsTimecaptureModelApplyRequest(); // E3EAPITimeModelsTimecaptureModelApplyRequest | The request details. (optional) 

            try
            {
                // Applies a TimeCapture model.
                E3EAPIDataObjectModelModelsDataObjectModelApplyResponse result = apiInstance.TimeApplyTimeCaptureModel(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecaptureModelApplyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeApplyTimeCaptureModel: " + e.Message );
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
 **e3EAPITimeModelsTimecaptureModelApplyRequest** | [**E3EAPITimeModelsTimecaptureModelApplyRequest**](E3EAPITimeModelsTimecaptureModelApplyRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIDataObjectModelModelsDataObjectModelApplyResponse**](E3EAPIDataObjectModelModelsDataObjectModelApplyResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json, application/xml, text/xml, application/_*+xml
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


## TimeCleanupPendingTimecards

> E3EAPITimeModelsTimecardCleanupResponse TimeCleanupPendingTimecards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardCleanupRequest e3EAPITimeModelsTimecardCleanupRequest = null)

Cleans up pending timecards, so that only timecards with works hours or timecards with work hours or narrative remain.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeCleanupPendingTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardCleanupRequest = new E3EAPITimeModelsTimecardCleanupRequest(); // E3EAPITimeModelsTimecardCleanupRequest | The request details. (optional) 

            try
            {
                // Cleans up pending timecards, so that only timecards with works hours or timecards with work hours or narrative remain.
                E3EAPITimeModelsTimecardCleanupResponse result = apiInstance.TimeCleanupPendingTimecards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardCleanupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeCleanupPendingTimecards: " + e.Message );
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
 **e3EAPITimeModelsTimecardCleanupRequest** | [**E3EAPITimeModelsTimecardCleanupRequest**](E3EAPITimeModelsTimecardCleanupRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardCleanupResponse**](E3EAPITimeModelsTimecardCleanupResponse.md)

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


## TimeClearTimecapturePostExceptions

> E3EAPITimeModelsTimecardClearResponse TimeClearTimecapturePostExceptions (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardClearRequest e3EAPITimeModelsTimecardClearRequest = null)

Cleaars timecapture post exceptions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeClearTimecapturePostExceptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardClearRequest = new E3EAPITimeModelsTimecardClearRequest(); // E3EAPITimeModelsTimecardClearRequest | The ItemId values of the timecards. (optional) 

            try
            {
                // Cleaars timecapture post exceptions.
                E3EAPITimeModelsTimecardClearResponse result = apiInstance.TimeClearTimecapturePostExceptions(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardClearRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeClearTimecapturePostExceptions: " + e.Message );
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
 **e3EAPITimeModelsTimecardClearRequest** | [**E3EAPITimeModelsTimecardClearRequest**](E3EAPITimeModelsTimecardClearRequest.md)| The ItemId values of the timecards. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardClearResponse**](E3EAPITimeModelsTimecardClearResponse.md)

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


## TimeClonePendingTimecards

> E3EAPITimeModelsTimecardCloneResponse TimeClonePendingTimecards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardCloneRequest e3EAPITimeModelsTimecardCloneRequest = null)

Clones one or more existing pending timecards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeClonePendingTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardCloneRequest = new E3EAPITimeModelsTimecardCloneRequest(); // E3EAPITimeModelsTimecardCloneRequest | The TimecardPending.TimePendIndex values of the timecards to be cloned. (optional) 

            try
            {
                // Clones one or more existing pending timecards.
                E3EAPITimeModelsTimecardCloneResponse result = apiInstance.TimeClonePendingTimecards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardCloneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeClonePendingTimecards: " + e.Message );
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
 **e3EAPITimeModelsTimecardCloneRequest** | [**E3EAPITimeModelsTimecardCloneRequest**](E3EAPITimeModelsTimecardCloneRequest.md)| The TimecardPending.TimePendIndex values of the timecards to be cloned. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardCloneResponse**](E3EAPITimeModelsTimecardCloneResponse.md)

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


## TimeClonePostedTimecards

> E3EAPITimeModelsTimecardCloneResponse TimeClonePostedTimecards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardCloneRequest e3EAPITimeModelsTimecardCloneRequest = null)

Clones one or more existing posted timecards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeClonePostedTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardCloneRequest = new E3EAPITimeModelsTimecardCloneRequest(); // E3EAPITimeModelsTimecardCloneRequest | The Timecard.TimeIndex values of the timecards to be cloned. (optional) 

            try
            {
                // Clones one or more existing posted timecards.
                E3EAPITimeModelsTimecardCloneResponse result = apiInstance.TimeClonePostedTimecards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardCloneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeClonePostedTimecards: " + e.Message );
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
 **e3EAPITimeModelsTimecardCloneRequest** | [**E3EAPITimeModelsTimecardCloneRequest**](E3EAPITimeModelsTimecardCloneRequest.md)| The Timecard.TimeIndex values of the timecards to be cloned. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardCloneResponse**](E3EAPITimeModelsTimecardCloneResponse.md)

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


## TimeClonePostedTimecardsAsPendingTimecards

> E3EAPITimeModelsTimecardCloneResponse TimeClonePostedTimecardsAsPendingTimecards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardCloneRequest e3EAPITimeModelsTimecardCloneRequest = null)

Clones one or more existing posted timecards and creates one or more pending timecards from them.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeClonePostedTimecardsAsPendingTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardCloneRequest = new E3EAPITimeModelsTimecardCloneRequest(); // E3EAPITimeModelsTimecardCloneRequest | The Timecard.TimeIndex values of the timecards to be cloned. (optional) 

            try
            {
                // Clones one or more existing posted timecards and creates one or more pending timecards from them.
                E3EAPITimeModelsTimecardCloneResponse result = apiInstance.TimeClonePostedTimecardsAsPendingTimecards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardCloneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeClonePostedTimecardsAsPendingTimecards: " + e.Message );
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
 **e3EAPITimeModelsTimecardCloneRequest** | [**E3EAPITimeModelsTimecardCloneRequest**](E3EAPITimeModelsTimecardCloneRequest.md)| The Timecard.TimeIndex values of the timecards to be cloned. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardCloneResponse**](E3EAPITimeModelsTimecardCloneResponse.md)

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


## TimeCloneTimecaptureCard

> E3EAPITimeModelsTimecardCloneResponse TimeCloneTimecaptureCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardCloneRequest e3EAPITimeModelsTimecardCloneRequest = null)

Clones one or more existing timecapture records.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeCloneTimecaptureCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardCloneRequest = new E3EAPITimeModelsTimecardCloneRequest(); // E3EAPITimeModelsTimecardCloneRequest | The TimecardPending.TimePendIndex values of the timecards to be cloned. (optional) 

            try
            {
                // Clones one or more existing timecapture records.
                E3EAPITimeModelsTimecardCloneResponse result = apiInstance.TimeCloneTimecaptureCard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardCloneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeCloneTimecaptureCard: " + e.Message );
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
 **e3EAPITimeModelsTimecardCloneRequest** | [**E3EAPITimeModelsTimecardCloneRequest**](E3EAPITimeModelsTimecardCloneRequest.md)| The TimecardPending.TimePendIndex values of the timecards to be cloned. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardCloneResponse**](E3EAPITimeModelsTimecardCloneResponse.md)

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


## TimeCreatePendingTimecard

> E3EAPITimeModelsTimecardCreateResponse TimeCreatePendingTimecard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardCreateRequest e3EAPITimeModelsTimecardCreateRequest = null)

Creates a pending timecard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeCreatePendingTimecardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardCreateRequest = new E3EAPITimeModelsTimecardCreateRequest(); // E3EAPITimeModelsTimecardCreateRequest | The request details. (optional) 

            try
            {
                // Creates a pending timecard.
                E3EAPITimeModelsTimecardCreateResponse result = apiInstance.TimeCreatePendingTimecard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeCreatePendingTimecard: " + e.Message );
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
 **e3EAPITimeModelsTimecardCreateRequest** | [**E3EAPITimeModelsTimecardCreateRequest**](E3EAPITimeModelsTimecardCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardCreateResponse**](E3EAPITimeModelsTimecardCreateResponse.md)

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


## TimeCreatePostedTimecard

> E3EAPITimeModelsTimecardCreateResponse TimeCreatePostedTimecard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardCreateRequest e3EAPITimeModelsTimecardCreateRequest = null)

Creates a posted timecard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeCreatePostedTimecardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardCreateRequest = new E3EAPITimeModelsTimecardCreateRequest(); // E3EAPITimeModelsTimecardCreateRequest | The request details. (optional) 

            try
            {
                // Creates a posted timecard.
                E3EAPITimeModelsTimecardCreateResponse result = apiInstance.TimeCreatePostedTimecard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeCreatePostedTimecard: " + e.Message );
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
 **e3EAPITimeModelsTimecardCreateRequest** | [**E3EAPITimeModelsTimecardCreateRequest**](E3EAPITimeModelsTimecardCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardCreateResponse**](E3EAPITimeModelsTimecardCreateResponse.md)

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


## TimeCreateTimeCaptureCard

> E3EAPITimeModelsTimecardCreateResponse TimeCreateTimeCaptureCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardCreateRequest e3EAPITimeModelsTimecardCreateRequest = null)

Creates a new timecapture record.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeCreateTimeCaptureCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardCreateRequest = new E3EAPITimeModelsTimecardCreateRequest(); // E3EAPITimeModelsTimecardCreateRequest | The request details. (optional) 

            try
            {
                // Creates a new timecapture record.
                E3EAPITimeModelsTimecardCreateResponse result = apiInstance.TimeCreateTimeCaptureCard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeCreateTimeCaptureCard: " + e.Message );
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
 **e3EAPITimeModelsTimecardCreateRequest** | [**E3EAPITimeModelsTimecardCreateRequest**](E3EAPITimeModelsTimecardCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardCreateResponse**](E3EAPITimeModelsTimecardCreateResponse.md)

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


## TimeCreateTimeCaptureModel

> E3EAPIDataObjectModelModelsDataObjectModelCreateResponse TimeCreateTimeCaptureModel (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIDataObjectModelModelsDataObjectModelCreateRequest e3EAPIDataObjectModelModelsDataObjectModelCreateRequest = null)

Creates a TimeCapture model.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeCreateTimeCaptureModelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIDataObjectModelModelsDataObjectModelCreateRequest = new E3EAPIDataObjectModelModelsDataObjectModelCreateRequest(); // E3EAPIDataObjectModelModelsDataObjectModelCreateRequest | The request details. (optional) 

            try
            {
                // Creates a TimeCapture model.
                E3EAPIDataObjectModelModelsDataObjectModelCreateResponse result = apiInstance.TimeCreateTimeCaptureModel(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIDataObjectModelModelsDataObjectModelCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeCreateTimeCaptureModel: " + e.Message );
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
 **e3EAPIDataObjectModelModelsDataObjectModelCreateRequest** | [**E3EAPIDataObjectModelModelsDataObjectModelCreateRequest**](E3EAPIDataObjectModelModelsDataObjectModelCreateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIDataObjectModelModelsDataObjectModelCreateResponse**](E3EAPIDataObjectModelModelsDataObjectModelCreateResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json, application/xml, text/xml, application/_*+xml
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


## TimeCreateTimecaptureCardFromPosted

> E3EAPITimeModelsTimecardCloneResponse TimeCreateTimecaptureCardFromPosted (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardCloneRequest e3EAPITimeModelsTimecardCloneRequest = null)

Clones one or more existing posted timecards and creates one or more timecapture records from them.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeCreateTimecaptureCardFromPostedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardCloneRequest = new E3EAPITimeModelsTimecardCloneRequest(); // E3EAPITimeModelsTimecardCloneRequest | The Timecard.TimeIndex values of the timecards to be cloned. (optional) 

            try
            {
                // Clones one or more existing posted timecards and creates one or more timecapture records from them.
                E3EAPITimeModelsTimecardCloneResponse result = apiInstance.TimeCreateTimecaptureCardFromPosted(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardCloneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeCreateTimecaptureCardFromPosted: " + e.Message );
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
 **e3EAPITimeModelsTimecardCloneRequest** | [**E3EAPITimeModelsTimecardCloneRequest**](E3EAPITimeModelsTimecardCloneRequest.md)| The Timecard.TimeIndex values of the timecards to be cloned. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardCloneResponse**](E3EAPITimeModelsTimecardCloneResponse.md)

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


## TimeDeletePendingTimecards

> E3EAPITimeModelsTimecardDeleteResponse TimeDeletePendingTimecards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardDeleteRequest e3EAPITimeModelsTimecardDeleteRequest = null)

Deletes one or more existing pending timecards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeDeletePendingTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardDeleteRequest = new E3EAPITimeModelsTimecardDeleteRequest(); // E3EAPITimeModelsTimecardDeleteRequest | The TimecardPending.TimePendIndex values of the timecards to be deleted. (optional) 

            try
            {
                // Deletes one or more existing pending timecards.
                E3EAPITimeModelsTimecardDeleteResponse result = apiInstance.TimeDeletePendingTimecards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeDeletePendingTimecards: " + e.Message );
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
 **e3EAPITimeModelsTimecardDeleteRequest** | [**E3EAPITimeModelsTimecardDeleteRequest**](E3EAPITimeModelsTimecardDeleteRequest.md)| The TimecardPending.TimePendIndex values of the timecards to be deleted. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardDeleteResponse**](E3EAPITimeModelsTimecardDeleteResponse.md)

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


## TimeDeleteTimeCaptureModel

> E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse TimeDeleteTimeCaptureModel (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIDataObjectModelModelsDataObjectModelDeleteRequest e3EAPIDataObjectModelModelsDataObjectModelDeleteRequest = null)

Deletes a TimeCapture model.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeDeleteTimeCaptureModelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIDataObjectModelModelsDataObjectModelDeleteRequest = new E3EAPIDataObjectModelModelsDataObjectModelDeleteRequest(); // E3EAPIDataObjectModelModelsDataObjectModelDeleteRequest | The request details. (optional) 

            try
            {
                // Deletes a TimeCapture model.
                E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse result = apiInstance.TimeDeleteTimeCaptureModel(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIDataObjectModelModelsDataObjectModelDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeDeleteTimeCaptureModel: " + e.Message );
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
 **e3EAPIDataObjectModelModelsDataObjectModelDeleteRequest** | [**E3EAPIDataObjectModelModelsDataObjectModelDeleteRequest**](E3EAPIDataObjectModelModelsDataObjectModelDeleteRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse**](E3EAPIDataObjectModelModelsDataObjectModelDeleteResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json, application/xml, text/xml, application/_*+xml
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


## TimeGetActiveTimers

> E3EAPITimeModelsActiveTimersResponse TimeGetActiveTimers (int? index = null, DateTime? startDate = null, DateTime? endDate = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, List<Guid> itemIds = null, List<string> attributesToInclude = null, string filterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> filterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? filterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> filterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets active timers for a given timekeeper and returns a ActiveTimersResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetActiveTimersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var index = 56;  // int? |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the StartDate (WorkDate). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the EndDate (WorkDate). (optional) 
            var timekeeperIndex = 56;  // int? |  (optional) 
            var timekeeperNumber = timekeeperNumber_example;  // string |  (optional) 
            var timekeeperID = new Guid?(); // Guid? |  (optional) 
            var itemIds = new List<Guid>(); // List<Guid> |  (optional) 
            var attributesToInclude = new List<string>(); // List<string> |  (optional) 
            var filterXOQL = filterXOQL_example;  // string |  (optional) 
            var filterPredicates = new List<E3EAPIQuerySJQLSJPredicate>(); // List<E3EAPIQuerySJQLSJPredicate> | Gets or Sets predicates. (optional) 
            var filterOperator = ;  // E3EAPIQuerySJQLSJLogicalOperator? | Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. (optional) 
            var filterGroups = new List<E3EAPIQuerySJQLSJPredicateGroup>(); // List<E3EAPIQuerySJQLSJPredicateGroup> | Gets or Sets group of predicates based on a logical operator. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets active timers for a given timekeeper and returns a ActiveTimersResponse.
                E3EAPITimeModelsActiveTimersResponse result = apiInstance.TimeGetActiveTimers(index, startDate, endDate, timekeeperIndex, timekeeperNumber, timekeeperID, itemIds, attributesToInclude, filterXOQL, filterPredicates, filterOperator, filterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetActiveTimers: " + e.Message );
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
 **index** | **int?**|  | [optional] 
 **startDate** | **DateTime?**| Gets or sets the StartDate (WorkDate). | [optional] 
 **endDate** | **DateTime?**| Gets or sets the EndDate (WorkDate). | [optional] 
 **timekeeperIndex** | **int?**|  | [optional] 
 **timekeeperNumber** | **string**|  | [optional] 
 **timekeeperID** | [**Guid?**](Guid?.md)|  | [optional] 
 **itemIds** | [**List&lt;Guid&gt;**](Guid.md)|  | [optional] 
 **attributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **filterXOQL** | **string**|  | [optional] 
 **filterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **filterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **filterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPITimeModelsActiveTimersResponse**](E3EAPITimeModelsActiveTimersResponse.md)

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


## TimeGetCalendarReport

> E3EAPITimeModelsCalendarReportGetResponse TimeGetCalendarReport (int timekeeper, DateTime startDate, DateTime endDate, int? matter = null, int? _client = null, bool? includeHours = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets calendar data report for a given timekeeper and period.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetCalendarReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var timekeeper = 56;  // int | Gets or sets the timekeeper index.
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | Gets or sets the start date for a reporting period.
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | Gets or sets the end date for a reporting period.
            var matter = 56;  // int? | Gets or sets the matter index. (optional) 
            var _client = 56;  // int? | Gets or sets the client index. (optional) 
            var includeHours = true;  // bool? | Gets or sets a value indicating whether to return week hours objectives. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets calendar data report for a given timekeeper and period.
                E3EAPITimeModelsCalendarReportGetResponse result = apiInstance.TimeGetCalendarReport(timekeeper, startDate, endDate, matter, _client, includeHours, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetCalendarReport: " + e.Message );
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
 **timekeeper** | **int**| Gets or sets the timekeeper index. | 
 **startDate** | **DateTime**| Gets or sets the start date for a reporting period. | 
 **endDate** | **DateTime**| Gets or sets the end date for a reporting period. | 
 **matter** | **int?**| Gets or sets the matter index. | [optional] 
 **_client** | **int?**| Gets or sets the client index. | [optional] 
 **includeHours** | **bool?**| Gets or sets a value indicating whether to return week hours objectives. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPITimeModelsCalendarReportGetResponse**](E3EAPITimeModelsCalendarReportGetResponse.md)

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


## TimeGetNewPendingTimecard

> E3EAPITimeModelsTimecardTemplateResponse TimeGetNewPendingTimecard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets a new pending timecard with default values.

This method does not launch a process or add any data in 3E.  It is intended to be used with CreateTimecardPending.  e.g. call this method, then set whichever attributes need to be changed and then call CreateTimecardPending with the modified RootData.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetNewPendingTimecardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets a new pending timecard with default values.
                E3EAPITimeModelsTimecardTemplateResponse result = apiInstance.TimeGetNewPendingTimecard(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetNewPendingTimecard: " + e.Message );
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

[**E3EAPITimeModelsTimecardTemplateResponse**](E3EAPITimeModelsTimecardTemplateResponse.md)

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


## TimeGetNewPostedTimecard

> E3EAPITimeModelsTimecardTemplateResponse TimeGetNewPostedTimecard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets a new posted timecard with default values.

This method does not launch a process or add any data in 3E.  It is intended to be used with CreatePendingTimecard.  e.g. call this method, then set whichever attributes need to be changed and then call CreateTimecardPosted with the modified RootData.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetNewPostedTimecardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets a new posted timecard with default values.
                E3EAPITimeModelsTimecardTemplateResponse result = apiInstance.TimeGetNewPostedTimecard(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetNewPostedTimecard: " + e.Message );
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

[**E3EAPITimeModelsTimecardTemplateResponse**](E3EAPITimeModelsTimecardTemplateResponse.md)

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


## TimeGetNewTimeCaptureCard

> E3EAPITimeModelsTimecardTemplateResponse TimeGetNewTimeCaptureCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets a new timecapture timecard with default values.

This method does not launch a process or add any data in 3E.  It is intended to be used with CreateTimecardPending.  e.g. call this method, then set whichever attributes need to be changed and then call CreateTimecardPending with the modified RootData.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetNewTimeCaptureCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets a new timecapture timecard with default values.
                E3EAPITimeModelsTimecardTemplateResponse result = apiInstance.TimeGetNewTimeCaptureCard(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetNewTimeCaptureCard: " + e.Message );
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

[**E3EAPITimeModelsTimecardTemplateResponse**](E3EAPITimeModelsTimecardTemplateResponse.md)

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


## TimeGetPendingTimecardSchema

> E3EAPITimeModelsTimecardGetSchemaResponse TimeGetPendingTimecardSchema (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets the schema for pending timecards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetPendingTimecardSchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets the schema for pending timecards.
                E3EAPITimeModelsTimecardGetSchemaResponse result = apiInstance.TimeGetPendingTimecardSchema(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetPendingTimecardSchema: " + e.Message );
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

[**E3EAPITimeModelsTimecardGetSchemaResponse**](E3EAPITimeModelsTimecardGetSchemaResponse.md)

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


## TimeGetPendingTimecards

> E3EAPITimeModelsTimecardGetResponse TimeGetPendingTimecards (DateTime? startDate = null, DateTime? endDate = null, List<Guid> timeCardPendingID = null, int? timePendIndex = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets pending timecards for a given timekeeper and returns a TimecardGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetPendingTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the StartDate (WorkDate). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the EndDate (WorkDate). (optional) 
            var timeCardPendingID = new List<Guid>(); // List<Guid> | Gets or sets the TimeCardPendingIDs. (optional) 
            var timePendIndex = 56;  // int? | Gets or sets the TimePendIndex. (optional) 
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
                // Gets pending timecards for a given timekeeper and returns a TimecardGetResponse.
                E3EAPITimeModelsTimecardGetResponse result = apiInstance.TimeGetPendingTimecards(startDate, endDate, timeCardPendingID, timePendIndex, timekeeperIndex, timekeeperNumber, timekeeperID, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetPendingTimecards: " + e.Message );
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
 **timeCardPendingID** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the TimeCardPendingIDs. | [optional] 
 **timePendIndex** | **int?**| Gets or sets the TimePendIndex. | [optional] 
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

[**E3EAPITimeModelsTimecardGetResponse**](E3EAPITimeModelsTimecardGetResponse.md)

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


## TimeGetPostedTimecardSchema

> E3EAPITimeModelsTimecardGetSchemaResponse TimeGetPostedTimecardSchema (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets the schema for posted timecards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetPostedTimecardSchemaExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets the schema for posted timecards.
                E3EAPITimeModelsTimecardGetSchemaResponse result = apiInstance.TimeGetPostedTimecardSchema(x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetPostedTimecardSchema: " + e.Message );
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

[**E3EAPITimeModelsTimecardGetSchemaResponse**](E3EAPITimeModelsTimecardGetSchemaResponse.md)

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


## TimeGetPostedTimecards

> E3EAPITimeModelsTimecardGetResponse TimeGetPostedTimecards (DateTime? startDate = null, DateTime? endDate = null, List<Guid> timecardID = null, int? timeIndex = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets posted timecards for a given timekeeper and returns a TimecardGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetPostedTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the StartDate (WorkDate). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the EndDate (WorkDate). (optional) 
            var timecardID = new List<Guid>(); // List<Guid> | Gets or sets the TimecardIDs. (optional) 
            var timeIndex = 56;  // int? | Gets or sets the TimeIndex. (optional) 
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
                // Gets posted timecards for a given timekeeper and returns a TimecardGetResponse.
                E3EAPITimeModelsTimecardGetResponse result = apiInstance.TimeGetPostedTimecards(startDate, endDate, timecardID, timeIndex, timekeeperIndex, timekeeperNumber, timekeeperID, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetPostedTimecards: " + e.Message );
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
 **timecardID** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the TimecardIDs. | [optional] 
 **timeIndex** | **int?**| Gets or sets the TimeIndex. | [optional] 
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

[**E3EAPITimeModelsTimecardGetResponse**](E3EAPITimeModelsTimecardGetResponse.md)

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


## TimeGetTimeCaptureAllCards

> E3EAPITimeModelsTimecardGetAllResponse TimeGetTimeCaptureAllCards (int? index = null, DateTime? startDate = null, DateTime? endDate = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, List<Guid> itemIds = null, List<string> attributesToInclude = null, string filterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> filterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? filterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> filterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets timecapture records (both posted and pending) for a given timekeeper and returns a TimecardGetAllResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetTimeCaptureAllCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var index = 56;  // int? |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the StartDate (WorkDate). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the EndDate (WorkDate). (optional) 
            var timekeeperIndex = 56;  // int? |  (optional) 
            var timekeeperNumber = timekeeperNumber_example;  // string |  (optional) 
            var timekeeperID = new Guid?(); // Guid? |  (optional) 
            var itemIds = new List<Guid>(); // List<Guid> |  (optional) 
            var attributesToInclude = new List<string>(); // List<string> |  (optional) 
            var filterXOQL = filterXOQL_example;  // string |  (optional) 
            var filterPredicates = new List<E3EAPIQuerySJQLSJPredicate>(); // List<E3EAPIQuerySJQLSJPredicate> | Gets or Sets predicates. (optional) 
            var filterOperator = ;  // E3EAPIQuerySJQLSJLogicalOperator? | Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. (optional) 
            var filterGroups = new List<E3EAPIQuerySJQLSJPredicateGroup>(); // List<E3EAPIQuerySJQLSJPredicateGroup> | Gets or Sets group of predicates based on a logical operator. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets timecapture records (both posted and pending) for a given timekeeper and returns a TimecardGetAllResponse.
                E3EAPITimeModelsTimecardGetAllResponse result = apiInstance.TimeGetTimeCaptureAllCards(index, startDate, endDate, timekeeperIndex, timekeeperNumber, timekeeperID, itemIds, attributesToInclude, filterXOQL, filterPredicates, filterOperator, filterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetTimeCaptureAllCards: " + e.Message );
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
 **index** | **int?**|  | [optional] 
 **startDate** | **DateTime?**| Gets or sets the StartDate (WorkDate). | [optional] 
 **endDate** | **DateTime?**| Gets or sets the EndDate (WorkDate). | [optional] 
 **timekeeperIndex** | **int?**|  | [optional] 
 **timekeeperNumber** | **string**|  | [optional] 
 **timekeeperID** | [**Guid?**](Guid?.md)|  | [optional] 
 **itemIds** | [**List&lt;Guid&gt;**](Guid.md)|  | [optional] 
 **attributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **filterXOQL** | **string**|  | [optional] 
 **filterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **filterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **filterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPITimeModelsTimecardGetAllResponse**](E3EAPITimeModelsTimecardGetAllResponse.md)

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


## TimeGetTimeCaptureModels

> E3EAPIDataObjectModelModelsDataObjectModelGetResponse TimeGetTimeCaptureModels (Guid? modelId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets TimeCapture models.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetTimeCaptureModelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var modelId = new Guid?(); // Guid? | Gets or sets the ID of a model. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets TimeCapture models.
                E3EAPIDataObjectModelModelsDataObjectModelGetResponse result = apiInstance.TimeGetTimeCaptureModels(modelId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetTimeCaptureModels: " + e.Message );
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
 **modelId** | [**Guid?**](Guid?.md)| Gets or sets the ID of a model. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPIDataObjectModelModelsDataObjectModelGetResponse**](E3EAPIDataObjectModelModelsDataObjectModelGetResponse.md)

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


## TimeGetTimeCapturePendingCards

> E3EAPITimeModelsTimecardGetResponse TimeGetTimeCapturePendingCards (DateTime? startDate = null, DateTime? endDate = null, List<Guid> timeCardPendingID = null, int? timePendIndex = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, List<string> advancedFilterAttributesToInclude = null, string advancedFilterFilterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> advancedFilterFilterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? advancedFilterFilterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> advancedFilterFilterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets timecapture pending records for a given timekeeper and returns a TimecardGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetTimeCapturePendingCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the StartDate (WorkDate). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the EndDate (WorkDate). (optional) 
            var timeCardPendingID = new List<Guid>(); // List<Guid> | Gets or sets the TimeCardPendingIDs. (optional) 
            var timePendIndex = 56;  // int? | Gets or sets the TimePendIndex. (optional) 
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
                // Gets timecapture pending records for a given timekeeper and returns a TimecardGetResponse.
                E3EAPITimeModelsTimecardGetResponse result = apiInstance.TimeGetTimeCapturePendingCards(startDate, endDate, timeCardPendingID, timePendIndex, timekeeperIndex, timekeeperNumber, timekeeperID, advancedFilterAttributesToInclude, advancedFilterFilterXOQL, advancedFilterFilterPredicates, advancedFilterFilterOperator, advancedFilterFilterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetTimeCapturePendingCards: " + e.Message );
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
 **timeCardPendingID** | [**List&lt;Guid&gt;**](Guid.md)| Gets or sets the TimeCardPendingIDs. | [optional] 
 **timePendIndex** | **int?**| Gets or sets the TimePendIndex. | [optional] 
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

[**E3EAPITimeModelsTimecardGetResponse**](E3EAPITimeModelsTimecardGetResponse.md)

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


## TimeGetTimecards

> E3EAPITimeModelsTimecardGetAllResponse TimeGetTimecards (int? index = null, DateTime? startDate = null, DateTime? endDate = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, List<Guid> itemIds = null, List<string> attributesToInclude = null, string filterXOQL = null, List<E3EAPIQuerySJQLSJPredicate> filterPredicates = null, E3EAPIQuerySJQLSJLogicalOperator? filterOperator = null, List<E3EAPIQuerySJQLSJPredicateGroup> filterGroups = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets timecards (both posted and pending) for a given timekeeper and returns a TimecardGetAllResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var index = 56;  // int? |  (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the StartDate (WorkDate). (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Gets or sets the EndDate (WorkDate). (optional) 
            var timekeeperIndex = 56;  // int? |  (optional) 
            var timekeeperNumber = timekeeperNumber_example;  // string |  (optional) 
            var timekeeperID = new Guid?(); // Guid? |  (optional) 
            var itemIds = new List<Guid>(); // List<Guid> |  (optional) 
            var attributesToInclude = new List<string>(); // List<string> |  (optional) 
            var filterXOQL = filterXOQL_example;  // string |  (optional) 
            var filterPredicates = new List<E3EAPIQuerySJQLSJPredicate>(); // List<E3EAPIQuerySJQLSJPredicate> | Gets or Sets predicates. (optional) 
            var filterOperator = ;  // E3EAPIQuerySJQLSJLogicalOperator? | Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. (optional) 
            var filterGroups = new List<E3EAPIQuerySJQLSJPredicateGroup>(); // List<E3EAPIQuerySJQLSJPredicateGroup> | Gets or Sets group of predicates based on a logical operator. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets timecards (both posted and pending) for a given timekeeper and returns a TimecardGetAllResponse.
                E3EAPITimeModelsTimecardGetAllResponse result = apiInstance.TimeGetTimecards(index, startDate, endDate, timekeeperIndex, timekeeperNumber, timekeeperID, itemIds, attributesToInclude, filterXOQL, filterPredicates, filterOperator, filterGroups, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetTimecards: " + e.Message );
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
 **index** | **int?**|  | [optional] 
 **startDate** | **DateTime?**| Gets or sets the StartDate (WorkDate). | [optional] 
 **endDate** | **DateTime?**| Gets or sets the EndDate (WorkDate). | [optional] 
 **timekeeperIndex** | **int?**|  | [optional] 
 **timekeeperNumber** | **string**|  | [optional] 
 **timekeeperID** | [**Guid?**](Guid?.md)|  | [optional] 
 **itemIds** | [**List&lt;Guid&gt;**](Guid.md)|  | [optional] 
 **attributesToInclude** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **filterXOQL** | **string**|  | [optional] 
 **filterPredicates** | [**List&lt;E3EAPIQuerySJQLSJPredicate&gt;**](E3EAPIQuerySJQLSJPredicate.md)| Gets or Sets predicates. | [optional] 
 **filterOperator** | **E3EAPIQuerySJQLSJLogicalOperator?**| Gets or Sets the logical operator between the group of E3E.API.Query.SJQL.SJPredicateGroup.Predicates and the E3E.API.Query.SJQL.SJPredicateGroup.Groups. | [optional] 
 **filterGroups** | [**List&lt;E3EAPIQuerySJQLSJPredicateGroup&gt;**](E3EAPIQuerySJQLSJPredicateGroup.md)| Gets or Sets group of predicates based on a logical operator. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPITimeModelsTimecardGetAllResponse**](E3EAPITimeModelsTimecardGetAllResponse.md)

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


## TimeGetTimecardsGroupedByDay

> E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse TimeGetTimecardsGroupedByDay (DateTime startDate, DateTime endDate, int? lastDays = null, int? timekeeperIndex = null, string timekeeperNumber = null, Guid? timekeeperID = null, int? mattIndex = null, int? clientIndex = null, List<string> attributesToInclude = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets pending and posted timecards grouped for display in weekly view.

The following attributes are always returned by default (in addition to anything specified in AttributesToInclude):  WorkDate, TimePendIndex, TimeIndex, WorkHrs, IsNB, IsNoCharge, WorkType, TimeType, Office, Matter, Phase, Task, Activity, IsFlatFeeComplete, Phase2, Task2, Activity2.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeGetTimecardsGroupedByDayExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | Gets or sets the StartDate.
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | Gets or sets the EndDate.
            var lastDays = 56;  // int? | Gets or sets the LastDays. (optional) 
            var timekeeperIndex = 56;  // int? |  (optional) 
            var timekeeperNumber = timekeeperNumber_example;  // string |  (optional) 
            var timekeeperID = new Guid?(); // Guid? |  (optional) 
            var mattIndex = 56;  // int? | Gets or sets the MattIndex. (optional) 
            var clientIndex = 56;  // int? | Gets or sets the ClientIndex. (optional) 
            var attributesToInclude = new List<string>(); // List<string> | Gets or sets a collection of attributes that should be returned with the response. (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets pending and posted timecards grouped for display in weekly view.
                E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse result = apiInstance.TimeGetTimecardsGroupedByDay(startDate, endDate, lastDays, timekeeperIndex, timekeeperNumber, timekeeperID, mattIndex, clientIndex, attributesToInclude, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeGetTimecardsGroupedByDay: " + e.Message );
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
 **startDate** | **DateTime**| Gets or sets the StartDate. | 
 **endDate** | **DateTime**| Gets or sets the EndDate. | 
 **lastDays** | **int?**| Gets or sets the LastDays. | [optional] 
 **timekeeperIndex** | **int?**|  | [optional] 
 **timekeeperNumber** | **string**|  | [optional] 
 **timekeeperID** | [**Guid?**](Guid?.md)|  | [optional] 
 **mattIndex** | **int?**| Gets or sets the MattIndex. | [optional] 
 **clientIndex** | **int?**| Gets or sets the ClientIndex. | [optional] 
 **attributesToInclude** | [**List&lt;string&gt;**](string.md)| Gets or sets a collection of attributes that should be returned with the response. | [optional] 
 **x3ESessionId** | **string**| The user&#39;s session identifier | [optional] [default to &quot;e6f862be-06ae-434e-bf07-54888f552016&quot;]
 **x3EUserId** | **string**| The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present | [optional] 
 **acceptLanguage** | **string**| Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user&#39;s 3E language assignment which can be retrieved by the session endpoint | [optional] [default to &quot;DEFAULT&quot;]

### Return type

[**E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse**](E3EAPITimeWeeklyViewModelsTimeWeeklyViewGetResponse.md)

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


## TimeModelFromPendingTimecards

> E3EAPITimeModelsTimecardGetResponse TimeModelFromPendingTimecards (List<string> itemId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets cloned pending timecards and returns a TimecardGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeModelFromPendingTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var itemId = new List<string>(); // List<string> |  (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets cloned pending timecards and returns a TimecardGetResponse.
                E3EAPITimeModelsTimecardGetResponse result = apiInstance.TimeModelFromPendingTimecards(itemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeModelFromPendingTimecards: " + e.Message );
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

[**E3EAPITimeModelsTimecardGetResponse**](E3EAPITimeModelsTimecardGetResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TimeModelFromPostedTimecards

> E3EAPIDataObjectModelsDataObjectGetResponse TimeModelFromPostedTimecards (List<string> itemId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Gets cloned timecards and returns a TimecardGetResponse.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeModelFromPostedTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var itemId = new List<string>(); // List<string> |  (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Gets cloned timecards and returns a TimecardGetResponse.
                E3EAPIDataObjectModelsDataObjectGetResponse result = apiInstance.TimeModelFromPostedTimecards(itemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeModelFromPostedTimecards: " + e.Message );
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

[**E3EAPIDataObjectModelsDataObjectGetResponse**](E3EAPIDataObjectModelsDataObjectGetResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TimePostPendingTimecards

> E3EAPITimeModelsTimecardPostResponse TimePostPendingTimecards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardPostRequest e3EAPITimeModelsTimecardPostRequest = null)

Posts one or more existing pending timecards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimePostPendingTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardPostRequest = new E3EAPITimeModelsTimecardPostRequest(); // E3EAPITimeModelsTimecardPostRequest | The TimecardPending.TimePendIndex values of the timecards to be posted. (optional) 

            try
            {
                // Posts one or more existing pending timecards.
                E3EAPITimeModelsTimecardPostResponse result = apiInstance.TimePostPendingTimecards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimePostPendingTimecards: " + e.Message );
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
 **e3EAPITimeModelsTimecardPostRequest** | [**E3EAPITimeModelsTimecardPostRequest**](E3EAPITimeModelsTimecardPostRequest.md)| The TimecardPending.TimePendIndex values of the timecards to be posted. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardPostResponse**](E3EAPITimeModelsTimecardPostResponse.md)

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


## TimeQueryTimeCaptureAllCards

> E3EAPITimeModelsTimecardGetAllResponse TimeQueryTimeCaptureAllCards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardGetRequest e3EAPITimeModelsTimecardGetRequest = null)

Queries timecapture records (both posted and pending) filtered out according to request body conditions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeQueryTimeCaptureAllCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardGetRequest = new E3EAPITimeModelsTimecardGetRequest(); // E3EAPITimeModelsTimecardGetRequest | The request details. (optional) 

            try
            {
                // Queries timecapture records (both posted and pending) filtered out according to request body conditions.
                E3EAPITimeModelsTimecardGetAllResponse result = apiInstance.TimeQueryTimeCaptureAllCards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeQueryTimeCaptureAllCards: " + e.Message );
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
 **e3EAPITimeModelsTimecardGetRequest** | [**E3EAPITimeModelsTimecardGetRequest**](E3EAPITimeModelsTimecardGetRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardGetAllResponse**](E3EAPITimeModelsTimecardGetAllResponse.md)

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
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TimeQueryTimeCapturePendingCards

> E3EAPITimeModelsTimecardGetResponse TimeQueryTimeCapturePendingCards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardGetRequest e3EAPITimeModelsTimecardGetRequest = null)

Queries timecapture records (pending only) filtered out according to request body conditions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeQueryTimeCapturePendingCardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardGetRequest = new E3EAPITimeModelsTimecardGetRequest(); // E3EAPITimeModelsTimecardGetRequest | The request details. (optional) 

            try
            {
                // Queries timecapture records (pending only) filtered out according to request body conditions.
                E3EAPITimeModelsTimecardGetResponse result = apiInstance.TimeQueryTimeCapturePendingCards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardGetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeQueryTimeCapturePendingCards: " + e.Message );
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
 **e3EAPITimeModelsTimecardGetRequest** | [**E3EAPITimeModelsTimecardGetRequest**](E3EAPITimeModelsTimecardGetRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardGetResponse**](E3EAPITimeModelsTimecardGetResponse.md)

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
| **204** | NoContent - The request has not produced any outputs, see messages in response header for details. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TimeSpellcheckPendingTimecards

> E3EAPITimeModelsTimecardSpellCheckResponse TimeSpellcheckPendingTimecards (List<string> itemId = null, string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null)

Spellchecks one or more existing pending timecards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeSpellcheckPendingTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var itemId = new List<string>(); // List<string> |  (optional) 
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")

            try
            {
                // Spellchecks one or more existing pending timecards.
                E3EAPITimeModelsTimecardSpellCheckResponse result = apiInstance.TimeSpellcheckPendingTimecards(itemId, x3ESessionId, x3EUserId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeSpellcheckPendingTimecards: " + e.Message );
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

[**E3EAPITimeModelsTimecardSpellCheckResponse**](E3EAPITimeModelsTimecardSpellCheckResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TimeStartStopTimer

> E3EAPITimeModelsStartStopTimerResponse TimeStartStopTimer (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsStartStopTimerRequest e3EAPITimeModelsStartStopTimerRequest = null)

Starts/stops a timer for a given pending timecard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeStartStopTimerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsStartStopTimerRequest = new E3EAPITimeModelsStartStopTimerRequest(); // E3EAPITimeModelsStartStopTimerRequest | The request details. (optional) 

            try
            {
                // Starts/stops a timer for a given pending timecard.
                E3EAPITimeModelsStartStopTimerResponse result = apiInstance.TimeStartStopTimer(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsStartStopTimerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeStartStopTimer: " + e.Message );
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
 **e3EAPITimeModelsStartStopTimerRequest** | [**E3EAPITimeModelsStartStopTimerRequest**](E3EAPITimeModelsStartStopTimerRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsStartStopTimerResponse**](E3EAPITimeModelsStartStopTimerResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json, application/xml, text/xml, application/_*+xml
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


## TimeUpdatePendingTimecard

> E3EAPITimeModelsTimecardUpdateResponse TimeUpdatePendingTimecard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardUpdateRequest e3EAPITimeModelsTimecardUpdateRequest = null)

Updates a pending timecard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeUpdatePendingTimecardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardUpdateRequest = new E3EAPITimeModelsTimecardUpdateRequest(); // E3EAPITimeModelsTimecardUpdateRequest | The request details. (optional) 

            try
            {
                // Updates a pending timecard.
                E3EAPITimeModelsTimecardUpdateResponse result = apiInstance.TimeUpdatePendingTimecard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeUpdatePendingTimecard: " + e.Message );
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
 **e3EAPITimeModelsTimecardUpdateRequest** | [**E3EAPITimeModelsTimecardUpdateRequest**](E3EAPITimeModelsTimecardUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardUpdateResponse**](E3EAPITimeModelsTimecardUpdateResponse.md)

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


## TimeUpdatePostedTimecard

> E3EAPITimeModelsTimecardUpdateResponse TimeUpdatePostedTimecard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardUpdateRequest e3EAPITimeModelsTimecardUpdateRequest = null)

Updates a posted timecard.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeUpdatePostedTimecardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardUpdateRequest = new E3EAPITimeModelsTimecardUpdateRequest(); // E3EAPITimeModelsTimecardUpdateRequest | The request details. (optional) 

            try
            {
                // Updates a posted timecard.
                E3EAPITimeModelsTimecardUpdateResponse result = apiInstance.TimeUpdatePostedTimecard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeUpdatePostedTimecard: " + e.Message );
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
 **e3EAPITimeModelsTimecardUpdateRequest** | [**E3EAPITimeModelsTimecardUpdateRequest**](E3EAPITimeModelsTimecardUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardUpdateResponse**](E3EAPITimeModelsTimecardUpdateResponse.md)

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


## TimeUpdateTimeCaptureCard

> E3EAPITimeModelsTimecardUpdateResponse TimeUpdateTimeCaptureCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardUpdateRequest e3EAPITimeModelsTimecardUpdateRequest = null)

Updates an existing timecapture record.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeUpdateTimeCaptureCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardUpdateRequest = new E3EAPITimeModelsTimecardUpdateRequest(); // E3EAPITimeModelsTimecardUpdateRequest | The request details. (optional) 

            try
            {
                // Updates an existing timecapture record.
                E3EAPITimeModelsTimecardUpdateResponse result = apiInstance.TimeUpdateTimeCaptureCard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeUpdateTimeCaptureCard: " + e.Message );
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
 **e3EAPITimeModelsTimecardUpdateRequest** | [**E3EAPITimeModelsTimecardUpdateRequest**](E3EAPITimeModelsTimecardUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardUpdateResponse**](E3EAPITimeModelsTimecardUpdateResponse.md)

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


## TimeUpdateTimeCaptureModel

> E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse TimeUpdateTimeCaptureModel (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest e3EAPIDataObjectModelModelsDataObjectModelUpdateRequest = null)

Updates a TimeCapture model.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeUpdateTimeCaptureModelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPIDataObjectModelModelsDataObjectModelUpdateRequest = new E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest(); // E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest | The request details. (optional) 

            try
            {
                // Updates a TimeCapture model.
                E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse result = apiInstance.TimeUpdateTimeCaptureModel(x3ESessionId, x3EUserId, acceptLanguage, e3EAPIDataObjectModelModelsDataObjectModelUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeUpdateTimeCaptureModel: " + e.Message );
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
 **e3EAPIDataObjectModelModelsDataObjectModelUpdateRequest** | [**E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest**](E3EAPIDataObjectModelModelsDataObjectModelUpdateRequest.md)| The request details. | [optional] 

### Return type

[**E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse**](E3EAPIDataObjectModelModelsDataObjectModelUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json, application/xml, text/xml, application/_*+xml
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


## TimeValidatePendingTimecards

> E3EAPITimeModelsTimecardValidateResponse TimeValidatePendingTimecards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardValidateRequest e3EAPITimeModelsTimecardValidateRequest = null)

Validates one or more existing pending timecards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeValidatePendingTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardValidateRequest = new E3EAPITimeModelsTimecardValidateRequest(); // E3EAPITimeModelsTimecardValidateRequest | The Timecardpending.TimePendIndex values of the timecards to be validated. (optional) 

            try
            {
                // Validates one or more existing pending timecards.
                E3EAPITimeModelsTimecardValidateResponse result = apiInstance.TimeValidatePendingTimecards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeValidatePendingTimecards: " + e.Message );
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
 **e3EAPITimeModelsTimecardValidateRequest** | [**E3EAPITimeModelsTimecardValidateRequest**](E3EAPITimeModelsTimecardValidateRequest.md)| The Timecardpending.TimePendIndex values of the timecards to be validated. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardValidateResponse**](E3EAPITimeModelsTimecardValidateResponse.md)

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


## TimeValidatePostedTimecards

> E3EAPITimeModelsTimecardValidateResponse TimeValidatePostedTimecards (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardValidateRequest e3EAPITimeModelsTimecardValidateRequest = null)

Validates one or more existing timecards.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeValidatePostedTimecardsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardValidateRequest = new E3EAPITimeModelsTimecardValidateRequest(); // E3EAPITimeModelsTimecardValidateRequest | The Timecard.TimeIndex values of the timecards to be validated. (optional) 

            try
            {
                // Validates one or more existing timecards.
                E3EAPITimeModelsTimecardValidateResponse result = apiInstance.TimeValidatePostedTimecards(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeValidatePostedTimecards: " + e.Message );
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
 **e3EAPITimeModelsTimecardValidateRequest** | [**E3EAPITimeModelsTimecardValidateRequest**](E3EAPITimeModelsTimecardValidateRequest.md)| The Timecard.TimeIndex values of the timecards to be validated. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardValidateResponse**](E3EAPITimeModelsTimecardValidateResponse.md)

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


## TimeValidateTimecaptureCard

> E3EAPITimeModelsTimecardValidateResponse TimeValidateTimecaptureCard (string x3ESessionId = null, string x3EUserId = null, string acceptLanguage = null, E3EAPITimeModelsTimecardValidateRequest e3EAPITimeModelsTimecardValidateRequest = null)

Validates one or more existing timecapture records.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeValidateTimecaptureCardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://ldbm3ewapi1/TE_3E_SAMPLE/web";
            var apiInstance = new TimeApi(Configuration.Default);
            var x3ESessionId = x3ESessionId_example;  // string | The user's session identifier (optional)  (default to "e6f862be-06ae-434e-bf07-54888f552016")
            var x3EUserId = x3EUserId_example;  // string | The unique user identifier - this is only allowed in conjunction with the Integration scope for applications like EIF.  A forbidden response will be returned if this scope is not present (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Preferred language code of the request (en-GB, en-US, fr-FR). Defaults to the user's 3E language assignment which can be retrieved by the session endpoint (optional)  (default to "DEFAULT")
            var e3EAPITimeModelsTimecardValidateRequest = new E3EAPITimeModelsTimecardValidateRequest(); // E3EAPITimeModelsTimecardValidateRequest | The ItemId values of the timecards to be validated. (optional) 

            try
            {
                // Validates one or more existing timecapture records.
                E3EAPITimeModelsTimecardValidateResponse result = apiInstance.TimeValidateTimecaptureCard(x3ESessionId, x3EUserId, acceptLanguage, e3EAPITimeModelsTimecardValidateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimeApi.TimeValidateTimecaptureCard: " + e.Message );
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
 **e3EAPITimeModelsTimecardValidateRequest** | [**E3EAPITimeModelsTimecardValidateRequest**](E3EAPITimeModelsTimecardValidateRequest.md)| The ItemId values of the timecards to be validated. | [optional] 

### Return type

[**E3EAPITimeModelsTimecardValidateResponse**](E3EAPITimeModelsTimecardValidateResponse.md)

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

