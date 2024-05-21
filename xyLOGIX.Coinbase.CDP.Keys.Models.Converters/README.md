<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Keys.Models.Converters

## Contents

- [ConvertCoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Converters.ConvertCoinbaseJwtPrivateKey')
  - [Settings](#F-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey-Settings 'xyLOGIX.Coinbase.CDP.Keys.Models.Converters.ConvertCoinbaseJwtPrivateKey.Settings')
  - [#cctor()](#M-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey-#cctor 'xyLOGIX.Coinbase.CDP.Keys.Models.Converters.ConvertCoinbaseJwtPrivateKey.#cctor')
  - [FromJson(json)](#M-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey-FromJson-System-String- 'xyLOGIX.Coinbase.CDP.Keys.Models.Converters.ConvertCoinbaseJwtPrivateKey.FromJson(System.String)')
  - [ToJson(data)](#M-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey-ToJson-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey- 'xyLOGIX.Coinbase.CDP.Keys.Models.Converters.ConvertCoinbaseJwtPrivateKey.ToJson(xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey)')
- [Resources](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-Properties-Resources 'xyLOGIX.Coinbase.CDP.Keys.Models.Converters.Properties.Resources')
  - [Culture](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Keys.Models.Converters.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Keys.Models.Converters.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey'></a>
## ConvertCoinbaseJwtPrivateKey `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Models.Converters

##### Summary

Exposes static methods that are to be used in order to serialize and
deserialize `Coinbase CDP Private Key` data to/from JSON.

<a name='F-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey-Settings'></a>
### Settings `constants`

##### Summary

Reference to an instance of
[JsonSerializerSettings](#T-Newtonsoft-Json-JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') that specifies JSON
configuration settings for the conversion operation.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[ConvertCoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Converters.ConvertCoinbaseJwtPrivateKey')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey-FromJson-System-String-'></a>
### FromJson(json) `method`

##### Summary

Parses the specified `json` content and, if successful,
initializes an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface whose properties are initialized from the JSON provided, or a
`null` reference if an error occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| json | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the JSON content to be parsed. |

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-ConvertCoinbaseJwtPrivateKey-ToJson-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey-'></a>
### ToJson(data) `method`

##### Summary

Serializes an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface to JSON and returns this data in the form of a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

##### Returns

If successful, this method returns a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
that contains the JSON content equivalent to the object passed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey') | (Required.) Reference to an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface that represents the data which is to be serialized. |

##### Remarks

If the `data` parameter is passed a
`null` reference, then the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value is returned.

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Models.Converters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Models-Converters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
