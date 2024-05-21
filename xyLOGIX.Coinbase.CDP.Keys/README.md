<a name='assembly'></a>
# xyLOGIX.Coinbase.CDP.Keys

## Contents

- [ApiKeyAuthHelpers](#T-xyLOGIX-Coinbase-Authorization-Helpers-ApiKeyAuthHelpers 'xyLOGIX.Coinbase.CDP.Keys.ApiKeyAuthHelpers')
  - [#cctor()](#M-xyLOGIX-Coinbase-Authorization-Helpers-ApiKeyAuthHelpers-#cctor 'xyLOGIX.Coinbase.CDP.Keys.ApiKeyAuthHelpers.#cctor')
- [OAuthHelpers](#T-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers 'xyLOGIX.Coinbase.CDP.Keys.OAuthHelpers')
  - [#cctor()](#M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-#cctor 'xyLOGIX.Coinbase.CDP.Keys.OAuthHelpers.#cctor')
  - [GetAccessTokenAsync(code,clientId,clientSecret,redirectUri)](#M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-GetAccessTokenAsync-System-String,System-String,System-String,System-String- 'xyLOGIX.Coinbase.CDP.Keys.OAuthHelpers.GetAccessTokenAsync(System.String,System.String,System.String,System.String)')
  - [GetAuthorizeUrl()](#M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-GetAuthorizeUrl-xyLOGIX-Coinbase-Models-AuthorizeOptions- 'xyLOGIX.Coinbase.CDP.Keys.OAuthHelpers.GetAuthorizeUrl(xyLOGIX.Coinbase.Models.AuthorizeOptions)')
  - [RenewAccessAsync(refreshToken,clientId,clientSecret)](#M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-RenewAccessAsync-System-String,System-String,System-String- 'xyLOGIX.Coinbase.CDP.Keys.OAuthHelpers.RenewAccessAsync(System.String,System.String,System.String)')
  - [RevokeTokenAsync(token,accessToken)](#M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-RevokeTokenAsync-System-String,System-String- 'xyLOGIX.Coinbase.CDP.Keys.OAuthHelpers.RevokeTokenAsync(System.String,System.String)')
- [Resources](#T-xyLOGIX-Coinbase-Authorization-Helpers-Properties-Resources 'xyLOGIX.Coinbase.CDP.Keys.Properties.Resources')
  - [Culture](#P-xyLOGIX-Coinbase-Authorization-Helpers-Properties-Resources-Culture 'xyLOGIX.Coinbase.CDP.Keys.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Coinbase-Authorization-Helpers-Properties-Resources-ResourceManager 'xyLOGIX.Coinbase.CDP.Keys.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Coinbase-Authorization-Helpers-ApiKeyAuthHelpers'></a>
## ApiKeyAuthHelpers `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys

<a name='M-xyLOGIX-Coinbase-Authorization-Helpers-ApiKeyAuthHelpers-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[ApiKeyAuthHelpers](#T-xyLOGIX-Coinbase-Authorization-Helpers-ApiKeyAuthHelpers 'xyLOGIX.Coinbase.CDP.Keys.ApiKeyAuthHelpers')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='T-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers'></a>
## OAuthHelpers `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys

<a name='M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [OAuthHelpers](#T-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers 'xyLOGIX.Coinbase.CDP.Keys.OAuthHelpers')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-GetAccessTokenAsync-System-String,System-String,System-String,System-String-'></a>
### GetAccessTokenAsync(code,clientId,clientSecret,redirectUri) `method`

##### Summary

After you have received the temporary code, you can exchange it for valid
access and refresh tokens.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Required Value from the GetAuthorizeUrl step. |
| clientId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Required The client ID you received after registering
your application. |
| clientSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Required The client secret you received after
registering your application. |
| redirectUri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Required Your application’s redirect URI |

<a name='M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-GetAuthorizeUrl-xyLOGIX-Coinbase-Models-AuthorizeOptions-'></a>
### GetAuthorizeUrl() `method`

##### Summary

When redirecting a user to Coinbase to authorize access to your application,
you’ll need to construct the authorization URL with the correct parameters
and scopes. Here’s a list of parameters you should always specify:

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-RenewAccessAsync-System-String,System-String,System-String-'></a>
### RenewAccessAsync(refreshToken,clientId,clientSecret) `method`

##### Summary

Coinbase uses an optional security feature of OAuth2 called refresh tokens.
When you first authenticate, your app will be given an access_token and a
refresh_token. The access token is used to authenticate all your requests,
but expires in two hours. Once an access token has expired, you will need
to use the refresh token to obtain a new access token and a new refresh token.
The refresh token never expires but it can only be exchanged once for a new
set of access and refresh tokens. If you try to make a call with an expired
access token, a 401 response will be returned.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| refreshToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| clientId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| clientSecret | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-xyLOGIX-Coinbase-Authorization-Helpers-OAuthHelpers-RevokeTokenAsync-System-String,System-String-'></a>
### RevokeTokenAsync(token,accessToken) `method`

##### Summary

Active access tokens can be revoked at any time. This request needs to be made
authenticated like any other regular API request (either containing
access_token parameter or Authentication header with bearer token) and 200 OK
is returned for both successful and unsuccessful request. This can be useful,
for example, when implementing log-out feature.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| token | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The access token to expire. |
| accessToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The token used to make the authenticated request.
This can be the same as the token in the first parameter. |

##### Remarks

Access tokens can be revoked manually if you want to disconnect your
application’s access to the user’s account. Revoking can also be used to
implement a log-out feature. You’ll need to supply the current access token
twice, once to revoke it, and another to authenticate the request (either
containing access_token parameter or Authentication header with bearer token).
200 OK is returned for both successful and unsuccessful requests.

<a name='T-xyLOGIX-Coinbase-Authorization-Helpers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Coinbase.CDP.Keys.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Coinbase-Authorization-Helpers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Coinbase-Authorization-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
resource class.

<a name='P-xyLOGIX-Coinbase-Authorization-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
