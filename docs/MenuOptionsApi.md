# Com.CircuitID.Api.MenuOptionsApi

All URIs are relative to *https://cloud9.circuitid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMenuOption**](MenuOptionsApi.md#createmenuoption) | **POST** /menuoptions | Create a new object
[**FindMenuOptions**](MenuOptionsApi.md#findmenuoptions) | **GET** /menuoptions | Find multiple objects
[**GetMenuOption**](MenuOptionsApi.md#getmenuoption) | **GET** /menuoptions/{id} | Get object by id
[**PatchMenuOption**](MenuOptionsApi.md#patchmenuoption) | **PATCH** /menuoptions/{id} | Patch object&#39;s data
[**RemoveMenuOption**](MenuOptionsApi.md#removemenuoption) | **DELETE** /menuoptions/{id} | Delete object by id



## CreateMenuOption

> Object CreateMenuOption (Menuoptions menuoptions)

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
    public class CreateMenuOptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuOptionsApi(Configuration.Default);
            var menuoptions = new Menuoptions(); // Menuoptions | The JSON object that will be posted to the REST API endpoint.

            try
            {
                // Create a new object
                Object result = apiInstance.CreateMenuOption(menuoptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenuOptionsApi.CreateMenuOption: " + e.Message );
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
 **menuoptions** | [**Menuoptions**](Menuoptions.md)| The JSON object that will be posted to the REST API endpoint. | 

### Return type

**Object**

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the new object created |  -  |
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


## FindMenuOptions

> FindMenuOptions200Response FindMenuOptions (Object search = null, Object limit = null, Object skip = null, Object sort = null, Object select = null, Object or = null, Object and = null)

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
    public class FindMenuOptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuOptionsApi(Configuration.Default);
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
                FindMenuOptions200Response result = apiInstance.FindMenuOptions(search, limit, skip, sort, select, or, and);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenuOptionsApi.FindMenuOptions: " + e.Message );
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

[**FindMenuOptions200Response**](FindMenuOptions200Response.md)

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


## GetMenuOption

> Object GetMenuOption (Object id)

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
    public class GetMenuOptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuOptionsApi(Configuration.Default);
            var id = new Object(); // Object | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Get object by id
                Object result = apiInstance.GetMenuOption(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenuOptionsApi.GetMenuOption: " + e.Message );
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

**Object**

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


## PatchMenuOption

> Object PatchMenuOption (Object id, Menuoptions menuoptions)

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
    public class PatchMenuOptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuOptionsApi(Configuration.Default);
            var id = new Object(); // Object | The ObjectId (unique 12 bytes ID) of record you would like to GET.
            var menuoptions = new Menuoptions(); // Menuoptions | The request data.

            try
            {
                // Patch object's data
                Object result = apiInstance.PatchMenuOption(id, menuoptions);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenuOptionsApi.PatchMenuOption: " + e.Message );
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
 **menuoptions** | [**Menuoptions**](Menuoptions.md)| The request data. | 

### Return type

**Object**

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the modified data. |  -  |
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


## RemoveMenuOption

> Object RemoveMenuOption (Object id)

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
    public class RemoveMenuOptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://cloud9.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MenuOptionsApi(Configuration.Default);
            var id = new Object(); // Object | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Delete object by id
                Object result = apiInstance.RemoveMenuOption(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenuOptionsApi.RemoveMenuOption: " + e.Message );
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

**Object**

### Authorization

[jwt](../README.md#jwt)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing the deleted data. |  -  |
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

