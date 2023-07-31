# Com.CircuitID.Api.AuthenticationApi

All URIs are relative to *https://rest.circuitid.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAuthentication**](AuthenticationApi.md#createauthentication) | **POST** /authentication | Create a new object



## CreateAuthentication

> CreateAuthentication200Response CreateAuthentication (AuthenticationCreateOrPatch authenticationCreateOrPatch)

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
            var authenticationCreateOrPatch = new AuthenticationCreateOrPatch(); // AuthenticationCreateOrPatch | The JSON object that will be posted to the REST API endpoint.

            try
            {
                // Create a new object
                CreateAuthentication200Response result = apiInstance.CreateAuthentication(authenticationCreateOrPatch);
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
 **authenticationCreateOrPatch** | [**AuthenticationCreateOrPatch**](AuthenticationCreateOrPatch.md)| The JSON object that will be posted to the REST API endpoint. | 

### Return type

[**CreateAuthentication200Response**](CreateAuthentication200Response.md)

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

