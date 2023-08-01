# Com.CircuitID.Api.PhoneInboundRulesApi

All URIs are relative to *https://cloud9.circuitid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePhoneInboundRule**](PhoneInboundRulesApi.md#createphoneinboundrule) | **POST** /phoneinboundrules | Create a new object
[**FindPhoneInboundRules**](PhoneInboundRulesApi.md#findphoneinboundrules) | **GET** /phoneinboundrules | Find multiple objects
[**GetPhoneInboundRule**](PhoneInboundRulesApi.md#getphoneinboundrule) | **GET** /phoneinboundrules/{id} | Get object by id
[**PatchPhoneInboundRule**](PhoneInboundRulesApi.md#patchphoneinboundrule) | **PATCH** /phoneinboundrules/{id} | Patch object&#39;s data
[**RemovePhoneInboundRule**](PhoneInboundRulesApi.md#removephoneinboundrule) | **DELETE** /phoneinboundrules/{id} | Delete object by id



## CreatePhoneInboundRule

> GetPhoneInboundRule200Response CreatePhoneInboundRule (PhoneinboundrulesCreateOrPatch phoneinboundrulesCreateOrPatch)

Create a new object

Add a new object to the system.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.CircuitID.Api;
using Com.CircuitID.Client;
using Com.CircuitID.Models;

namespace Example
{
    public class CreatePhoneInboundRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneInboundRulesApi(Configuration.Default);
            var phoneinboundrulesCreateOrPatch = new PhoneinboundrulesCreateOrPatch(); // PhoneinboundrulesCreateOrPatch | The JSON object that will be posted to the REST API endpoint.

            try
            {
                // Create a new object
                GetPhoneInboundRule200Response result = apiInstance.CreatePhoneInboundRule(phoneinboundrulesCreateOrPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneInboundRulesApi.CreatePhoneInboundRule: " + e.Message );
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
 **phoneinboundrulesCreateOrPatch** | [**PhoneinboundrulesCreateOrPatch**](PhoneinboundrulesCreateOrPatch.md)| The JSON object that will be posted to the REST API endpoint. | 

### Return type

[**GetPhoneInboundRule200Response**](GetPhoneInboundRule200Response.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the new object created |  -  |
| **400** | Bad Request |  -  |
| **401** | Not Authenticated |  -  |
| **403** | Forbidden |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **408** | Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | General Error |  -  |
| **503** | Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FindPhoneInboundRules

> FindPhoneInboundRules200Response FindPhoneInboundRules (string search = null, int? limit = null, int? skip = null, Object sort = null, List<string> select = null, List<Object> or = null, List<Object> and = null)

Find multiple objects

Search and retrieve multiple objects simultaneously. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.CircuitID.Api;
using Com.CircuitID.Client;
using Com.CircuitID.Models;

namespace Example
{
    public class FindPhoneInboundRulesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneInboundRulesApi(Configuration.Default);
            var search = "search_example";  // string | Filter results by the specified value. (optional) 
            var limit = 56;  // int? | $limit will return only the number of results you specify. (optional) 
            var skip = 56;  // int? | $skip will skip the specified number of results. (optional) 
            var sort = new Object(); // Object | $sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional) 
            var select = new List<string>(); // List<string> | $select allows to pick which fields to include in the result. (optional) 
            var or = new List<Object>(); // List<Object> | Find all records that match any of the given criteria. (optional) 
            var and = new List<Object>(); // List<Object> | Find all records that match all of the given criteria. (optional) 

            try
            {
                // Find multiple objects
                FindPhoneInboundRules200Response result = apiInstance.FindPhoneInboundRules(search, limit, skip, sort, select, or, and);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneInboundRulesApi.FindPhoneInboundRules: " + e.Message );
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
 **search** | **string**| Filter results by the specified value. | [optional] 
 **limit** | **int?**| $limit will return only the number of results you specify. | [optional] 
 **skip** | **int?**| $skip will skip the specified number of results. | [optional] 
 **sort** | [**Object**](Object.md)| $sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). | [optional] 
 **select** | [**List&lt;string&gt;**](string.md)| $select allows to pick which fields to include in the result. | [optional] 
 **or** | [**List&lt;Object&gt;**](Object.md)| Find all records that match any of the given criteria. | [optional] 
 **and** | [**List&lt;Object&gt;**](Object.md)| Find all records that match all of the given criteria. | [optional] 

### Return type

[**FindPhoneInboundRules200Response**](FindPhoneInboundRules200Response.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the requested data |  -  |
| **400** | Bad Request |  -  |
| **401** | Not Authenticated |  -  |
| **403** | Forbidden |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **408** | Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | General Error |  -  |
| **503** | Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPhoneInboundRule

> GetPhoneInboundRule200Response GetPhoneInboundRule (string id)

Get object by id

Get an object from the REST API Endpoint by its unique id.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.CircuitID.Api;
using Com.CircuitID.Client;
using Com.CircuitID.Models;

namespace Example
{
    public class GetPhoneInboundRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneInboundRulesApi(Configuration.Default);
            var id = "id_example";  // string | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Get object by id
                GetPhoneInboundRule200Response result = apiInstance.GetPhoneInboundRule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneInboundRulesApi.GetPhoneInboundRule: " + e.Message );
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
 **id** | **string**| The ObjectId (unique 12 bytes ID) of record you would like to GET. | 

### Return type

[**GetPhoneInboundRule200Response**](GetPhoneInboundRule200Response.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the requested data. |  -  |
| **400** | Bad Request |  -  |
| **401** | Not Authenticated |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **408** | Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | General Error |  -  |
| **503** | Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchPhoneInboundRule

> GetPhoneInboundRule200Response PatchPhoneInboundRule (string id, PhoneinboundrulesCreateOrPatch phoneinboundrulesCreateOrPatch)

Patch object's data

Make updates to specific fields within the record without replacing the entire dataset.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.CircuitID.Api;
using Com.CircuitID.Client;
using Com.CircuitID.Models;

namespace Example
{
    public class PatchPhoneInboundRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneInboundRulesApi(Configuration.Default);
            var id = "id_example";  // string | The ObjectId (unique 12 bytes ID) of record you would like to GET.
            var phoneinboundrulesCreateOrPatch = new PhoneinboundrulesCreateOrPatch(); // PhoneinboundrulesCreateOrPatch | The request data.

            try
            {
                // Patch object's data
                GetPhoneInboundRule200Response result = apiInstance.PatchPhoneInboundRule(id, phoneinboundrulesCreateOrPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneInboundRulesApi.PatchPhoneInboundRule: " + e.Message );
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
 **id** | **string**| The ObjectId (unique 12 bytes ID) of record you would like to GET. | 
 **phoneinboundrulesCreateOrPatch** | [**PhoneinboundrulesCreateOrPatch**](PhoneinboundrulesCreateOrPatch.md)| The request data. | 

### Return type

[**GetPhoneInboundRule200Response**](GetPhoneInboundRule200Response.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the modified data. |  -  |
| **400** | Bad Request |  -  |
| **401** | Not Authenticated |  -  |
| **403** | Forbidden |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **408** | Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | General Error |  -  |
| **503** | Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemovePhoneInboundRule

> GetPhoneInboundRule200Response RemovePhoneInboundRule (string id)

Delete object by id

Delete an object by id, removing it from the service.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.CircuitID.Api;
using Com.CircuitID.Client;
using Com.CircuitID.Models;

namespace Example
{
    public class RemovePhoneInboundRuleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneInboundRulesApi(Configuration.Default);
            var id = "id_example";  // string | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Delete object by id
                GetPhoneInboundRule200Response result = apiInstance.RemovePhoneInboundRule(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PhoneInboundRulesApi.RemovePhoneInboundRule: " + e.Message );
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
 **id** | **string**| The ObjectId (unique 12 bytes ID) of record you would like to GET. | 

### Return type

[**GetPhoneInboundRule200Response**](GetPhoneInboundRule200Response.md)

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the deleted data. |  -  |
| **400** | Bad Request |  -  |
| **401** | Not Authenticated |  -  |
| **403** | Forbidden |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **408** | Timeout |  -  |
| **429** | Too Many Requests |  -  |
| **500** | General Error |  -  |
| **503** | Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

