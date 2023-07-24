# circuitid-csharp.CircuitID.ClientsApi

All URIs are relative to *https://rest.circuitid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateClient**](ClientsApi.md#createclient) | **POST** /clients | Create a new object
[**FindClients**](ClientsApi.md#findclients) | **GET** /clients | Find multiple objects
[**GetClient**](ClientsApi.md#getclient) | **GET** /clients/{id} | Get object by id
[**PatchClient**](ClientsApi.md#patchclient) | **PATCH** /clients/{id} | Patch object&#39;s data
[**RemoveClient**](ClientsApi.md#removeclient) | **DELETE** /clients/{id} | Delete object by id



## CreateClient

> Object CreateClient (Clients clients)

Create a new object

Add a new object to the system.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using circuitid-csharp.CircuitID;
using circuitid-csharp.Client;
using circuitid-csharp.CircuitID;

namespace Example
{
    public class CreateClientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(Configuration.Default);
            var clients = new Clients(); // Clients | The JSON object that will be posted to the REST API endpoint.

            try
            {
                // Create a new object
                Object result = apiInstance.CreateClient(clients);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientsApi.CreateClient: " + e.Message );
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
 **clients** | [**Clients**](Clients.md)| The JSON object that will be posted to the REST API endpoint. | 

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


## FindClients

> FindClients200Response FindClients (Object search = null, Object limit = null, Object skip = null, Object sort = null, Object select = null, Object or = null, Object and = null)

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
    public class FindClientsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(Configuration.Default);
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
                FindClients200Response result = apiInstance.FindClients(search, limit, skip, sort, select, or, and);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientsApi.FindClients: " + e.Message );
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

[**FindClients200Response**](FindClients200Response.md)

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


## GetClient

> Object GetClient (Object id)

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
    public class GetClientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(Configuration.Default);
            var id = new Object(); // Object | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Get object by id
                Object result = apiInstance.GetClient(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientsApi.GetClient: " + e.Message );
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


## PatchClient

> Object PatchClient (Object id, Clients clients)

Patch object's data

Make updates to specific fields within the record without replacing the entire dataset.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using circuitid-csharp.CircuitID;
using circuitid-csharp.Client;
using circuitid-csharp.CircuitID;

namespace Example
{
    public class PatchClientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(Configuration.Default);
            var id = new Object(); // Object | The ObjectId (unique 12 bytes ID) of record you would like to GET.
            var clients = new Clients(); // Clients | The request data.

            try
            {
                // Patch object's data
                Object result = apiInstance.PatchClient(id, clients);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientsApi.PatchClient: " + e.Message );
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
 **clients** | [**Clients**](Clients.md)| The request data. | 

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


## RemoveClient

> Object RemoveClient (Object id)

Delete object by id

Delete an object by id, removing it from the service.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using circuitid-csharp.CircuitID;
using circuitid-csharp.Client;
using circuitid-csharp.CircuitID;

namespace Example
{
    public class RemoveClientExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ClientsApi(Configuration.Default);
            var id = new Object(); // Object | The ObjectId (unique 12 bytes ID) of record you would like to GET.

            try
            {
                // Delete object by id
                Object result = apiInstance.RemoveClient(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ClientsApi.RemoveClient: " + e.Message );
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

