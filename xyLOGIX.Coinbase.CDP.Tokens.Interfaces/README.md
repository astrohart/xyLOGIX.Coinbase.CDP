<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Tokens.Interfaces

## Contents

- [IJwtTokenGenerator](#T-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-IJwtTokenGenerator 'xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator')
  - [GenerateFor(key,method,path)](#M-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-IJwtTokenGenerator-GenerateFor-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String,System-String- 'xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator.GenerateFor(xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey,System.String,System.String)')
  - [GenerateFor(name,method,path,privateKey)](#M-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-IJwtTokenGenerator-GenerateFor-System-String,System-String,System-Net-Http-HttpMethod,System-String- 'xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator.GenerateFor(System.String,System.String,System.Net.Http.HttpMethod,System.String)')
- [Resources](#T-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-Properties-Resources 'xyLOGIX.Coinbase.CDP.Tokens.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Tokens.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Tokens.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-IJwtTokenGenerator'></a>
## IJwtTokenGenerator `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Tokens.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of an object that
generates `JSON Web Tokens` for use on the `Coinbase (Retail)` or
`Coinbase (Advanced Trade)` trading platform(s).

<a name='M-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-IJwtTokenGenerator-GenerateFor-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String,System-String-'></a>
### GenerateFor(key,method,path) `method`

##### Summary

Attempts to generate a `JSON Web Token (JWT)` for use on the
`Coinbase (Retail)` or the `Coinbase (Advanced Trade)` platform(s).

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value containing the
JWT token that has been generated, or the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value if failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey') | (Required.) Reference to an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface that represents a private key. |
| method | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the HTTP method name,
e.g., `GET`, in all uppercase, that is being used for the particular REST
API call for which a JWT is desired. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the path, e.g.,
`/v2/accounts`, that is being used for the particular REST API call for
which a JWT is desired. |

##### Remarks

If a `null` reference is passed as the argument of
the `key` parameter, or its property(ies) do not contain
valid information, then this method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='M-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-IJwtTokenGenerator-GenerateFor-System-String,System-String,System-Net-Http-HttpMethod,System-String-'></a>
### GenerateFor(name,method,path,privateKey) `method`

##### Summary

Attempts to generate a `JSON Web Token (JWT)` for use on the
`Coinbase (Retail)` or the `Coinbase (Advanced Trade)` platform(s).

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value containing the
JWT token that has been generated, or the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value if failed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the API
user's private key. |
| method | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the HTTP method name,
e.g., `GET`, in all uppercase, that is being used for the particular REST
API call for which a JWT is desired. |
| path | [System.Net.Http.HttpMethod](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpMethod 'System.Net.Http.HttpMethod') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the path, e.g.,
`/v2/accounts`, that is being used for the particular REST API call for
which a JWT is desired. |
| privateKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the PEM-formatted
private key of the API user. |

##### Remarks

If a `null` reference is passed as the argument of
the `key` parameter, or its property(ies) do not contain
valid information, then this method returns the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='T-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Tokens.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
