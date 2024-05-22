<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Keys.Models

## Contents

- [CoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey')
  - [#ctor()](#M-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-#ctor 'xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey.#ctor')
  - [KeyId](#P-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-KeyId 'xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey.KeyId')
  - [Name](#P-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-Name 'xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey.Name')
  - [PrivateKeyPem](#P-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-PrivateKeyPem 'xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey.PrivateKeyPem')
  - [#cctor()](#M-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-#cctor 'xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey.#cctor')
  - [ToString()](#M-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-ToString 'xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey.ToString')
- [Resources](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Properties-Resources 'xyLOGIX.Coinbase.CDP.Keys.Models.Properties.Resources')
  - [Culture](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Keys.Models.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Keys.Models.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey'></a>
## CoinbaseJwtPrivateKey `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Models

##### Summary

Encapsulates the `name` and `privateKey` fields of the JSON object
provided to users of the `Coinbase Developer Platform (CDP)` upon the
creation of a new API key.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a new instance of
[CoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-KeyId'></a>
### KeyId `property`

##### Summary

Gets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that distinguishes one instance of this
object from another.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-Name'></a>
### Name `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the name of the JWT
private key.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-PrivateKeyPem'></a>
### PrivateKeyPem `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the private key --
in PEM format.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[CoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.CoinbaseJwtPrivateKey')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-CoinbaseJwtPrivateKey-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Models-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Models.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
