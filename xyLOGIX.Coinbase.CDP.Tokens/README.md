<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Tokens

## Contents

- [JwtTokenGenerator](#T-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator')
  - [#ctor()](#M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-#ctor 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.#ctor')
  - [REQUEST_HOST](#F-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-REQUEST_HOST 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.REQUEST_HOST')
  - [RETAIL_REST_API_PROXY](#F-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-RETAIL_REST_API_PROXY 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.RETAIL_REST_API_PROXY')
  - [_rng](#F-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-_rng 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator._rng')
  - [_validHttpMethods](#F-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-_validHttpMethods 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator._validHttpMethods')
  - [Instance](#P-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-Instance 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.Instance')
  - [ValidHttpMethods](#P-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-ValidHttpMethods 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.ValidHttpMethods')
  - [#cctor()](#M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-#cctor 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.#cctor')
  - [FormatJwtUri(method,path)](#M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-FormatJwtUri-System-String,System-String- 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.FormatJwtUri(System.String,System.String)')
  - [GenerateFor(key,method,path)](#M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-GenerateFor-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String,System-String- 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.GenerateFor(xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey,System.String,System.String)')
  - [GenerateFor(name,method,path,privateKey)](#M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-GenerateFor-System-String,System-String,System-Net-Http-HttpMethod,System-String- 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.GenerateFor(System.String,System.String,System.Net.Http.HttpMethod,System.String)')
  - [GenerateNonce()](#M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-GenerateNonce-System-Int32- 'xyLOGIX.Coinbase.CDP.Tokens.JwtTokenGenerator.GenerateNonce(System.Int32)')
- [Resources](#T-xyLOGIX-Coinbase-CDP-Tokens-Properties-Resources 'xyLOGIX.Coinbase.CDP.Tokens.Properties.Resources')
  - [Culture](#P-xyLOGIX-Coinbase-CDP-Tokens-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Tokens.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Coinbase-CDP-Tokens-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Tokens.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator'></a>
## JwtTokenGenerator `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Tokens

##### Summary

Generates so-called `JSON Web Tokens` for use on the
`Coinbase (Retail)` or the `Coinbase (Advanced Trade)` trading
platform(s).

<a name='M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-REQUEST_HOST'></a>
### REQUEST_HOST `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value that contains the hostname of the REST
API server.

<a name='F-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-RETAIL_REST_API_PROXY'></a>
### RETAIL_REST_API_PROXY `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the name of the audit service.

<a name='F-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-_rng'></a>
### _rng `constants`

##### Summary

Reference to an instance of [Random](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Random 'System.Random') that generates
random values for the `nonce`.

<a name='F-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-_validHttpMethods'></a>
### _validHttpMethods `constants`

##### Summary

A static readonly HashSet that contains valid HTTP methods.

<a name='P-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IJwtTokenGenerator](#T-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-IJwtTokenGenerator 'xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator')
interface.

<a name='P-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-ValidHttpMethods'></a>
### ValidHttpMethods `property`

##### Summary

Gets the valid HTTP methods.

<a name='M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-FormatJwtUri-System-String,System-String-'></a>
### FormatJwtUri(method,path) `method`

##### Summary

Formats a URI for use with a JSON web token value, given the specified HTTP
`method` and `path`.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') is returned containing
the properly-formatted URI; otherwise, the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| method | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains
the representation of the HTTP method, such as `GET`, `POST`, etc.
being used. |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The path and query of the Coinbase API request. |

<a name='M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-GenerateFor-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String,System-String-'></a>
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

<a name='M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-GenerateFor-System-String,System-String,System-Net-Http-HttpMethod,System-String-'></a>
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

<a name='M-xyLOGIX-Coinbase-CDP-Tokens-JwtTokenGenerator-GenerateNonce-System-Int32-'></a>
### GenerateNonce() `method`

##### Summary

Generates a unique nonce value.
This method generates a random value which is sufficiently large to
ensure uniqueness and security.

##### Returns

A nonce value as a hexadecimal string.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Coinbase-CDP-Tokens-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Tokens.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-CDP-Tokens-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-CDP-Tokens-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
