<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Keys.Providers.Actions

## Contents

- [Check](#T-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Check 'xyLOGIX.Coinbase.CDP.Keys.Providers.Actions.Check')
  - [WhetherDataIsEncrypted(data)](#M-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Check-WhetherDataIsEncrypted-System-Byte[]- 'xyLOGIX.Coinbase.CDP.Keys.Providers.Actions.Check.WhetherDataIsEncrypted(System.Byte[])')
- [Resources](#T-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Properties-Resources 'xyLOGIX.Coinbase.CDP.Keys.Providers.Actions.Properties.Resources')
  - [Culture](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Keys.Providers.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Keys.Providers.Actions.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Check'></a>
## Check `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Providers.Actions

##### Summary

Exposes static methods to examine data.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Check-WhetherDataIsEncrypted-System-Byte[]-'></a>
### WhetherDataIsEncrypted(data) `method`

##### Summary

Checks whether the specified Coinbase CDP Private Key `data`
is encrypted.

##### Returns

`true` if the data is not useful as-is; otherwise,
`false`, meaning the data is NOT encrypted.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | (Required.) An array of [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') values
that contains the possibly-encrypted data. |

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Providers.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
