<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Keys.Models.Factories

## Contents

- [MakeNewCoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Factories.MakeNewCoinbaseJwtPrivateKey')
  - [#cctor()](#M-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey-#cctor 'xyLOGIX.Coinbase.CDP.Keys.Models.Factories.MakeNewCoinbaseJwtPrivateKey.#cctor')
  - [AndPrivateKeyPem(self,pem)](#M-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey-AndPrivateKeyPem-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String- 'xyLOGIX.Coinbase.CDP.Keys.Models.Factories.MakeNewCoinbaseJwtPrivateKey.AndPrivateKeyPem(xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey,System.String)')
  - [FromScratch()](#M-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey-FromScratch 'xyLOGIX.Coinbase.CDP.Keys.Models.Factories.MakeNewCoinbaseJwtPrivateKey.FromScratch')
  - [HavingName(self,name)](#M-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey-HavingName-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String- 'xyLOGIX.Coinbase.CDP.Keys.Models.Factories.MakeNewCoinbaseJwtPrivateKey.HavingName(xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey,System.String)')
- [Resources](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-Properties-Resources 'xyLOGIX.Coinbase.CDP.Keys.Models.Factories.Properties.Resources')
  - [Culture](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Keys.Models.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Keys.Models.Factories.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey'></a>
## MakeNewCoinbaseJwtPrivateKey `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Models.Factories

##### Summary

Creates new instances of objects that implement the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface, and returns references to
them.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[MakeNewCoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Factories.MakeNewCoinbaseJwtPrivateKey')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey-AndPrivateKeyPem-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String-'></a>
### AndPrivateKeyPem(self,pem) `method`

##### Summary

Builder extension method that initializes the
[PrivateKey](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey-PrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey.PrivateKey')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey') | (Required.) Reference to an instance of an object that implements
the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface. |
| pem | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a private key in PEM
format. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface and returns a reference to
it.

##### Returns

Reference to an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-MakeNewCoinbaseJwtPrivateKey-HavingName-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String-'></a>
### HavingName(self,name) `method`

##### Summary

Builder extension method that initializes the
[Name](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey-Name 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey.Name')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey') | (Required.) Reference to an instance of an object that implements
the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') bearing the name of the private
key. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Models.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
