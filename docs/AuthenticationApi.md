# circuitid-csharp.CircuitID.AuthenticationApi

All URIs are relative to *https://rest.circuitid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAuthentication**](AuthenticationApi.md#createauthentication) | **POST** /authentication | Create a new object



## CreateAuthentication

> Object CreateAuthentication (Authentication authentication)

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
    public class CreateAuthenticationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.circuitid.com";
            // Configure API key authorization: jwt
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi(Configuration.Default);
            var authentication = new Authentication(); // Authentication | The JSON object that will be posted to the REST API endpoint.

            try
            {
                // Create a new object
                Object result = apiInstance.CreateAuthentication(authentication);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationApi.CreateAuthentication: " + e.Message );
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
 **authentication** | [**Authentication**](Authentication.md)| The JSON object that will be posted to the REST API endpoint. | 

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

