<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces

## Contents

- [ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
  - [KeyId](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey-KeyId 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey.KeyId')
  - [Name](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey-Name 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey.Name')
  - [PrivateKey](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey-PrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey.PrivateKey')
- [Resources](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-Properties-Resources 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey'></a>
## ICoinbaseJwtPrivateKey `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of an object that
encapsulates the `name` and `privateKey` fields of the JSON object
provided to users of the `Coinbase Developer Platform (CDP)` upon the
creation of a new API key.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey-KeyId'></a>
### KeyId `property`

##### Summary

Gets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that distinguishes one instance of this
object from another.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey-Name'></a>
### Name `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the name of the JWT
private key.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey-PrivateKey'></a>
### PrivateKey `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the private key --
in PEM format.

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
