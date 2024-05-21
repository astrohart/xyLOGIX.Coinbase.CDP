<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Keys.Providers

## Contents

- [CDPPrivateKeyProvider](#T-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider 'xyLOGIX.Coinbase.CDP.Keys.Providers.CDPPrivateKeyProvider')
  - [#ctor()](#M-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-#ctor 'xyLOGIX.Coinbase.CDP.Keys.Providers.CDPPrivateKeyProvider.#ctor')
  - [SecretsFilePathname](#F-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-SecretsFilePathname 'xyLOGIX.Coinbase.CDP.Keys.Providers.CDPPrivateKeyProvider.SecretsFilePathname')
  - [CurrentPrivateKey](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-CurrentPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Providers.CDPPrivateKeyProvider.CurrentPrivateKey')
  - [Instance](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-Instance 'xyLOGIX.Coinbase.CDP.Keys.Providers.CDPPrivateKeyProvider.Instance')
  - [#cctor()](#M-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-#cctor 'xyLOGIX.Coinbase.CDP.Keys.Providers.CDPPrivateKeyProvider.#cctor')
  - [Load(pathname)](#M-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-Load-System-String- 'xyLOGIX.Coinbase.CDP.Keys.Providers.CDPPrivateKeyProvider.Load(System.String)')
  - [Save(privateKeyData,pathname)](#M-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-Save-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String- 'xyLOGIX.Coinbase.CDP.Keys.Providers.CDPPrivateKeyProvider.Save(xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey,System.String)')
- [ICDPPrivateKeyProvider](#T-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider 'xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider')
  - [CurrentPrivateKey](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider-CurrentPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider.CurrentPrivateKey')
  - [Load(pathname)](#M-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider-Load-System-String- 'xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider.Load(System.String)')
  - [Save(privateKeyData,pathname)](#M-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider-Save-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String- 'xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider.Save(xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey,System.String)')
- [Resources](#T-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources 'xyLOGIX.Coinbase.CDP.Keys.Providers.Properties.Resources')
  - [CoinbaseCdpSecretFileLocation](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-CoinbaseCdpSecretFileLocation 'xyLOGIX.Coinbase.CDP.Keys.Providers.Properties.Resources.CoinbaseCdpSecretFileLocation')
  - [Culture](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Keys.Providers.Properties.Resources.Culture')
  - [File_PrivateKeyPem](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-File_PrivateKeyPem 'xyLOGIX.Coinbase.CDP.Keys.Providers.Properties.Resources.File_PrivateKeyPem')
  - [File_PublicKeyPem](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-File_PublicKeyPem 'xyLOGIX.Coinbase.CDP.Keys.Providers.Properties.Resources.File_PublicKeyPem')
  - [ResourceManager](#P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Keys.Providers.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider'></a>
## CDPPrivateKeyProvider `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Providers

##### Summary

Methods and properties for loading, accessing, and saving the configuration.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-SecretsFilePathname'></a>
### SecretsFilePathname `constants`

##### Summary

Gets the fully-qualified pathname of the default configuration file.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-CurrentPrivateKey'></a>
### CurrentPrivateKey `property`

##### Summary

Gets or sets a reference to the instance of an object implementing the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface that
represents the currently-loaded private key.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ICDPPrivateKeyProvider](#T-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider 'xyLOGIX.Coinbase.CDP.Keys.Providers.ICDPPrivateKeyProvider')
interface.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration from the default configuration file, and stores the
result in the values of the
[CurrentSecrets](#P-xyLOGIX-Coinbase-Tests-Config-Providers-CDPPrivateKeyProvider-CurrentSecrets 'xyLOGIX.Coinbase.Tests.Config.Providers.CDPPrivateKeyProvider.CurrentSecrets')
property.

##### Returns

Reference to an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface, whose
properties have been initialized from the values in the application's default
configuration file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file from which the secrets are to be loaded. |

##### Remarks

If the configuration file does not exist, or an I/O or other error occurs
during the read operation, then the method returns a newly-constructed
configuration object, all of whose properties are initialized to the default
settings.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Providers-CDPPrivateKeyProvider-Save-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String-'></a>
### Save(privateKeyData,pathname) `method`

##### Summary

Saves the current configuration to the encrypted configuration file on the disk
having the specified `pathname` or having the default
pathname (if none is provided).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| privateKeyData | [xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey') | (Optional.) Reference to an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-Tests-Config-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.Tests.Config.Interfaces.ICoinbaseJwtPrivateKey')
interface that contains the secret information that is to be saved to a file
having the specified `pathname`. |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to which the API secrets are to be saved.



The default value of this parameter is the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.



If the argument of this parameter is the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value, then the default pathname is used. |

##### Remarks

The file to which the `privateKeyData` are saved is
encrypted with a 512-bit RSA encryption algorithm.

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider'></a>
## ICDPPrivateKeyProvider `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Providers

##### Summary

Defines the publicly-exposed events, methods and properties of a provider of
`Coinbase CDP` private key information.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider-CurrentPrivateKey'></a>
### CurrentPrivateKey `property`

##### Summary

Gets or sets a reference to the instance of an object implementing the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface that
represents the currently-loaded private key.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider-Load-System-String-'></a>
### Load(pathname) `method`

##### Summary

Loads the configuration from the default configuration file, and stores the
result in the values of the
[CurrentSecrets](#P-xyLOGIX-Coinbase-Tests-Config-Providers-CDPPrivateKeyProvider-CurrentSecrets 'xyLOGIX.Coinbase.Tests.Config.Providers.CDPPrivateKeyProvider.CurrentSecrets')
property.

##### Returns

Reference to an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey')
interface, whose
properties have been initialized from the values in the application's default
configuration file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file from which the secrets are to be loaded. |

##### Remarks

If the configuration file does not exist, or an I/O or other error occurs
during the read operation, then the method returns a newly-constructed
configuration object, all of whose properties are initialized to the default
settings.

<a name='M-xyLOGIX-Coinbase-CDP-Keys-Providers-ICDPPrivateKeyProvider-Save-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey,System-String-'></a>
### Save(privateKeyData,pathname) `method`

##### Summary

Saves the current configuration to the encrypted configuration file on the disk
having the specified `pathname` or having the default
pathname (if none is provided).

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| privateKeyData | [xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-CDP-Keys-Models-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.CDP.Keys.Models.Interfaces.ICoinbaseJwtPrivateKey') | (Optional.) Reference to an instance of an object that implements the
[ICoinbaseJwtPrivateKey](#T-xyLOGIX-Coinbase-Tests-Config-Interfaces-ICoinbaseJwtPrivateKey 'xyLOGIX.Coinbase.Tests.Config.Interfaces.ICoinbaseJwtPrivateKey')
interface that contains the secret information that is to be saved to a file
having the specified `pathname`. |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file to which the API secrets are to be saved.



The default value of this parameter is the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value.



If the argument of this parameter is the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value, then the default pathname is used. |

##### Remarks

The file to which the `privateKeyData` are saved is
encrypted with a 512-bit RSA encryption algorithm.

<a name='T-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Providers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-CoinbaseCdpSecretFileLocation'></a>
### CoinbaseCdpSecretFileLocation `property`

##### Summary

Looks up a localized string similar to C:\Users\Brian Hart\AppData\Local\Coinbase\Config\.cdp_key.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-File_PrivateKeyPem'></a>
### File_PrivateKeyPem `property`

##### Summary

Looks up a localized string similar to C:\Users\Brian Hart\source\repos\astrohart\private_key.pem.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-File_PublicKeyPem'></a>
### File_PublicKeyPem `property`

##### Summary

Looks up a localized string similar to C:\Users\Brian Hart\source\repos\astrohart\public_key.pem.

<a name='P-xyLOGIX-Coinbase-CDP-Keys-Providers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
