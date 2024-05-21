<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Keys

## Contents

- [CoinbaseCDPKeyAuthHelpers](#T-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers 'xyLOGIX.Coinbase.CDP.Keys.CoinbaseCDPKeyAuthHelpers')
  - [JwtTokenGenerator](#P-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-JwtTokenGenerator 'xyLOGIX.Coinbase.CDP.Keys.CoinbaseCDPKeyAuthHelpers.JwtTokenGenerator')
  - [PrivateKeyProvider](#P-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-PrivateKeyProvider 'xyLOGIX.Coinbase.CDP.Keys.CoinbaseCDPKeyAuthHelpers.PrivateKeyProvider')
  - [#cctor()](#M-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-#cctor 'xyLOGIX.Coinbase.CDP.Keys.CoinbaseCDPKeyAuthHelpers.#cctor')
  - [GetJWT(keyInfo,method,url)](#M-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-GetJWT-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String,System-String- 'xyLOGIX.Coinbase.CDP.Keys.CoinbaseCDPKeyAuthHelpers.GetJWT(xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey,System.String,System.String)')
  - [GetJWT(method,url)](#M-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-GetJWT-System-String,System-String- 'xyLOGIX.Coinbase.CDP.Keys.CoinbaseCDPKeyAuthHelpers.GetJWT(System.String,System.String)')
- [Resources](#T-xyLOGIX-Coinbase-CDP-Keys-Properties-Resources 'xyLOGIX.Coinbase.CDP.Keys.Properties.Resources')
  - [Culture](#P-xyLOGIX-Coinbase-CDP-Keys-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Keys.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Coinbase-CDP-Keys-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Keys.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers'></a>
## CoinbaseCDPKeyAuthHelpers `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys

<a name='P-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-JwtTokenGenerator'></a>
### JwtTokenGenerator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IJwtTokenGenerator](#T-xyLOGIX-Coinbase-CDP-Tokens-Interfaces-IJwtTokenGenerator 'xyLOGIX.Coinbase.CDP.Tokens.Interfaces.IJwtTokenGenerator')
interface.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-PrivateKeyProvider'></a>
### PrivateKeyProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICDPPrivateKeyProvider](#T-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider 'xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider')
interface.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[ApiKeyAuthHelpers](#T-xyLOGIX-Coinbase-CDP-Keys-ApiKeyAuthHelpers 'xyLOGIX.Coinbase.CDP.Keys.ApiKeyAuthHelpers')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-GetJWT-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String,System-String-'></a>
### GetJWT(keyInfo,method,url) `method`

##### Summary

Gets a `JSON Web Token (JWT)` value given the specified
`method` and request `url`.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the JWT
that is to be used; otherwise, the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value
is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyInfo | [xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey') | (Required.) Reference to an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface representing private-key information on the
`Coinbase Developer Platform (CDP)`. |
| method | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains
the particular HTTP method, say, for example, `GET`, `PUT`, or
`POST` that is in use for the current request, in all-uppercase letters. |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
path and query of a request, e.g., `/v2/accounts?expand=all`. |

<a name='M-xyLOGIX-Coinbase-CDP-Keys-CoinbaseCDPKeyAuthHelpers-GetJWT-System-String,System-String-'></a>
### GetJWT(method,url) `method`

##### Summary

Gets a `JSON Web Token (JWT)` value given the specified
`method` and request `url`.

##### Returns

If successful, a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the JWT
that is to be used; otherwise, the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value
is returned.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| method | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains
the particular HTTP method, say, for example, `GET`, `PUT`, or
`POST` that is in use for the current request, in all-uppercase letters. |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
path and query of a request, e.g., `/v2/accounts?expand=all`. |

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
