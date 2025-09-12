
# Getting Started with APIMATIC Calculator - zip

## Introduction

Simple calculator API hosted on APIMATIC for demo purposes

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package SoniaBarreraSDK --version 3.0.0
```

You can also view the package at:
https://www.nuget.org/packages/SoniaBarreraSDK/3.0.0

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(60)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |

The API client can be initialized as follows:

```csharp
using APIMATICCalculatorZip.Standard;

namespace ConsoleApp;

APIMATICCalculatorZipClient client = new APIMATICCalculatorZipClient.Builder()
    .Build();
```

## List of APIs

* [Simple Calculator](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/controllers/simple-calculator.md)

## SDK Infrastructure

### Configuration

* [HttpClientConfiguration](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/http-client-configuration-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/http-callback.md)
* [HttpContext](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/http-context.md)
* [HttpRequest](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/api-exception.md)
* [ApiHelper](https://www.github.com/ZahraN444/sonia-barrera-dotnet-sdk/tree/3.0.0/doc/api-helper.md)

