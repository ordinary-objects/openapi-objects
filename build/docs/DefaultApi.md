# Ordinary.Core.PenpotApi.Api.DefaultApi

All URIs are relative to *http://localhost:3449/api/rpc*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CommandAnalyticsEventPost**](DefaultApi.md#commandanalyticseventpost) | **POST** /command/analytics-event |  |
| [**CommandCloneTemplatePost**](DefaultApi.md#commandclonetemplatepost) | **POST** /command/clone-template |  |
| [**CommandCreateFilePost**](DefaultApi.md#commandcreatefilepost) | **POST** /command/create-file |  |
| [**CommandCreateFileThumbnailPost**](DefaultApi.md#commandcreatefilethumbnailpost) | **POST** /command/create-file-thumbnail |  |
| [**CommandCreateProjectPost**](DefaultApi.md#commandcreateprojectpost) | **POST** /command/create-project |  |
| [**CommandCreateTeamInvitationsPost**](DefaultApi.md#commandcreateteaminvitationspost) | **POST** /command/create-team-invitations |  |
| [**CommandCreateTeamPost**](DefaultApi.md#commandcreateteampost) | **POST** /command/create-team |  |
| [**CommandCreateTeamWithInvitationsPost**](DefaultApi.md#commandcreateteamwithinvitationspost) | **POST** /command/create-team-with-invitations |  |
| [**CommandDeleteFilePost**](DefaultApi.md#commanddeletefilepost) | **POST** /command/delete-file |  |
| [**CommandDeleteProjectPost**](DefaultApi.md#commanddeleteprojectpost) | **POST** /command/delete-project |  |
| [**CommandDeleteTeamMemberPost**](DefaultApi.md#commanddeleteteammemberpost) | **POST** /command/delete-team-member |  |
| [**CommandDuplicateFilePost**](DefaultApi.md#commandduplicatefilepost) | **POST** /command/duplicate-file |  |
| [**CommandExportBinfilePost**](DefaultApi.md#commandexportbinfilepost) | **POST** /command/export-binfile |  |
| [**CommandGetBuiltinTemplatesPost**](DefaultApi.md#commandgetbuiltintemplatespost) | **POST** /command/get-builtin-templates |  |
| [**CommandGetFilePost**](DefaultApi.md#commandgetfilepost) | **POST** /command/get-file |  |
| [**CommandGetProfilePost**](DefaultApi.md#commandgetprofilepost) | **POST** /command/get-profile |  |
| [**CommandGetProjectFilesPost**](DefaultApi.md#commandgetprojectfilespost) | **POST** /command/get-project-files |  |
| [**CommandGetProjectsPost**](DefaultApi.md#commandgetprojectspost) | **POST** /command/get-projects |  |
| [**CommandGetTeamInvitationsPost**](DefaultApi.md#commandgetteaminvitationspost) | **POST** /command/get-team-invitations |  |
| [**CommandGetTeamMembersPost**](DefaultApi.md#commandgetteammemberspost) | **POST** /command/get-team-members |  |
| [**CommandGetTeamsPost**](DefaultApi.md#commandgetteamspost) | **POST** /command/get-teams |  |
| [**CommandImportBinfilePost**](DefaultApi.md#commandimportbinfilepost) | **POST** /command/import-binfile |  |
| [**CommandLoginWithPasswordPost**](DefaultApi.md#commandloginwithpasswordpost) | **POST** /command/login-with-password |  |
| [**CommandLogoutPost**](DefaultApi.md#commandlogoutpost) | **POST** /command/logout |  |
| [**CommandMoveFilesPost**](DefaultApi.md#commandmovefilespost) | **POST** /command/move-files |  |
| [**CommandPrepareRegisterProfilePost**](DefaultApi.md#commandprepareregisterprofilepost) | **POST** /command/prepare-register-profile |  |
| [**CommandPushAuditEventsPost**](DefaultApi.md#commandpushauditeventspost) | **POST** /command/push-audit-events |  |
| [**CommandRecoverProfilePost**](DefaultApi.md#commandrecoverprofilepost) | **POST** /command/recover-profile |  |
| [**CommandRegisterProfilePost**](DefaultApi.md#commandregisterprofilepost) | **POST** /command/register-profile |  |
| [**CommandRenameFilePost**](DefaultApi.md#commandrenamefilepost) | **POST** /command/rename-file |  |
| [**CommandRenameProjectPost**](DefaultApi.md#commandrenameprojectpost) | **POST** /command/rename-project |  |
| [**CommandRequestProfileRecoveryPost**](DefaultApi.md#commandrequestprofilerecoverypost) | **POST** /command/request-profile-recovery |  |
| [**CommandUpdateFilePost**](DefaultApi.md#commandupdatefilepost) | **POST** /command/update-file |  |
| [**CommandUpdateProfilePasswordPost**](DefaultApi.md#commandupdateprofilepasswordpost) | **POST** /command/update-profile-password |  |
| [**CommandUpdateProfilePost**](DefaultApi.md#commandupdateprofilepost) | **POST** /command/update-profile |  |
| [**CommandUpdateTeamPost**](DefaultApi.md#commandupdateteampost) | **POST** /command/update-team |  |
| [**CommandUploadFileMediaObjectPost**](DefaultApi.md#commanduploadfilemediaobjectpost) | **POST** /command/upload-file-media-object |  |
| [**CommandVerifyTokenPost**](DefaultApi.md#commandverifytokenpost) | **POST** /command/verify-token |  |

<a id="commandanalyticseventpost"></a>
# **CommandAnalyticsEventPost**
> AnalyticsResponse CommandAnalyticsEventPost (AnalyticsEvent analyticsEvent)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandAnalyticsEventPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var analyticsEvent = new AnalyticsEvent(); // AnalyticsEvent | 

            try
            {
                AnalyticsResponse result = apiInstance.CommandAnalyticsEventPost(analyticsEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandAnalyticsEventPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandAnalyticsEventPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AnalyticsResponse> response = apiInstance.CommandAnalyticsEventPostWithHttpInfo(analyticsEvent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandAnalyticsEventPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **analyticsEvent** | [**AnalyticsEvent**](AnalyticsEvent.md) |  |  |

### Return type

[**AnalyticsResponse**](AnalyticsResponse.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandclonetemplatepost"></a>
# **CommandCloneTemplatePost**
> CloneTemplateResult CommandCloneTemplatePost (CloneTemplate cloneTemplate)



Clone into the specified project the template by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandCloneTemplatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var cloneTemplate = new CloneTemplate(); // CloneTemplate | 

            try
            {
                CloneTemplateResult result = apiInstance.CommandCloneTemplatePost(cloneTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandCloneTemplatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandCloneTemplatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CloneTemplateResult> response = apiInstance.CommandCloneTemplatePostWithHttpInfo(cloneTemplate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandCloneTemplatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cloneTemplate** | [**CloneTemplate**](CloneTemplate.md) |  |  |

### Return type

[**CloneTemplateResult**](CloneTemplateResult.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandcreatefilepost"></a>
# **CommandCreateFilePost**
> File CommandCreateFilePost (CreateFile createFile)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandCreateFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var createFile = new CreateFile(); // CreateFile | 

            try
            {
                File result = apiInstance.CommandCreateFilePost(createFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandCreateFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandCreateFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<File> response = apiInstance.CommandCreateFilePostWithHttpInfo(createFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandCreateFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFile** | [**CreateFile**](CreateFile.md) |  |  |

### Return type

[**File**](File.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandcreatefilethumbnailpost"></a>
# **CommandCreateFileThumbnailPost**
> CommandCreateFileThumbnailPostDefaultResponse CommandCreateFileThumbnailPost (Guid fileId, int revn, System.IO.Stream content)



Creates or updates the file thumbnail. Mainly used for paint the grid thumbnails.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandCreateFileThumbnailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var fileId = new Guid(); // Guid | 
            var revn = 56;  // int | 
            var content = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                CommandCreateFileThumbnailPostDefaultResponse result = apiInstance.CommandCreateFileThumbnailPost(fileId, revn, content);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandCreateFileThumbnailPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandCreateFileThumbnailPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CommandCreateFileThumbnailPostDefaultResponse> response = apiInstance.CommandCreateFileThumbnailPostWithHttpInfo(fileId, revn, content);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandCreateFileThumbnailPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | [**Guid**](Guid.md) |  |  |
| **revn** | **int** |  |  |
| **content** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

[**CommandCreateFileThumbnailPostDefaultResponse**](CommandCreateFileThumbnailPostDefaultResponse.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandcreateprojectpost"></a>
# **CommandCreateProjectPost**
> CreateProjectResult CommandCreateProjectPost (CreateProject createProject)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandCreateProjectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var createProject = new CreateProject(); // CreateProject | 

            try
            {
                CreateProjectResult result = apiInstance.CommandCreateProjectPost(createProject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandCreateProjectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandCreateProjectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CreateProjectResult> response = apiInstance.CommandCreateProjectPostWithHttpInfo(createProject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandCreateProjectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createProject** | [**CreateProject**](CreateProject.md) |  |  |

### Return type

[**CreateProjectResult**](CreateProjectResult.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandcreateteaminvitationspost"></a>
# **CommandCreateTeamInvitationsPost**
> Object CommandCreateTeamInvitationsPost (CreateTeamInvitations createTeamInvitations)



A rpc call that allow to send a single or multiple invitations to join the team.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandCreateTeamInvitationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var createTeamInvitations = new CreateTeamInvitations(); // CreateTeamInvitations | 

            try
            {
                Object result = apiInstance.CommandCreateTeamInvitationsPost(createTeamInvitations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandCreateTeamInvitationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandCreateTeamInvitationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.CommandCreateTeamInvitationsPostWithHttpInfo(createTeamInvitations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandCreateTeamInvitationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTeamInvitations** | [**CreateTeamInvitations**](CreateTeamInvitations.md) |  |  |

### Return type

**Object**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandcreateteampost"></a>
# **CommandCreateTeamPost**
> void CommandCreateTeamPost (CreateTeam createTeam)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandCreateTeamPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var createTeam = new CreateTeam(); // CreateTeam | 

            try
            {
                apiInstance.CommandCreateTeamPost(createTeam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandCreateTeamPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandCreateTeamPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandCreateTeamPostWithHttpInfo(createTeam);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandCreateTeamPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTeam** | [**CreateTeam**](CreateTeam.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandcreateteamwithinvitationspost"></a>
# **CommandCreateTeamWithInvitationsPost**
> Object CommandCreateTeamWithInvitationsPost (CreateTeamWithInvitations createTeamWithInvitations)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandCreateTeamWithInvitationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var createTeamWithInvitations = new CreateTeamWithInvitations(); // CreateTeamWithInvitations | 

            try
            {
                Object result = apiInstance.CommandCreateTeamWithInvitationsPost(createTeamWithInvitations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandCreateTeamWithInvitationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandCreateTeamWithInvitationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.CommandCreateTeamWithInvitationsPostWithHttpInfo(createTeamWithInvitations);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandCreateTeamWithInvitationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTeamWithInvitations** | [**CreateTeamWithInvitations**](CreateTeamWithInvitations.md) |  |  |

### Return type

**Object**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commanddeletefilepost"></a>
# **CommandDeleteFilePost**
> Object CommandDeleteFilePost (DeleteFile deleteFile)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandDeleteFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var deleteFile = new DeleteFile(); // DeleteFile | 

            try
            {
                Object result = apiInstance.CommandDeleteFilePost(deleteFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandDeleteFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandDeleteFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.CommandDeleteFilePostWithHttpInfo(deleteFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandDeleteFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteFile** | [**DeleteFile**](DeleteFile.md) |  |  |

### Return type

**Object**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commanddeleteprojectpost"></a>
# **CommandDeleteProjectPost**
> Object CommandDeleteProjectPost (DeleteProject deleteProject)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandDeleteProjectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var deleteProject = new DeleteProject(); // DeleteProject | 

            try
            {
                Object result = apiInstance.CommandDeleteProjectPost(deleteProject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandDeleteProjectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandDeleteProjectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.CommandDeleteProjectPostWithHttpInfo(deleteProject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandDeleteProjectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteProject** | [**DeleteProject**](DeleteProject.md) |  |  |

### Return type

**Object**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commanddeleteteammemberpost"></a>
# **CommandDeleteTeamMemberPost**
> void CommandDeleteTeamMemberPost (DeleteTeamMember deleteTeamMember)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandDeleteTeamMemberPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var deleteTeamMember = new DeleteTeamMember(); // DeleteTeamMember | 

            try
            {
                apiInstance.CommandDeleteTeamMemberPost(deleteTeamMember);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandDeleteTeamMemberPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandDeleteTeamMemberPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandDeleteTeamMemberPostWithHttpInfo(deleteTeamMember);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandDeleteTeamMemberPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteTeamMember** | [**DeleteTeamMember**](DeleteTeamMember.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandduplicatefilepost"></a>
# **CommandDuplicateFilePost**
> DuplicateFileResult CommandDuplicateFilePost (DuplicateFile duplicateFile)



Duplicate a single file in the same team.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandDuplicateFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var duplicateFile = new DuplicateFile(); // DuplicateFile | 

            try
            {
                DuplicateFileResult result = apiInstance.CommandDuplicateFilePost(duplicateFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandDuplicateFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandDuplicateFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DuplicateFileResult> response = apiInstance.CommandDuplicateFilePostWithHttpInfo(duplicateFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandDuplicateFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **duplicateFile** | [**DuplicateFile**](DuplicateFile.md) |  |  |

### Return type

[**DuplicateFileResult**](DuplicateFileResult.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandexportbinfilepost"></a>
# **CommandExportBinfilePost**
> System.IO.Stream CommandExportBinfilePost (CommandExportBinfilePostRequest commandExportBinfilePostRequest = null)



Export a penpot file in a binary format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandExportBinfilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var commandExportBinfilePostRequest = new CommandExportBinfilePostRequest(); // CommandExportBinfilePostRequest |  (optional) 

            try
            {
                System.IO.Stream result = apiInstance.CommandExportBinfilePost(commandExportBinfilePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandExportBinfilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandExportBinfilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<System.IO.Stream> response = apiInstance.CommandExportBinfilePostWithHttpInfo(commandExportBinfilePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandExportBinfilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **commandExportBinfilePostRequest** | [**CommandExportBinfilePostRequest**](CommandExportBinfilePostRequest.md) |  | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandgetbuiltintemplatespost"></a>
# **CommandGetBuiltinTemplatesPost**
> List&lt;BuiltinTemplate&gt; CommandGetBuiltinTemplatesPost (Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandGetBuiltinTemplatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var body = {};  // Object | 

            try
            {
                List<BuiltinTemplate> result = apiInstance.CommandGetBuiltinTemplatesPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGetBuiltinTemplatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandGetBuiltinTemplatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<BuiltinTemplate>> response = apiInstance.CommandGetBuiltinTemplatesPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandGetBuiltinTemplatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

### Return type

[**List&lt;BuiltinTemplate&gt;**](BuiltinTemplate.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandgetfilepost"></a>
# **CommandGetFilePost**
> File CommandGetFilePost (GetFile getFile)



Retrieve a file by its ID. Only authenticated users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandGetFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var getFile = new GetFile(); // GetFile | 

            try
            {
                File result = apiInstance.CommandGetFilePost(getFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGetFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandGetFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<File> response = apiInstance.CommandGetFilePostWithHttpInfo(getFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandGetFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getFile** | [**GetFile**](GetFile.md) |  |  |

### Return type

[**File**](File.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandgetprofilepost"></a>
# **CommandGetProfilePost**
> Profile CommandGetProfilePost (Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandGetProfilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var body = {};  // Object | 

            try
            {
                Profile result = apiInstance.CommandGetProfilePost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGetProfilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandGetProfilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Profile> response = apiInstance.CommandGetProfilePostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandGetProfilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

### Return type

[**Profile**](Profile.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandgetprojectfilespost"></a>
# **CommandGetProjectFilesPost**
> List&lt;SimplifiedFile&gt; CommandGetProjectFilesPost (GetProjectFiles getProjectFiles)



Get all files for the specified project.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandGetProjectFilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var getProjectFiles = new GetProjectFiles(); // GetProjectFiles | 

            try
            {
                List<SimplifiedFile> result = apiInstance.CommandGetProjectFilesPost(getProjectFiles);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGetProjectFilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandGetProjectFilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SimplifiedFile>> response = apiInstance.CommandGetProjectFilesPostWithHttpInfo(getProjectFiles);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandGetProjectFilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getProjectFiles** | [**GetProjectFiles**](GetProjectFiles.md) |  |  |

### Return type

[**List&lt;SimplifiedFile&gt;**](SimplifiedFile.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandgetprojectspost"></a>
# **CommandGetProjectsPost**
> List&lt;Project&gt; CommandGetProjectsPost (GetProjects getProjects)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandGetProjectsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var getProjects = new GetProjects(); // GetProjects | 

            try
            {
                List<Project> result = apiInstance.CommandGetProjectsPost(getProjects);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGetProjectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandGetProjectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Project>> response = apiInstance.CommandGetProjectsPostWithHttpInfo(getProjects);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandGetProjectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getProjects** | [**GetProjects**](GetProjects.md) |  |  |

### Return type

[**List&lt;Project&gt;**](Project.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandgetteaminvitationspost"></a>
# **CommandGetTeamInvitationsPost**
> void CommandGetTeamInvitationsPost (GetTeamInvitations getTeamInvitations)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandGetTeamInvitationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var getTeamInvitations = new GetTeamInvitations(); // GetTeamInvitations | 

            try
            {
                apiInstance.CommandGetTeamInvitationsPost(getTeamInvitations);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGetTeamInvitationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandGetTeamInvitationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandGetTeamInvitationsPostWithHttpInfo(getTeamInvitations);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandGetTeamInvitationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getTeamInvitations** | [**GetTeamInvitations**](GetTeamInvitations.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandgetteammemberspost"></a>
# **CommandGetTeamMembersPost**
> List&lt;Profile&gt; CommandGetTeamMembersPost (GetTeamMembers getTeamMembers)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandGetTeamMembersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var getTeamMembers = new GetTeamMembers(); // GetTeamMembers | 

            try
            {
                List<Profile> result = apiInstance.CommandGetTeamMembersPost(getTeamMembers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGetTeamMembersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandGetTeamMembersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Profile>> response = apiInstance.CommandGetTeamMembersPostWithHttpInfo(getTeamMembers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandGetTeamMembersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getTeamMembers** | [**GetTeamMembers**](GetTeamMembers.md) |  |  |

### Return type

[**List&lt;Profile&gt;**](Profile.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandgetteamspost"></a>
# **CommandGetTeamsPost**
> List&lt;Team&gt; CommandGetTeamsPost (Object body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandGetTeamsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var body = {};  // Object | 

            try
            {
                List<Team> result = apiInstance.CommandGetTeamsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandGetTeamsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandGetTeamsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Team>> response = apiInstance.CommandGetTeamsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandGetTeamsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object** |  |  |

### Return type

[**List&lt;Team&gt;**](Team.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandimportbinfilepost"></a>
# **CommandImportBinfilePost**
> Object CommandImportBinfilePost (System.IO.Stream content, Guid? projectId = null)



Import a penpot file in a binary format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandImportBinfilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var content = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 
            var projectId = new Guid?(); // Guid? |  (optional) 

            try
            {
                Object result = apiInstance.CommandImportBinfilePost(content, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandImportBinfilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandImportBinfilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.CommandImportBinfilePostWithHttpInfo(content, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandImportBinfilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **content** | **System.IO.Stream****System.IO.Stream** |  |  |
| **projectId** | [**Guid?**](Guid?.md) |  | [optional]  |

### Return type

**Object**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandloginwithpasswordpost"></a>
# **CommandLoginWithPasswordPost**
> Profile CommandLoginWithPasswordPost (LoginWithPassword loginWithPassword)



Performs authentication using penpot password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandLoginWithPasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var loginWithPassword = new LoginWithPassword(); // LoginWithPassword | 

            try
            {
                Profile result = apiInstance.CommandLoginWithPasswordPost(loginWithPassword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandLoginWithPasswordPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandLoginWithPasswordPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Profile> response = apiInstance.CommandLoginWithPasswordPostWithHttpInfo(loginWithPassword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandLoginWithPasswordPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loginWithPassword** | [**LoginWithPassword**](LoginWithPassword.md) |  |  |

### Return type

[**Profile**](Profile.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandlogoutpost"></a>
# **CommandLogoutPost**
> void CommandLogoutPost (Logout logout)



Clears the authentication cookie and logout the current session.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandLogoutPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var logout = new Logout(); // Logout | 

            try
            {
                apiInstance.CommandLogoutPost(logout);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandLogoutPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandLogoutPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandLogoutPostWithHttpInfo(logout);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandLogoutPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **logout** | [**Logout**](Logout.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandmovefilespost"></a>
# **CommandMoveFilesPost**
> Object CommandMoveFilesPost (MoveFiles moveFiles)



Move a set of files from one project to other.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandMoveFilesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var moveFiles = new MoveFiles(); // MoveFiles | 

            try
            {
                Object result = apiInstance.CommandMoveFilesPost(moveFiles);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandMoveFilesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandMoveFilesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.CommandMoveFilesPostWithHttpInfo(moveFiles);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandMoveFilesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moveFiles** | [**MoveFiles**](MoveFiles.md) |  |  |

### Return type

**Object**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandprepareregisterprofilepost"></a>
# **CommandPrepareRegisterProfilePost**
> void CommandPrepareRegisterProfilePost (PrepareRegisterProfile prepareRegisterProfile)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandPrepareRegisterProfilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var prepareRegisterProfile = new PrepareRegisterProfile(); // PrepareRegisterProfile | 

            try
            {
                apiInstance.CommandPrepareRegisterProfilePost(prepareRegisterProfile);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandPrepareRegisterProfilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandPrepareRegisterProfilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandPrepareRegisterProfilePostWithHttpInfo(prepareRegisterProfile);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandPrepareRegisterProfilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **prepareRegisterProfile** | [**PrepareRegisterProfile**](PrepareRegisterProfile.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandpushauditeventspost"></a>
# **CommandPushAuditEventsPost**
> Object CommandPushAuditEventsPost (PushAuditEvents pushAuditEvents)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandPushAuditEventsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var pushAuditEvents = new PushAuditEvents(); // PushAuditEvents | 

            try
            {
                Object result = apiInstance.CommandPushAuditEventsPost(pushAuditEvents);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandPushAuditEventsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandPushAuditEventsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.CommandPushAuditEventsPostWithHttpInfo(pushAuditEvents);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandPushAuditEventsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pushAuditEvents** | [**PushAuditEvents**](PushAuditEvents.md) |  |  |

### Return type

**Object**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandrecoverprofilepost"></a>
# **CommandRecoverProfilePost**
> void CommandRecoverProfilePost (RecoverProfile recoverProfile)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandRecoverProfilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var recoverProfile = new RecoverProfile(); // RecoverProfile | 

            try
            {
                apiInstance.CommandRecoverProfilePost(recoverProfile);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandRecoverProfilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandRecoverProfilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandRecoverProfilePostWithHttpInfo(recoverProfile);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandRecoverProfilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recoverProfile** | [**RecoverProfile**](RecoverProfile.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandregisterprofilepost"></a>
# **CommandRegisterProfilePost**
> void CommandRegisterProfilePost (RegisterProfile registerProfile)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandRegisterProfilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var registerProfile = new RegisterProfile(); // RegisterProfile | 

            try
            {
                apiInstance.CommandRegisterProfilePost(registerProfile);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandRegisterProfilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandRegisterProfilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandRegisterProfilePostWithHttpInfo(registerProfile);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandRegisterProfilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerProfile** | [**RegisterProfile**](RegisterProfile.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandrenamefilepost"></a>
# **CommandRenameFilePost**
> Object CommandRenameFilePost (RenameFileParams renameFileParams)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandRenameFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var renameFileParams = new RenameFileParams(); // RenameFileParams | 

            try
            {
                Object result = apiInstance.CommandRenameFilePost(renameFileParams);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandRenameFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandRenameFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.CommandRenameFilePostWithHttpInfo(renameFileParams);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandRenameFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **renameFileParams** | [**RenameFileParams**](RenameFileParams.md) |  |  |

### Return type

**Object**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandrenameprojectpost"></a>
# **CommandRenameProjectPost**
> Object CommandRenameProjectPost (RenameProject renameProject)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandRenameProjectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var renameProject = new RenameProject(); // RenameProject | 

            try
            {
                Object result = apiInstance.CommandRenameProjectPost(renameProject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandRenameProjectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandRenameProjectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.CommandRenameProjectPostWithHttpInfo(renameProject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandRenameProjectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **renameProject** | [**RenameProject**](RenameProject.md) |  |  |

### Return type

**Object**

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandrequestprofilerecoverypost"></a>
# **CommandRequestProfileRecoveryPost**
> void CommandRequestProfileRecoveryPost (RequestProfileRecovery requestProfileRecovery)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandRequestProfileRecoveryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var requestProfileRecovery = new RequestProfileRecovery(); // RequestProfileRecovery | 

            try
            {
                apiInstance.CommandRequestProfileRecoveryPost(requestProfileRecovery);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandRequestProfileRecoveryPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandRequestProfileRecoveryPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandRequestProfileRecoveryPostWithHttpInfo(requestProfileRecovery);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandRequestProfileRecoveryPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestProfileRecovery** | [**RequestProfileRecovery**](RequestProfileRecovery.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandupdatefilepost"></a>
# **CommandUpdateFilePost**
> List&lt;CommandUpdateFilePostDefaultResponseInner&gt; CommandUpdateFilePost (UpdateFile updateFile)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandUpdateFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var updateFile = new UpdateFile(); // UpdateFile | 

            try
            {
                List<CommandUpdateFilePostDefaultResponseInner> result = apiInstance.CommandUpdateFilePost(updateFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandUpdateFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandUpdateFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<CommandUpdateFilePostDefaultResponseInner>> response = apiInstance.CommandUpdateFilePostWithHttpInfo(updateFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandUpdateFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateFile** | [**UpdateFile**](UpdateFile.md) |  |  |

### Return type

[**List&lt;CommandUpdateFilePostDefaultResponseInner&gt;**](CommandUpdateFilePostDefaultResponseInner.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandupdateprofilepasswordpost"></a>
# **CommandUpdateProfilePasswordPost**
> void CommandUpdateProfilePasswordPost (UpdateProfilePassword updateProfilePassword)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandUpdateProfilePasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var updateProfilePassword = new UpdateProfilePassword(); // UpdateProfilePassword | 

            try
            {
                apiInstance.CommandUpdateProfilePasswordPost(updateProfilePassword);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandUpdateProfilePasswordPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandUpdateProfilePasswordPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandUpdateProfilePasswordPostWithHttpInfo(updateProfilePassword);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandUpdateProfilePasswordPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateProfilePassword** | [**UpdateProfilePassword**](UpdateProfilePassword.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandupdateprofilepost"></a>
# **CommandUpdateProfilePost**
> Profile CommandUpdateProfilePost (UpdateProfile updateProfile)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandUpdateProfilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var updateProfile = new UpdateProfile(); // UpdateProfile | 

            try
            {
                Profile result = apiInstance.CommandUpdateProfilePost(updateProfile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandUpdateProfilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandUpdateProfilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Profile> response = apiInstance.CommandUpdateProfilePostWithHttpInfo(updateProfile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandUpdateProfilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateProfile** | [**UpdateProfile**](UpdateProfile.md) |  |  |

### Return type

[**Profile**](Profile.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | A default response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandupdateteampost"></a>
# **CommandUpdateTeamPost**
> void CommandUpdateTeamPost (UpdateTeam updateTeam)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandUpdateTeamPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var updateTeam = new UpdateTeam(); // UpdateTeam | 

            try
            {
                apiInstance.CommandUpdateTeamPost(updateTeam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandUpdateTeamPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandUpdateTeamPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandUpdateTeamPostWithHttpInfo(updateTeam);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandUpdateTeamPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateTeam** | [**UpdateTeam**](UpdateTeam.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commanduploadfilemediaobjectpost"></a>
# **CommandUploadFileMediaObjectPost**
> CommandUploadFileMediaObjectPostDefaultResponse CommandUploadFileMediaObjectPost (Guid fileId, System.IO.Stream content)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandUploadFileMediaObjectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var fileId = new Guid(); // Guid | 
            var content = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                CommandUploadFileMediaObjectPostDefaultResponse result = apiInstance.CommandUploadFileMediaObjectPost(fileId, content);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandUploadFileMediaObjectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandUploadFileMediaObjectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CommandUploadFileMediaObjectPostDefaultResponse> response = apiInstance.CommandUploadFileMediaObjectPostWithHttpInfo(fileId, content);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandUploadFileMediaObjectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | [**Guid**](Guid.md) |  |  |
| **content** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

[**CommandUploadFileMediaObjectPostDefaultResponse**](CommandUploadFileMediaObjectPostDefaultResponse.md)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="commandverifytokenpost"></a>
# **CommandVerifyTokenPost**
> void CommandVerifyTokenPost (VerifyToken verifyToken)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ordinary.Core.PenpotApi.Api;
using Ordinary.Core.PenpotApi.Client;
using Ordinary.Core.PenpotApi.Model;

namespace Example
{
    public class CommandVerifyTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3449/api/rpc";
            // Configure API key authorization: CookieAuth
            config.AddApiKey("auth-token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth-token", "Bearer");
            // Configure Bearer token for authorization: AccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var verifyToken = new VerifyToken(); // VerifyToken | 

            try
            {
                apiInstance.CommandVerifyTokenPost(verifyToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CommandVerifyTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CommandVerifyTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CommandVerifyTokenPostWithHttpInfo(verifyToken);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CommandVerifyTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verifyToken** | [**VerifyToken**](VerifyToken.md) |  |  |

### Return type

void (empty response body)

### Authorization

[CookieAuth](../README.md#CookieAuth), [AccessToken](../README.md#AccessToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

