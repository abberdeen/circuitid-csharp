# Com.CircuitID.Api.FaxAccountsApi

All URIs are relative to *https://cloud9.circuitid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFaxAccount**](FaxAccountsApi.md#createfaxaccount) | **POST** /faxaccounts | Create a new object
[**FindFaxAccounts**](FaxAccountsApi.md#findfaxaccounts) | **GET** /faxaccounts | Find multiple objects
[**GetFaxAccount**](FaxAccountsApi.md#getfaxaccount) | **GET** /faxaccounts/{id} | Get object by id
[**PatchFaxAccount**](FaxAccountsApi.md#patchfaxaccount) | **PATCH** /faxaccounts/{id} | Patch object&#39;s data
[**RemoveFaxAccount**](FaxAccountsApi.md#removefaxaccount) | **DELETE** /faxaccounts/{id} | Delete object by id



## CreateFaxAccount

> GetFaxAccount200Response CreateFaxAccount (FaxaccountsCreateOrPatch faxaccountsCreateOrPatch)

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
    public class CreateFaxAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FaxAccountsApi(Configuration.Default);
            var faxaccountsCreateOrPatch = new FaxaccountsCreateOrPatch(); // FaxaccountsCreateOrPatch | The JSON object that will be posted to the REST API endpoint.

            try
            {
                // Create a new object
                GetFaxAccount200Response result = apiInstance.CreateFaxAccount(faxaccountsCreateOrPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FaxAccountsApi.CreateFaxAccount: " + e.Message );
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
 **faxaccountsCreateOrPatch** | [**FaxaccountsCreateOrPatch**](FaxaccountsCreateOrPatch.md)| The JSON object that will be posted to the REST API endpoint. | 

### Return type

[**GetFaxAccount200Response**](GetFaxAccount200Response.md)

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


## FindFaxAccounts

> FindFaxAccounts200Response FindFaxAccounts (string search = null, int? limit = null, int? skip = null, Object sort = null, List<string> select = null, List<Object> or = null, List<Object> and = null)

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
    public class FindFaxAccountsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FaxAccountsApi(Configuration.Default);
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
                FindFaxAccounts200Response result = apiInstance.FindFaxAccounts(search, limit, skip, sort, select, or, and);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FaxAccountsApi.FindFaxAccounts: " + e.Message );
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

[**FindFaxAccounts200Response**](FindFaxAccounts200Response.md)

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


## GetFaxAccount

> GetFaxAccount200Response GetFaxAccount (string id)

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
    public class GetFaxAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FaxAccountsApi(Configuration.Default);
            var id = "id_example";  // string | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Get object by id
                GetFaxAccount200Response result = apiInstance.GetFaxAccount(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FaxAccountsApi.GetFaxAccount: " + e.Message );
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

[**GetFaxAccount200Response**](GetFaxAccount200Response.md)

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


## PatchFaxAccount

> GetFaxAccount200Response PatchFaxAccount (string id, FaxaccountsCreateOrPatch faxaccountsCreateOrPatch)

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
    public class PatchFaxAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FaxAccountsApi(Configuration.Default);
            var id = "id_example";  // string | The ObjectId (unique 12 bytes ID) of record you would like to GET.
            var faxaccountsCreateOrPatch = new FaxaccountsCreateOrPatch(); // FaxaccountsCreateOrPatch | The request data.

            try
            {
                // Patch object's data
                GetFaxAccount200Response result = apiInstance.PatchFaxAccount(id, faxaccountsCreateOrPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FaxAccountsApi.PatchFaxAccount: " + e.Message );
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
 **faxaccountsCreateOrPatch** | [**FaxaccountsCreateOrPatch**](FaxaccountsCreateOrPatch.md)| The request data. | 

### Return type

[**GetFaxAccount200Response**](GetFaxAccount200Response.md)

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


## RemoveFaxAccount

> GetFaxAccount200Response RemoveFaxAccount (string id)

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
    public class RemoveFaxAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FaxAccountsApi(Configuration.Default);
            var id = "id_example";  // string | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Delete object by id
                GetFaxAccount200Response result = apiInstance.RemoveFaxAccount(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FaxAccountsApi.RemoveFaxAccount: " + e.Message );
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

[**GetFaxAccount200Response**](GetFaxAccount200Response.md)

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

