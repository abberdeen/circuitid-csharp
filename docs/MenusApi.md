# Com.CircuitID.Api.MenusApi

All URIs are relative to *https://rest.circuitid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMenu**](MenusApi.md#createmenu) | **POST** /menus | Create a new object
[**FindMenus**](MenusApi.md#findmenus) | **GET** /menus | Find multiple objects
[**GetMenu**](MenusApi.md#getmenu) | **GET** /menus/{id} | Get object by id
[**PatchMenu**](MenusApi.md#patchmenu) | **PATCH** /menus/{id} | Patch object&#39;s data
[**RemoveMenu**](MenusApi.md#removemenu) | **DELETE** /menus/{id} | Delete object by id



## CreateMenu

> GetMenu200Response CreateMenu (MenusCreateOrPatch menusCreateOrPatch)

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
    public class CreateMenuExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenusApi(Configuration.Default);
            var menusCreateOrPatch = new MenusCreateOrPatch(); // MenusCreateOrPatch | The JSON object that will be posted to the REST API endpoint.

            try
            {
                // Create a new object
                GetMenu200Response result = apiInstance.CreateMenu(menusCreateOrPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenusApi.CreateMenu: " + e.Message );
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
 **menusCreateOrPatch** | [**MenusCreateOrPatch**](MenusCreateOrPatch.md)| The JSON object that will be posted to the REST API endpoint. | 

### Return type

[**GetMenu200Response**](GetMenu200Response.md)

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


## FindMenus

> FindMenus200Response FindMenus (string search = null, int? limit = null, int? skip = null, Object sort = null, List<string> select = null, List<Object> or = null, List<Object> and = null)

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
    public class FindMenusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenusApi(Configuration.Default);
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
                FindMenus200Response result = apiInstance.FindMenus(search, limit, skip, sort, select, or, and);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenusApi.FindMenus: " + e.Message );
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

[**FindMenus200Response**](FindMenus200Response.md)

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


## GetMenu

> GetMenu200Response GetMenu (string id)

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
    public class GetMenuExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenusApi(Configuration.Default);
            var id = "id_example";  // string | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Get object by id
                GetMenu200Response result = apiInstance.GetMenu(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenusApi.GetMenu: " + e.Message );
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

[**GetMenu200Response**](GetMenu200Response.md)

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


## PatchMenu

> GetMenu200Response PatchMenu (string id, MenusCreateOrPatch menusCreateOrPatch)

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
    public class PatchMenuExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenusApi(Configuration.Default);
            var id = "id_example";  // string | The ObjectId (unique 12 bytes ID) of record you would like to GET.
            var menusCreateOrPatch = new MenusCreateOrPatch(); // MenusCreateOrPatch | The request data.

            try
            {
                // Patch object's data
                GetMenu200Response result = apiInstance.PatchMenu(id, menusCreateOrPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenusApi.PatchMenu: " + e.Message );
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
 **menusCreateOrPatch** | [**MenusCreateOrPatch**](MenusCreateOrPatch.md)| The request data. | 

### Return type

[**GetMenu200Response**](GetMenu200Response.md)

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


## RemoveMenu

> GetMenu200Response RemoveMenu (string id)

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
    public class RemoveMenuExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenusApi(Configuration.Default);
            var id = "id_example";  // string | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Delete object by id
                GetMenu200Response result = apiInstance.RemoveMenu(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenusApi.RemoveMenu: " + e.Message );
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

[**GetMenu200Response**](GetMenu200Response.md)

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

