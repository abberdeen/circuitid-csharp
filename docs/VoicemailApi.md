# circuitid-csharp.CircuitID.VoicemailApi

All URIs are relative to *https://cloud9.circuitid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FindVoicemail**](VoicemailApi.md#findvoicemail) | **GET** /voicemail | Find multiple objects
[**GetVoicemail**](VoicemailApi.md#getvoicemail) | **GET** /voicemail/{id} | Get object by id



## FindVoicemail

> Object FindVoicemail (Object search = null, Object limit = null, Object skip = null, Object sort = null, Object select = null, Object or = null, Object and = null)

Find multiple objects

Search and retrieve multiple objects simultaneously. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using circuitid-csharp.CircuitID;
using circuitid-csharp.Client;
using circuitid-csharp.CircuitID;

namespace Example
{
    public class FindVoicemailExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(Configuration.Default);
            var search = new Object(); // Object | Filter results by the specified value. (optional) 
            var limit = new Object(); // Object | $limit will return only the number of results you specify. (optional) 
            var skip = new Object(); // Object | $skip will skip the specified number of results. (optional) 
            var sort = new Object(); // Object | $sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional) 
            var select = new Object(); // Object | $select allows to pick which fields to include in the result. (optional) 
            var or = new Object(); // Object | Find all records that match any of the given criteria. (optional) 
            var and = new Object(); // Object | Find all records that match all of the given criteria. (optional) 

            try
            {
                // Find multiple objects
                Object result = apiInstance.FindVoicemail(search, limit, skip, sort, select, or, and);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VoicemailApi.FindVoicemail: " + e.Message );
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
 **search** | [**Object**](Object.md)| Filter results by the specified value. | [optional] 
 **limit** | [**Object**](Object.md)| $limit will return only the number of results you specify. | [optional] 
 **skip** | [**Object**](Object.md)| $skip will skip the specified number of results. | [optional] 
 **sort** | [**Object**](Object.md)| $sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). | [optional] 
 **select** | [**Object**](Object.md)| $select allows to pick which fields to include in the result. | [optional] 
 **or** | [**Object**](Object.md)| Find all records that match any of the given criteria. | [optional] 
 **and** | [**Object**](Object.md)| Find all records that match all of the given criteria. | [optional] 

### Return type

**Object**

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the requested data |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **405** |  |  -  |
| **406** |  |  -  |
| **408** |  |  -  |
| **429** |  |  -  |
| **500** |  |  -  |
| **503** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetVoicemail

> void GetVoicemail (Object id)

Get object by id

Get an object from the REST API Endpoint by its unique id.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using circuitid-csharp.CircuitID;
using circuitid-csharp.Client;
using circuitid-csharp.CircuitID;

namespace Example
{
    public class GetVoicemailExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VoicemailApi(Configuration.Default);
            var id = new Object(); // Object | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Get object by id
                apiInstance.GetVoicemail(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VoicemailApi.GetVoicemail: " + e.Message );
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
 **id** | [**Object**](Object.md)| The ObjectId (unique 12 bytes ID) of record you would like to GET. | 

### Return type

void (empty response body)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the requested data. |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **404** | Not Found |  -  |
| **405** |  |  -  |
| **406** |  |  -  |
| **408** |  |  -  |
| **429** |  |  -  |
| **500** |  |  -  |
| **503** |  |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

