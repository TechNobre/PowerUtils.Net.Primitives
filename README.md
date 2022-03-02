# PowerUtils.Net.Primitives
Provides additional types and constants for network-based libraries.

![Tests](https://github.com/TechNobre/PowerUtils.Net.Primitives/actions/workflows/test-project.yml/badge.svg)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Net.Primitives&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Net.Primitives)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Net.Primitives&metric=coverage)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Net.Primitives)

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.Net.Primitives.svg)](https://www.nuget.org/packages/PowerUtils.Net.Primitives)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.Net.Primitives.svg)](https://www.nuget.org/packages/PowerUtils.Net.Primitives)
[![License: MIT](https://img.shields.io/github/license/ofpinewood/http-exceptions.svg)](https://github.com/TechNobre/PowerUtils.Net.Primitives/blob/main/LICENSE)



## Support to
- .NET 3.1, .NET 5.0 and .NET 6.0



## Features

- [Installation](#Installation)
- [Helpers](#Helpers)
  - [ExtendedMediaTypeNames](#ExtendedMediaTypeNames)
  - [StatusCodeLink](#StatusCodeLink)


## Documentation

### How to use

#### Install NuGet package <a name="Installation"></a>
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.Net.Primitives

**Nuget**
```bash
Install-Package PowerUtils.Net.Primitives
```

**.NET CLI**
```
dotnet add package PowerUtils.Net.Primitives
```



### Helpers <a name="Helpers"></a>
#### ExtendedMediaTypeNames <a name="ExtendedMediaTypeNames"></a>
- **Contains:** `ProblemApplication`
  - `ExtendedMediaTypeNames.ProblemApplication.JSON`;
  - `ExtendedMediaTypeNames.ProblemApplication.XML`;
- **Contains:** `Multipart`
  - `ExtendedMediaTypeNames.Multipart.FORM_DATA`;

#### StatusCodeLink <a name="StatusCodeLink"></a>
- **Contains:**
  - `StatusCodeLink.STATUS_CODES`;
  - `StatusCodeLink.BAD_REQUEST`;
  - `StatusCodeLink.UNAUTHORIZED`;
  - `StatusCodeLink.PAYMENT_REQUIRED`;
  - `StatusCodeLink.FORBIDDEN`;
  - `StatusCodeLink.NOT_FOUND`;
  - `StatusCodeLink.METHOD_NOT_ALLOWED`;
  - `StatusCodeLink.NOT_ACCEPTABLE`;
  - `StatusCodeLink.PROXY_AUTHENTICATION_REQUIRED`;
  - `StatusCodeLink.REQUEST_TIMEOUT`;
  - `StatusCodeLink.CONFLICT`;
  - `StatusCodeLink.GONE`;
  - `StatusCodeLink.LENGTH_REQUIRED`;
  - `StatusCodeLink.PRECONDITION_FAILED`;
  - `StatusCodeLink.REQUEST_ENTITY_TOO_LARGE`;
  - `StatusCodeLink.REQUEST_URI_TOO_LONG`;
  - `StatusCodeLink.UNSUPPORTED_MEDIA_TYPE`;
  - `StatusCodeLink.REQUESTED_RANGE_NOT_SATISFIABLE`;
  - `StatusCodeLink.EXPECTATION_FAILED`;
  - `StatusCodeLink.I_AM_A_TEAPOT`;
  - `StatusCodeLink.UNPROCESSABLE_ENTITY`;
  - `StatusCodeLink.TOO_EARLY`;
  - `StatusCodeLink.UPGRADE_REQUIRED`;
  - `StatusCodeLink.PRECONDITION_REQUIRED`;
  - `StatusCodeLink.TOO_MANY_REQUESTS`;
  - `StatusCodeLink.REQUEST_HEADER_FIELDS_TOO_LARGE`;
  - `StatusCodeLink.UNAVAILABLE_FOR_LEGAL_REASONS`;
  - `StatusCodeLink.INTERNAL_SERVER_ERROR`;
  - `StatusCodeLink.NOT_IMPLEMENTED`;
  - `StatusCodeLink.BAD_GATEWAY`;
  - `StatusCodeLink.SERVICE_UNAVAILABLE`;
  - `StatusCodeLink.GATEWAY_TIMEOUT`;
  - `StatusCodeLink.HTTP_VERSION_NOT_SUPPORTED`;
  - `StatusCodeLink.VARIANT_ALSO_NEGOTIATES`;
  - `StatusCodeLink.INSUFFICIENT_STORAGE`;
  - `StatusCodeLink.LOOP_DETECTED`;
  - `StatusCodeLink.NOT_EXTENDED`;
  - `StatusCodeLink.NETWORK_AUTHENTICATION_REQUIRED`;

- **Methods:**
  - `StatusCodeLink.GetStatusCodeLink(this int statuCode)`: Get documentation link by status code;
  - `StatusCodeLink.GetStatusCodeLink(this int? statuCode)`: Get documentation link by status code;
  - `StatusCodeLink.GetStatusCodeLinkOrDefault(this int statuCode)`: Get documentation link by status code;



## Contribution

*Help me to help others*




## LICENSE

[MIT](https://github.com/TechNobre/PowerUtils.Net.Primitives/blob/main/LICENSE)




## Changelog

[Here](./CHANGELOG.md)